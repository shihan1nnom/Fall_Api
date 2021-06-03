using Microsoft.EntityFrameworkCore.Migrations;

namespace Fall_Api.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Datos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    oc = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    f12 = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    sku = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    cc = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    estado = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Datos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Datos");
        }
    }
}
