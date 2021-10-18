using Microsoft.EntityFrameworkCore.Migrations;

namespace TermProjectV1.Migrations
{
    public partial class Secondary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AllergyId",
                table: "Recommends",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Allergies",
                columns: table => new
                {
                    AllergyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Allergen = table.Column<string>(nullable: true),
                    Examples = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allergies", x => x.AllergyId);
                });

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "AllergyId", "Allergen", "Examples" },
                values: new object[] { 1, "None", "Water" });

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "AllergyId", "Allergen", "Examples" },
                values: new object[] { 2, "Peanuts", "Peanut Butter, Brittle" });

            migrationBuilder.InsertData(
                table: "Allergies",
                columns: new[] { "AllergyId", "Allergen", "Examples" },
                values: new object[] { 3, "Gluten", "Bread, Beer" });

            migrationBuilder.UpdateData(
                table: "Recommends",
                keyColumn: "RecommendId",
                keyValue: 1,
                column: "AllergyId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Recommends",
                keyColumn: "RecommendId",
                keyValue: 2,
                column: "AllergyId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Recommends",
                keyColumn: "RecommendId",
                keyValue: 3,
                column: "AllergyId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Recommends_AllergyId",
                table: "Recommends",
                column: "AllergyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recommends_Allergies_AllergyId",
                table: "Recommends",
                column: "AllergyId",
                principalTable: "Allergies",
                principalColumn: "AllergyId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recommends_Allergies_AllergyId",
                table: "Recommends");

            migrationBuilder.DropTable(
                name: "Allergies");

            migrationBuilder.DropIndex(
                name: "IX_Recommends_AllergyId",
                table: "Recommends");

            migrationBuilder.DropColumn(
                name: "AllergyId",
                table: "Recommends");
        }
    }
}
