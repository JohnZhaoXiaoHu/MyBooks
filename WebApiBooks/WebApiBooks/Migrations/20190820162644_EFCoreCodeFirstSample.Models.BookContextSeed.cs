using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiBooks.Migrations
{
    public partial class EFCoreCodeFirstSampleModelsBookContextSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "book",
                columns: new[] { "BookId", "Author", "Page", "nameBook" },
                values: new object[] { 1, "Andrew Troelsen", 1328, "C# 7 .Net Core" });

            migrationBuilder.InsertData(
                table: "book",
                columns: new[] { "BookId", "Author", "Page", "nameBook" },
                values: new object[] { 2, "Allen G.Taylor", 402, "SQL" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "book",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "book",
                keyColumn: "BookId",
                keyValue: 2);
        }
    }
}
