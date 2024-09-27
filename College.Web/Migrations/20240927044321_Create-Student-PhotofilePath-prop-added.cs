using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace College.Web.Migrations
{
    /// <inheritdoc />
    public partial class CreateStudentPhotofilePathpropadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotofilePath",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotofilePath",
                table: "Students");
        }
    }
}
