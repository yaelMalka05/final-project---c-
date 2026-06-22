using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace repository.Migrations
{
    /// <inheritdoc />
    public partial class five : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PossibleTasks_AreasOfExpertise_TaskTypeId",
                table: "PossibleTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_PossibleTasks_Feedback_TaskFeedbackId",
                table: "PossibleTasks");

            migrationBuilder.DropIndex(
                name: "IX_PossibleTasks_TaskTypeId",
                table: "PossibleTasks");

            migrationBuilder.DropColumn(
                name: "TaskTypeId",
                table: "PossibleTasks");

            migrationBuilder.AlterColumn<int>(
                name: "Urgency",
                table: "PossibleTasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TaskFeedbackId",
                table: "PossibleTasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "PossibleTasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "PossibleTasks",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "TaskTypeIdId",
                table: "PossibleTasks",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Star",
                table: "Feedback",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CompletionReportingTime",
                table: "Assignments",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateIndex(
                name: "IX_PossibleTasks_TaskTypeIdId",
                table: "PossibleTasks",
                column: "TaskTypeIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_PossibleTasks_AreasOfExpertise_TaskTypeIdId",
                table: "PossibleTasks",
                column: "TaskTypeIdId",
                principalTable: "AreasOfExpertise",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PossibleTasks_Feedback_TaskFeedbackId",
                table: "PossibleTasks",
                column: "TaskFeedbackId",
                principalTable: "Feedback",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PossibleTasks_AreasOfExpertise_TaskTypeIdId",
                table: "PossibleTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_PossibleTasks_Feedback_TaskFeedbackId",
                table: "PossibleTasks");

            migrationBuilder.DropIndex(
                name: "IX_PossibleTasks_TaskTypeIdId",
                table: "PossibleTasks");

            migrationBuilder.DropColumn(
                name: "TaskTypeIdId",
                table: "PossibleTasks");

            migrationBuilder.AlterColumn<int>(
                name: "Urgency",
                table: "PossibleTasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TaskFeedbackId",
                table: "PossibleTasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "PossibleTasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "PossibleTasks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaskTypeId",
                table: "PossibleTasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Star",
                table: "Feedback",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CompletionReportingTime",
                table: "Assignments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PossibleTasks_TaskTypeId",
                table: "PossibleTasks",
                column: "TaskTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PossibleTasks_AreasOfExpertise_TaskTypeId",
                table: "PossibleTasks",
                column: "TaskTypeId",
                principalTable: "AreasOfExpertise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PossibleTasks_Feedback_TaskFeedbackId",
                table: "PossibleTasks",
                column: "TaskFeedbackId",
                principalTable: "Feedback",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
