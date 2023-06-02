using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PosApi.Migrations
{
    public partial class random : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Invoices",
                newName: "CustomerPhone");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Invoices",
                newName: "CustomerName");

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "InvoiceDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "InvoiceDetails");

            migrationBuilder.RenameColumn(
                name: "CustomerPhone",
                table: "Invoices",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "CustomerName",
                table: "Invoices",
                newName: "Name");
        }
    }
}
