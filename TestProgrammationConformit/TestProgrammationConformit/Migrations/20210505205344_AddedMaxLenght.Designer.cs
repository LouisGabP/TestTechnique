﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TestProgrammationConformit.Infrastructures;

namespace TestProgrammationConformit.Migrations
{
    [DbContext(typeof(ConformitContext))]
    [Migration("20210505205344_AddedMaxLenght")]
    partial class AddedMaxLenght
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("TestProgrammationConformit.Infrastructures.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("EventId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("TestProgrammationConformit.Infrastructures.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("PersonName")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("TestProgrammationConformit.Infrastructures.Models.Comment", b =>
                {
                    b.HasOne("TestProgrammationConformit.Infrastructures.Models.Event", null)
                        .WithMany("Comments")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
