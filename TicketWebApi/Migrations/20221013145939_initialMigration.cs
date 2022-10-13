using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketWebApi.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Asuntos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clave = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    seleccionable = table.Column<bool>(type: "bit", nullable: false),
                    super = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AsuntoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asuntos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asuntos_Asuntos_AsuntoId",
                        column: x => x.AsuntoId,
                        principalTable: "Asuntos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clave = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    super = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartamentoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departamentos_Departamentos_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamentos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Ejercicios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    anio = table.Column<int>(type: "int", nullable: false),
                    activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ejercicios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedioContactos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clave = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    local = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedioContactos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clave = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clave = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoClientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clave = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoClientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Rol_RolId",
                        column: x => x.RolId,
                        principalTable: "Rol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clave = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoClienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_TipoClientes_TipoClienteId",
                        column: x => x.TipoClienteId,
                        principalTable: "TipoClientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TicketDetalles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechaFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    descripcionProblema = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descripcionSolucion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    AsuntoId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    super = table.Column<int>(type: "int", nullable: true),
                    TicketDetallesId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketDetalles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TicketDetalles_Asuntos_AsuntoId",
                        column: x => x.AsuntoId,
                        principalTable: "Asuntos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TicketDetalles_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TicketDetalles_TicketDetalles_TicketDetallesId",
                        column: x => x.TicketDetallesId,
                        principalTable: "TicketDetalles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TicketDetalles_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    AsuntoId = table.Column<int>(type: "int", nullable: false),
                    MedioContactoId = table.Column<int>(type: "int", nullable: false),
                    DepartamentoId = table.Column<int>(type: "int", nullable: false),
                    EjercicioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Asuntos_AsuntoId",
                        column: x => x.AsuntoId,
                        principalTable: "Asuntos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Departamentos_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Ejercicios_EjercicioId",
                        column: x => x.EjercicioId,
                        principalTable: "Ejercicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_MedioContactos_MedioContactoId",
                        column: x => x.MedioContactoId,
                        principalTable: "MedioContactos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asuntos_AsuntoId",
                table: "Asuntos",
                column: "AsuntoId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_TipoClienteId",
                table: "Clientes",
                column: "TipoClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Departamentos_DepartamentoId",
                table: "Departamentos",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketDetalles_AsuntoId",
                table: "TicketDetalles",
                column: "AsuntoId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketDetalles_StatusId",
                table: "TicketDetalles",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketDetalles_TicketDetallesId",
                table: "TicketDetalles",
                column: "TicketDetallesId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketDetalles_UsuarioId",
                table: "TicketDetalles",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_AsuntoId",
                table: "Tickets",
                column: "AsuntoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ClienteId",
                table: "Tickets",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_DepartamentoId",
                table: "Tickets",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_EjercicioId",
                table: "Tickets",
                column: "EjercicioId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_MedioContactoId",
                table: "Tickets",
                column: "MedioContactoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_RolId",
                table: "Usuarios",
                column: "RolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TicketDetalles");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Asuntos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Departamentos");

            migrationBuilder.DropTable(
                name: "Ejercicios");

            migrationBuilder.DropTable(
                name: "MedioContactos");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropTable(
                name: "TipoClientes");
        }
    }
}
