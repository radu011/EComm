﻿// <auto-generated />
using System;
using EComm.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EComm.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230410163349_UserRole")]
    partial class UserRole
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EComm.Shared.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("EComm.Shared.CartItem", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("UserId", "ProductId", "ProductTypeId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("EComm.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Placi video",
                            Url = "placiVideo"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Procesoare",
                            Url = "procesoare"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Memorii",
                            Url = "memorii"
                        });
                });

            modelBuilder.Entity("EComm.Shared.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("EComm.Shared.OrderItem", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId", "ProductId", "ProductTypeId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("EComm.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Featured")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Cea mai recentă iteratie a gamei iconice MSI GAMING aduce din nou performantă, eficientă redusă a zgomotului si estetică pe care jucătorii hardcore au ajuns să o recunoască si să aibă încredere. Acum si tu te poti bucura de toate jocurile tale preferate cu o placă grafică puternică, care rămâne rece si silentioasă. Asa cum îti place.",
                            Featured = false,
                            ImageUrl = "https://s1.cel.ro/images/Products/placa-video-msi-geforce-rtx-3060-gaming-x-12gb-gddr6-192-bit.jpg",
                            Title = "Placa video MSI GAMING X NVIDIA GeForce RTX 3060 12GB GDDR6 192-bit"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Designul premiat MSI TORX Fan 3.0 mentine limitele performantei termice în rotatie. Palele ventilatorului alternează între palele traditionale si paletele de dispersie care concentrează si accelerează fluxul de aer în radiator.",
                            Featured = false,
                            ImageUrl = "https://s1.cel.ro/images/Products/2022/10/13/MSI-GeForce-RTX-3050-VENTUS-2X-8G-OC-NVIDIA-8-Giga-Bites-GDDR6.jpg",
                            Title = "Placa Video MSI NVIDIA GeForce RTX 3050 VENTUS 2X OC 8GB GDDR6 128-bit"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Sistemul de răcire WINDFORCE are trei ventilatoare cu pale unice de 110 mm, rotatie alternativă, 10 conducte de căldură din cupru compozit, o cameră mare de vapori atinge direct GPU-ul, ventilatoare active 3D si răcire cu ecran, care împreună asigură disiparea căldurii de înaltă eficientă.",
                            Featured = true,
                            ImageUrl = "https://s1.cel.ro/images/Products/2022/10/12/Placa-Video-GIGABYTE-GeForce-RTX-4090-Gaming-24GB-GDDR6X-384-bit-N4090GAMING-OC-24G.jpg",
                            Title = "Placa Video GIGABYTE GeForce RTX 4090 Gaming OC 24GB GDDR6X 384-bit"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "AMD StoreMI Technology\r\n\r\nO modalitate rapidă si usoară de a extinde si accelera stocarea pe un computer desktop cu un procesor AMD Ryzen.",
                            Featured = false,
                            ImageUrl = "https://s1.cel.ro/images/Products/procesor-amd-ryzen-7-5800x-38ghz-socket-am4-box.jpg",
                            Title = "Procesor AMD Ryzen 7 5800X up to 4.7GHz Socket AM4 Box"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "Măriti -vă productivitatea, jocurile si crearea de continut cuprocesorul Intel Core i9-13900K 3 GHz 24-Core LGA 1700Acest procesor desktop din generatia a 13-a se bazează pe arhitectura Hybrid Core si pe procesul Intel 7 prin potrivirea a 24 de nuclee – cu opt mai multe decât generatia anterioară – într-un singur procesor, în timp ce încă se potriveste socket-ului LGA 1700. Conceput pentru a oferi performante exceptionale, Core i9-13900K dispune de 16 nuclee eficiente de joasă tensiune care se ocupă de sarcini de fundal pentru multitasking, în timp ce cele opt nuclee de performantă de 3 GHz oferă viteză pentru aplicatii si jocuri solicitante. Intel Thread Director încorporat asigură că cele două functionează perfect împreună, atribuind în mod dinamic si inteligent sarcinile de lucru nucleului potrivit, la momentul potrivit.",
                            Featured = false,
                            ImageUrl = "https://s1.cel.ro/images/Products/2022/10/26/Procesor-Intel-Raptor-Lake-Core-i9-13900K-3-0GHz-Box-BX8071513900K.jpg",
                            Title = "Procesor Intel Core i9-13900K 3.0GHz LGA 1700 Raptor Lake Box"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Description = "Schimbă modul în care joci\r\n\r\nCând PC-ul tău are cel mai avansat procesor desktop din lume pentru jucători, te poti concentra pe ceea ce contează cu adevărat: să fii victorios pe câmpul de luptă digital. Indiferent dacă jucati cele mai recente titluri sau revedeti un clasic, procesoarele AMD Ryzen™ din seria 7000 sunt o putere de gaming cu nuclee „Zen 4” de înaltă performantă. Cu până la 16 nuclee, 32 fire de executie, ceasuri sporite de până la 5,7 GHz2si până la 80 MB de memorie cache, procesoarele AMD Ryzen 7000 Series oferă performante care schimbă jocul.",
                            Featured = true,
                            ImageUrl = "https://s1.cel.ro/images/Products/2022/12/28/Procesor-AMD-Ryzen-9-7900-3-7GHz-Box-Socket-AM5-100-100000590BOX.jpg",
                            Title = "Procesor AMD Ryzen 9 7900 3.7GHz Box Socket AM5"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Description = "Kingston FURY™ Beast DDR4 oferă un puternic plus de performantă pentru jocuri, editare video si redare cu viteze până la 3733MHz si capacităti ale kittului de 8GB–128GB. Dispune de overclocking automat Plug N Play la viteze de 2666 MHz 1 si este pregătit atât pentru Intel XMP, cât si pentru AMD Ryzen. FURY Beast DDR4 lucrează la temperatură scăzută datorată radiatorului său de căldură elegant, cu profil redus. Testat la viteză 100% si sustinută de garantie pe viată, este un upgrade usor, fără griji, pentru sistemul tău Intel sau AMD.",
                            Featured = false,
                            ImageUrl = "https://s1.cel.ro/images/Products/2021/09/02/Kit-Memorie-Kingston-FURY-Beast-32GB-2x-16-GB-DDR4-3200MHz-CL16-Dual-Channel.jpg",
                            Title = "Kit Memorie Kingston FURY Beast 32GB 2x16GB DDR4 3200MHz CL16 Dual Channel"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Description = "Kingston FURY™ Beast DDR4 oferă un puternic plus de performantă pentru jocuri, editare video si redare cu viteze până la 3733MHz si capacităti ale kittului de 8GB–128GB. Dispune de overclocking automat Plug N Play la viteze de 2666 MHz 1 si este pregătit atât pentru Intel XMP, cât si pentru AMD Ryzen. FURY Beast DDR4 lucrează la temperatură scăzută datorată radiatorului său de căldură elegant, cu profil redus. Testat la viteză 100% si sustinută de garantie pe viată, este un upgrade usor, fără griji, pentru sistemul tău Intel sau AMD.",
                            Featured = false,
                            ImageUrl = "https://s1.cel.ro/images/Products/memorie-ram-kingston-dimm-ddr4-16gb-2x8gb-cl16-3200mhz.jpg",
                            Title = "Kit Memorie Kingston Fury Beast 16GB 2X8GB DDR4 3200Mhz Dual Channel CL16"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            Description = "Memoriile Kingston FURY™ Beast DDR5 aduc cea mai recenta tehnologie de ultima generatie pentru platformele de jocuri de ultima generatie. Ducand viteza, capacitatea si fiabilitatea si mai departe, DDR5 soseste cu un arsenal de caracteristici imbunatatite, cum ar fi ECC on-die (ODECC) pentru o stabilitate imbunatatita la viteze extreme, subcanale duale pe 32 de biti pentru o eficienta sporita si un circuit integrat de gestionare a energiei (PMIC) pe modul pentru a furniza energie acolo unde este cel mai necesar.",
                            Featured = true,
                            ImageUrl = "https://s1.cel.ro/images/Products/memorie-ram-kingston-fury-beast-dimm-ddr5-32-gb-2x16gb-cl40-5200-mhz.jpg",
                            Title = "Kit Memorie Kingston FURY Beast Black 32GB 2x16GB DDR5 5200MHz CL40 Dual Channel"
                        });
                });

            modelBuilder.Entity("EComm.Shared.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "New"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Used"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Refurbished"
                        },
                        new
                        {
                            Id = 4,
                            Name = "New gen"
                        });
                });

            modelBuilder.Entity("EComm.Shared.ProductVariant", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId", "ProductTypeId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("ProductVariants");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 1,
                            OriginalPrice = 2349.99m,
                            Price = 2249.99m
                        },
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 2,
                            OriginalPrice = 0m,
                            Price = 1249.99m
                        },
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 3,
                            OriginalPrice = 1749.99m,
                            Price = 1649.99m
                        },
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 4,
                            OriginalPrice = 0m,
                            Price = 2549.99m
                        },
                        new
                        {
                            ProductId = 2,
                            ProductTypeId = 1,
                            OriginalPrice = 0m,
                            Price = 2249.99m
                        },
                        new
                        {
                            ProductId = 3,
                            ProductTypeId = 2,
                            OriginalPrice = 1299.99m,
                            Price = 1249.99m
                        },
                        new
                        {
                            ProductId = 4,
                            ProductTypeId = 3,
                            OriginalPrice = 0m,
                            Price = 1649.99m
                        },
                        new
                        {
                            ProductId = 5,
                            ProductTypeId = 4,
                            OriginalPrice = 2799.99m,
                            Price = 2549.99m
                        },
                        new
                        {
                            ProductId = 6,
                            ProductTypeId = 2,
                            OriginalPrice = 0m,
                            Price = 1249.99m
                        },
                        new
                        {
                            ProductId = 7,
                            ProductTypeId = 3,
                            OriginalPrice = 0m,
                            Price = 1649.99m
                        },
                        new
                        {
                            ProductId = 8,
                            ProductTypeId = 4,
                            OriginalPrice = 2799.99m,
                            Price = 3199.99m
                        });
                });

            modelBuilder.Entity("EComm.Shared.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EComm.Shared.Address", b =>
                {
                    b.HasOne("EComm.Shared.User", null)
                        .WithOne("Address")
                        .HasForeignKey("EComm.Shared.Address", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EComm.Shared.OrderItem", b =>
                {
                    b.HasOne("EComm.Shared.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EComm.Shared.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EComm.Shared.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("EComm.Shared.Product", b =>
                {
                    b.HasOne("EComm.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EComm.Shared.ProductVariant", b =>
                {
                    b.HasOne("EComm.Shared.Product", "Product")
                        .WithMany("Variants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EComm.Shared.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("EComm.Shared.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("EComm.Shared.Product", b =>
                {
                    b.Navigation("Variants");
                });

            modelBuilder.Entity("EComm.Shared.User", b =>
                {
                    b.Navigation("Address")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
