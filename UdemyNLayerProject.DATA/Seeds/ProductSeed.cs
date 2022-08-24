using System.ComponentModel.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UdemyNlayerProject.CORE.Model;

namespace UdemyNLayerProject.DATA.Seeds
{
    public class ProductSeed: IEntityTypeConfiguration<Product>
    {
        private readonly int[] _ids;
        public ProductSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1, Name = "Telefon", Price = 12000m, Stock = 100,
                    CategoryId = _ids[0]
                },
                new Product
                {
                    Id = 2, Name = "Bilgisayar", Price = 15000m, Stock = 110,
                    CategoryId = _ids[0]
                },
                new Product
                {
                    Id = 4, Name = "Küçük Masa", Price = 7000m, Stock = 120,
                    CategoryId = _ids[1]
                },
                new Product
                    {
                        Id = 5, Name = "Orta Masa", Price = 7000m, Stock = 120,
                        CategoryId = _ids[1]
                    },
                new Product
                    {
                        Id = 6, Name = "Büyük Masa", Price = 7000m, Stock = 120,
                        CategoryId = _ids[1]
                    }
                );
        }
    }
}