using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Entities
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        //Veritabanı test verileri
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){ Name="Kamera",Description = "Kamera Ürünleri"},
                new Category(){ Name="Bilgisayar",Description = "Bilgisayar Ürünleri"},
                new Category(){ Name="Elektronik",Description = "Elektronik Ürünler"},
                new Category(){ Name="Telefon",Description = "Telefon Ürünleri"},
                new Category(){ Name="Beyaz Eşya",Description = "Beyaz Eşya Ürünleri"}
            };
            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product(){ Name="Canon EOS 250D + EF-S 18-55mm f/3.5-5.6 DC III Siyah",Description="EOS 250D'nin taşınabilir gövdesinin içinde bulunan 24,1 megapiksel sensör ve DIGIC 8 görüntü işlemcisi, hareket halinde mükemmel sonuçlar sağlar. Optik vizör, net ve gerçek zamanlı bir görünüm sunar.",Price=7000,Stock=3,IsApproved=true,CategoryId=1, IsHome=true},

                new Product(){ Name="Nikon D3200 18-55mm KİT",Description="Üstün Performans, Yenilikçi Teknolojiler",Price=3000,Stock=2,IsApproved=false,CategoryId=1},

                new Product(){ Name="Lenovo IdeaPad Gaming 3 AMD Ryzen 5 4600H 8GB 512GB SSD GTX 1650 Freedos 15.6 FHD",Description="EOS 250D'nin taşınabilir gövdesinin içinde bulunan 24,1 megapiksel sensör ve DIGIC 8 görüntü işlemcisi, hareket halinde mükemmel sonuçlar sağlar. Optik vizör, net ve gerçek zamanlı bir görünüm sunar.",Price=7750,Stock=12,IsApproved=true,CategoryId=2},

                new Product(){ Name="Xiaomi Redmi Note 10 Pro 128 GB",Description="Yüksek Performanslı ve Hızlı Akıllı Telefon Arayışındakileri Tercihi",Price=3750,Stock=38,IsApproved=false,CategoryId=4, IsHome=true},

                new Product(){ Name="Arduino Uno R3 Klon (Smd) + 40 Pin Header + Usb Kablo",Description="Yapay zeka",Price=100,Stock=35,IsApproved=true,CategoryId=3, IsHome=true},

                new Product(){ Name="Samsung RT46K6000WW/TR 468 lt No-Frost Buzdolabı",Description="Yeni Nesil Teknolojiler Bir Arada",Price=5400,Stock=30,IsApproved=true,CategoryId=5},
            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}