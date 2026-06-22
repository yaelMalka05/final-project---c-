using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace repository.Migrations
{
    /// <inheritdoc />
    public partial class four : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PossibleTasks_Feedback_TaskFeedbackId",
                table: "PossibleTasks");

            migrationBuilder.AlterColumn<int>(
                name: "TaskFeedbackId",
                table: "PossibleTasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PossibleTasks_Feedback_TaskFeedbackId",
                table: "PossibleTasks",
                column: "TaskFeedbackId",
                principalTable: "Feedback",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PossibleTasks_Feedback_TaskFeedbackId",
                table: "PossibleTasks");

            migrationBuilder.AlterColumn<int>(
                name: "TaskFeedbackId",
                table: "PossibleTasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_PossibleTasks_Feedback_TaskFeedbackId",
                table: "PossibleTasks",
                column: "TaskFeedbackId",
                principalTable: "Feedback",
                principalColumn: "Id");
        }
    }
}
