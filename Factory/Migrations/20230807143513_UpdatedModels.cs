using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Factory.Migrations
{
    public partial class UpdatedModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MachineDescription",
                table: "Machines",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "MachineType",
                table: "Machines",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "EngineerDetails",
                table: "Engineers",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "EngineerName",
                table: "Engineers",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "MachineId",
                table: "Engineers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Engineers_MachineId",
                table: "Engineers",
                column: "MachineId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Engineers_Machines_MachineId",
                table: "Engineers",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "MachineId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Engineers_Machines_MachineId",
                table: "Engineers");

            migrationBuilder.DropIndex(
                name: "IX_Engineers_MachineId",
                table: "Engineers");

            migrationBuilder.DropColumn(
                name: "MachineDescription",
                table: "Machines");

            migrationBuilder.DropColumn(
                name: "MachineType",
                table: "Machines");

            migrationBuilder.DropColumn(
                name: "EngineerDetails",
                table: "Engineers");

            migrationBuilder.DropColumn(
                name: "EngineerName",
                table: "Engineers");

            migrationBuilder.DropColumn(
                name: "MachineId",
                table: "Engineers");
        }
    }
}
