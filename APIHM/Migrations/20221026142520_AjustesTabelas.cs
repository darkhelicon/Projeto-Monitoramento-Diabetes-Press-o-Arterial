using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIHM.Migrations
{
    public partial class AjustesTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Glico_Med_MedId",
                table: "Glico");

            migrationBuilder.DropForeignKey(
                name: "FK_Hiper_Med_MedId",
                table: "Hiper");

            migrationBuilder.DropIndex(
                name: "IX_Hiper_MedId",
                table: "Hiper");

            migrationBuilder.DropIndex(
                name: "IX_Glico_MedId",
                table: "Glico");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Media",
                table: "Hiper");

            migrationBuilder.DropColumn(
                name: "Desc",
                table: "Glico");

            migrationBuilder.DropColumn(
                name: "MedId",
                table: "Glico");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Glico");

            migrationBuilder.DropColumn(
                name: "Desc",
                table: "Extra");

            migrationBuilder.RenameColumn(
                name: "Desc",
                table: "Med",
                newName: "Descri");

            migrationBuilder.RenameColumn(
                name: "MedId",
                table: "Hiper",
                newName: "Categoria");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Glico",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Extra",
                newName: "Descri");

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Med",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hiper_PersonId",
                table: "Hiper",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Glico_PersonId",
                table: "Glico",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Glico_Persons_PersonId",
                table: "Glico",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hiper_Persons_PersonId",
                table: "Hiper",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Glico_Persons_PersonId",
                table: "Glico");

            migrationBuilder.DropForeignKey(
                name: "FK_Hiper_Persons_PersonId",
                table: "Hiper");

            migrationBuilder.DropIndex(
                name: "IX_Hiper_PersonId",
                table: "Hiper");

            migrationBuilder.DropIndex(
                name: "IX_Glico_PersonId",
                table: "Glico");

            migrationBuilder.RenameColumn(
                name: "Descri",
                table: "Med",
                newName: "Desc");

            migrationBuilder.RenameColumn(
                name: "Categoria",
                table: "Hiper",
                newName: "MedId");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "Glico",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "Descri",
                table: "Extra",
                newName: "Type");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Med",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<decimal>(
                name: "Media",
                table: "Hiper",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "Glico",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MedId",
                table: "Glico",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Glico",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "Extra",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hiper_MedId",
                table: "Hiper",
                column: "MedId");

            migrationBuilder.CreateIndex(
                name: "IX_Glico_MedId",
                table: "Glico",
                column: "MedId");

            migrationBuilder.AddForeignKey(
                name: "FK_Glico_Med_MedId",
                table: "Glico",
                column: "MedId",
                principalTable: "Med",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hiper_Med_MedId",
                table: "Hiper",
                column: "MedId",
                principalTable: "Med",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
