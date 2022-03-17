using Microsoft.EntityFrameworkCore.Migrations;

namespace Ajax_Test.Migrations
{
    public partial class ini : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblCountries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCountries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblState",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(nullable: true),
                    CountryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblState", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblState_TblCountries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "TblCountries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblCity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(nullable: true),
                    StateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblCity_TblState_StateId",
                        column: x => x.StateId,
                        principalTable: "TblState",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblCity_StateId",
                table: "TblCity",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_TblState_CountryId",
                table: "TblState",
                column: "CountryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblCity");

            migrationBuilder.DropTable(
                name: "TblState");

            migrationBuilder.DropTable(
                name: "TblCountries");
        }
    }
}
