using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PosApi.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProuctName",
                table: "Products",
                newName: "ProductName");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Invoice_DetailsId", "Price", "ProductCode", "ProductName" },
                values: new object[,]
                {
                    { 1, null, 180, "SO1", "Soyabean Oil 1" },
                    { 2, null, 50, "AS1", "ACI Salt 1" },
                    { 3, null, 40, "LS1", "Lifeboy Body Soap" },
                    { 4, null, 5, "MP1", "Matador Pen" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "Products",
                newName: "ProuctName");
        }
    }
}
