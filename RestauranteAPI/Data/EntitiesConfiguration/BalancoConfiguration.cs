using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestauranteAPI.Data.Models;

namespace RestauranteAPI.Data.EntitiesConfiguration
{
    public class BalancoConfiguration : IEntityTypeConfiguration<Balanco>
    {
        public void Configure(EntityTypeBuilder<Balanco> builder)
        {
            builder.HasKey(x => x.IdBalanco);
            builder.Property(x => x.Valor).HasPrecision(12, 2);
            builder.HasOne(x => x.Prato).WithMany(x => x.Balanco).HasForeignKey(x => x.IdPrato);

        }
    }
}
