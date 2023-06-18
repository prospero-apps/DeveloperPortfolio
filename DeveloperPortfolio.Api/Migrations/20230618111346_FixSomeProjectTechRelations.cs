using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeveloperPortfolio.Api.Migrations
{
    /// <inheritdoc />
    public partial class FixSomeProjectTechRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProjectTechRelations",
                keyColumn: "Id",
                keyValue: 33,
                column: "TechId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "ProjectTechRelations",
                keyColumn: "Id",
                keyValue: 34,
                column: "TechId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ProjectTechRelations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ProjectId", "TechId" },
                values: new object[] { 22, 9 });

            migrationBuilder.InsertData(
                table: "ProjectTechRelations",
                columns: new[] { "Id", "ProjectId", "TechId" },
                values: new object[] { 37, 23, 14 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProjectTechRelations",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.UpdateData(
                table: "ProjectTechRelations",
                keyColumn: "Id",
                keyValue: 33,
                column: "TechId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ProjectTechRelations",
                keyColumn: "Id",
                keyValue: 34,
                column: "TechId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "ProjectTechRelations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ProjectId", "TechId" },
                values: new object[] { 23, 14 });
        }
    }
}
