﻿namespace EComm.Server.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>().HasData(
					new Product
					{
						Id = 1,
						Title = "Placa video MSI GAMING X NVIDIA GeForce RTX 3060 12GB GDDR6 192-bit",
						Description = "Cea mai recentă iteratie a gamei iconice MSI GAMING aduce din nou performantă, eficientă redusă a zgomotului si estetică pe care jucătorii hardcore au ajuns să o recunoască si să aibă încredere. Acum si tu te poti bucura de toate jocurile tale preferate cu o placă grafică puternică, care rămâne rece si silentioasă. Asa cum îti place.",
						ImageUrl = "https://s1.cel.ro/images/Products/placa-video-msi-geforce-rtx-3060-gaming-x-12gb-gddr6-192-bit.jpg",
						Price = 2249.99m
					},
					new Product
					{
						Id = 2,
						Title = "Placa Video MSI NVIDIA GeForce RTX 3050 VENTUS 2X OC 8GB GDDR6 128-bit",
						Description = "Designul premiat MSI TORX Fan 3.0 mentine limitele performantei termice în rotatie. Palele ventilatorului alternează între palele traditionale si paletele de dispersie care concentrează si accelerează fluxul de aer în radiator.",
						ImageUrl = "https://s1.cel.ro/images/Products/2022/10/13/MSI-GeForce-RTX-3050-VENTUS-2X-8G-OC-NVIDIA-8-Giga-Bites-GDDR6.jpg",
						Price = 1477m
					},
					new Product
					{
						Id = 3,
						Title = "Placa Video GIGABYTE GeForce RTX 4090 Gaming OC 24GB GDDR6X 384-bit",
						Description = "Sistemul de răcire WINDFORCE are trei ventilatoare cu pale unice de 110 mm, rotatie alternativă, 10 conducte de căldură din cupru compozit, o cameră mare de vapori atinge direct GPU-ul, ventilatoare active 3D si răcire cu ecran, care împreună asigură disiparea căldurii de înaltă eficientă.",
						ImageUrl = "https://s1.cel.ro/images/Products/2022/10/12/Placa-Video-GIGABYTE-GeForce-RTX-4090-Gaming-24GB-GDDR6X-384-bit-N4090GAMING-OC-24G.jpg",
						Price = 9599.90m
					}
				);
		}

		public DbSet<Product> Products { get; set; }
	}
}
