﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tunes.Data.Context;

namespace Tunes.Data.Migrations
{
    [DbContext(typeof(TunesContext))]
    [Migration("20201019225452_Artista")]
    partial class Artista
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Tunes.Business.Models.Artista", b =>
                {
                    b.Property<int>("ArtistaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("artista_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("nome")
                        .HasColumnType("varchar(120)");

                    b.Property<DateTime>("data_criacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("ArtistaId");

                    b.ToTable("artistas");
                });
#pragma warning restore 612, 618
        }
    }
}
