using MovieStoreC.DL.Interfaces;
using MovieStoreC.Models.DTO;

namespace MovieStoreC.BL.Interfaces
{
    public interface IBusinessService
    {
        List<Movie> GetAll();
        Movie? GetById(int id);


    }
}
