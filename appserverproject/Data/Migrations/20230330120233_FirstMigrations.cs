using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace appserverproject.Data.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Promos",
                columns: table => new
                {
                    PromoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PromoTitle = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    PromoType = table.Column<int>(type: "INTEGER", nullable: false),
                    PromoCurrency = table.Column<int>(type: "INTEGER", nullable: false),
                    PromoStart = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    PromoEnd = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Model = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Channel = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promos", x => x.PromoId);
                });

            migrationBuilder.InsertData(
                table: "Promos",
                columns: new[] { "PromoId", "Channel", "Model", "PromoCurrency", "PromoEnd", "PromoStart", "PromoTitle", "PromoType" },
                values: new object[,]
                {
                    { 1, "", "", 1, "30.09.2022", "28.09.2022", "Post 1", 1 },
                    { 2, "", "", 1, "30.09.2022", "28.09.2022", "Post 2", 1 },
                    { 3, "", "", 1, "30.09.2022", "28.09.2022", "Post 3", 1 },
                    { 4, "", "", 1, "30.09.2022", "28.09.2022", "Post 4", 1 },
                    { 5, "", "", 1, "30.09.2022", "28.09.2022", "Post 5", 1 },
                    { 6, "", "", 1, "30.09.2022", "28.09.2022", "Post 6", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Promos");
        }
    }
}
