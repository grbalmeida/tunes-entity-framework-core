﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tunes.Data.Migrations
{
    public partial class Artista : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "artistas",
                columns: table => new
                {
                    artista_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "varchar(120)", nullable: false),
                    data_criacao = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_artistas", x => x.artista_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "artistas");
        }
    }
}
