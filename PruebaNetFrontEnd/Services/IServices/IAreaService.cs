using PruebaNetFrontEnd.Models;
using System.Threading.Tasks;

namespace PruebaNetFrontEnd.Services.IServices
{
    public interface IAreaService
    {
        Task<ResponseDto?> GetAreasAsync();
        Task<ResponseDto?> GetAreaByIdAsync(int id);
        Task<ResponseDto?> GetAreaByNameAsync(String name);
        Task<ResponseDto?> PostAreaAsync(Area area);
        Task<ResponseDto?> PutAreaAsync(Area area);
        Task<ResponseDto?> DeleteAreaByIdAsync(int id);

    }
}
