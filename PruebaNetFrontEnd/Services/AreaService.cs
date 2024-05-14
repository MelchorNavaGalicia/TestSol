using Newtonsoft.Json;
using PruebaNetFrontEnd.Models;
using PruebaNetFrontEnd.Services.IServices;
using PruebaNetFrontEnd.Utility;
using System;
using System.Text;

namespace PruebaNetFrontEnd.Services
{
    public class AreaService : IAreaService
    {
        private readonly IHttpClientFactory _ClientFactory;

        public AreaService(IHttpClientFactory clientFactory)
        {
            _ClientFactory = clientFactory;
        }

        private async Task<ResponseDto> SendAsync(RequestDto requestDto)
        {
            var response = new ResponseDto();
            try
            {
                HttpClient client = _ClientFactory.CreateClient("PruebaNet");
                HttpRequestMessage message = new HttpRequestMessage();

                message.Headers.Add("Accept", "application/json");

                message.RequestUri = new Uri(requestDto.Url);

                if (requestDto.Data != null)
                {
                    message.Content = new StringContent(JsonConvert.SerializeObject(requestDto.Data), Encoding.UTF8, "application/json");
                }

                switch (requestDto.ApiType)
                {
                    case SD.ApiType.POST:
                        message.Method = HttpMethod.Post;
                        break;
                    case SD.ApiType.PUT:
                        message.Method = HttpMethod.Put;
                        break;
                    case SD.ApiType.DELETE:
                        message.Method = HttpMethod.Delete;
                        break;
                    default:
                        message.Method = HttpMethod.Get;
                        break;
                }

                HttpResponseMessage apiResponse = await client.SendAsync(message);

                switch (apiResponse.StatusCode)
                {
                    case System.Net.HttpStatusCode.NotFound:
                        response.IsSuccess = false;
                        response.Message = "Not Found";
                        break;
                    case System.Net.HttpStatusCode.Unauthorized:
                        response.IsSuccess = false;
                        response.Message = "Unauthorized";
                        break;
                    case System.Net.HttpStatusCode.Forbidden:
                        response.IsSuccess = false;
                        response.Message = "Access Denied";
                        break;
                    case System.Net.HttpStatusCode.InternalServerError:
                        response.IsSuccess = false;
                        response.Message = "Internal Server Error";
                        break;
                    default:
                        var apiContent = await apiResponse.Content.ReadAsStringAsync();
                        response = JsonConvert.DeserializeObject<ResponseDto>(apiContent);
                        break;
                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }
            return response;
        }
        public async Task<ResponseDto?> GetAreasAsync()
        {
            return await SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.PruebaNet + "api/Area/GetAreas",
            });
        }

        public async Task<ResponseDto?> GetAreaByIdAsync(int id)
        {
            return await SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.PruebaNet + $"api/Area/GetAreaById/{id}",
            });
        }

        public async Task<ResponseDto?> GetAreaByNameAsync(string title)
        {
            return await SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.PruebaNet + $"api/Area/GetAreasByName/{title}",
            });
        }

        public async Task<ResponseDto?> PostAreaAsync(Area area)
        {
            return await SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Url = SD.PruebaNet + "api/Area/PostArea",
                Data = area,
            });
        }

        public async Task<ResponseDto?> PutAreaAsync(Area area)
        {
            return await SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.PUT,
                Url = SD.PruebaNet + "api/Area/PutArea",
                Data = area,
            });
        }

        public async Task<ResponseDto?> DeleteAreaByIdAsync(int id)
        {
            return await SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.DELETE,
                Url = SD.PruebaNet + $"api/Area/DeleteAreaById/{id}",
            });
        }
    }
}
