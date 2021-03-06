// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineStore.Data;

namespace OnlineStore.Migrations
{
    [DbContext(typeof(OnlineStoreDbContext))]
    partial class OnlineStoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineStore.Models.Database.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(128)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(32)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Vegetables"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Fruits"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Groceries"
                        });
                });

            modelBuilder.Entity("OnlineStore.Models.Database.Comment", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("ntext");

                    b.HasKey("ProductId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("OnlineStore.Models.Database.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Path = "carrots.jpg"
                        },
                        new
                        {
                            Id = 2,
                            Path = "handwash.jpg"
                        },
                        new
                        {
                            Id = 3,
                            Path = "onions.jpg"
                        },
                        new
                        {
                            Id = 4,
                            Path = "oranges.jpg"
                        },
                        new
                        {
                            Id = 5,
                            Path = "potatos.jpg"
                        });
                });

            modelBuilder.Entity("OnlineStore.Models.Database.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<bool?>("CommentsEnabled")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatorUserId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsUnicode(true)
                        .HasColumnType("ntext");

                    b.Property<int>("ImageId")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(7,2)");

                    b.Property<string>("Producer")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CreatorUserId");

                    b.HasIndex("ImageId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CommentsEnabled = true,
                            CreationTime = new DateTime(2022, 7, 1, 12, 1, 15, 267, DateTimeKind.Local).AddTicks(7980),
                            CreatorUserId = 3,
                            Description = "Organic fresh Potatos.",
                            ImageId = 1,
                            Model = "",
                            Price = 40.00,
                            Producer = "Vegetable"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CommentsEnabled = true,
                            CreationTime = new DateTime(2022, 7, 1, 12, 1, 15, 267, DateTimeKind.Local).AddTicks(8542),
                            CreatorUserId = 3,
                            Description = "Organic fresh Onions. ",
                            ImageId = 2,
                            Model = "",
                            Price = 40.00,
                            Producer = "Vegetable"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            CommentsEnabled = true,
                            CreationTime = new DateTime(2022, 7, 1, 12, 1, 15, 267, DateTimeKind.Local).AddTicks(8548),
                            CreatorUserId = 3,
                            Description = "Organic fresh Carrots",
                            ImageId = 3,
                            Model = "",
                            Price = 30.00,
                            Producer = "Fruit"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            CommentsEnabled = true,
                            CreationTime = new DateTime(2022, 7, 1, 12, 1, 15, 267, DateTimeKind.Local).AddTicks(8550),
                            CreatorUserId = 3,
                            Description = "Organic fresh oranges",
                            ImageId = 4,
                            Model = "",
                            Price = 40.00,
                            Producer = "Fruit"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 3,
                            CommentsEnabled = true,
                            CreationTime = new DateTime(2022, 7, 1, 12, 1, 15, 267, DateTimeKind.Local).AddTicks(8552),
                            CreatorUserId = 3,
                            Description = "New germicheck handwash.",
                            ImageId = 5,
                            Model = "",
                            Price = 110.00,
                            Producer = "Dettol"
                        });
                });

            modelBuilder.Entity("OnlineStore.Models.Database.Purchase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("FullPrice")
                        .HasColumnType("decimal(8,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("OnlineStore.Models.Database.PurchaseProduct", b =>
                {
                    b.Property<int>("PurchaseId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.HasKey("PurchaseId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("PurchaseProducts");
                });

            modelBuilder.Entity("OnlineStore.Models.Database.Rate", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Rates");
                });

            modelBuilder.Entity("OnlineStore.Models.Database.ShoppingCart", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.HasKey("UserId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("OnlineStore.Models.Database.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasMaxLength(256)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("AuthValue")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(128)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(128)");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("PasswordHash")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adress = "",
                            CreationTime = new DateTime(2022, 7, 1, 12, 1, 15, 262, DateTimeKind.Local).AddTicks(7795),
                            Email = "vasylvlasiuk@gmail.com",
                            LastLogin = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Vasyl",
                            PasswordHash = "%�Z҃�@\n�d�mq<�",
                            RoleId = 1,
                            Surname = "Vlasiuk"
                        },
                        new
                        {
                            Id = 2,
                            Adress = "",
                            CreationTime = new DateTime(2022, 7, 1, 12, 1, 15, 267, DateTimeKind.Local).AddTicks(5134),
                            Email = "johndoe@gmail.com",
                            LastLogin = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "John",
                            PasswordHash = "1[��N�W��?�}",
                            RoleId = 2,
                            Surname = "Doe"
                        },
                        new
                        {
                            Id = 3,
                            Adress = "",
                            CreationTime = new DateTime(2022, 7, 1, 12, 1, 15, 267, DateTimeKind.Local).AddTicks(5508),
                            Email = "ostepbondar@gmail.com",
                            LastLogin = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ostap",
                            PasswordHash = "^�g�9ƏQE�/���\"	",
                            RoleId = 3,
                            Surname = "Bondar"
                        });
                });

            modelBuilder.Entity("OnlineStore.Models.Database.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("Id");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Name = "Administrator"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Vendor"
                        },
                        new
                        {
                            Id = 1,
                            Name = "SimpleUser"
                        });
                });

            modelBuilder.Entity("OnlineStore.Models.Database.Comment", b =>
                {
                    b.HasOne("OnlineStore.Models.Database.Product", "Product")
                        .WithMany("Comments")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineStore.Models.Database.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OnlineStore.Models.Database.Product", b =>
                {
                    b.HasOne("OnlineStore.Models.Database.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineStore.Models.Database.User", "CreatorUser")
                        .WithMany("Products")
                        .HasForeignKey("CreatorUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineStore.Models.Database.Image", "Image")
                        .WithMany("Products")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("CreatorUser");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("OnlineStore.Models.Database.Purchase", b =>
                {
                    b.HasOne("OnlineStore.Models.Database.User", "User")
                        .WithMany("Purchases")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("OnlineStore.Models.Database.PurchaseProduct", b =>
                {
                    b.HasOne("OnlineStore.Models.Database.Product", "Product")
                        .WithMany("PurchaseProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineStore.Models.Database.Purchase", "Purchase")
                        .WithMany("PurchaseProducts")
                        .HasForeignKey("PurchaseId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Purchase");
                });

            modelBuilder.Entity("OnlineStore.Models.Database.Rate", b =>
                {
                    b.HasOne("OnlineStore.Models.Database.Product", "Product")
                        .WithMany("Rates")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineStore.Models.Database.User", "User")
                        .WithMany("Rates")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OnlineStore.Models.Database.ShoppingCart", b =>
                {
                    b.HasOne("OnlineStore.Models.Database.Product", "Product")
                        .WithMany("ShoppingCarts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineStore.Models.Database.User", "User")
                        .WithMany("ShoppingCart")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OnlineStore.Models.Database.User", b =>
                {
                    b.HasOne("OnlineStore.Models.Database.UserRole", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("OnlineStore.Models.Database.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("OnlineStore.Models.Database.Image", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("OnlineStore.Models.Database.Product", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("PurchaseProducts");

                    b.Navigation("Rates");

                    b.Navigation("ShoppingCarts");
                });

            modelBuilder.Entity("OnlineStore.Models.Database.Purchase", b =>
                {
                    b.Navigation("PurchaseProducts");
                });

            modelBuilder.Entity("OnlineStore.Models.Database.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Products");

                    b.Navigation("Purchases");

                    b.Navigation("Rates");

                    b.Navigation("ShoppingCart");
                });

            modelBuilder.Entity("OnlineStore.Models.Database.UserRole", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
