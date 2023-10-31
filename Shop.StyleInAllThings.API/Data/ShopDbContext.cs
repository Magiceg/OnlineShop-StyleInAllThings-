using Microsoft.EntityFrameworkCore;
using Shop.StyleInAllThings.API.Entities;
using System;

namespace Shop.StyleInAllThings.API.Data
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> option) : base(option)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Products
            //Sofa Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Sofa Nemo Velvet Yellow",
                Description = "A stylish yellow sofa that will look great under the interior",
                ImageURL = "/images/Sofa/sofa1.png",
                Price = 630,
                Quantity = 23,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Sofa Atlanta",
                Description = "The stylish Atlanta sofa, straight, with a reliable transformation mechanism 'Eurocook' is designed for daily use.",
                ImageURL = "/images/Sofa/sofa2.png",
                Price = 459,
                Quantity = 15,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "CORNER sofa Vermont",
                Description = "Original design, straight lines, representative appearance, wide seat space and moderately wide armrests with firmware",
                ImageURL = "/images/Sofa/sofa3.png",
                Price = 599,
                Quantity = 10,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Good story sofa",
                Description = "Simple and flawless appearance with plain faux suede upholstery.",
                ImageURL = "/images/Sofa/sofa4.png",
                Price = 580,
                Quantity = 12,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Domo Pro corner sofa",
                Description = "Anatomical sofa bed Domo PRO is the designer of your ideal sleep.",
                ImageURL = "/images/Sofa/sofa5.png",
                Price = 30,
                Quantity = 85,
                CategoryId = 1

            });         
            //Chairs Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "White Leather Home Chair",
                Description = "Very comfortable white leather home chair",
                ImageURL = "/images/Chairs/chair1.png",
                Price = 90,
                Quantity = 212,
                CategoryId = 2
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                Name = "Chair with pillow",
                Description = "Very comfortable chair with pillow for home",
                ImageURL = "/images/Chairs/chair2.png",
                Price = 50,
                Quantity = 112,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 14,
                Name = "High chair",
                Description = "Very comfortable stylish high chair",
                ImageURL = "/images/Chairs/chair3.png",
                Price = 160,
                Quantity = 40,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 15,
                Name = "Chair with a green cushion",
                Description = "Very a comfortable armchair with a green cushion for your interior",
                ImageURL = "/images/Chairs/chair4.png",
                Price = 120,
                Quantity = 95,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 16,
                Name = "Computer chair",
                Description = "Silver-colored computer chair",
                ImageURL = "/images/Chairs/chair5.png",
                Price = 210,
                Quantity =50,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 17,
                Name = "Pink chair",
                Description = "Perfect chair suitable for both kitchen and living room",
                ImageURL = "/images/Chairs/chair6.png",
                Price = 60,
                Quantity = 47,
                CategoryId = 2
            });
			//Bed Category
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 6,
				Name = "Double bed",
				Description = "Standard double bed in your bedroom",
				ImageURL = "/images/Bed/bed1.png",
				Price = 450,
				Quantity = 14,
				CategoryId = 3

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 7,
				Name = "Empire Suite bed with lifting mechanism",
				Description = "A comfortable bed for a comfortable stay. High quality materials and soft fillers will contribute to complete muscle relaxation and sound sleep.",
				ImageURL = "/images/Bed/bed2.png",
				Price = 790,
				Quantity = 18,
				CategoryId = 3

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 8,
				Name = "Nicoletti Lux bed with lifting mechanism",
				Description = "A double soft bed with a high headboard. This magnificent bed provides a comfortable sleeping place for you and your significant other.",
				ImageURL = "/images/Bed/bed3.png",
				Price = 500,
				Quantity = 10,
				CategoryId = 3

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 9,
				Name = "AGATHA - bed",
				Description = "There is a sense of modernity and naturalness in the model, unity with your soulmate and complete freedom for individuality.",
				ImageURL = "/images/Bed/bed4.png",
				Price = 600,
				Quantity = 20,
				CategoryId = 3

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 10,
				Name = "Bed made of solid oak Piastre",
				Description = "The Piastre bed is made of solid oak with a thickness of 40 mm, which makes the bed strong and solid. Thanks to the laconic design, the bed looks weightless and floats freely in the room.",
				ImageURL = "/images/Bed/bed5.png",
				Price = 690,
				Quantity = 15,
				CategoryId = 3

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 11,
				Name = "LINDA bed",
				Description = "The bed from the LINDA collection is a combination of modern design trends, impeccable quality and environmentally friendly materials.",
				ImageURL = "/images/Bed/bed6.png",
				Price = 710,
				Quantity = 9,
				CategoryId = 3
			});
			//Table Category
			modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 18,
                Name = "Dining table Lagus",
                Description = "Excellent dining table made in loft style",
                ImageURL = "/images/Table/table1.png",
                Price = 300,
                Quantity = 23,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 19,
                Name = "Millwood Cape Town Dining Table",
                Description = "The unusual shape of the base makes the table not only practical, but also decorative. A stylish addition to your interior",
                ImageURL = "/images/Table/table2.png",
                Price = 220,
                Quantity = 30,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 20,
                Name = "Kitchen table Reima 5",
                Description = "The classic rectangular table top is located on a chipboard base and four stable metal legs of contrasting color.",
                ImageURL = "/images/Table/table3.png",
                Price = 250,
                Quantity = 190,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 21,
                Name = "Bacchus 110 dining table",
                Description = "Legs are an array of alder, the table top is MDF, lined with natural oak veneer, covered with white enamel,",
                ImageURL = "/images/Table/table4.png",
                Price = 210,
                Quantity = 17,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 22,
                Name = "DOLCE NEWECONOM table",
                Description = "Original table in a modern style will be a great addition to the kitchen or dining area. The round table top is made of MDF, painted white. Legs made of metal painted in the color of wood",
                ImageURL = "/images/Table/table5.png",
                Price = 140,
                Quantity = 100,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 23,
                Name = "Coffee table Halmar Mariffka",
                Description = "Stylish coffee table will fit perfectly into your interior",
                ImageURL = "/images/Table/table6.png",
                Price = 170,
                Quantity = 34,
                CategoryId = 4
            });

            //Add users
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                UserName = "Bob"

            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 2,
                UserName = "Sarah"

            });

            //Create Shopping Cart for Users
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 1,
                UserId = 1

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 2,
                UserId = 2

            });
            //Add Product Categories
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 1,
                Name = "Sofas"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
				Id = 2,
                Name = "Chairs"
			});
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 3,
                Name = "Beds"
			});
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 4,
                Name = "Tables"
            });
        }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				// Здесь добавьте настройки подключения к базе данных, включая строку подключения и сборку миграций
				optionsBuilder.UseSqlServer("ShopStyleInAllThingsConnection", b => b.MigrationsAssembly("Shop.StyleInAllThings.API"));
			}
		}

		public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
