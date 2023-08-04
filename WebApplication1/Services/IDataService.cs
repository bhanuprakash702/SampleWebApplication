using Microsoft.Identity.Client;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IDataService
    {
        void InsertData(APIData data);
    }
}
