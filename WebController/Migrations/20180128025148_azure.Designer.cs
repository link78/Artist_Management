﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WebController.Entities;

namespace WebController.Migrations
{
    [DbContext(typeof(ArtistContext))]
    [Migration("20180128025148_azure")]
    partial class azure
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebController.Entities.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Provence")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("WebSite")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("WebController.Entities.ArtistSkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ArtistId");

                    b.Property<string>("Details")
                        .HasMaxLength(255);

                    b.Property<int>("SkillLevel");

                    b.Property<string>("Styles")
                        .HasMaxLength(255);

                    b.Property<string>("TalentName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.ToTable("ArtistSkill");
                });

            modelBuilder.Entity("WebController.Entities.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ArtistId");

                    b.Property<string>("Body");

                    b.Property<int>("Rating");

                    b.Property<string>("ReviewName");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("WebController.Entities.ArtistSkill", b =>
                {
                    b.HasOne("WebController.Entities.Artist", "Artist")
                        .WithMany("ArtistSkills")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebController.Entities.Review", b =>
                {
                    b.HasOne("WebController.Entities.Artist", "Artist")
                        .WithMany("Reviews")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}