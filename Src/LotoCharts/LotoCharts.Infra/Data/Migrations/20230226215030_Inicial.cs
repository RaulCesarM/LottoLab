using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LotoCharts.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LotoFacil",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Concurso = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Casa_1 = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Casa_2 = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Casa_3 = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Casa_4 = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Casa_5 = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Casa_6 = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Casa_7 = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Casa_8 = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Casa_9 = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Casa_10 = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Casa_11 = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Casa_12 = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Casa_13 = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Casa_14 = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Casa_15 = table.Column<int>(type: "int", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LotoFacil", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LotoFacil");
        }
    }
}
