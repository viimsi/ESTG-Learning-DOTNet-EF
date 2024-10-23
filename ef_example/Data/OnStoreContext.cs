using ef_example.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_example.Data
{
    internal class OnStoreContext : DbContext
    {
        //DBSet maps an entity (table) of the DB with a data class (Model) of the application being developed
        public DbSet<Product> Products { get; set; } = null;

        public DbSet<Category> Categories { get; set; } = null;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source = (LocalDb)\\MSSQLLocalDB; TrustServerCertificate = True; Database = Program; Integrated Security = True");
            //this would rather and ideally be done in another location, like a json file
        }
    }
}
