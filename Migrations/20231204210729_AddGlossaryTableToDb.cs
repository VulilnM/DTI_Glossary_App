using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DTI_Glossary_App.Migrations
{
    /// <inheritdoc />
    public partial class AddGlossaryTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Glossaries",
                columns: table => new
                {
                    GlossaryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Term = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Definition = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Glossaries", x => x.GlossaryId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Glossaries");
        }
    }
}
