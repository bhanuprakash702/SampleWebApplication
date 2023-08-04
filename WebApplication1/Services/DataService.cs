using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class DataService : IDataService
    {
        private readonly IGenericRepository<APIData> _repository;

        public DataService(IGenericRepository<APIData> repository)
        {
            _repository = repository; 
        }
        public void InsertData(APIData data)
        {
            _repository.Create(data);
        }
    }
}
