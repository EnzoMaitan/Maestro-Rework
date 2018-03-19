using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Maestro_Rework.Migrations
{
    public partial class RemovendoPrazoConteudo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataFim",
                table: "Conteudos");

            migrationBuilder.DropColumn(
                name: "DataInicio",
                table: "Conteudos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataFim",
                table: "Conteudos",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataInicio",
                table: "Conteudos",
                nullable: true);
        }
    }
}
