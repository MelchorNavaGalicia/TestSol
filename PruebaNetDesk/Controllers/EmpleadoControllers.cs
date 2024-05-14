using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PruebaNetDesk.Models;
using PruebaNetDesk.Utility;

namespace PruebaNetDesk.Controllers.Services
{
    public class EmpleadoService
    {
        private readonly HttpClient _client;

        public EmpleadoService()
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

        public async Task<ResponseDto?> GetEmpleadosAsync()
        {
            return await SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = "api/Empleado/GetEmpleados",
            });
        }

        public async Task<ResponseDto?> GetEmpleadoByIdAsync(int id)
        {
            return await SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = $"api/Empleado/GetEmpleadoById/{id}",
            });
        }

        public async Task<ResponseDto?> GetEmpleadoByNameAsync(string name)
        {
            return await SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = $"api/Empleado/GetEmpleadoByName/{name}",
            });
        }

        public async Task<ResponseDto?> PostEmpleadoAsync(Empleado empleado)
        {
            return await SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Url = "api/Empleado/PostEmpleado",
                Data = empleado,
            });
        }

        public async Task<ResponseDto?> PutEmpleadoAsync(Empleado empleado)
        {
            return await SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.PUT,
                Url = "api/Empleado/PutEmpleado",
                Data = empleado,
            });
        }

        public async Task<ResponseDto?> DeleteEmpleadoByIdAsync(int id)
        {
            return await SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.DELETE,
                Url = $"api/Empleado/DeleteEmpleadoById/{id}",
            });
        }
    }
}

