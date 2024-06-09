using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieTechniczne.Cinema.Storage
{
    public class CinemaTicketDbContext : DbContext
    {

        private IConfiguration _configuration { get; }
        public DbSet<SzkolenieTechniczne.Cinema.Storage.Entities.Movie> Movies {  get; set; }
        public DbSet<SzkolenieTechniczne.Cinema.Storage.Entities.Seance> Seances { get; set; }
        public DbSet<SzkolenieTechniczne.Cinema.Storage.Entities.Ticket> Tickets { get; set; }
        public DbSet<SzkolenieTechniczne.Cinema.Storage.Entities.MovieCategory> MovieCategories { get; set; }
        public CinemaTicketDbContext(IConfiguration configuration): base() 
        { 
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;",
                // options.UseSqlServer(@"server=(localdb)\MSSQLLocalDB;database=cinema-dev1;trusted
                x => x.MigrationsHistoryTable("__EFMigrationsHistory", "Cinema"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
