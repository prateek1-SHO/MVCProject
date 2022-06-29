using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mango.Services.ProductAPI.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CotegoryName", "ImageUrl", "Price", "ProductDescription", "ProductName" },
                values: new object[,]
                {
                    { 1, "Apptizer", "", 24.0, " aeejwefjiwrnrnwe", "Prateek" },
                    { 2, "Apptizer", "", 24.0, " aeejwefjiwrnrnwe", "Prateek" },
                    { 3, "Apptizer", "", 24.0, " aeejwefjiwrnrnwe", "Prateek" },
                    { 4, "Apptizer", "", 24.0, " aeejwefjiwrnrnwe", "Raman Singh" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4);
        }
    }
}
