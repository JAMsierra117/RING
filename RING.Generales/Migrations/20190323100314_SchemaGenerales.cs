using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RING.Generales.Migrations
{
    public partial class SchemaGenerales : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Generales");

            migrationBuilder.CreateTable(
                name: "Clasificaciones",
                schema: "Generales",
                columns: table => new
                {
                    ID_Clasificacion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clasificaciones", x => x.ID_Clasificacion);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                schema: "Generales",
                columns: table => new
                {
                    ID_Producto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CodigoProducto = table.Column<string>(nullable: true),
                    NombreProducto = table.Column<string>(nullable: true),
                    ID_Clasificacion = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.ID_Producto);
                    table.ForeignKey(
                        name: "FK_Productos_Clasificaciones_ID_Clasificacion",
                        column: x => x.ID_Clasificacion,
                        principalSchema: "Generales",
                        principalTable: "Clasificaciones",
                        principalColumn: "ID_Clasificacion",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Productos_ID_Clasificacion",
                schema: "Generales",
                table: "Productos",
                column: "ID_Clasificacion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos",
                schema: "Generales");

            migrationBuilder.DropTable(
                name: "Clasificaciones",
                schema: "Generales");
        }
    }
}
