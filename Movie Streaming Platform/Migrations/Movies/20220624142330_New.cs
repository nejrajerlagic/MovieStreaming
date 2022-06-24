using Microsoft.EntityFrameworkCore.Migrations;

namespace Movie_Streaming_Platform.Migrations.Movies
{
    public partial class New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotoMemoryLocation",
                table: "Movies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoMemoryLocation",
                table: "Movies");
        }
    }
}
