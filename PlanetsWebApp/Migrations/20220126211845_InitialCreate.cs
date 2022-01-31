using Microsoft.EntityFrameworkCore.Migrations;

namespace PlanetsWebApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Planet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mass = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MassDisplay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diameter = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SunDistance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planet", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Planet");
        }
    }
}
