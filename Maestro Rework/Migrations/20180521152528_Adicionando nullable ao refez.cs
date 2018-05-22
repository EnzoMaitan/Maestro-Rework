using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Maestro_Rework.Migrations
{
    public partial class Adicionandonullableaorefez : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Refez",
                table: "QuestionarioUsuarios",
                nullable: true,
                oldClrType: typeof(bool));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Refez",
                table: "QuestionarioUsuarios",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);
        }
    }
}
