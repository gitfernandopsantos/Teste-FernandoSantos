using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Teste.CrmEducacional.Api.Migrations
{
    public partial class RelacionamentosEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Inscricoes_CandidatoId",
                schema: "public",
                table: "Inscricoes",
                column: "CandidatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Inscricoes_CursoId",
                schema: "public",
                table: "Inscricoes",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Inscricoes_ProcessoSeletivoId",
                schema: "public",
                table: "Inscricoes",
                column: "ProcessoSeletivoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inscricoes_Candidatos_CandidatoId",
                schema: "public",
                table: "Inscricoes",
                column: "CandidatoId",
                principalSchema: "public",
                principalTable: "Candidatos",
                principalColumn: "IdCandidato",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inscricoes_Cursos_CursoId",
                schema: "public",
                table: "Inscricoes",
                column: "CursoId",
                principalSchema: "public",
                principalTable: "Cursos",
                principalColumn: "IdCurso",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inscricoes_ProcessoSeletivo_ProcessoSeletivoId",
                schema: "public",
                table: "Inscricoes",
                column: "ProcessoSeletivoId",
                principalSchema: "public",
                principalTable: "ProcessoSeletivo",
                principalColumn: "IdProcessoSeletivo",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inscricoes_Candidatos_CandidatoId",
                schema: "public",
                table: "Inscricoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Inscricoes_Cursos_CursoId",
                schema: "public",
                table: "Inscricoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Inscricoes_ProcessoSeletivo_ProcessoSeletivoId",
                schema: "public",
                table: "Inscricoes");

            migrationBuilder.DropIndex(
                name: "IX_Inscricoes_CandidatoId",
                schema: "public",
                table: "Inscricoes");

            migrationBuilder.DropIndex(
                name: "IX_Inscricoes_CursoId",
                schema: "public",
                table: "Inscricoes");

            migrationBuilder.DropIndex(
                name: "IX_Inscricoes_ProcessoSeletivoId",
                schema: "public",
                table: "Inscricoes");
        }
    }
}
