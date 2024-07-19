using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace mobile_service.Models
{
    public class Mobile
    {
        public int Id { get; set; }

        [StringLength
            (30,
            ErrorMessage = "Mobile name must be 5 to 30 characters",
            MinimumLength = 5)
        ]
        public string Name { get; set; }

        [Range(500, 5000, ErrorMessage = "Price must be in range $500 - $5000")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Color can not be empty")]
        public string Color { get; set; }

        public bool BestSeller { get; set; }
    }
}
