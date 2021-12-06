using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "e10a8c4c-022f-404f-80ce-182809a119d0", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "931c8fd2-5924-4262-bc57-b04689d0d35f", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "2e229ddc-e500-48c2-b679-0bdae25db8f7", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEHRzLLdwbw+tnZjTzTUIb9UhJw4VGWLVcRxaG8PXps1g+7F1Mq78jlXjK3GSOa0Xlg==", null, false, "d2bc3758-0f11-4e5f-bfee-51ef473f31fb", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 23, 10, 48, 56, 681, DateTimeKind.Local).AddTicks(6930), new DateTime(2021, 11, 23, 10, 48, 56, 683, DateTimeKind.Local).AddTicks(5489), "Black", "System" },
                    { 2, "System", new DateTime(2021, 11, 23, 10, 48, 56, 683, DateTimeKind.Local).AddTicks(6458), new DateTime(2021, 11, 23, 10, 48, 56, 683, DateTimeKind.Local).AddTicks(6463), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 23, 10, 48, 56, 684, DateTimeKind.Local).AddTicks(7864), new DateTime(2021, 11, 23, 10, 48, 56, 684, DateTimeKind.Local).AddTicks(7871), "BMW", "System" },
                    { 2, "System", new DateTime(2021, 11, 23, 10, 48, 56, 684, DateTimeKind.Local).AddTicks(7875), new DateTime(2021, 11, 23, 10, 48, 56, 684, DateTimeKind.Local).AddTicks(7876), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 23, 10, 48, 56, 685, DateTimeKind.Local).AddTicks(1490), new DateTime(2021, 11, 23, 10, 48, 56, 685, DateTimeKind.Local).AddTicks(1496), "3 Series", "System" },
                    { 2, "System", new DateTime(2021, 11, 23, 10, 48, 56, 685, DateTimeKind.Local).AddTicks(1499), new DateTime(2021, 11, 23, 10, 48, 56, 685, DateTimeKind.Local).AddTicks(1500), "X5", "System" },
                    { 3, "System", new DateTime(2021, 11, 23, 10, 48, 56, 685, DateTimeKind.Local).AddTicks(1502), new DateTime(2021, 11, 23, 10, 48, 56, 685, DateTimeKind.Local).AddTicks(1503), "Prius", "System" },
                    { 4, "System", new DateTime(2021, 11, 23, 10, 48, 56, 685, DateTimeKind.Local).AddTicks(1504), new DateTime(2021, 11, 23, 10, 48, 56, 685, DateTimeKind.Local).AddTicks(1505), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
