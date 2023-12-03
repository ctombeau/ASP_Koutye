using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Koutye.Migrations
{
    /// <inheritdoc />
    public partial class ThirdCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppartementFerme_appartements_appartementsid",
                table: "AppartementFerme");

            migrationBuilder.DropForeignKey(
                name: "FK_AppartementFerme_fermes_fermesid",
                table: "AppartementFerme");

            migrationBuilder.DropForeignKey(
                name: "FK_appartements_Utilisateurs_utilisateurid",
                table: "appartements");

            migrationBuilder.DropForeignKey(
                name: "FK_appartements_adresses_adresseid",
                table: "appartements");

            migrationBuilder.DropForeignKey(
                name: "FK_imageAppartements_appartements_appartementid",
                table: "imageAppartements");

            migrationBuilder.DropForeignKey(
                name: "FK_Utilisateurs_typeUtilisateurs_typeUtilisateurId",
                table: "Utilisateurs");

            migrationBuilder.DropForeignKey(
                name: "FK_videoAppartement_appartements_appartementid",
                table: "videoAppartement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Utilisateurs",
                table: "Utilisateurs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_typeUtilisateurs",
                table: "typeUtilisateurs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_imageAppartements",
                table: "imageAppartements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_fermes",
                table: "fermes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_appartements",
                table: "appartements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_adresses",
                table: "adresses");

            migrationBuilder.RenameTable(
                name: "Utilisateurs",
                newName: "utilisateur");

            migrationBuilder.RenameTable(
                name: "typeUtilisateurs",
                newName: "typeUtilisateur");

            migrationBuilder.RenameTable(
                name: "imageAppartements",
                newName: "imageAppartement");

            migrationBuilder.RenameTable(
                name: "fermes",
                newName: "ferme");

            migrationBuilder.RenameTable(
                name: "appartements",
                newName: "appartement");

            migrationBuilder.RenameTable(
                name: "adresses",
                newName: "adresse");

            migrationBuilder.RenameIndex(
                name: "IX_Utilisateurs_typeUtilisateurId",
                table: "utilisateur",
                newName: "IX_utilisateur_typeUtilisateurId");

            migrationBuilder.RenameIndex(
                name: "IX_imageAppartements_appartementid",
                table: "imageAppartement",
                newName: "IX_imageAppartement_appartementid");

            migrationBuilder.RenameIndex(
                name: "IX_appartements_utilisateurid",
                table: "appartement",
                newName: "IX_appartement_utilisateurid");

            migrationBuilder.RenameIndex(
                name: "IX_appartements_adresseid",
                table: "appartement",
                newName: "IX_appartement_adresseid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_utilisateur",
                table: "utilisateur",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_typeUtilisateur",
                table: "typeUtilisateur",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_imageAppartement",
                table: "imageAppartement",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ferme",
                table: "ferme",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_appartement",
                table: "appartement",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_adresse",
                table: "adresse",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_appartement_adresse_adresseid",
                table: "appartement",
                column: "adresseid",
                principalTable: "adresse",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_appartement_utilisateur_utilisateurid",
                table: "appartement",
                column: "utilisateurid",
                principalTable: "utilisateur",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppartementFerme_appartement_appartementsid",
                table: "AppartementFerme",
                column: "appartementsid",
                principalTable: "appartement",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppartementFerme_ferme_fermesid",
                table: "AppartementFerme",
                column: "fermesid",
                principalTable: "ferme",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_imageAppartement_appartement_appartementid",
                table: "imageAppartement",
                column: "appartementid",
                principalTable: "appartement",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_utilisateur_typeUtilisateur_typeUtilisateurId",
                table: "utilisateur",
                column: "typeUtilisateurId",
                principalTable: "typeUtilisateur",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_videoAppartement_appartement_appartementid",
                table: "videoAppartement",
                column: "appartementid",
                principalTable: "appartement",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appartement_adresse_adresseid",
                table: "appartement");

            migrationBuilder.DropForeignKey(
                name: "FK_appartement_utilisateur_utilisateurid",
                table: "appartement");

            migrationBuilder.DropForeignKey(
                name: "FK_AppartementFerme_appartement_appartementsid",
                table: "AppartementFerme");

            migrationBuilder.DropForeignKey(
                name: "FK_AppartementFerme_ferme_fermesid",
                table: "AppartementFerme");

            migrationBuilder.DropForeignKey(
                name: "FK_imageAppartement_appartement_appartementid",
                table: "imageAppartement");

            migrationBuilder.DropForeignKey(
                name: "FK_utilisateur_typeUtilisateur_typeUtilisateurId",
                table: "utilisateur");

            migrationBuilder.DropForeignKey(
                name: "FK_videoAppartement_appartement_appartementid",
                table: "videoAppartement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_utilisateur",
                table: "utilisateur");

            migrationBuilder.DropPrimaryKey(
                name: "PK_typeUtilisateur",
                table: "typeUtilisateur");

            migrationBuilder.DropPrimaryKey(
                name: "PK_imageAppartement",
                table: "imageAppartement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ferme",
                table: "ferme");

            migrationBuilder.DropPrimaryKey(
                name: "PK_appartement",
                table: "appartement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_adresse",
                table: "adresse");

            migrationBuilder.RenameTable(
                name: "utilisateur",
                newName: "Utilisateurs");

            migrationBuilder.RenameTable(
                name: "typeUtilisateur",
                newName: "typeUtilisateurs");

            migrationBuilder.RenameTable(
                name: "imageAppartement",
                newName: "imageAppartements");

            migrationBuilder.RenameTable(
                name: "ferme",
                newName: "fermes");

            migrationBuilder.RenameTable(
                name: "appartement",
                newName: "appartements");

            migrationBuilder.RenameTable(
                name: "adresse",
                newName: "adresses");

            migrationBuilder.RenameIndex(
                name: "IX_utilisateur_typeUtilisateurId",
                table: "Utilisateurs",
                newName: "IX_Utilisateurs_typeUtilisateurId");

            migrationBuilder.RenameIndex(
                name: "IX_imageAppartement_appartementid",
                table: "imageAppartements",
                newName: "IX_imageAppartements_appartementid");

            migrationBuilder.RenameIndex(
                name: "IX_appartement_utilisateurid",
                table: "appartements",
                newName: "IX_appartements_utilisateurid");

            migrationBuilder.RenameIndex(
                name: "IX_appartement_adresseid",
                table: "appartements",
                newName: "IX_appartements_adresseid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Utilisateurs",
                table: "Utilisateurs",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_typeUtilisateurs",
                table: "typeUtilisateurs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_imageAppartements",
                table: "imageAppartements",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_fermes",
                table: "fermes",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_appartements",
                table: "appartements",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_adresses",
                table: "adresses",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppartementFerme_appartements_appartementsid",
                table: "AppartementFerme",
                column: "appartementsid",
                principalTable: "appartements",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppartementFerme_fermes_fermesid",
                table: "AppartementFerme",
                column: "fermesid",
                principalTable: "fermes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_appartements_Utilisateurs_utilisateurid",
                table: "appartements",
                column: "utilisateurid",
                principalTable: "Utilisateurs",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_appartements_adresses_adresseid",
                table: "appartements",
                column: "adresseid",
                principalTable: "adresses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_imageAppartements_appartements_appartementid",
                table: "imageAppartements",
                column: "appartementid",
                principalTable: "appartements",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Utilisateurs_typeUtilisateurs_typeUtilisateurId",
                table: "Utilisateurs",
                column: "typeUtilisateurId",
                principalTable: "typeUtilisateurs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_videoAppartement_appartements_appartementid",
                table: "videoAppartement",
                column: "appartementid",
                principalTable: "appartements",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
