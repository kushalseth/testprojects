using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CompressedAPI;

namespace CompressedAPI.Models
{
    public class CompressedAPIContext : DbContext
    {
        public CompressedAPIContext (DbContextOptions<CompressedAPIContext> options)
            : base(options)
        {
        }

        public DbSet<CompressedAPI.DataModel> DataModel { get; set; }
    }
}
