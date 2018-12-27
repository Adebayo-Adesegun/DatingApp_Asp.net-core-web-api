using DatingApp.Core;
using Microsoft.EntityFrameworkCore;
using System;

namespace DatingApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options){}
        public DbSet<Values> Values { get; set; } 
    }
}
