using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCBasics.Migrations
{
    public partial class SubjectsStudentsTeacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MarksModel",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    StudentID = table.Column<int>(nullable: false),
                    SubjectID = table.Column<int>(nullable: false),
                    MarksID = table.Column<int>(nullable: false),
                    marks = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarksModel", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "StudentsModel",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    StudentID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Grade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsModel", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SubjectsModel",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    SubjectID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectsModel", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MarksModel");

            migrationBuilder.DropTable(
                name: "StudentsModel");

            migrationBuilder.DropTable(
                name: "SubjectsModel");
        }
    }
}
