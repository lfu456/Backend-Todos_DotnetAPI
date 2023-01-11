using fbb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace fbb.Configuration
{
    public class TodoConfiguration : IEntityTypeConfiguration<Todo>
    {
        public void Configure(EntityTypeBuilder<Todo> builder)
        {
            builder.ToTable("hocdb");
            builder.HasKey(t => t.Id);//t la todo
            builder.Property(t => t.Name).IsRequired().HasDefaultValue(false);
        }

    
    }
}
