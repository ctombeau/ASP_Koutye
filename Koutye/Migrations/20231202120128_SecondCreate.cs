using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Koutye.Migrations
{
    /// <inheritdoc />
    public partial class SecondCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "adresses",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numero = table.Column<int>(type: "int", nullable: false),
                    commune = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    departement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pays = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rue = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adresses", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "fermes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    debut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    montant = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fermes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "appartements",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adresseid = table.Column<int>(type: "int", nullable: false),
                    utilisateurid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appartements", x => x.id);
                    table.ForeignKey(
                        name: "FK_appartements_Utilisateurs_utilisateurid",
                        column: x => x.utilisateurid,
                        principalTable: "Utilisateurs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_appartements_adresses_adresseid",
                        column: x => x.adresseid,
                        principalTable: "adresses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppartementFerme",
                columns: table => new
                {
                    appartementsid = table.Column<int>(type: "int", nullable: false),
                    fermesid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppartementFerme", x => new { x.appartementsid, x.fermesid });
                    table.ForeignKey(
                        name: "FK_AppartementFerme_appartements_appartementsid",
                        column: x => x.appartementsid,
                        principalTable: "appartements",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppartementFerme_fermes_fermesid",
                        column: x => x.fermesid,
                        principalTable: "fermes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "imageAppartements",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description_image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    appartementid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_imageAppartements", x => x.id);
                    table.ForeignKey(
                        name: "FK_imageAppartements_appartements_appartementid",
                        column: x => x.appartementid,
                        principalTable: "appartements",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "videoAppartement",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description_video = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    video = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    appartementid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_videoAppartement", x => x.id);
                    table.ForeignKey(
                        name: "FK_videoAppartement_appartements_appartementid",
                        column: x => x.appartementid,
                        principalTable: "appartements",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppartementFerme_fermesid",
                table: "AppartementFerme",
                column: "fermesid");

            migrationBuilder.CreateIndex(
                name: "IX_appartements_adresseid",
                table: "appartements",
                column: "adresseid");

            migrationBuilder.CreateIndex(
                name: "IX_appartements_utilisateurid",
                table: "appartements",
                column: "utilisateurid");

            migrationBuilder.CreateIndex(
                name: "IX_imageAppartements_appartementid",
                table: "imageAppartements",
                column: "appartementid");

            migrationBuilder.CreateIndex(
                name: "IX_videoAppartement_appartementid",
                table: "videoAppartement",
                column: "appartementid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppartementFerme");

            migrationBuilder.DropTable(
                name: "imageAppartements");

            migrationBuilder.DropTable(
                name: "videoAppartement");

            migrationBuilder.DropTable(
                name: "fermes");

            migrationBuilder.DropTable(
                name: "appartements");

            migrationBuilder.DropTable(
                name: "adresses");
        }
    }
}
