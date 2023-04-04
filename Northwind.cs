using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packt.Shared
{
    public class Northwind:DbContext
    {
        DbSet<Category>? Categories { get; set; }
        DbSet<Product>? Products { get; set; }

        DbSet<Comment>? Comments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();

            if (ProjectConstants.DatabaseProvider == "SQLite")
            {
                //string path = Path.Combine(
                //  Environment.CurrentDirectory, "Northwind.db");

                //WriteLine($"Using {path} database file.");

                //optionsBuilder.UseSqlite($"Filename={path}");
            }
            else
            {
                string connection = "Data Source=.;" +
                  "Initial Catalog=Northwind;" +
                  "Integrated Security=true;" +
                  "MultipleActiveResultSets=true;";

                optionsBuilder.UseSqlServer(connection);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().Property(category => category.CategoryName).IsRequired()
                .HasMaxLength(15);
        }
    }
}
