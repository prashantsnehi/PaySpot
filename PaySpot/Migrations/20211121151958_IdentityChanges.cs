using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PaySpot.Migrations
{
    public partial class IdentityChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c3270a9-afec-4ac9-9d01-d53898d09adb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57673071-5a5c-421c-95b1-1d4b59c53fe6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8a815c1-8cd0-47d3-a99d-63167d9df0c6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7e9a928-a956-40b1-9d56-29d041313c73");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f841bb90-757c-4b9c-89a4-38973d38a558");

            migrationBuilder.RenameColumn(
                name: "KycType",
                table: "KycInfo",
                newName: "DocumentType");

            migrationBuilder.RenameColumn(
                name: "KycImage",
                table: "KycInfo",
                newName: "DocumentImage");

            migrationBuilder.AddColumn<string>(
                name: "Latitude",
                table: "WorkInfo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Longitude",
                table: "WorkInfo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResidenceType",
                table: "ResidenceAddressInfo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocumentNumber",
                table: "KycInfo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ProfileImage",
                table: "AspNetUsers",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "fe03d62e-ff42-4a81-90c4-fde49c63711c", "b04529d9-4ef4-4a17-9894-6f9ba80c92f6", "Agent", "AGENT" },
                    { "b2cce697-5096-4726-a679-c671ba4133a1", "2e7ab931-9b98-43ce-bd39-3cb3805ba1a9", "User", "USER" },
                    { "05e100a0-ef8c-4928-b793-4b95b6686ee2", "3ca54494-656a-4aad-a9a5-7090b35b0efd", "Sales", "SALES" },
                    { "f7f385be-0407-4912-8cef-de7d6dd3a3c9", "23e7a9b2-e2f2-4b22-9909-e43fb349ff2b", "Distributor", "DISTRIBUTOR" },
                    { "8a6d3004-099f-4b01-b869-126b5606bd31", "a7b99a35-65cd-420b-899b-0bc6f8da57b6", "SuperDistributor", "SUPERDISTRIBUTOR" },
                    { "65eb6af2-e7d7-40cf-a701-f0c72cbf60f7", "a17c866e-2051-43ea-8888-603b0b396cc2", "Admin", "ADMIN" },
                    { "9686828a-85f6-4b93-805d-1cadb5c7c92a", "f5d59975-1296-4ab1-b4b8-243ebeae8867", "SuperAdmin", "SUPERADMIN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05e100a0-ef8c-4928-b793-4b95b6686ee2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65eb6af2-e7d7-40cf-a701-f0c72cbf60f7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a6d3004-099f-4b01-b869-126b5606bd31");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9686828a-85f6-4b93-805d-1cadb5c7c92a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2cce697-5096-4726-a679-c671ba4133a1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7f385be-0407-4912-8cef-de7d6dd3a3c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe03d62e-ff42-4a81-90c4-fde49c63711c");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "WorkInfo");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "WorkInfo");

            migrationBuilder.DropColumn(
                name: "ResidenceType",
                table: "ResidenceAddressInfo");

            migrationBuilder.DropColumn(
                name: "DocumentNumber",
                table: "KycInfo");

            migrationBuilder.DropColumn(
                name: "ProfileImage",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "DocumentType",
                table: "KycInfo",
                newName: "KycType");

            migrationBuilder.RenameColumn(
                name: "DocumentImage",
                table: "KycInfo",
                newName: "KycImage");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c8a815c1-8cd0-47d3-a99d-63167d9df0c6", "d8fa6c3b-5c7a-4f74-aeeb-c67d7772b96d", "User", "USER" },
                    { "f7e9a928-a956-40b1-9d56-29d041313c73", "c3a027b3-9ed0-4ab2-b9a2-0f0684609bc5", "Distributor", "DISTRIBUTOR" },
                    { "f841bb90-757c-4b9c-89a4-38973d38a558", "fc5525dc-8e9c-4ca3-8893-4ce4ecf72aad", "SuperDistributor", "SUPERDISTRIBUTOR" },
                    { "3c3270a9-afec-4ac9-9d01-d53898d09adb", "e9c29f1f-c6a0-43c5-b518-b8f7819295a5", "Admin", "ADMIN" },
                    { "57673071-5a5c-421c-95b1-1d4b59c53fe6", "2e6a8479-6898-4583-a563-e976a835d644", "SuperAdmin", "SUPERADMIN" }
                });
        }
    }
}
