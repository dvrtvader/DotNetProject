using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetProject.Migrations
{
    public partial class dataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookReadingCard_ReadingCard_readingCardId",
                table: "BookReadingCard");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReadingCard",
                table: "ReadingCard");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "ReadingCard",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReadingCard",
                table: "ReadingCard",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_ReadingCard_userId",
                table: "ReadingCard",
                column: "userId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BookReadingCard_ReadingCard_readingCardId",
                table: "BookReadingCard",
                column: "readingCardId",
                principalTable: "ReadingCard",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookReadingCard_ReadingCard_readingCardId",
                table: "BookReadingCard");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReadingCard",
                table: "ReadingCard");

            migrationBuilder.DropIndex(
                name: "IX_ReadingCard_userId",
                table: "ReadingCard");

            migrationBuilder.DropColumn(
                name: "id",
                table: "ReadingCard");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReadingCard",
                table: "ReadingCard",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookReadingCard_ReadingCard_readingCardId",
                table: "BookReadingCard",
                column: "readingCardId",
                principalTable: "ReadingCard",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
