using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Koutye.Migrations
{
    /// <inheritdoc />
    public partial class FourthCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "appartementid",
                table: "videoAppartement",
                newName: "appartementId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "videoAppartement",
                newName: "video_id");

            migrationBuilder.RenameIndex(
                name: "IX_videoAppartement_appartementid",
                table: "videoAppartement",
                newName: "IX_videoAppartement_appartementId");

            migrationBuilder.RenameColumn(
                name: "typeUtilisateurId",
                table: "utilisateur",
                newName: "typeUtilisateurtypeId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "utilisateur",
                newName: "utilisateur_id");

            migrationBuilder.RenameIndex(
                name: "IX_utilisateur_typeUtilisateurId",
                table: "utilisateur",
                newName: "IX_utilisateur_typeUtilisateurtypeId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "typeUtilisateur",
                newName: "type_id");

            migrationBuilder.RenameColumn(
                name: "appartementid",
                table: "imageAppartement",
                newName: "appartementId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "imageAppartement",
                newName: "image_id");

            migrationBuilder.RenameIndex(
                name: "IX_imageAppartement_appartementid",
                table: "imageAppartement",
                newName: "IX_imageAppartement_appartementId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "ferme",
                newName: "ferme_id");

            migrationBuilder.RenameColumn(
                name: "fermesid",
                table: "AppartementFerme",
                newName: "fermesfermeId");

            migrationBuilder.RenameColumn(
                name: "appartementsid",
                table: "AppartementFerme",
                newName: "appartementsappartementId");

            migrationBuilder.RenameIndex(
                name: "IX_AppartementFerme_fermesid",
                table: "AppartementFerme",
                newName: "IX_AppartementFerme_fermesfermeId");

            migrationBuilder.RenameColumn(
                name: "utilisateurid",
                table: "appartement",
                newName: "utilisateurId");

            migrationBuilder.RenameColumn(
                name: "adresseid",
                table: "appartement",
                newName: "adresseId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "appartement",
                newName: "appartement_id");

            migrationBuilder.RenameIndex(
                name: "IX_appartement_utilisateurid",
                table: "appartement",
                newName: "IX_appartement_utilisateurId");

            migrationBuilder.RenameIndex(
                name: "IX_appartement_adresseid",
                table: "appartement",
                newName: "IX_appartement_adresseId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "adresse",
                newName: "adresse_id");

            migrationBuilder.AddForeignKey(
                name: "FK_appartement_adresse_adresseId",
                table: "appartement",
                column: "adresseId",
                principalTable: "adresse",
                principalColumn: "adresse_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_appartement_utilisateur_utilisateurId",
                table: "appartement",
                column: "utilisateurId",
                principalTable: "utilisateur",
                principalColumn: "utilisateur_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppartementFerme_appartement_appartementsappartementId",
                table: "AppartementFerme",
                column: "appartementsappartementId",
                principalTable: "appartement",
                principalColumn: "appartement_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppartementFerme_ferme_fermesfermeId",
                table: "AppartementFerme",
                column: "fermesfermeId",
                principalTable: "ferme",
                principalColumn: "ferme_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_imageAppartement_appartement_appartementId",
                table: "imageAppartement",
                column: "appartementId",
                principalTable: "appartement",
                principalColumn: "appartement_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_utilisateur_typeUtilisateur_typeUtilisateurtypeId",
                table: "utilisateur",
                column: "typeUtilisateurtypeId",
                principalTable: "typeUtilisateur",
                principalColumn: "type_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_videoAppartement_appartement_appartementId",
                table: "videoAppartement",
                column: "appartementId",
                principalTable: "appartement",
                principalColumn: "appartement_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appartement_adresse_adresseId",
                table: "appartement");

            migrationBuilder.DropForeignKey(
                name: "FK_appartement_utilisateur_utilisateurId",
                table: "appartement");

            migrationBuilder.DropForeignKey(
                name: "FK_AppartementFerme_appartement_appartementsappartementId",
                table: "AppartementFerme");

            migrationBuilder.DropForeignKey(
                name: "FK_AppartementFerme_ferme_fermesfermeId",
                table: "AppartementFerme");

            migrationBuilder.DropForeignKey(
                name: "FK_imageAppartement_appartement_appartementId",
                table: "imageAppartement");

            migrationBuilder.DropForeignKey(
                name: "FK_utilisateur_typeUtilisateur_typeUtilisateurtypeId",
                table: "utilisateur");

            migrationBuilder.DropForeignKey(
                name: "FK_videoAppartement_appartement_appartementId",
                table: "videoAppartement");

            migrationBuilder.RenameColumn(
                name: "appartementId",
                table: "videoAppartement",
                newName: "appartementid");

            migrationBuilder.RenameColumn(
                name: "video_id",
                table: "videoAppartement",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_videoAppartement_appartementId",
                table: "videoAppartement",
                newName: "IX_videoAppartement_appartementid");

            migrationBuilder.RenameColumn(
                name: "typeUtilisateurtypeId",
                table: "utilisateur",
                newName: "typeUtilisateurId");

            migrationBuilder.RenameColumn(
                name: "utilisateur_id",
                table: "utilisateur",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_utilisateur_typeUtilisateurtypeId",
                table: "utilisateur",
                newName: "IX_utilisateur_typeUtilisateurId");

            migrationBuilder.RenameColumn(
                name: "type_id",
                table: "typeUtilisateur",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "appartementId",
                table: "imageAppartement",
                newName: "appartementid");

            migrationBuilder.RenameColumn(
                name: "image_id",
                table: "imageAppartement",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_imageAppartement_appartementId",
                table: "imageAppartement",
                newName: "IX_imageAppartement_appartementid");

            migrationBuilder.RenameColumn(
                name: "ferme_id",
                table: "ferme",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "fermesfermeId",
                table: "AppartementFerme",
                newName: "fermesid");

            migrationBuilder.RenameColumn(
                name: "appartementsappartementId",
                table: "AppartementFerme",
                newName: "appartementsid");

            migrationBuilder.RenameIndex(
                name: "IX_AppartementFerme_fermesfermeId",
                table: "AppartementFerme",
                newName: "IX_AppartementFerme_fermesid");

            migrationBuilder.RenameColumn(
                name: "utilisateurId",
                table: "appartement",
                newName: "utilisateurid");

            migrationBuilder.RenameColumn(
                name: "adresseId",
                table: "appartement",
                newName: "adresseid");

            migrationBuilder.RenameColumn(
                name: "appartement_id",
                table: "appartement",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_appartement_utilisateurId",
                table: "appartement",
                newName: "IX_appartement_utilisateurid");

            migrationBuilder.RenameIndex(
                name: "IX_appartement_adresseId",
                table: "appartement",
                newName: "IX_appartement_adresseid");

            migrationBuilder.RenameColumn(
                name: "adresse_id",
                table: "adresse",
                newName: "id");

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
    }
}
