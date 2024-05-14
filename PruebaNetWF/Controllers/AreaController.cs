using Newtonsoft.Json;
using PruebaNetWF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.MonthCalendar;

namespace PruebaNetWF.Controladores
{
    public class AreaController
    {
        string Url = "http://localhost:9095/api/";

        public async Task<string> getAreas()
        {
            WebRequest oRequest = WebRequest.Create(Url+ "Area/GetAreas");
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());


            string str = await sr.ReadToEndAsync();

            if (str != null)
            {
                Response<Area> response = JsonConvert.DeserializeObject<Response<Area>>(str);

                if (response.IsSuccess && response.Data != null)
                {
                    // Deserializar la lista de empleados desde Data
                    return JsonConvert.SerializeObject(response.Data);
                }
                else
                {
                    return "";
                }


            }
            else
            {
                return "";
            }
        }

        public async Task<string> getAreaById(int AreaId)
        {
            string url = Url + "Area/GetAreaById/" + AreaId; // Agregar el ID al final de la URL

            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());

            string str = await sr.ReadToEndAsync();

            if (str != null)
            {
                ResponseById response = JsonConvert.DeserializeObject<ResponseById>(str);

                if (response.IsSuccess && response.Data != null)
                {
                    // Deserializar el empleado desde Data
                    return JsonConvert.SerializeObject(response.Data);
                }
                else
                {
                    return "";
                }
            }
            else
            {
                return "";
            }
        }

        public async Task<string> PostArea(Area area)
        {
            try
            {
                // Serializar el objeto Empleado a JSON
                string empleadoJson = JsonConvert.SerializeObject(area);

                // Crear la solicitud HTTP POST
                WebRequest request = WebRequest.Create(Url + "Area/PostArea");
                request.Method = "POST";
                request.ContentType = "application/json";

                // Escribir los datos del empleado en el cuerpo de la solicitud
                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(empleadoJson);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                // Obtener la respuesta del servidor
                WebResponse response = await request.GetResponseAsync();
                StreamReader sr = new StreamReader(response.GetResponseStream());
                string responseJson = await sr.ReadToEndAsync();

                // Deserializar la respuesta JSON
                Response<string> jsonResponse = JsonConvert.DeserializeObject<Response<string>>(responseJson);

                // Verificar si la solicitud fue exitosa y devolver la respuesta del servidor
                if (jsonResponse.IsSuccess)
                {
                    return "Exito";
                }
                else
                {
                    return jsonResponse.Message;
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        public async Task<bool> deleteArea(int areaId)
        {
            string url = Url + "Area/DeleteAreaById/" + areaId; // Agregar el ID al final de la URL

            try
            {
                WebRequest request = WebRequest.Create(url);
                request.Method = "DELETE";

                using (WebResponse response = await request.GetResponseAsync())
                {
                    // Verificar el código de estado de la respuesta
                    if (((HttpWebResponse)response).StatusCode == HttpStatusCode.OK)
                    {
                        return true; // Eliminación exitosa
                    }
                }
            }
            catch (WebException ex)
            {
                // Manejar cualquier error de solicitud web
                Console.WriteLine("Error: " + ex.Message);
            }

            return false; // Eliminación fallida
        }

        public async Task<bool> PutArea(Area area)
        {
            string url = Url + "Area/PutArea";

            try
            {
                // Serializar el objeto empleado a formato JSON
                string empleadoJson = JsonConvert.SerializeObject(area);

                // Configurar la solicitud HTTP PUT
                WebRequest request = WebRequest.Create(url);
                request.Method = "PUT";
                request.ContentType = "application/json";

                // Escribir el objeto empleado serializado en el cuerpo de la solicitud
                using (StreamWriter streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(empleadoJson);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                // Enviar la solicitud HTTP y obtener la respuesta
                using (WebResponse response = await request.GetResponseAsync())
                {
                    // Verificar el código de estado de la respuesta
                    if (((HttpWebResponse)response).StatusCode == HttpStatusCode.OK)
                    {
                        return true; // Actualización exitosa
                    }
                }
            }
            catch (WebException ex)
            {
                // Manejar cualquier error de solicitud web
                Console.WriteLine("Error: " + ex.Message);
            }

            return false; // Actualización fallida
        }
    }
}
