using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiBooks.Migrations
{
    public partial class EFCoreCodeFirstSampleModelsRepositoryContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_book",
                table: "book");

            migrationBuilder.DeleteData(
                table: "book",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "book",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "book");

            migrationBuilder.RenameColumn(
                name: "nameBook",
                table: "book",
                newName: "NameBook");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "book",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_book",
                table: "book",
                column: "Id");

            migrationBuilder.InsertData(
                table: "book",
                columns: new[] { "Id", "Author", "NameBook", "Page" },
                values: new object[] { new Guid("bd7d39cc-115a-4abe-a588-a76318fcc30c"), "Andrew Troelsen", "C# 7 .Net Core", 1328 });

            migrationBuilder.InsertData(
                table: "book",
                columns: new[] { "Id", "Author", "NameBook", "Page" },
                values: new object[] { new Guid("5a8fc52c-27e2-4459-a9a0-9dfc844ad4f5"), "Allen G.Taylor", "SQL", 402 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_book",
                table: "book");

            migrationBuilder.DeleteData(
                table: "book",
                keyColumn: "Id",
                keyValue: new Guid("5a8fc52c-27e2-4459-a9a0-9dfc844ad4f5"));

            migrationBuilder.DeleteData(
                table: "book",
                keyColumn: "Id",
                keyValue: new Guid("bd7d39cc-115a-4abe-a588-a76318fcc30c"));

            migrationBuilder.DropColumn(
                name: "Id",
                table: "book");

            migrationBuilder.RenameColumn(
                name: "NameBook",
                table: "book",
                newName: "nameBook");

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "book",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_book",
                table: "book",
                column: "BookId");

            migrationBuilder.InsertData(
                table: "book",
                columns: new[] { "BookId", "Author", "Page", "nameBook" },
                values: new object[] { 1, "Andrew Troelsen", 1328, "C# 7 .Net Core" });

            migrationBuilder.InsertData(
                table: "book",
                columns: new[] { "BookId", "Author", "Page", "nameBook" },
                values: new object[] { 2, "Allen G.Taylor", 402, "SQL" });
        }
    }
}
