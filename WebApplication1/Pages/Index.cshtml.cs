using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using WebApplication1.Constants;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _dbContext;
        private readonly UrlInfo _urlInfo;

        static HttpClient client = new HttpClient();
        public APIData  Data { get; set; }
        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext dbContext, IOptions<UrlInfo> options)
        {
            _logger = logger;
            _dbContext = dbContext;
            _urlInfo = options.Value;
        }
        public void OnGet()
        {
            Data = new APIData();
        }        
        public async Task OnPostAsync()
        {
            string apiUrl = _urlInfo.Url;
            try
            {
                var response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    _logger.LogInformation("Data retrived successfully");

                    Data = await response.Content.ReadAsAsync<APIData>();
                    
                    _dbContext.Data.Add(Data.response);

                    await _dbContext.SaveChangesAsync();

                    _logger.LogInformation("Data successfully saved");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                _logger.LogInformation($"{ex.Message}");    
            }
        }
    }
}