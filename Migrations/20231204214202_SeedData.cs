using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DTI_Glossary_App.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Glossaries",
                columns: new[] { "GlossaryId", "Definition", "Term" },
                values: new object[,]
                {
                    { 1, "Definition of the glossary number 1", "Gloss1" },
                    { 2, "Definition of the glossary number 2", "Gloss2" },
                    { 3, "Definition of the glossary number 3", "Gloss3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Glossaries",
                keyColumn: "GlossaryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Glossaries",
                keyColumn: "GlossaryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Glossaries",
                keyColumn: "GlossaryId",
                keyValue: 3);
        }
    }
}
