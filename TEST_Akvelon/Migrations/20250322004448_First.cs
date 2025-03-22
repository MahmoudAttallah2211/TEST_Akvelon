using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TEST_Akvelon.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FizzBuzzEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Input = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Output = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FizzBuzzEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FizzBuzzRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Input = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "FizzBuzzResults",
                columns: table => new
                {
                    Output = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "FizzBuzzServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Input = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Output = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.InsertData(
                table: "FizzBuzzEntities",
                columns: new[] { "Id", "Count", "Input", "Output" },
                values: new object[] { 1, 2, "Mary had a little lamb", "Buzz had Fizz little lamb" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FizzBuzzEntities");

            migrationBuilder.DropTable(
                name: "FizzBuzzRequests");

            migrationBuilder.DropTable(
                name: "FizzBuzzResults");

            migrationBuilder.DropTable(
                name: "FizzBuzzServices");
        }
    }
}
