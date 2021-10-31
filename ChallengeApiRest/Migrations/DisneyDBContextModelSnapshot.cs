﻿// <auto-generated />
using System;
using ChallengeApiRest.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChallengeApiRest.Migrations
{
    [DbContext(typeof(DisneyDBContext))]
    partial class DisneyDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ChallengeApiRest.Entities.Genre", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Genre Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Genre Name");

                    b.HasKey("id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("ChallengeApiRest.Entities.Movie", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Movie Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Creation Date");

                    b.Property<int?>("Genreid")
                        .HasColumnType("int");

                    b.Property<int?>("Genreid1")
                        .HasColumnType("int");

                    b.Property<int>("calification")
                        .HasColumnType("int")
                        .HasColumnName("Calification");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Movie Title");

                    b.HasKey("id");

                    b.HasIndex("Genreid");

                    b.HasIndex("Genreid1");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("ChallengeApiRest.Entities.Series", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Series Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Creation Date");

                    b.Property<int>("calification")
                        .HasColumnType("int")
                        .HasColumnName("Calification");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Series Title");

                    b.HasKey("id");

                    b.ToTable("_Series");
                });

            modelBuilder.Entity("ChallengeApiRest.Models.Character", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Character Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("age")
                        .HasColumnType("int")
                        .HasColumnName("Character Age");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Character Name");

                    b.Property<string>("story")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Character Story");

                    b.Property<double>("weight")
                        .HasColumnType("float")
                        .HasColumnName("Character Weight");

                    b.HasKey("id");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("CharacterMovie", b =>
                {
                    b.Property<int>("RelatedMovieid")
                        .HasColumnType("int");

                    b.Property<int>("relatedCharactersid")
                        .HasColumnType("int");

                    b.HasKey("RelatedMovieid", "relatedCharactersid");

                    b.HasIndex("relatedCharactersid");

                    b.ToTable("CharacterMovie");
                });

            modelBuilder.Entity("CharacterSeries", b =>
                {
                    b.Property<int>("RelatedSeriesid")
                        .HasColumnType("int");

                    b.Property<int>("relatedCharactersid")
                        .HasColumnType("int");

                    b.HasKey("RelatedSeriesid", "relatedCharactersid");

                    b.HasIndex("relatedCharactersid");

                    b.ToTable("CharacterSeries");
                });

            modelBuilder.Entity("ChallengeApiRest.Entities.Movie", b =>
                {
                    b.HasOne("ChallengeApiRest.Entities.Genre", null)
                        .WithMany("RelatedSeries")
                        .HasForeignKey("Genreid");

                    b.HasOne("ChallengeApiRest.Entities.Genre", null)
                        .WithMany("relatedMovie")
                        .HasForeignKey("Genreid1");
                });

            modelBuilder.Entity("CharacterMovie", b =>
                {
                    b.HasOne("ChallengeApiRest.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("RelatedMovieid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChallengeApiRest.Models.Character", null)
                        .WithMany()
                        .HasForeignKey("relatedCharactersid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CharacterSeries", b =>
                {
                    b.HasOne("ChallengeApiRest.Entities.Series", null)
                        .WithMany()
                        .HasForeignKey("RelatedSeriesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChallengeApiRest.Models.Character", null)
                        .WithMany()
                        .HasForeignKey("relatedCharactersid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ChallengeApiRest.Entities.Genre", b =>
                {
                    b.Navigation("relatedMovie");

                    b.Navigation("RelatedSeries");
                });
#pragma warning restore 612, 618
        }
    }
}
