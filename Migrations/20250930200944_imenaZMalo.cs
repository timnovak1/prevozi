using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prevozi.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class imenaZMalo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Carriers_CarrierRegistrationNumber",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Users",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Users",
                newName: "firstName");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Users",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "CarrierRegistrationNumber",
                table: "Users",
                newName: "carrierRegistrationNumber");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Users",
                newName: "userRole");

            migrationBuilder.RenameIndex(
                name: "IX_Users_CarrierRegistrationNumber",
                table: "Users",
                newName: "IX_Users_carrierRegistrationNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Carriers_carrierRegistrationNumber",
                table: "Users",
                column: "carrierRegistrationNumber",
                principalTable: "Carriers",
                principalColumn: "RegistrationNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Carriers_carrierRegistrationNumber",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "Users",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "firstName",
                table: "Users",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "carrierRegistrationNumber",
                table: "Users",
                newName: "CarrierRegistrationNumber");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "userRole",
                table: "Users",
                newName: "Role");

            migrationBuilder.RenameIndex(
                name: "IX_Users_carrierRegistrationNumber",
                table: "Users",
                newName: "IX_Users_CarrierRegistrationNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Carriers_CarrierRegistrationNumber",
                table: "Users",
                column: "CarrierRegistrationNumber",
                principalTable: "Carriers",
                principalColumn: "RegistrationNumber");
        }
    }
}
