namespace Taleon.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Taleon.Data.Models;

    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> city)
        {
            city.HasMany(a => a.Addresses)
                .WithOne(x => x.City)
                .HasForeignKey(a => a.CityId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
