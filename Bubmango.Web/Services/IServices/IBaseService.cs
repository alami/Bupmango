using System;
using System.Threading.Tasks;
using Bupmango.Web.Models;

namespace Bubmango.Web.Services.IServices
{
    public class IBaseService : IDisposable
    {
        ResponseDto responseModel { get; set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
