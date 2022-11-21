using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiLibros.Migrations
{
    public partial class ComentarioUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "Seccions",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seccions_UsuarioId",
                table: "Seccions",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seccions_AspNetUsers_UsuarioId",
                table: "Seccions",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
           name: "FK_Seccions_AspNetUsers_UsuarioId",
           table: "Seccions");

            migrationBuilder.DropIndex(
                name: "IX_Cursos_UsuarioId",
                table: "Seccions");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Seccions");
        }
    }
}
