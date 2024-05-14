using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaNet.Data;
using PruebaNet.Models;
using PruebaNet.Models.Dto;
using System.Collections.Generic;

namespace PruebaNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : Controller
    {

        private readonly ContextDb _context;
        private ResponseDto _response;

        public EmpleadoController(ContextDb context)
        {
            this._context = context;
            this._response = new ResponseDto();
        }

        [HttpGet("GetEmpleados")]
        public ResponseDto GetEmpleados()
        {
            try
            {
                IEnumerable<Empleado> empleados = _context.Empleado.Include(emp => emp.Area).ToList();

                if (empleados == null)
                {
                    _response.Message = "No exsiten registros";
                }else
                {
                    _response.Data = empleados;
                }
            }
            catch (Exception ex)
            {
                _response.isSuccess = false;
                _response.Message = ex.Message;
            }

            return _response;
        }

        [HttpGet("GetEmpleadoById/{id}")]
        public ResponseDto GetEmpleadoById(int id)
        {
            try
            {

				Empleado? empleado = _context.Empleado.Include(emp => emp.Area).FirstOrDefault(e => e.Id == id);

                if (empleado == null)
                {
                    _response.Message = "No exsiten registros";
                }
                else
                {
                    _response.Data = empleado;
                }
            }
            catch (Exception ex)
            {
                _response.isSuccess = false;
                _response.Message = ex.Message;
            }

            return _response;
        }

        [HttpGet("GetEmpleadoByName/{name}")]
        public ResponseDto GetEmpleadoByName(String name)
        {
            try
            {
                var empleado = _context.Empleado.Include(emp => emp.Area.NombreArea).FirstOrDefault(e => e.Nombre == name);

                if (empleado == null)
                {
                    _response.Message = "No exsiten registros";
                }
                else
                {
                    _response.Data = empleado;
                }
            }
            catch (Exception ex)
            {
                _response.isSuccess = false;
                _response.Message = ex.Message;
            }

            return _response;
        }

        [HttpPost("PostEmpleado")]
        public ResponseDto PostEmpleado([ FromBody] Empleado emp)
        {
            try
            {
                _context.Empleado.Add(emp);
                _context.SaveChanges();

                _response.Data = emp;
                _response.Message = "Guardado Correctamente";
            }
            catch (Exception ex)
            {
                _response.isSuccess = false;
                _response.Message = ex.Message;
            }

            return _response;
        }

        [HttpPut("PutEmpleado")]
        public ResponseDto PutEmpleado([FromBody] Empleado emp)
        {
            try
            {
                _context.Empleado.Update(emp);
                _context.SaveChanges();

                _response.Data = emp;
                _response.Message = "Guardado Correctamente";
            }
            catch (Exception ex)
            {
                _response.isSuccess = false;
                _response.Message = ex.Message;
            }

            return _response;
        }

        [HttpDelete("DeleteEmpleadoById/{id}")]
        public ResponseDto DeleteEmpleadoById(int id)
        {
            try
            {
                var empleado = _context.Empleado.FirstOrDefault(e => e.Id == id);


                if (empleado == null)
                {
                    _response.Message = "No existen registros";
                }
                else
                {
                    _context.Remove(empleado);
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
