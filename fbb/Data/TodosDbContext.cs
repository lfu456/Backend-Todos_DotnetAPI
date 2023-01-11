using fbb.Configuration;
using fbb.Models;
using fbb.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace fbb.Database
{
    public class TodosDbContext : DbContext
    {
        public TodosDbContext(DbContextOptions Options) : base(Options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration( new TodoConfiguration() );
            modelBuilder.Seed();
        }

        public DbSet<Todo> Todos { get; set; }


    }



}
 