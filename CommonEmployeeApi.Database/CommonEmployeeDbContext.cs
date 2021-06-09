using CommonEmployeeAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommonEmployeeAPI.CommonEmployeeApi.Database
{
    public class CommonEmployeeDbContext : DbContext
    {
        public CommonEmployeeDbContext(DbContextOptions<CommonEmployeeDbContext> options) : base(options)
        {

        }

        public DbSet<Users> Users { get; set; }
    }
}
