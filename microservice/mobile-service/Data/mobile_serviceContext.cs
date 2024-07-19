using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mobile_service.Models;

namespace mobile_service.Data
{
    public class mobile_serviceContext : DbContext
    {
        public mobile_serviceContext (DbContextOptions<mobile_serviceContext> options)
            : base(options)
        {
        }

        public DbSet<mobile_service.Models.Mobile> Mobile { get; set; } = default!;
    }
}
