using PruebaNetFrontEnd.Models;

namespace PruebaNetFrontEnd.Services.IServices
{
    public interface IEmpleadoService
    {

        Task<ResponseDto?> GetEmpleadosAsync();
        Task<ResponseDto?> GetEmpleadoByIdAsync(int id);
        Task<ResponseDto?> GetEmpleadoByNameAsync(String name);
        Task<ResponseDto?> PostEmpleadoAsync(Empleado Empleado);
        Task<ResponseDto?> PutEmpleadoAsync(Empleado Empleado);
        Task<ResponseDto?> DeleteEmpleadoByIdAsync(int id);

    }
}
