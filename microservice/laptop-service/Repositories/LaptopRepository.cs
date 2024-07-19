using laptop_service.Models;
using laptop_service.Repositories.Interfaces;
using laptop_service.Data;

namespace laptop_service.Repositories
{
    public class LaptopRepository : ILaptopRepository
    {
        private laptop_serviceContext _context;

        public LaptopRepository(laptop_serviceContext context)
        {
            _context = context;
        }

        public List<Laptop> DisplayAllLaptops()
        {
            try
            {
                var laptops = _context.Laptop.ToList();
                return laptops;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Laptop DisplayLaptopById(int id)
        {
            try
            {
                var laptop = _context.Laptop.FirstOrDefault(lap => lap.Id == id);
                return laptop;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
