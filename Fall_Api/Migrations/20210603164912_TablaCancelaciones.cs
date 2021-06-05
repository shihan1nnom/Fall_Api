using Microsoft.EntityFrameworkCore.Migrations;

namespace Fall_Api.Migrations
{
    public partial class TablaCancelaciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cancelaciones",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    oc = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    precio_despacho = table.Column<int>(type: "INTEGER", nullable: false),
                    monto_total_linea = table.Column<int>(type: "INTEGER", nullable: false),
                    sku_linea = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    f12 = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    tipo_abastecimiento = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    dup_oc = table.Column<int>(type: "INTEGER", nullable: false),
                    dup_f12 = table.Column<int>(type: "INTEGER", nullable: false),
                    estado_linea = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    estado_orden_oms = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    estado_cd = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cancelaciones", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cancelaciones");
        }
    }
}
