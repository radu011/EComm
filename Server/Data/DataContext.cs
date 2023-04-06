namespace EComm.Server.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>().HasData(
					new Category
					{
						Id = 1,
						Name = "Placi video",
						Url = "placiVideo"
					},
					new Category
					{
						Id = 2,
						Name = "Procesoare",
						Url = "procesoare"
					},
					new Category
					{
						Id = 3,
						Name = "Memorii",
						Url = "memorii"
					}
				);

			modelBuilder.Entity<Product>().HasData(
					new Product
					{
						Id = 1,
						Title = "Placa video MSI GAMING X NVIDIA GeForce RTX 3060 12GB GDDR6 192-bit",
						Description = "Cea mai recentă iteratie a gamei iconice MSI GAMING aduce din nou performantă, eficientă redusă a zgomotului si estetică pe care jucătorii hardcore au ajuns să o recunoască si să aibă încredere. Acum si tu te poti bucura de toate jocurile tale preferate cu o placă grafică puternică, care rămâne rece si silentioasă. Asa cum îti place.",
						ImageUrl = "https://s1.cel.ro/images/Products/placa-video-msi-geforce-rtx-3060-gaming-x-12gb-gddr6-192-bit.jpg",
						Price = 2249.99m,
						CategoryId = 1
					},
					new Product
					{
						Id = 2,
						Title = "Placa Video MSI NVIDIA GeForce RTX 3050 VENTUS 2X OC 8GB GDDR6 128-bit",
						Description = "Designul premiat MSI TORX Fan 3.0 mentine limitele performantei termice în rotatie. Palele ventilatorului alternează între palele traditionale si paletele de dispersie care concentrează si accelerează fluxul de aer în radiator.",
						ImageUrl = "https://s1.cel.ro/images/Products/2022/10/13/MSI-GeForce-RTX-3050-VENTUS-2X-8G-OC-NVIDIA-8-Giga-Bites-GDDR6.jpg",
						Price = 1477m,
						CategoryId = 1
					},
					new Product
					{
						Id = 3,
						Title = "Placa Video GIGABYTE GeForce RTX 4090 Gaming OC 24GB GDDR6X 384-bit",
						Description = "Sistemul de răcire WINDFORCE are trei ventilatoare cu pale unice de 110 mm, rotatie alternativă, 10 conducte de căldură din cupru compozit, o cameră mare de vapori atinge direct GPU-ul, ventilatoare active 3D si răcire cu ecran, care împreună asigură disiparea căldurii de înaltă eficientă.",
						ImageUrl = "https://s1.cel.ro/images/Products/2022/10/12/Placa-Video-GIGABYTE-GeForce-RTX-4090-Gaming-24GB-GDDR6X-384-bit-N4090GAMING-OC-24G.jpg",
						Price = 9599.90m,
						CategoryId = 1
					},
					new Product
					{
						Id = 4,
						Title = "Procesor AMD Ryzen 7 5800X up to 4.7GHz Socket AM4 Box",
						Description = "AMD StoreMI Technology\r\n\r\nO modalitate rapidă si usoară de a extinde si accelera stocarea pe un computer desktop cu un procesor AMD Ryzen.",
						ImageUrl = "https://s1.cel.ro/images/Products/procesor-amd-ryzen-7-5800x-38ghz-socket-am4-box.jpg",
						Price = 1164m,
						CategoryId = 1
					},
					new Product
					{
						Id = 5,
						Title = "Procesor Intel Core i9-13900K 3.0GHz LGA 1700 Raptor Lake Box",
						Description = "Măriti -vă productivitatea, jocurile si crearea de continut cuprocesorul Intel Core i9-13900K 3 GHz 24-Core LGA 1700Acest procesor desktop din generatia a 13-a se bazează pe arhitectura Hybrid Core si pe procesul Intel 7 prin potrivirea a 24 de nuclee – cu opt mai multe decât generatia anterioară – într-un singur procesor, în timp ce încă se potriveste socket-ului LGA 1700. Conceput pentru a oferi performante exceptionale, Core i9-13900K dispune de 16 nuclee eficiente de joasă tensiune care se ocupă de sarcini de fundal pentru multitasking, în timp ce cele opt nuclee de performantă de 3 GHz oferă viteză pentru aplicatii si jocuri solicitante. Intel Thread Director încorporat asigură că cele două functionează perfect împreună, atribuind în mod dinamic si inteligent sarcinile de lucru nucleului potrivit, la momentul potrivit.",
						ImageUrl = "https://s1.cel.ro/images/Products/2022/10/26/Procesor-Intel-Raptor-Lake-Core-i9-13900K-3-0GHz-Box-BX8071513900K.jpg",
						Price = 3179m,
						CategoryId = 2
					},
					new Product
					{
						Id = 6,
						Title = "Procesor AMD Ryzen 9 7900 3.7GHz Box Socket AM5",
						Description = "Schimbă modul în care joci\r\n\r\nCând PC-ul tău are cel mai avansat procesor desktop din lume pentru jucători, te poti concentra pe ceea ce contează cu adevărat: să fii victorios pe câmpul de luptă digital. Indiferent dacă jucati cele mai recente titluri sau revedeti un clasic, procesoarele AMD Ryzen™ din seria 7000 sunt o putere de gaming cu nuclee „Zen 4” de înaltă performantă. Cu până la 16 nuclee, 32 fire de executie, ceasuri sporite de până la 5,7 GHz2si până la 80 MB de memorie cache, procesoarele AMD Ryzen 7000 Series oferă performante care schimbă jocul.",
						ImageUrl = "https://s1.cel.ro/images/Products/2022/12/28/Procesor-AMD-Ryzen-9-7900-3-7GHz-Box-Socket-AM5-100-100000590BOX.jpg",
						Price = 2249m,
						CategoryId = 2
					},
					new Product
					{
						Id = 7,
						Title = "Kit Memorie Kingston FURY Beast 32GB 2x16GB DDR4 3200MHz CL16 Dual Channel",
						Description = "Kingston FURY™ Beast DDR4 oferă un puternic plus de performantă pentru jocuri, editare video si redare cu viteze până la 3733MHz si capacităti ale kittului de 8GB–128GB. Dispune de overclocking automat Plug N Play la viteze de 2666 MHz 1 si este pregătit atât pentru Intel XMP, cât si pentru AMD Ryzen. FURY Beast DDR4 lucrează la temperatură scăzută datorată radiatorului său de căldură elegant, cu profil redus. Testat la viteză 100% si sustinută de garantie pe viată, este un upgrade usor, fără griji, pentru sistemul tău Intel sau AMD.",
						ImageUrl = "https://s1.cel.ro/images/Products/2021/09/02/Kit-Memorie-Kingston-FURY-Beast-32GB-2x-16-GB-DDR4-3200MHz-CL16-Dual-Channel.jpg",
						Price = 399m,
						CategoryId = 3
					},
					new Product
					{
						Id = 8,
						Title = "Kit Memorie Kingston Fury Beast 16GB 2X8GB DDR4 3200Mhz Dual Channel CL16",
						Description = "Kingston FURY™ Beast DDR4 oferă un puternic plus de performantă pentru jocuri, editare video si redare cu viteze până la 3733MHz si capacităti ale kittului de 8GB–128GB. Dispune de overclocking automat Plug N Play la viteze de 2666 MHz 1 si este pregătit atât pentru Intel XMP, cât si pentru AMD Ryzen. FURY Beast DDR4 lucrează la temperatură scăzută datorată radiatorului său de căldură elegant, cu profil redus. Testat la viteză 100% si sustinută de garantie pe viată, este un upgrade usor, fără griji, pentru sistemul tău Intel sau AMD.",
						ImageUrl = "https://s1.cel.ro/images/Products/memorie-ram-kingston-dimm-ddr4-16gb-2x8gb-cl16-3200mhz.jpg",
						Price = 219m,
						CategoryId = 3
					},
					new Product
					{
						Id = 9,
						Title = "Kit Memorie Kingston FURY Beast Black 32GB 2x16GB DDR5 5200MHz CL40 Dual Channel",
						Description = "Memoriile Kingston FURY™ Beast DDR5 aduc cea mai recenta tehnologie de ultima generatie pentru platformele de jocuri de ultima generatie. Ducand viteza, capacitatea si fiabilitatea si mai departe, DDR5 soseste cu un arsenal de caracteristici imbunatatite, cum ar fi ECC on-die (ODECC) pentru o stabilitate imbunatatita la viteze extreme, subcanale duale pe 32 de biti pentru o eficienta sporita si un circuit integrat de gestionare a energiei (PMIC) pe modul pentru a furniza energie acolo unde este cel mai necesar.",
						ImageUrl = "https://s1.cel.ro/images/Products/memorie-ram-kingston-fury-beast-dimm-ddr5-32-gb-2x16gb-cl40-5200-mhz.jpg",
						Price = 599m,
						CategoryId = 3
					}
				);
		}

		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
	}
}
