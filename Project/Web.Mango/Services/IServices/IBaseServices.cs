using System;
using System.Threading.Tasks;
using Web.Mango.Models;

namespace Web.Mango.Services.IServices
{
    public interface IBaseServices:IDisposable
    {
        ResponceDtos responceDtos { get; set; }
        Task<T> SendAsync<T>(APIREquest Apirequest);
    }
}
