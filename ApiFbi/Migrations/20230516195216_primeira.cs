using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiFbi.Migrations
{
    /// <inheritdoc />
    public partial class primeira : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fbi",
                columns: table => new
                {
                    TitleId = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    Url = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Sex = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Description = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Nationality = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fbi", x => x.TitleId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fbi");
        }
    }
}
