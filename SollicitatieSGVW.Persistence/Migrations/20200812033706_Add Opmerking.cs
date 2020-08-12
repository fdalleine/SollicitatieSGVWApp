using Microsoft.EntityFrameworkCore.Migrations;

namespace SollicitatieSGVW.Persistence.Migrations
{
    public partial class AddOpmerking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Opmerking",
                table: "TewerkstellingsRecords",
                maxLength: 500,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Opmerking",
                table: "TewerkstellingsRecords");
        }
    }
}
