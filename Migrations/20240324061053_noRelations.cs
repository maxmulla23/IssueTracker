using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IssueTracker.Migrations
{
    /// <inheritdoc />
    public partial class noRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BugIssues_AspNetUsers_UserId",
                table: "BugIssues");

            migrationBuilder.DropForeignKey(
                name: "FK_Recommendations_AspNetUsers_UserId",
                table: "Recommendations");

            migrationBuilder.DropIndex(
                name: "IX_Recommendations_UserId",
                table: "Recommendations");

            migrationBuilder.DropIndex(
                name: "IX_BugIssues_UserId",
                table: "BugIssues");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Recommendations");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "BugIssues");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Recommendations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "BugIssues",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Recommendations_UserId",
                table: "Recommendations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BugIssues_UserId",
                table: "BugIssues",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BugIssues_AspNetUsers_UserId",
                table: "BugIssues",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recommendations_AspNetUsers_UserId",
                table: "Recommendations",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
