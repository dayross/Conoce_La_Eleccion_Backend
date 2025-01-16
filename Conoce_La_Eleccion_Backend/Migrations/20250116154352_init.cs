using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Conoce_La_Eleccion_Backend.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cargo",
                columns: table => new
                {
                    IdCargo = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargo", x => x.IdCargo);
                });

            migrationBuilder.CreateTable(
                name: "TipoRedSocial",
                columns: table => new
                {
                    IdTipoRedSocial = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoRedSocial", x => x.IdTipoRedSocial);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nickname = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Aspirante",
                columns: table => new
                {
                    IdAspirante = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Apellidos = table.Column<string>(type: "text", nullable: false),
                    Edad = table.Column<int>(type: "integer", nullable: false),
                    Presentacion = table.Column<string>(type: "text", nullable: false),
                    IdCargo = table.Column<int>(type: "integer", nullable: false),
                    CargoIdCargo = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aspirante", x => x.IdAspirante);
                    table.ForeignKey(
                        name: "FK_Aspirante_Cargo_CargoIdCargo",
                        column: x => x.CargoIdCargo,
                        principalTable: "Cargo",
                        principalColumn: "IdCargo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Calificacion",
                columns: table => new
                {
                    IdCalificacion = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Puntuacion = table.Column<int>(type: "integer", nullable: false),
                    IdUsuario = table.Column<int>(type: "integer", nullable: false),
                    UsuarioIdUsuario = table.Column<int>(type: "integer", nullable: false),
                    IdAspirante = table.Column<int>(type: "integer", nullable: false),
                    AspiranteIdAspirante = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calificacion", x => x.IdCalificacion);
                    table.ForeignKey(
                        name: "FK_Calificacion_Aspirante_AspiranteIdAspirante",
                        column: x => x.AspiranteIdAspirante,
                        principalTable: "Aspirante",
                        principalColumn: "IdAspirante",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Calificacion_Usuario_UsuarioIdUsuario",
                        column: x => x.UsuarioIdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CorreoElectronico",
                columns: table => new
                {
                    IdCorreoElectronico = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    IdAspirante = table.Column<int>(type: "integer", nullable: false),
                    AspiranteIdAspirante = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorreoElectronico", x => x.IdCorreoElectronico);
                    table.ForeignKey(
                        name: "FK_CorreoElectronico_Aspirante_AspiranteIdAspirante",
                        column: x => x.AspiranteIdAspirante,
                        principalTable: "Aspirante",
                        principalColumn: "IdAspirante",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Educacion",
                columns: table => new
                {
                    IdEducacion = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    ImpartidoPor = table.Column<string>(type: "text", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IdAspirante = table.Column<int>(type: "integer", nullable: false),
                    AspiranteIdAspirante = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educacion", x => x.IdEducacion);
                    table.ForeignKey(
                        name: "FK_Educacion_Aspirante_AspiranteIdAspirante",
                        column: x => x.AspiranteIdAspirante,
                        principalTable: "Aspirante",
                        principalColumn: "IdAspirante",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Experiencia",
                columns: table => new
                {
                    IDExperiencia = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Puesto = table.Column<string>(type: "text", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LugarTrabajo = table.Column<string>(type: "text", nullable: false),
                    IdAspirante = table.Column<int>(type: "integer", nullable: false),
                    AspiranteIdAspirante = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiencia", x => x.IDExperiencia);
                    table.ForeignKey(
                        name: "FK_Experiencia_Aspirante_AspiranteIdAspirante",
                        column: x => x.AspiranteIdAspirante,
                        principalTable: "Aspirante",
                        principalColumn: "IdAspirante",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RedesSociales",
                columns: table => new
                {
                    IdRedesSociales = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Url = table.Column<string>(type: "text", nullable: false),
                    IdTipoRedSocial = table.Column<int>(type: "integer", nullable: false),
                    TipoRedSocialIdTipoRedSocial = table.Column<int>(type: "integer", nullable: false),
                    IdAspirante = table.Column<int>(type: "integer", nullable: false),
                    AspiranteIdAspirante = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RedesSociales", x => x.IdRedesSociales);
                    table.ForeignKey(
                        name: "FK_RedesSociales_Aspirante_AspiranteIdAspirante",
                        column: x => x.AspiranteIdAspirante,
                        principalTable: "Aspirante",
                        principalColumn: "IdAspirante",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RedesSociales_TipoRedSocial_TipoRedSocialIdTipoRedSocial",
                        column: x => x.TipoRedSocialIdTipoRedSocial,
                        principalTable: "TipoRedSocial",
                        principalColumn: "IdTipoRedSocial",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Telefono",
                columns: table => new
                {
                    IdTelefono = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NumTelefono = table.Column<string>(type: "text", nullable: false),
                    Whatsapp = table.Column<bool>(type: "boolean", nullable: false),
                    IdAspirante = table.Column<int>(type: "integer", nullable: false),
                    AspiranteIdAspirante = table.Column<int>(type: "integer", nullable: false),
                    IdUsuario = table.Column<int>(type: "integer", nullable: false),
                    UsuarioIdUsuario = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefono", x => x.IdTelefono);
                    table.ForeignKey(
                        name: "FK_Telefono_Aspirante_AspiranteIdAspirante",
                        column: x => x.AspiranteIdAspirante,
                        principalTable: "Aspirante",
                        principalColumn: "IdAspirante",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Telefono_Usuario_UsuarioIdUsuario",
                        column: x => x.UsuarioIdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aspirante_CargoIdCargo",
                table: "Aspirante",
                column: "CargoIdCargo");

            migrationBuilder.CreateIndex(
                name: "IX_Calificacion_AspiranteIdAspirante",
                table: "Calificacion",
                column: "AspiranteIdAspirante");

            migrationBuilder.CreateIndex(
                name: "IX_Calificacion_UsuarioIdUsuario",
                table: "Calificacion",
                column: "UsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_CorreoElectronico_AspiranteIdAspirante",
                table: "CorreoElectronico",
                column: "AspiranteIdAspirante");

            migrationBuilder.CreateIndex(
                name: "IX_Educacion_AspiranteIdAspirante",
                table: "Educacion",
                column: "AspiranteIdAspirante");

            migrationBuilder.CreateIndex(
                name: "IX_Experiencia_AspiranteIdAspirante",
                table: "Experiencia",
                column: "AspiranteIdAspirante");

            migrationBuilder.CreateIndex(
                name: "IX_RedesSociales_AspiranteIdAspirante",
                table: "RedesSociales",
                column: "AspiranteIdAspirante");

            migrationBuilder.CreateIndex(
                name: "IX_RedesSociales_TipoRedSocialIdTipoRedSocial",
                table: "RedesSociales",
                column: "TipoRedSocialIdTipoRedSocial");

            migrationBuilder.CreateIndex(
                name: "IX_Telefono_AspiranteIdAspirante",
                table: "Telefono",
                column: "AspiranteIdAspirante");

            migrationBuilder.CreateIndex(
                name: "IX_Telefono_UsuarioIdUsuario",
                table: "Telefono",
                column: "UsuarioIdUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calificacion");

            migrationBuilder.DropTable(
                name: "CorreoElectronico");

            migrationBuilder.DropTable(
                name: "Educacion");

            migrationBuilder.DropTable(
                name: "Experiencia");

            migrationBuilder.DropTable(
                name: "RedesSociales");

            migrationBuilder.DropTable(
                name: "Telefono");

            migrationBuilder.DropTable(
                name: "TipoRedSocial");

            migrationBuilder.DropTable(
                name: "Aspirante");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Cargo");
        }
    }
}
