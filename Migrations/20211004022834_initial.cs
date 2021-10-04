using Microsoft.EntityFrameworkCore.Migrations;

namespace TermProjectV1.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recommends",
                columns: table => new
                {
                    RecommendId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Food = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recommends", x => x.RecommendId);
                });

            migrationBuilder.InsertData(
                table: "Recommends",
                columns: new[] { "RecommendId", "Food", "Name", "Rating" },
                values: new object[] { 1, "Hot Dish", "Johnathan Fischer", 5 });

            migrationBuilder.InsertData(
                table: "Recommends",
                columns: new[] { "RecommendId", "Food", "Name", "Rating" },
                values: new object[] { 2, "Vernor's Ginger Ale", "CadillacConvertable98", 2 });

            migrationBuilder.InsertData(
                table: "Recommends",
                columns: new[] { "RecommendId", "Food", "Name", "Rating" },
                values: new object[] { 3, "Mackinac Island Fudge", "Gerald", 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recommends");
        }
    }
}
