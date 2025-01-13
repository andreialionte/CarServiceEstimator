using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarServiceEstimator.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "CarServiceEstimatorSchema");

            migrationBuilder.CreateTable(
                name: "Client",
                schema: "CarServiceEstimatorSchema",
                columns: table => new
                {
                    IdClient = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumeClient = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NrTelefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.IdClient);
                });

            migrationBuilder.CreateTable(
                name: "Reper",
                schema: "CarServiceEstimatorSchema",
                columns: table => new
                {
                    IdReper = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DenumireReper = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PretUnitar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SpImagine = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reper", x => x.IdReper);
                });

            migrationBuilder.CreateTable(
                name: "Deviz",
                schema: "CarServiceEstimatorSchema",
                columns: table => new
                {
                    IdDeviz = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DenumireDeviz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataDeviz = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdClient = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MarcaModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NrInmatriculare = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deviz", x => x.IdDeviz);
                    table.ForeignKey(
                        name: "FK_Deviz_Client_IdClient",
                        column: x => x.IdClient,
                        principalSchema: "CarServiceEstimatorSchema",
                        principalTable: "Client",
                        principalColumn: "IdClient",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DevizContinut",
                schema: "CarServiceEstimatorSchema",
                columns: table => new
                {
                    IdDevizContinut = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDeviz = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nrc = table.Column<int>(type: "int", nullable: false),
                    IdReper = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PretUnitar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Cantitate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevizContinut", x => x.IdDevizContinut);
                    table.ForeignKey(
                        name: "FK_DevizContinut_Deviz_IdDeviz",
                        column: x => x.IdDeviz,
                        principalSchema: "CarServiceEstimatorSchema",
                        principalTable: "Deviz",
                        principalColumn: "IdDeviz",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DevizContinut_Reper_IdReper",
                        column: x => x.IdReper,
                        principalSchema: "CarServiceEstimatorSchema",
                        principalTable: "Reper",
                        principalColumn: "IdReper",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Deviz_IdClient",
                schema: "CarServiceEstimatorSchema",
                table: "Deviz",
                column: "IdClient");

            migrationBuilder.CreateIndex(
                name: "IX_DevizContinut_IdDeviz",
                schema: "CarServiceEstimatorSchema",
                table: "DevizContinut",
                column: "IdDeviz");

            migrationBuilder.CreateIndex(
                name: "IX_DevizContinut_IdReper",
                schema: "CarServiceEstimatorSchema",
                table: "DevizContinut",
                column: "IdReper");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DevizContinut",
                schema: "CarServiceEstimatorSchema");

            migrationBuilder.DropTable(
                name: "Deviz",
                schema: "CarServiceEstimatorSchema");

            migrationBuilder.DropTable(
                name: "Reper",
                schema: "CarServiceEstimatorSchema");

            migrationBuilder.DropTable(
                name: "Client",
                schema: "CarServiceEstimatorSchema");
        }
    }
}
