using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiFbi.Migrations
{
    /// <inheritdoc />
    public partial class segundacompleta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Fbi",
                table: "Fbi");

            migrationBuilder.DropColumn(
                name: "TitleId",
                table: "Fbi");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Fbi",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0)
                .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Fbi",
                type: "NVARCHAR2(2000)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fbi",
                table: "Fbi",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Interpol",
                columns: table => new
                {
                    EntityId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Forename = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Nationalities = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interpol", x => x.EntityId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Interpol");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fbi",
                table: "Fbi");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Fbi");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Fbi");

            migrationBuilder.AddColumn<string>(
                name: "TitleId",
                table: "Fbi",
                type: "NVARCHAR2(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fbi",
                table: "Fbi",
                column: "TitleId");
        }
    }
}
