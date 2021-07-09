namespace Taleon.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Taleon.Data.Models;

    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder
                 .HasMany(a => a.Users)
                 .WithOne(x => x.Address)
                 .HasForeignKey(e => e.AddressId)
                 .IsRequired()
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
