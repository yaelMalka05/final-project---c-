using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace repository.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Volunteers_AreasOfExpertise_PersonalAreasOfExpertiseId",
                table: "Volunteers");

            migrationBuilder.AlterColumn<int>(
                name: "PersonalAreasOfExpertiseId",
                table: "Volunteers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Volunteers_AreasOfExpertise_PersonalAreasOfExpertiseId",
                table: "Volunteers",
                column: "PersonalAreasOfExpertiseId",
                principalTable: "AreasOfExpertise",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Volunteers_AreasOfExpertise_PersonalAreasOfExpertiseId",
                table: "Volunteers");

            migrationBuilder.AlterColumn<int>(
                name: "PersonalAreasOfExpertiseId",
                table: "Volunteers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Volunteers_AreasOfExpertise_PersonalAreasOfExpertiseId",
                table: "Volunteers",
                column: "PersonalAreasOfExpertiseId",
                principalTable: "AreasOfExpertise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
