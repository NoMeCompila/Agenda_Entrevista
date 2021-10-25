using Microsoft.EntityFrameworkCore.Migrations;

namespace ultimoBack.Migrations
{
    public partial class migracion1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empleo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    puesto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    empresa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    recriuter = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    correo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    fecha = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleo", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empleo");
        }
    }
}
