using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tarea7.Migrations
{
    public partial class solicitante : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vacunados_vacunas_vacuna1_id",
                table: "vacunados");

            migrationBuilder.AlterColumn<int>(
                name: "vacuna1_id",
                table: "vacunados",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "vacuna1_fecha",
                table: "vacunados",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "telefono",
                table: "vacunados",
                type: "TEXT",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Solicitantes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Cedula = table.Column<string>(type: "TEXT", maxLength: 11, nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Apellido = table.Column<string>(type: "TEXT", nullable: false),
                    Telefono = table.Column<string>(type: "TEXT", nullable: false),
                    Correo = table.Column<string>(type: "TEXT", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Sangre = table.Column<string>(type: "TEXT", nullable: false),
                    ProvinciaId = table.Column<int>(type: "INTEGER", nullable: false),
                    Direccion = table.Column<string>(type: "TEXT", nullable: false),
                    Latitud = table.Column<float>(type: "REAL", nullable: false),
                    Longitud = table.Column<float>(type: "REAL", nullable: false),
                    HaTenidoCovid = table.Column<bool>(type: "INTEGER", nullable: false),
                    Justificacion = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicitantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Solicitantes_provincias_ProvinciaId",
                        column: x => x.ProvinciaId,
                        principalTable: "provincias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Solicitantes_ProvinciaId",
                table: "Solicitantes",
                column: "ProvinciaId");

            migrationBuilder.AddForeignKey(
                name: "FK_vacunados_vacunas_vacuna1_id",
                table: "vacunados",
                column: "vacuna1_id",
                principalTable: "vacunas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vacunados_vacunas_vacuna1_id",
                table: "vacunados");

            migrationBuilder.DropTable(
                name: "Solicitantes");

            migrationBuilder.AlterColumn<int>(
                name: "vacuna1_id",
                table: "vacunados",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<DateTime>(
                name: "vacuna1_fecha",
                table: "vacunados",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "telefono",
                table: "vacunados",
                type: "TEXT",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 10);

            migrationBuilder.AddForeignKey(
                name: "FK_vacunados_vacunas_vacuna1_id",
                table: "vacunados",
                column: "vacuna1_id",
                principalTable: "vacunas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
