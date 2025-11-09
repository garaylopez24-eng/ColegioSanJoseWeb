using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ColegioWeb.Migrations
{
    /// <inheritdoc />
    public partial class Segunda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expediente_Alumno_AlumnoId",
                table: "Expediente");

            migrationBuilder.DropForeignKey(
                name: "FK_Expediente_Materia_MateriaId",
                table: "Expediente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Materia",
                table: "Materia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Expediente",
                table: "Expediente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Alumno",
                table: "Alumno");

            migrationBuilder.RenameTable(
                name: "Materia",
                newName: "Materias");

            migrationBuilder.RenameTable(
                name: "Expediente",
                newName: "Expedientes");

            migrationBuilder.RenameTable(
                name: "Alumno",
                newName: "Alumnos");

            migrationBuilder.RenameIndex(
                name: "IX_Expediente_MateriaId",
                table: "Expedientes",
                newName: "IX_Expedientes_MateriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Expediente_AlumnoId",
                table: "Expedientes",
                newName: "IX_Expedientes_AlumnoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Materias",
                table: "Materias",
                column: "MateriaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Expedientes",
                table: "Expedientes",
                column: "ExpedienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Alumnos",
                table: "Alumnos",
                column: "AlumnoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expedientes_Alumnos_AlumnoId",
                table: "Expedientes",
                column: "AlumnoId",
                principalTable: "Alumnos",
                principalColumn: "AlumnoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Expedientes_Materias_MateriaId",
                table: "Expedientes",
                column: "MateriaId",
                principalTable: "Materias",
                principalColumn: "MateriaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expedientes_Alumnos_AlumnoId",
                table: "Expedientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Expedientes_Materias_MateriaId",
                table: "Expedientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Materias",
                table: "Materias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Expedientes",
                table: "Expedientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Alumnos",
                table: "Alumnos");

            migrationBuilder.RenameTable(
                name: "Materias",
                newName: "Materia");

            migrationBuilder.RenameTable(
                name: "Expedientes",
                newName: "Expediente");

            migrationBuilder.RenameTable(
                name: "Alumnos",
                newName: "Alumno");

            migrationBuilder.RenameIndex(
                name: "IX_Expedientes_MateriaId",
                table: "Expediente",
                newName: "IX_Expediente_MateriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Expedientes_AlumnoId",
                table: "Expediente",
                newName: "IX_Expediente_AlumnoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Materia",
                table: "Materia",
                column: "MateriaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Expediente",
                table: "Expediente",
                column: "ExpedienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Alumno",
                table: "Alumno",
                column: "AlumnoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expediente_Alumno_AlumnoId",
                table: "Expediente",
                column: "AlumnoId",
                principalTable: "Alumno",
                principalColumn: "AlumnoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Expediente_Materia_MateriaId",
                table: "Expediente",
                column: "MateriaId",
                principalTable: "Materia",
                principalColumn: "MateriaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
