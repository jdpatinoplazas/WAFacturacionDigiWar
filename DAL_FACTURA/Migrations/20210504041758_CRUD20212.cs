using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL_FACTURA.Migrations
{
    public partial class CRUD20212 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "cantidadProducto",
                schema: "dbo",
                table: "Factura",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idVenta",
                schema: "dbo",
                table: "Factura",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "precioProducto",
                schema: "dbo",
                table: "Factura",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cantidadProducto",
                schema: "dbo",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "idVenta",
                schema: "dbo",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "precioProducto",
                schema: "dbo",
                table: "Factura");
        }
    }
}
