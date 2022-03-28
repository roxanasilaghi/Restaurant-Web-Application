using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AplicatieWeb.Migrations
{
    public partial class cl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rezervare",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervare", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RezervareID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Client_Rezervare_RezervareID",
                        column: x => x.RezervareID,
                        principalTable: "Rezervare",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Meniu",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pret = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    RezervareID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meniu", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Meniu_Rezervare_RezervareID",
                        column: x => x.RezervareID,
                        principalTable: "Rezervare",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Client_RezervareID",
                table: "Client",
                column: "RezervareID");

            migrationBuilder.CreateIndex(
                name: "IX_Meniu_RezervareID",
                table: "Meniu",
                column: "RezervareID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Meniu");

            migrationBuilder.DropTable(
                name: "Rezervare");
        }
    }
}
