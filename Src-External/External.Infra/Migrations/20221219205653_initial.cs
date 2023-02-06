using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace External.Infra.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
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
                    Concurso = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    Data = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Casa01 = table.Column<int>(name: "Casa_01", type: "int", maxLength: 2, nullable: false),
                    Casa02 = table.Column<int>(name: "Casa_02", type: "int", maxLength: 2, nullable: false),
                    Casa03 = table.Column<int>(name: "Casa_03", type: "int", maxLength: 2, nullable: false),
                    Casa04 = table.Column<int>(name: "Casa_04", type: "int", maxLength: 2, nullable: false),
                    Casa05 = table.Column<int>(name: "Casa_05", type: "int", maxLength: 2, nullable: false),
                    Casa06 = table.Column<int>(name: "Casa_06", type: "int", maxLength: 2, nullable: false),
                    Casa07 = table.Column<int>(name: "Casa_07", type: "int", maxLength: 2, nullable: false),
                    Casa08 = table.Column<int>(name: "Casa_08", type: "int", maxLength: 2, nullable: false),
                    Casa09 = table.Column<int>(name: "Casa_09", type: "int", maxLength: 2, nullable: false),
                    Casa10 = table.Column<int>(name: "Casa_10", type: "int", maxLength: 2, nullable: false),
                    Casa11 = table.Column<int>(name: "Casa_11", type: "int", maxLength: 2, nullable: false),
                    Casa12 = table.Column<int>(name: "Casa_12", type: "int", maxLength: 2, nullable: false),
                    Casa13 = table.Column<int>(name: "Casa_13", type: "int", maxLength: 2, nullable: false),
                    Casa14 = table.Column<int>(name: "Casa_14", type: "int", maxLength: 2, nullable: false),
                    Casa15 = table.Column<int>(name: "Casa_15", type: "int", maxLength: 2, nullable: false)
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
