using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EComm.Server.Migrations
{
    public partial class SeedMoreProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 4, 1, "AMD StoreMI Technology\r\n\r\nO modalitate rapidă si usoară de a extinde si accelera stocarea pe un computer desktop cu un procesor AMD Ryzen.", "https://s1.cel.ro/images/Products/procesor-amd-ryzen-7-5800x-38ghz-socket-am4-box.jpg", 1164m, "Procesor AMD Ryzen 7 5800X up to 4.7GHz Socket AM4 Box" },
                    { 5, 2, "Măriti -vă productivitatea, jocurile si crearea de continut cuprocesorul Intel Core i9-13900K 3 GHz 24-Core LGA 1700Acest procesor desktop din generatia a 13-a se bazează pe arhitectura Hybrid Core si pe procesul Intel 7 prin potrivirea a 24 de nuclee – cu opt mai multe decât generatia anterioară – într-un singur procesor, în timp ce încă se potriveste socket-ului LGA 1700. Conceput pentru a oferi performante exceptionale, Core i9-13900K dispune de 16 nuclee eficiente de joasă tensiune care se ocupă de sarcini de fundal pentru multitasking, în timp ce cele opt nuclee de performantă de 3 GHz oferă viteză pentru aplicatii si jocuri solicitante. Intel Thread Director încorporat asigură că cele două functionează perfect împreună, atribuind în mod dinamic si inteligent sarcinile de lucru nucleului potrivit, la momentul potrivit.", "https://s1.cel.ro/images/Products/2022/10/26/Procesor-Intel-Raptor-Lake-Core-i9-13900K-3-0GHz-Box-BX8071513900K.jpg", 3179m, "Procesor Intel Core i9-13900K 3.0GHz LGA 1700 Raptor Lake Box" },
                    { 6, 2, "Schimbă modul în care joci\r\n\r\nCând PC-ul tău are cel mai avansat procesor desktop din lume pentru jucători, te poti concentra pe ceea ce contează cu adevărat: să fii victorios pe câmpul de luptă digital. Indiferent dacă jucati cele mai recente titluri sau revedeti un clasic, procesoarele AMD Ryzen™ din seria 7000 sunt o putere de gaming cu nuclee „Zen 4” de înaltă performantă. Cu până la 16 nuclee, 32 fire de executie, ceasuri sporite de până la 5,7 GHz2si până la 80 MB de memorie cache, procesoarele AMD Ryzen 7000 Series oferă performante care schimbă jocul.", "https://s1.cel.ro/images/Products/2022/12/28/Procesor-AMD-Ryzen-9-7900-3-7GHz-Box-Socket-AM5-100-100000590BOX.jpg", 2249m, "Procesor AMD Ryzen 9 7900 3.7GHz Box Socket AM5" },
                    { 7, 3, "Kingston FURY™ Beast DDR4 oferă un puternic plus de performantă pentru jocuri, editare video si redare cu viteze până la 3733MHz si capacităti ale kittului de 8GB–128GB. Dispune de overclocking automat Plug N Play la viteze de 2666 MHz 1 si este pregătit atât pentru Intel XMP, cât si pentru AMD Ryzen. FURY Beast DDR4 lucrează la temperatură scăzută datorată radiatorului său de căldură elegant, cu profil redus. Testat la viteză 100% si sustinută de garantie pe viată, este un upgrade usor, fără griji, pentru sistemul tău Intel sau AMD.", "https://s1.cel.ro/images/Products/2021/09/02/Kit-Memorie-Kingston-FURY-Beast-32GB-2x-16-GB-DDR4-3200MHz-CL16-Dual-Channel.jpg", 399m, "Kit Memorie Kingston FURY Beast 32GB 2x16GB DDR4 3200MHz CL16 Dual Channel" },
                    { 8, 3, "Kingston FURY™ Beast DDR4 oferă un puternic plus de performantă pentru jocuri, editare video si redare cu viteze până la 3733MHz si capacităti ale kittului de 8GB–128GB. Dispune de overclocking automat Plug N Play la viteze de 2666 MHz 1 si este pregătit atât pentru Intel XMP, cât si pentru AMD Ryzen. FURY Beast DDR4 lucrează la temperatură scăzută datorată radiatorului său de căldură elegant, cu profil redus. Testat la viteză 100% si sustinută de garantie pe viată, este un upgrade usor, fără griji, pentru sistemul tău Intel sau AMD.", "https://s1.cel.ro/images/Products/memorie-ram-kingston-dimm-ddr4-16gb-2x8gb-cl16-3200mhz.jpg", 219m, "Kit Memorie Kingston Fury Beast 16GB 2X8GB DDR4 3200Mhz Dual Channel CL16" },
                    { 9, 3, "Memoriile Kingston FURY™ Beast DDR5 aduc cea mai recenta tehnologie de ultima generatie pentru platformele de jocuri de ultima generatie. Ducand viteza, capacitatea si fiabilitatea si mai departe, DDR5 soseste cu un arsenal de caracteristici imbunatatite, cum ar fi ECC on-die (ODECC) pentru o stabilitate imbunatatita la viteze extreme, subcanale duale pe 32 de biti pentru o eficienta sporita si un circuit integrat de gestionare a energiei (PMIC) pe modul pentru a furniza energie acolo unde este cel mai necesar.", "https://s1.cel.ro/images/Products/memorie-ram-kingston-fury-beast-dimm-ddr5-32-gb-2x16gb-cl40-5200-mhz.jpg", 599m, "Kit Memorie Kingston FURY Beast Black 32GB 2x16GB DDR5 5200MHz CL40 Dual Channel" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
