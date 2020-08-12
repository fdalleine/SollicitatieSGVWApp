using Microsoft.EntityFrameworkCore.Migrations;

namespace SollicitatieSGVW.Persistence.Migrations
{
    public partial class AddScholen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "School",
                table: "TewerkstellingsRecords");

            migrationBuilder.AddColumn<int>(
                name: "SchoolId",
                table: "TewerkstellingsRecords",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Scholen",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolNaam = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scholen", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TewerkstellingsRecords_SchoolId",
                table: "TewerkstellingsRecords",
                column: "SchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_TewerkstellingsRecords_Scholen_SchoolId",
                table: "TewerkstellingsRecords",
                column: "SchoolId",
                principalTable: "Scholen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TewerkstellingsRecords_Scholen_SchoolId",
                table: "TewerkstellingsRecords");

            migrationBuilder.DropTable(
                name: "Scholen");

            migrationBuilder.DropIndex(
                name: "IX_TewerkstellingsRecords_SchoolId",
                table: "TewerkstellingsRecords");

            migrationBuilder.DropColumn(
                name: "SchoolId",
                table: "TewerkstellingsRecords");

            migrationBuilder.AddColumn<int>(
                name: "School",
                table: "TewerkstellingsRecords",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
