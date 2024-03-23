using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IssueTracker.Migrations
{
    /// <inheritdoc />
    public partial class Thirdly : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BugIssues_AspNetUsers_UserId1",
                table: "BugIssues");

            migrationBuilder.DropForeignKey(
                name: "FK_Recommendations_AspNetUsers_UserId1",
                table: "Recommendations");

            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Developers_DeveloperId",
                table: "Todos");

            migrationBuilder.DropIndex(
                name: "IX_Recommendations_UserId1",
                table: "Recommendations");

            migrationBuilder.DropIndex(
                name: "IX_Feedbacks_BugIssueId",
                table: "Feedbacks");

            migrationBuilder.DropIndex(
                name: "IX_BugIssues_UserId1",
                table: "BugIssues");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Recommendations");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "BugIssues");

            migrationBuilder.AlterColumn<int>(
                name: "DeveloperId",
                table: "Todos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Recommendations",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "BugIssues",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Recommendations_UserId",
                table: "Recommendations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_BugIssueId",
                table: "Feedbacks",
                column: "BugIssueId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Developers_DeveloperId",
                table: "Todos",
                column: "DeveloperId",
                principalTable: "Developers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BugIssues_AspNetUsers_UserId",
                table: "BugIssues");

            migrationBuilder.DropForeignKey(
                name: "FK_Recommendations_AspNetUsers_UserId",
                table: "Recommendations");

            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Developers_DeveloperId",
                table: "Todos");

            migrationBuilder.DropIndex(
                name: "IX_Recommendations_UserId",
                table: "Recommendations");

            migrationBuilder.DropIndex(
                name: "IX_Feedbacks_BugIssueId",
                table: "Feedbacks");

            migrationBuilder.DropIndex(
                name: "IX_BugIssues_UserId",
                table: "BugIssues");

            migrationBuilder.AlterColumn<int>(
                name: "DeveloperId",
                table: "Todos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Recommendations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Recommendations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "BugIssues",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "BugIssues",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recommendations_UserId1",
                table: "Recommendations",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_BugIssueId",
                table: "Feedbacks",
                column: "BugIssueId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BugIssues_UserId1",
                table: "BugIssues",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_BugIssues_AspNetUsers_UserId1",
                table: "BugIssues",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Recommendations_AspNetUsers_UserId1",
                table: "Recommendations",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Developers_DeveloperId",
                table: "Todos",
                column: "DeveloperId",
                principalTable: "Developers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
