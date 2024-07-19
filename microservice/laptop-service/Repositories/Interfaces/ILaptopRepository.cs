using laptop_service.Models;

namespace laptop_service.Repositories.Interfaces
{
    public interface ILaptopRepository
    {
        List<Laptop> DisplayAllLaptops();
        Laptop DisplayLaptopById(int id);
    }
}
