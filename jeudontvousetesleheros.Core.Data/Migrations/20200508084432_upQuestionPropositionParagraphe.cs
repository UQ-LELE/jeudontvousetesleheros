using Microsoft.EntityFrameworkCore.Migrations;

namespace jeudontvousetesleheros.Core.Data.Migrations
{
    public partial class upQuestionPropositionParagraphe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Titre",
                table: "Proposition");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Proposition",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParagrapheId",
                table: "Proposition",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Titre",
                table: "Paragraphe",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Paragraphe",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EstInitial",
                table: "Paragraphe",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Proposition_ParagrapheId",
                table: "Proposition",
                column: "ParagrapheId");

            migrationBuilder.AddForeignKey(
                name: "FK_Proposition_Paragraphe_ParagrapheId",
                table: "Proposition",
                column: "ParagrapheId",
                principalTable: "Paragraphe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proposition_Paragraphe_ParagrapheId",
                table: "Proposition");

            migrationBuilder.DropIndex(
                name: "IX_Proposition_ParagrapheId",
                table: "Proposition");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Proposition");

            migrationBuilder.DropColumn(
                name: "ParagrapheId",
                table: "Proposition");

            migrationBuilder.DropColumn(
                name: "EstInitial",
                table: "Paragraphe");

            migrationBuilder.AddColumn<string>(
                name: "Titre",
                table: "Proposition",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Titre",
                table: "Paragraphe",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Paragraphe",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
