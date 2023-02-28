using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> buider)
        {
            buider.ToTable("User");
            
            buider.HasKey(u => u.Id);
            
            buider.HasIndex(u => u.Email)
                .IsUnique();

            buider.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(60);

            buider.Property(u => u.Email)
                .HasMaxLength(100);
        }
    }
}
