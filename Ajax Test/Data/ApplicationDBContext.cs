using Ajax_Test.Models;
using Ajax_Test.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ajax_Test.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {

        }

        public DbSet<Country> TblCountries { get; set; }
        public DbSet<State> TblState{ get; set; }
        public DbSet<City> TblCity{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<RegisterViewModel>(e => e.HasNoKey());
        }

        public DbSet<Ajax_Test.ViewModel.RegisterViewModel> RegisterViewModel { get; set; }

    }
}
