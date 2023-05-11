using DL_Calculator.Models;
using Microsoft.EntityFrameworkCore;

namespace DL_Calculator.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<dl_value> dl_Values { get; set; }
    }
}
