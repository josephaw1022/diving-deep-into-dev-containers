using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace auth_db.Migrations
{
    /// <inheritdoc />
    public partial class newemailfield : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "AuthUser",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "email",
                table: "AuthUser");
        }
    }
}
