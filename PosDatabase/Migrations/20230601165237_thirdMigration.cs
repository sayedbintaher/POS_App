using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PosApi.Migrations
{
    public partial class thirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_InvoiceDetails_InvoiceDetailsId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_InvoiceDetails_Invoice_DetailsId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_Invoice_DetailsId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_InvoiceDetailsId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "Invoice_DetailsId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "InvoiceDetailsId",
                table: "Invoices");

            migrationBuilder.RenameColumn(
                name: "CustomerPhone",
                table: "Invoices",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "CustomerName",
                table: "Invoices",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "InvoiceId",
                table: "InvoiceDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "InvoiceDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "InvoiceDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDetails_InvoiceId",
                table: "InvoiceDetails",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDetails_ProductId",
                table: "InvoiceDetails",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDetails_Invoices_InvoiceId",
                table: "InvoiceDetails",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDetails_Products_ProductId",
                table: "InvoiceDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDetails_Invoices_InvoiceId",
                table: "InvoiceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDetails_Products_ProductId",
                table: "InvoiceDetails");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceDetails_InvoiceId",
                table: "InvoiceDetails");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceDetails_ProductId",
                table: "InvoiceDetails");

            migrationBuilder.DropColumn(
                name: "InvoiceId",
                table: "InvoiceDetails");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "InvoiceDetails");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "InvoiceDetails");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Invoices",
                newName: "CustomerPhone");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Invoices",
                newName: "CustomerName");

            migrationBuilder.AddColumn<int>(
                name: "Invoice_DetailsId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InvoiceDetailsId",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_Invoice_DetailsId",
                table: "Products",
                column: "Invoice_DetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_InvoiceDetailsId",
                table: "Invoices",
                column: "InvoiceDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_InvoiceDetails_InvoiceDetailsId",
                table: "Invoices",
                column: "InvoiceDetailsId",
                principalTable: "InvoiceDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_InvoiceDetails_Invoice_DetailsId",
                table: "Products",
                column: "Invoice_DetailsId",
                principalTable: "InvoiceDetails",
                principalColumn: "Id");
        }
    }
}
