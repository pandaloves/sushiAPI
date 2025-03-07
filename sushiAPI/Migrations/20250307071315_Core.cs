using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sushiAPI.Migrations
{
    /// <inheritdoc />
    public partial class Core : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ProductDescription",
                value: "3 lax, 1 r�ka, 1 avokado, 3 futomakirullar med chilimajonn�s, �l s�s, sesamfr�, rom och rostad l�k.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ProductDescription",
                value: "3 lax, 1 r�ka, 1 avokado, 1 tonfisk, 1 bl�ckfisk, 4 futomakirullar med chilimajonn�s, �l s�s, sesamfr�, rom och rostad l�k.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ProductDescription",
                value: "5 lax, 1 r�ka, 1 avokado, 1 tonfisk, 1 hokkigai mussla, 1 bl�ckfisk, 4 futomakirullar med chilimajonn�s, �l s�s, sesamfr�, rom och rostad l�k.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "ProductDescription", "ProductName" },
                values: new object[] { "Halstrad lax med chilimajonn�s, �ls�s, sesamfr� och rostad l�k.", "L�tt grillad 8 bitar" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "ProductDescription",
                value: "3 lax, 1 r�ka, 1 avokado, 1 tonfisk, 1 hokkigai mussla, 1 pilgrims mussla, 1 sardin, 1 �l, 1 bl�ckfisk, chillimajon�s, �ls�s, sesamfr�, rom och rostad l�k.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "ProductDescription",
                value: "9 bitar laxnigiri med chilimajonn�s, �l s�s, sesamfr�, rom och rostad l�k.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "ProductDescription",
                value: "5 lax, 4 avokado, chilimajonn�s, �l s�s, sesamfr�, rom och rostad l�k.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "ProductDescription", "ProductName" },
                values: new object[] { "5 lax, 4 r�kor, chilimajonn�s, �l s�s, sesamfr�, rom och rostad l�k.", "Lax r�kor sushi 9 bitar" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "ProductDescription", "ProductName" },
                values: new object[] { "9 bitar r�knigiri med chilimajonn�s, �l s�s, sesamfr�, rom och rostad l�k.", "R�k sushi 9 bitar" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "ProductDescription",
                value: "3 avokado, 2 tofu, 4 vegetariska rullar, edamame, soya s�s, sesamfr� och rostad l�k.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "ProductDescription",
                value: "5 avokado, 3 tofu, 4 vegetariska rullar, edamame, soya s�s, sesamfr� och rostad l�k.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "ProductDescription",
                value: "2 avokado, 1 r�ka, 1 tofu, 1 crabstick surimi, 4 vegetariska rullar, chilimajonn�s, soya s�s, sesamfr� och rostad l�k.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "ProductDescription",
                value: "4 avokado, 1 r�ka, 2 tofu, 1 crabstick surimi, 4 vegetariska rullar, chilimajonn�s, soya s�s, sesamfr� och rostad l�k.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "ProductDescription",
                value: "Olika sorters r� fisk med blandad sallad, chilimajonn�s, �l s�s, sesamfr� och rostad l�k");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "ProductDescription",
                value: "Olika sorters r� fisk med blandad sallad, chilimajonn�s, �l s�s, sesamfr�, rom och rostad l�k.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "ProductDescription",
                value: "Lax, tonfisk, avokado, gurka, crabstick surimi, �l s�s, chilimajonn�s, sesamfr� och rostad l�k.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ProductDescription",
                value: "3 lax, 1 räka, 1 avokado, 3 futomakirullar med chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ProductDescription",
                value: "3 lax, 1 räka, 1 avokado, 1 tonfisk, 1 bläckfisk, 4 futomakirullar med chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ProductDescription",
                value: "5 lax, 1 räka, 1 avokado, 1 tonfisk, 1 hokkigai mussla, 1 bläckfisk, 4 futomakirullar med chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "ProductDescription", "ProductName" },
                values: new object[] { "Halstrad lax med chilimajonnäs, ålsås, sesamfrö och rostad lök.", "Lätt grillad 8 bitar" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "ProductDescription",
                value: "3 lax, 1 räka, 1 avokado, 1 tonfisk, 1 hokkigai mussla, 1 pilgrims mussla, 1 sardin, 1 ål, 1 bläckfisk, chillimajonäs, ålsås, sesamfrö, rom och rostad lök.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "ProductDescription",
                value: "9 bitar laxnigiri med chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "ProductDescription",
                value: "5 lax, 4 avokado, chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "ProductDescription", "ProductName" },
                values: new object[] { "5 lax, 4 räkor, chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.", "Lax räkor sushi 9 bitar" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "ProductDescription", "ProductName" },
                values: new object[] { "9 bitar räknigiri med chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.", "Räk sushi 9 bitar" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "ProductDescription",
                value: "3 avokado, 2 tofu, 4 vegetariska rullar, edamame, soya sås, sesamfrö och rostad lök.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "ProductDescription",
                value: "5 avokado, 3 tofu, 4 vegetariska rullar, edamame, soya sås, sesamfrö och rostad lök.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "ProductDescription",
                value: "2 avokado, 1 räka, 1 tofu, 1 crabstick surimi, 4 vegetariska rullar, chilimajonnäs, soya sås, sesamfrö och rostad lök.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "ProductDescription",
                value: "4 avokado, 1 räka, 2 tofu, 1 crabstick surimi, 4 vegetariska rullar, chilimajonnäs, soya sås, sesamfrö och rostad lök.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "ProductDescription",
                value: "Olika sorters rå fisk med blandad sallad, chilimajonnäs, ål sås, sesamfrö och rostad lök");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "ProductDescription",
                value: "Olika sorters rå fisk med blandad sallad, chilimajonnäs, ål sås, sesamfrö, rom och rostad lök.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "ProductDescription",
                value: "Lax, tonfisk, avokado, gurka, crabstick surimi, ål sås, chilimajonnäs, sesamfrö och rostad lök.");
        }
    }
}
