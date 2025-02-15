using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AplikacePojisteniBlazor.Migrations
{
    /// <inheritdoc />
    public partial class ClientData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Insurances_ClientsData_ClientDataId",
                table: "Insurances");

            migrationBuilder.DropForeignKey(
                name: "FK_Insurances_ClientsData_ClientId",
                table: "Insurances");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClientsData",
                table: "ClientsData");

            migrationBuilder.RenameTable(
                name: "ClientsData",
                newName: "ClientDatas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClientDatas",
                table: "ClientDatas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Insurances_ClientDatas_ClientDataId",
                table: "Insurances",
                column: "ClientDataId",
                principalTable: "ClientDatas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Insurances_ClientDatas_ClientId",
                table: "Insurances",
                column: "ClientId",
                principalTable: "ClientDatas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Insurances_ClientDatas_ClientDataId",
                table: "Insurances");

            migrationBuilder.DropForeignKey(
                name: "FK_Insurances_ClientDatas_ClientId",
                table: "Insurances");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClientDatas",
                table: "ClientDatas");

            migrationBuilder.RenameTable(
                name: "ClientDatas",
                newName: "ClientsData");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClientsData",
                table: "ClientsData",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Insurances_ClientsData_ClientDataId",
                table: "Insurances",
                column: "ClientDataId",
                principalTable: "ClientsData",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Insurances_ClientsData_ClientId",
                table: "Insurances",
                column: "ClientId",
                principalTable: "ClientsData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
