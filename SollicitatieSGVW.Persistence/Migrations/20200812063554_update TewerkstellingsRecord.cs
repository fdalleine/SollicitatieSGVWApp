using Microsoft.EntityFrameworkCore.Migrations;

namespace SollicitatieSGVW.Persistence.Migrations
{
    public partial class updateTewerkstellingsRecord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TewerkstellingsRecords_Scholen_SchoolId",
                table: "TewerkstellingsRecords");

            migrationBuilder.AlterColumn<int>(
                name: "SchoolId",
                table: "TewerkstellingsRecords",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TewerkstellingsRecords_Scholen_SchoolId",
                table: "TewerkstellingsRecords",
                column: "SchoolId",
                principalTable: "Scholen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TewerkstellingsRecords_Scholen_SchoolId",
                table: "TewerkstellingsRecords");

            migrationBuilder.AlterColumn<int>(
                name: "SchoolId",
                table: "TewerkstellingsRecords",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_TewerkstellingsRecords_Scholen_SchoolId",
                table: "TewerkstellingsRecords",
                column: "SchoolId",
                principalTable: "Scholen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
