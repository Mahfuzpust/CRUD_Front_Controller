using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDFrontController.Migrations
{
    /// <inheritdoc />
    public partial class citiess : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_States_StateId",
                table: "Cities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.RenameTable(
                name: "Cities",
                newName: "Citiess");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_StateId",
                table: "Citiess",
                newName: "IX_Citiess_StateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Citiess",
                table: "Citiess",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Citiess_States_StateId",
                table: "Citiess",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Citiess_States_StateId",
                table: "Citiess");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Citiess",
                table: "Citiess");

            migrationBuilder.RenameTable(
                name: "Citiess",
                newName: "Cities");

            migrationBuilder.RenameIndex(
                name: "IX_Citiess_StateId",
                table: "Cities",
                newName: "IX_Cities_StateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_States_StateId",
                table: "Cities",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
