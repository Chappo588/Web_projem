using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjeWeb.Data.Migrations
{
    public partial class TemelTablolar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tur",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TurAd = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tur", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Otel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OtelAd = table.Column<string>(nullable: true),
                    SehirMerkeziUzaklik = table.Column<double>(nullable: false),
                    Havuz = table.Column<bool>(nullable: false),
                    Bar = table.Column<bool>(nullable: false),
                    Spa = table.Column<bool>(nullable: false),
                    Restoran = table.Column<bool>(nullable: false),
                    Otopark = table.Column<bool>(nullable: false),
                    Resim = table.Column<string>(nullable: true),
                    Goster = table.Column<string>(nullable: true),
                    TurId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Otel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Otel_Tur_TurId",
                        column: x => x.TurId,
                        principalTable: "Tur",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Otel_TurId",
                table: "Otel",
                column: "TurId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Otel");

            migrationBuilder.DropTable(
                name: "Tur");
        }
    }
}
