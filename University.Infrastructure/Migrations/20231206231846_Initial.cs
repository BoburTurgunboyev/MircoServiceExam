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
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "examResultss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Terms = table.Column<int>(type: "int", nullable: false),
                    ExemMark = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    StudentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_examResultss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_examResultss_studentss_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "studentss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "StudentsSubjects",
                columns: table => new
                {
                    StudentSubjectId = table.Column<int>(type: "int", nullable: false),
                    StudentSubjectsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsSubjects", x => new { x.StudentSubjectId, x.StudentSubjectsId });
                    table.ForeignKey(
                        name: "FK_StudentsSubjects_studentss_StudentSubjectId",
                        column: x => x.StudentSubjectId,
                        principalTable: "studentss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentsSubjects_subjectss_StudentSubjectsId",
                        column: x => x.StudentSubjectsId,
                        principalTable: "subjectss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_examResultss_StudentsId",
                table: "examResultss",
                column: "StudentsId");

            migrationBuilder.CreateIndex(
                name: "IX_overAllMarkss_StudentsId",
                table: "overAllMarkss",
                column: "StudentsId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsSubjects_StudentSubjectsId",
                table: "StudentsSubjects",
                column: "StudentSubjectsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "examResultss");

            migrationBuilder.DropTable(
                name: "overAllMarkss");

            migrationBuilder.DropTable(
                name: "StudentsSubjects");

            migrationBuilder.DropTable(
                name: "studentss");

            migrationBuilder.DropTable(
                name: "subjectss");
        }
    }
}
