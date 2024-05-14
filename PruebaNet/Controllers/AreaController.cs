using Microsoft.AspNetCore.Mvc;
using PruebaNet.Data;
using PruebaNet.Models.Dto;
using PruebaNet.Models;

namespace PruebaNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AreaController : Controller

    {
        private readonly ContextDb _context;
        private ResponseDto _response;

        public AreaController(ContextDb context)
        {
            this._context = context;
            this._response = new ResponseDto();
        }

        [HttpGet("GetAreas")]
        public ResponseDto GetAreas()
        {
            try
            {
                IEnumerable<Area> Areas = _context.Area.ToList();
                if (Areas == null)
                {
                    _response.Message = "No exsiten registros";
                }
                else
                {
                    _response.Data = Areas;
                }
            }
            catch (Exception ex)
            {
                _response.isSuccess = false;
                _response.Message = ex.Message;
            }

            return _response;
        }

        [HttpGet("GetAreaById/{id}")]
        public ResponseDto GetAreaById(int id)
        {
            try
            {
                var Area = _context.Area.FirstOrDefault(e => e.IdArea == id);
                if (Area == null)
                {
                    _response.Message = "No exsiten registros";
                }
                else
                {
                    _response.Data = Area;
                }
            }
            catch (Exception ex)
            {
                _response.isSuccess = false;
                _response.Message = ex.Message;
            }

            return _response;
        }

        [HttpGet("GetAreaByName/{name}")]
        public ResponseDto GetAreaByName(String name)
        {
            try
            {
                var Area = _context.Area.FirstOrDefault(e => e.NombreArea == name);

                if (Area == null)
                {
                    _response.Message = "No exsiten registros";
                }
                else
                {
                    _response.Data = Area;
                }
                
            }
            catch (Exception ex)
            {
                _response.isSuccess = false;
                _response.Message = ex.Message;
            }

            return _response;
        }

        [HttpPost("PostArea")]
        public ResponseDto PostArea([FromBody] Area are)
        {
            try
            {
                _context.Area.Add(are);
                _context.SaveChanges();

                _response.Data = are;
                _response.Message = "Guardado Correctamente";
            }
            catch (Exception ex)
            {
                _response.isSuccess = false;
                _response.Message = ex.Message;
            }

            return _response;
        }

        [HttpPut("PutArea")]
        public ResponseDto PutArea([FromBody] Area are)
        {
            try
            {
                _context.Area.Update(are);
                _context.SaveChanges();

                _response.Data = are;
                _response.Message = "Guardado Correctamente";
            }
            catch (Exception ex)
            {
                _response.isSuccess = false;
                _response.Message = ex.Message;
            }

            return _response;
        }

        [HttpDelete("DeleteAreaById/{id}")]
        public ResponseDto DeleteAreaById(int id)
        {
            try
            {
                var Area = _context.Area.FirstOrDefault(e => e.IdArea == id);

                if (Area == null)
                {
                    _response.Message = "No exsiten registros";
                }
                else
                {
                    _context.Remove(Area);
                    _context.SaveChanges();
                }
                

                _response.Message = "Eliminado Correctamente";
            }
            catch (Exception ex)
            {
                _response.isSuccess = false;
                _response.Message = ex.Message;
            }

            return _response;
        }
    }
}
