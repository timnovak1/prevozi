using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prevozi.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class nova : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Carriers_carrierRegistrationNumber",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clients",
                table: "Clients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carriers",
                table: "Carriers");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "users");

            migrationBuilder.RenameTable(
                name: "Clients",
                newName: "clients");

            migrationBuilder.RenameTable(
                name: "Carriers",
                newName: "carriers");

            migrationBuilder.RenameIndex(
                name: "IX_Users_carrierRegistrationNumber",
                table: "users",
                newName: "IX_users_carrierRegistrationNumber");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "clients",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "clients",
                newName: "fullName");

            migrationBuilder.RenameColumn(
                name: "ContactPhone",
                table: "clients",
                newName: "contactPhone");

            migrationBuilder.RenameColumn(
                name: "ContactPerson",
                table: "clients",
                newName: "contactPerson");

            migrationBuilder.RenameColumn(
                name: "ContactEmail",
                table: "clients",
                newName: "contactEmail");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "clients",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "RegistrationNumber",
                table: "clients",
                newName: "registrationNumber");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "carriers",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "carriers",
                newName: "fullName");

            migrationBuilder.RenameColumn(
                name: "ContactPhone",
                table: "carriers",
                newName: "contactPhone");

            migrationBuilder.RenameColumn(
                name: "ContactPerson",
                table: "carriers",
                newName: "contactPerson");

            migrationBuilder.RenameColumn(
                name: "ContactEmail",
                table: "carriers",
                newName: "contactEmail");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "carriers",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "RegistrationNumber",
                table: "carriers",
                newName: "registrationNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_clients",
                table: "clients",
                column: "registrationNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_carriers",
                table: "carriers",
                column: "registrationNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_users_carriers_carrierRegistrationNumber",
                table: "users",
                column: "carrierRegistrationNumber",
                principalTable: "carriers",
                principalColumn: "registrationNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_carriers_carrierRegistrationNumber",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_clients",
                table: "clients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_carriers",
                table: "carriers");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "clients",
                newName: "Clients");

            migrationBuilder.RenameTable(
                name: "carriers",
                newName: "Carriers");

            migrationBuilder.RenameIndex(
                name: "IX_users_carrierRegistrationNumber",
                table: "Users",
                newName: "IX_Users_carrierRegistrationNumber");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Clients",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "fullName",
                table: "Clients",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "contactPhone",
                table: "Clients",
                newName: "ContactPhone");

            migrationBuilder.RenameColumn(
                name: "contactPerson",
                table: "Clients",
                newName: "ContactPerson");

            migrationBuilder.RenameColumn(
                name: "contactEmail",
                table: "Clients",
                newName: "ContactEmail");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "Clients",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "registrationNumber",
                table: "Clients",
                newName: "RegistrationNumber");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Carriers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "fullName",
                table: "Carriers",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "contactPhone",
                table: "Carriers",
                newName: "ContactPhone");

            migrationBuilder.RenameColumn(
                name: "contactPerson",
                table: "Carriers",
                newName: "ContactPerson");

            migrationBuilder.RenameColumn(
                name: "contactEmail",
                table: "Carriers",
                newName: "ContactEmail");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "Carriers",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "registrationNumber",
                table: "Carriers",
                newName: "RegistrationNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clients",
                table: "Clients",
                column: "RegistrationNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carriers",
                table: "Carriers",
                column: "RegistrationNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Carriers_carrierRegistrationNumber",
                table: "Users",
                column: "carrierRegistrationNumber",
                principalTable: "Carriers",
                principalColumn: "RegistrationNumber");
        }
    }
}
