using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Web.Mango.Models;

namespace Web.Mango.Services.IServices
{
    public class BaseServices : IBaseServices
    {
        public ResponceDtos responceDtos { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

       
        public IHttpClientFactory IhttpclientFatory { get; }

        public BaseServices(ResponceDtos responceDtos, IHttpClientFactory httpClientFactory)
        {
            this.responceDtos = new ResponceDtos();
            this.IhttpclientFatory = httpClientFactory;
        }

        public BaseServices(IHttpClientFactory ihttpclientFatory)
        {
            IhttpclientFatory = ihttpclientFatory;
        }

        public async Task<T> SendAsync<T>(APIREquest Apirequest)
        {
            try
            {
                var clinet = IhttpclientFatory.CreateClient("MangoAPI");
                HttpRequestMessage message = new HttpRequestMessage();
                message.Headers.Add("Content-Type", "application/json");
                message.Headers.Add("Accept", "application/json");
                message.RequestUri = new Uri(Apirequest.URL);
                clinet.DefaultRequestHeaders.Clear();
                if (Apirequest.data != null)
                {
                    message.Content = new StringContent(JsonConvert.SerializeObject(Apirequest.data), Encoding.UTF8, "application/json");
                }
                HttpResponseMessage apiresponce = null;
                switch (Apirequest.aPI_Type)
                {
                    case SD.API_Type.GET:
                        message.Method = HttpMethod.Get;
                        break;
                    case SD.API_Type.POST:
                        message.Method = HttpMethod.Post;
                        break;
                    case SD.API_Type.PUT:
                        message.Method = HttpMethod.Put;
                        break;
                    case SD.API_Type.DELETE:
                        message.Method = HttpMethod.Delete;
                        break;
                    default:
                        message.Method = HttpMethod.Get;
                        break;
                }
                apiresponce = await clinet.SendAsync(message);
                var APIContent = await apiresponce.Content.ReadAsStringAsync();
                var APIData = JsonConvert.DeserializeObject<T>(APIContent);
                return APIData;
            }
            catch (Exception ex)
            {

                var dto = new ResponceDtos
                {
                    DisplayName = "Error",
                    IsSuccess = false,
                    ErrorMessage = new List<string> { Convert.ToString(ex.Message) }

                };
                var res=JsonConvert.SerializeObject(dto);
                var apiresponcedgto=JsonConvert.DeserializeObject<T>(res);
                return apiresponcedgto;

            }
            
            
        }
        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
    }
}
