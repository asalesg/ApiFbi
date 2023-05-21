using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiFbi.Migrations
{
    /// <inheritdoc />
    public partial class terceira : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FbiInterpol",
                columns: table => new
                {
                    fbisId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    interpolsEntityId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FbiInterpol", x => new { x.fbisId, x.interpolsEntityId });
                    table.ForeignKey(
                        name: "FK_FbiInterpol_Fbi_fbisId",
                        column: x => x.fbisId,
                        principalTable: "Fbi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FbiInterpol_Interpol_interpolsEntityId",
                        column: x => x.interpolsEntityId,
                        principalTable: "Interpol",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FbiInterpol_interpolsEntityId",
                table: "FbiInterpol",
                column: "interpolsEntityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FbiInterpol");
        }
    }
}
