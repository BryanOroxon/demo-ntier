using Microsoft.EntityFrameworkCore.Migrations;

namespace Music.DAL.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Albumes",
                columns: new[] { "AlbumId", "Nombre" },
                values: new object[] { 1, "The beatles" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Albumes",
                keyColumn: "AlbumId",
                keyValue: 1);
        }
    }
}
