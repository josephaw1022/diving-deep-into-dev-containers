using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace auth_db.Migrations
{
    /// <inheritdoc />
    public partial class removepassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "password",
                table: "AuthUser");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "AuthUser",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
