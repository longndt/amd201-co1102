using System.ComponentModel.DataAnnotations;

namespace web.Models
{
    public class Laptop
    {
        //PRIMARY KEY, AUTO INCREMENT
        public int Id { get; set; }
        //public int LaptopId { get; set; }

        public string Brand { get; set; }
        public string Model { get; set; }

        [Range(1,100, ErrorMessage = "Số lượng sản phẩm phải từ 1 đến 100")]
        public int Quantity { get; set; }   
        public decimal Price { get; set; }

        public string Image { get; set; }
        public string Color { get; set; }   
    }
}
