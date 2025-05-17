using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SreeChintamaniTrustBackend.Migrations
{
    /// <inheritdoc />
    public partial class addedProp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "Devotees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Token",
                table: "Devotees");
        }
    }
}
