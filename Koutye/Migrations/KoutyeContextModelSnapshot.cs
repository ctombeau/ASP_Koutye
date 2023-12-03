﻿// <auto-generated />
using System;
using Koutye.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Koutye.Migrations
{
    [DbContext(typeof(KoutyeContext))]
    partial class KoutyeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AppartementFerme", b =>
                {
                    b.Property<int>("appartementsappartementId")
                        .HasColumnType("int");

                    b.Property<int>("fermesfermeId")
                        .HasColumnType("int");

                    b.HasKey("appartementsappartementId", "fermesfermeId");

                    b.HasIndex("fermesfermeId");

                    b.ToTable("AppartementFerme");
                });

            modelBuilder.Entity("Koutye.Models.Adresse", b =>
                {
                    b.Property<int>("adresseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("adresse_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("adresseId"));

                    b.Property<string>("commune")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("departement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numero")
                        .HasColumnType("int");

                    b.Property<string>("pays")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("adresseId");

                    b.ToTable("adresse");
                });

            modelBuilder.Entity("Koutye.Models.Appartement", b =>
                {
                    b.Property<int>("appartementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("appartement_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("appartementId"));

                    b.Property<int>("adresseId")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("utilisateurId")
                        .HasColumnType("int");

                    b.HasKey("appartementId");

                    b.HasIndex("adresseId");

                    b.HasIndex("utilisateurId");

                    b.ToTable("appartement");
                });

            modelBuilder.Entity("Koutye.Models.Ferme", b =>
                {
                    b.Property<int>("fermeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ferme_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("fermeId"));

                    b.Property<DateTime>("debut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fin")
                        .HasColumnType("datetime2");

                    b.Property<double>("montant")
                        .HasColumnType("float");

                    b.HasKey("fermeId");

                    b.ToTable("ferme");
                });

            modelBuilder.Entity("Koutye.Models.ImageAppartement", b =>
                {
                    b.Property<int>("imageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("image_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("imageId"));

                    b.Property<int>("appartementId")
                        .HasColumnType("int");

                    b.Property<string>("description_image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("imageId");

                    b.HasIndex("appartementId");

                    b.ToTable("imageAppartement");
                });

            modelBuilder.Entity("Koutye.Models.TypeUtilisateur", b =>
                {
                    b.Property<int>("typeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("type_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("typeId"));

                    b.Property<string>("nomType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("typeId");

                    b.ToTable("typeUtilisateur");
                });

            modelBuilder.Entity("Koutye.Models.Utilisateur", b =>
                {
                    b.Property<int>("utilisateurId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("utilisateur_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("utilisateurId"));

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("login_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("logoutDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("modificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("typeUtilisateurtypeId")
                        .HasColumnType("int");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("utilisateurId");

                    b.HasIndex("typeUtilisateurtypeId");

                    b.ToTable("utilisateur");
                });

            modelBuilder.Entity("Koutye.Models.VideoAppartement", b =>
                {
                    b.Property<int>("videoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("video_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("videoId"));

                    b.Property<int>("appartementId")
                        .HasColumnType("int");

                    b.Property<string>("description_video")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("video")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("videoId");

                    b.HasIndex("appartementId");

                    b.ToTable("videoAppartement");
                });

            modelBuilder.Entity("AppartementFerme", b =>
                {
                    b.HasOne("Koutye.Models.Appartement", null)
                        .WithMany()
                        .HasForeignKey("appartementsappartementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Koutye.Models.Ferme", null)
                        .WithMany()
                        .HasForeignKey("fermesfermeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Koutye.Models.Appartement", b =>
                {
                    b.HasOne("Koutye.Models.Adresse", "adresse")
                        .WithMany("appartements")
                        .HasForeignKey("adresseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Koutye.Models.Utilisateur", "utilisateur")
                        .WithMany("appartements")
                        .HasForeignKey("utilisateurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("adresse");

                    b.Navigation("utilisateur");
                });

            modelBuilder.Entity("Koutye.Models.ImageAppartement", b =>
                {
                    b.HasOne("Koutye.Models.Appartement", "appartement")
                        .WithMany("imageAppartements")
                        .HasForeignKey("appartementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("appartement");
                });

            modelBuilder.Entity("Koutye.Models.Utilisateur", b =>
                {
                    b.HasOne("Koutye.Models.TypeUtilisateur", "typeUtilisateur")
                        .WithMany("utilisateurs")
                        .HasForeignKey("typeUtilisateurtypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("typeUtilisateur");
                });

            modelBuilder.Entity("Koutye.Models.VideoAppartement", b =>
                {
                    b.HasOne("Koutye.Models.Appartement", "appartement")
                        .WithMany("videoAppartements")
                        .HasForeignKey("appartementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("appartement");
                });

            modelBuilder.Entity("Koutye.Models.Adresse", b =>
                {
                    b.Navigation("appartements");
                });

            modelBuilder.Entity("Koutye.Models.Appartement", b =>
                {
                    b.Navigation("imageAppartements");

                    b.Navigation("videoAppartements");
                });

            modelBuilder.Entity("Koutye.Models.TypeUtilisateur", b =>
                {
                    b.Navigation("utilisateurs");
                });

            modelBuilder.Entity("Koutye.Models.Utilisateur", b =>
                {
                    b.Navigation("appartements");
                });
#pragma warning restore 612, 618
        }
    }
}
