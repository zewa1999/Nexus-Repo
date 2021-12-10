using Microsoft.EntityFrameworkCore.Migrations;

namespace NexusBenefits.DataLayer.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Benefits",
                table: "Benefits");

            migrationBuilder.RenameTable(
                name: "Benefits",
                newName: "Benefit");

            migrationBuilder.AddColumn<int>(
                name: "BenefitId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Benefit",
                table: "Benefit",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_User_BenefitId",
                table: "User",
                column: "BenefitId");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId",
                table: "User",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Benefit_BenefitId",
                table: "User",
                column: "BenefitId",
                principalTable: "Benefit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Role_RoleId",
                table: "User",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Benefit_BenefitId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Role_RoleId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_BenefitId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_RoleId",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Benefit",
                table: "Benefit");

            migrationBuilder.DropColumn(
                name: "BenefitId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "User");

            migrationBuilder.RenameTable(
                name: "Benefit",
                newName: "Benefits");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Benefits",
                table: "Benefits",
                column: "Id");
        }
    }
}
