using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCBasics.Migrations
{
    public partial class EmployeeDeptAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "EmployeeModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Department",
                table: "EmployeeModel");
        }
    }
}
