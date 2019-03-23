using Microsoft.EntityFrameworkCore.Migrations;

namespace RING.Compras.Migrations
{
    public partial class SchemaCompras : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Compras");

            migrationBuilder.RenameTable(
                name: "Proveedores",
                newName: "Proveedores",
                newSchema: "Compras");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Proveedores",
                schema: "Compras",
                newName: "Proveedores");
        }
    }
}
