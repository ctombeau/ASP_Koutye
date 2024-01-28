using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Koutye.Migrations
{
    /// <inheritdoc />
    public partial class addCreationDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_utilisateur_typeUtilisateur_typeUtilisateurtypeId",
                table: "utilisateur");

            migrationBuilder.AlterColumn<int>(
                name: "typeUtilisateurtypeId",
                table: "utilisateur",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "creationDate",
                table: "utilisateur",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_utilisateur_typeUtilisateur_typeUtilisateurtypeId",
                table: "utilisateur",
                column: "typeUtilisateurtypeId",
                principalTable: "typeUtilisateur",
                principalColumn: "type_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_utilisateur_typeUtilisateur_typeUtilisateurtypeId",
                table: "utilisateur");

            migrationBuilder.DropColumn(
                name: "creationDate",
                table: "utilisateur");

            migrationBuilder.AlterColumn<int>(
                name: "typeUtilisateurtypeId",
                table: "utilisateur",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_utilisateur_typeUtilisateur_typeUtilisateurtypeId",
                table: "utilisateur",
                column: "typeUtilisateurtypeId",
                principalTable: "typeUtilisateur",
                principalColumn: "type_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
