using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mahalla.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MahallaKamitets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MahallaName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RaisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MahallaKamitets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Oilas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    member = table.Column<int>(type: "int", nullable: false),
                    MahallaKamitetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oilas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Oilas_MahallaKamitets_MahallaKamitetId",
                        column: x => x.MahallaKamitetId,
                        principalTable: "MahallaKamitets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Raiss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RaisMale = table.Column<int>(type: "int", nullable: false),
                    MahallaKamitetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Raiss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Raiss_MahallaKamitets_MahallaKamitetId",
                        column: x => x.MahallaKamitetId,
                        principalTable: "MahallaKamitets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Odams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeNumber = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OdamMale = table.Column<int>(type: "int", nullable: false),
                    OilaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Odams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Odams_Oilas_OilaId",
                        column: x => x.OilaId,
                        principalTable: "Oilas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Odams_OilaId",
                table: "Odams",
                column: "OilaId");

            migrationBuilder.CreateIndex(
                name: "IX_Oilas_MahallaKamitetId",
                table: "Oilas",
                column: "MahallaKamitetId");

            migrationBuilder.CreateIndex(
                name: "IX_Raiss_MahallaKamitetId",
                table: "Raiss",
                column: "MahallaKamitetId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Odams");

            migrationBuilder.DropTable(
                name: "Raiss");

            migrationBuilder.DropTable(
                name: "Oilas");

            migrationBuilder.DropTable(
                name: "MahallaKamitets");
        }
    }
}
