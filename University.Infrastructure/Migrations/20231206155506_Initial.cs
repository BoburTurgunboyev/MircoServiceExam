using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace University.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "studentss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "subjectss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subjectss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "overAllMarkss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarkType = table.Column<int>(type: "int", nullable: false),
                    StudentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_overAllMarkss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_overAllMarkss_studentss_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "studentss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "studentSubjectss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    StudentsId = table.Column<int>(type: "int", nullable: false),
                    SubjectsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentSubjectss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_studentSubjectss_studentss_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "studentss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_studentSubjectss_subjectss_SubjectsId",
                        column: x => x.SubjectsId,
                        principalTable: "subjectss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "examResultss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Terms = table.Column<int>(type: "int", nullable: false),
                    ExemMark = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    StudentSubjectId = table.Column<int>(type: "int", nullable: false),
                    StudentsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_examResultss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_examResultss_studentSubjectss_StudentSubjectId",
                        column: x => x.StudentSubjectId,
                        principalTable: "studentSubjectss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_examResultss_studentss_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "studentss",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_examResultss_StudentsId",
                table: "examResultss",
                column: "StudentsId");

            migrationBuilder.CreateIndex(
                name: "IX_examResultss_StudentSubjectId",
                table: "examResultss",
                column: "StudentSubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_overAllMarkss_StudentsId",
                table: "overAllMarkss",
                column: "StudentsId");

            migrationBuilder.CreateIndex(
                name: "IX_studentSubjectss_StudentsId",
                table: "studentSubjectss",
                column: "StudentsId");

            migrationBuilder.CreateIndex(
                name: "IX_studentSubjectss_SubjectsId",
                table: "studentSubjectss",
                column: "SubjectsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "examResultss");

            migrationBuilder.DropTable(
                name: "overAllMarkss");

            migrationBuilder.DropTable(
                name: "studentSubjectss");

            migrationBuilder.DropTable(
                name: "studentss");

            migrationBuilder.DropTable(
                name: "subjectss");
        }
    }
}
