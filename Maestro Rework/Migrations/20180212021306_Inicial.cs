using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Maestro_Rework.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    Cargo = table.Column<string>(nullable: true),
                    CodigoSenha = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Login = table.Column<string>(nullable: true),
                    Nivel = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    Verificado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Conteudos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    CodigoAcesso = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Tema = table.Column<string>(nullable: true),
                    Texto = table.Column<string>(nullable: true),
                    UsuarioID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conteudos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conteudos_Usuarios_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questionarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    CodigoAcesso = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Refazer = table.Column<bool>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questionarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questionarios_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegistroUsuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataEntrada = table.Column<DateTime>(nullable: false),
                    DataSaida = table.Column<DateTime>(nullable: false),
                    IpDaMaquina = table.Column<string>(nullable: true),
                    UsuarioID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroUsuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegistroUsuarios_Usuarios_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnexoConteudos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Anexo = table.Column<byte[]>(nullable: true),
                    ConteudoID = table.Column<int>(nullable: false),
                    Imagem = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnexoConteudos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnexoConteudos_Conteudos_ConteudoID",
                        column: x => x.ConteudoID,
                        principalTable: "Conteudos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegistroConteudos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ConteudoID = table.Column<int>(nullable: false),
                    DataAtualizacao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroConteudos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegistroConteudos_Conteudos_ConteudoID",
                        column: x => x.ConteudoID,
                        principalTable: "Conteudos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioConteudos",
                columns: table => new
                {
                    UsuarioID = table.Column<int>(nullable: false),
                    ConteudoID = table.Column<int>(nullable: false),
                    Acesso = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioConteudos", x => new { x.UsuarioID, x.ConteudoID });
                    table.ForeignKey(
                        name: "FK_UsuarioConteudos_Conteudos_ConteudoID",
                        column: x => x.ConteudoID,
                        principalTable: "Conteudos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_UsuarioConteudos_Usuarios_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "QuestionarioUsuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Acesso = table.Column<bool>(nullable: false),
                    QuestionarioID = table.Column<int>(nullable: false),
                    Refez = table.Column<bool>(nullable: false),
                    UsuarioID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionarioUsuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionarioUsuarios_Questionarios_QuestionarioID",
                        column: x => x.QuestionarioID,
                        principalTable: "Questionarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_QuestionarioUsuarios_Usuarios_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Questoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Imagem = table.Column<byte[]>(nullable: true),
                    Pergunta = table.Column<string>(nullable: true),
                    QuestionarioID = table.Column<int>(nullable: false),
                    Valor = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questoes_Questionarios_QuestionarioID",
                        column: x => x.QuestionarioID,
                        principalTable: "Questionarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegistroQuestionarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataAtualizacao = table.Column<DateTime>(nullable: false),
                    QuestionarioID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroQuestionarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegistroQuestionarios_Questionarios_QuestionarioID",
                        column: x => x.QuestionarioID,
                        principalTable: "Questionarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlternativaCorretas",
                columns: table => new
                {
                    QuestionarioUsuarioID = table.Column<int>(nullable: false),
                    AlternativaID = table.Column<int>(nullable: false),
                    Tentativa = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlternativaCorretas", x => new { x.QuestionarioUsuarioID, x.AlternativaID });
                    table.ForeignKey(
                        name: "FK_AlternativaCorretas_QuestionarioUsuarios_QuestionarioUsuarioID",
                        column: x => x.QuestionarioUsuarioID,
                        principalTable: "QuestionarioUsuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Alternativas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Correta = table.Column<bool>(nullable: false),
                    QuestaoID = table.Column<int>(nullable: false),
                    Texto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alternativas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alternativas_Questoes_QuestaoID",
                        column: x => x.QuestaoID,
                        principalTable: "Questoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alternativas_QuestaoID",
                table: "Alternativas",
                column: "QuestaoID");

            migrationBuilder.CreateIndex(
                name: "IX_AnexoConteudos_ConteudoID",
                table: "AnexoConteudos",
                column: "ConteudoID");

            migrationBuilder.CreateIndex(
                name: "IX_Conteudos_UsuarioID",
                table: "Conteudos",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Questionarios_UsuarioId",
                table: "Questionarios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionarioUsuarios_QuestionarioID",
                table: "QuestionarioUsuarios",
                column: "QuestionarioID");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionarioUsuarios_UsuarioID",
                table: "QuestionarioUsuarios",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Questoes_QuestionarioID",
                table: "Questoes",
                column: "QuestionarioID");

            migrationBuilder.CreateIndex(
                name: "IX_RegistroConteudos_ConteudoID",
                table: "RegistroConteudos",
                column: "ConteudoID");

            migrationBuilder.CreateIndex(
                name: "IX_RegistroQuestionarios_QuestionarioID",
                table: "RegistroQuestionarios",
                column: "QuestionarioID");

            migrationBuilder.CreateIndex(
                name: "IX_RegistroUsuarios_UsuarioID",
                table: "RegistroUsuarios",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioConteudos_ConteudoID",
                table: "UsuarioConteudos",
                column: "ConteudoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlternativaCorretas");

            migrationBuilder.DropTable(
                name: "Alternativas");

            migrationBuilder.DropTable(
                name: "AnexoConteudos");

            migrationBuilder.DropTable(
                name: "RegistroConteudos");

            migrationBuilder.DropTable(
                name: "RegistroQuestionarios");

            migrationBuilder.DropTable(
                name: "RegistroUsuarios");

            migrationBuilder.DropTable(
                name: "UsuarioConteudos");

            migrationBuilder.DropTable(
                name: "QuestionarioUsuarios");

            migrationBuilder.DropTable(
                name: "Questoes");

            migrationBuilder.DropTable(
                name: "Conteudos");

            migrationBuilder.DropTable(
                name: "Questionarios");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
