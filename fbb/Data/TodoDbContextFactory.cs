using fbb.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace fbb.Data
{
    public class TodoDbContextFactory : IDesignTimeDbContextFactory<TodosDbContext>
    {
        public TodosDbContext CreateDbContext(string[] arg)
        {
             IConfiguration configurationRoot = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configurationRoot.GetConnectionString("fbbContext");
            var optionBuilder = new DbContextOptionsBuilder<TodosDbContext>();
            optionBuilder.UseSqlServer(connectionString);
            return new TodosDbContext(optionBuilder.Options);
        }
    }
}
