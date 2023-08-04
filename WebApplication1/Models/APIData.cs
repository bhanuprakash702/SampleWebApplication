using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class APIData
    {
        [NotMapped]
        public Response? response { get; set; }
    }
}
