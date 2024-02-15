using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Koutye.Migrations
{
    /// <inheritdoc />
    public partial class changeColumnForeign : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_utilisateur_typeUtilisateur_typeUtilisateurtypeId",
                table: "utilisateur");

            migrationBuilder.RenameColumn(
                name: "typeUtilisateurtypeId",
                table: "utilisateur",
                newName: "type_id");

            migrationBuilder.RenameIndex(
                name: "IX_utilisateur_typeUtilisateurtypeId",
                table: "utilisateur",
                newName: "IX_utilisateur_type_id");

            migrationBuilder.AddForeignKey(
                name: "FK_utilisateur_typeUtilisateur_type_id",
                table: "utilisateur",
                column: "type_id",
                principalTable: "typeUtilisateur",
                principalColumn: "type_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_utilisateur_typeUtilisateur_type_id",
                table: "utilisateur");

            migrationBuilder.RenameColumn(
                name: "type_id",
                table: "utilisateur",
                newName: "typeUtilisateurtypeId");

            migrationBuilder.RenameIndex(
                name: "IX_utilisateur_type_id",
                table: "utilisateur",
                newName: "IX_utilisateur_typeUtilisateurtypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_utilisateur_typeUtilisateur_typeUtilisateurtypeId",
                table: "utilisateur",
                column: "typeUtilisateurtypeId",
                principalTable: "typeUtilisateur",
                principalColumn: "type_id");
        }
    }
}
