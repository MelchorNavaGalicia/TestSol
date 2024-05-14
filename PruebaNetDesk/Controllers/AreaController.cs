using Newtonsoft.Json;
using PruebaNetDesk.Models;
using PruebaNetDesk.Utility;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaNetDesk.Controllers.Services
{
    public class AreaService
    {
        private readonly HttpClient _client;

        public AreaService()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(SD.PruebaNet); // Ajusta la URL base según tu necesidad
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        private async Task<ResponseDto> SendAsync(RequestDto requestDto)
        {
            var response = new ResponseDto();
            try
            {
                HttpResponseMessage apiResponse;

                switch (requestDto.ApiType)
                {
                    case SD.ApiType.POST:
                        apiResponse = await _client.PostAsync(requestDto.Url, new StringContent(JsonConvert.SerializeObject(requestDto.Data), Encoding.UTF8, "application/json"));
                        break;
                    case SD.ApiType.PUT:
                        apiResponse = await _client.PutAsync(requestDto.Url, new StringContent(JsonConvert.SerializeObject(requestDto.Data), Encoding.UTF8, "application/json"));
                        break;
                    case SD.ApiType.DELETE:
                        apiResponse = await _client.DeleteAsync(requestDto.Url);
                        break;
                    default:
                        apiResponse = await _client.GetAsync(requestDto.Url);
                        break;
                }

                if (apiResponse.IsSuccessStatusCode)
                {
                    var apiContent = await apiResponse.Content.ReadAsStringAsync();
                    response = JsonConvert.DeserializeObject<ResponseDto>(apiContent);
                }
                else
                {
                    response.IsSuccess = false;
                    response.Message = apiResponse.ReasonPhrase;
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
                Url = "api/Area/GetAreas",
            });
        }

        public async Task<ResponseDto?> GetAreaByIdAsync(int id)
        {
            return await SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = $"api/Area/GetAreaById/{id}",
            });
        }

        public async Task<ResponseDto?> GetAreaByNameAsync(string title)
        {
            return await SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = $"api/Area/GetAreasByName/{title}",
            });
        }

        public async Task<ResponseDto?> PostAreaAsync(Area area)
        {
            return await SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Url = "api/Area/PostArea",
                Data = area,
            });
        }

        public async Task<ResponseDto?> PutAreaAsync(Area area)
        {
            return await SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.PUT,
                Url = "api/Area/PutArea",
                Data = area,
            });
        }

        public async Task<ResponseDto?> DeleteAreaByIdAsync(int id)
        {
            return await SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.DELETE,
                Url = $"api/Area/DeleteAreaById/{id}",
            });
        }
    }
}
