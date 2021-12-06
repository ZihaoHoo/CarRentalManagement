using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddApplicationTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "317ee998-8613-40f7-9af5-bd44218a854e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "29308cbc-a0a9-4eb0-ad80-6ca3c4587ee9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "272ffb7f-e0fc-45e1-8527-596e81175d96", "AQAAAAEAACcQAAAAEDDqMMLTrja5ZoeuF3P0jkX11YryGJnQEROGxaflzl23jcU+6yI7DZvup3Ui/XQL6w==", "8c391ac2-7dd3-4048-85d9-8f5e5d5cbb0b" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 29, 23, 44, 29, 114, DateTimeKind.Local).AddTicks(4122), new DateTime(2021, 11, 29, 23, 44, 29, 116, DateTimeKind.Local).AddTicks(92) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 29, 23, 44, 29, 116, DateTimeKind.Local).AddTicks(1009), new DateTime(2021, 11, 29, 23, 44, 29, 116, DateTimeKind.Local).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 29, 23, 44, 29, 117, DateTimeKind.Local).AddTicks(1430), new DateTime(2021, 11, 29, 23, 44, 29, 117, DateTimeKind.Local).AddTicks(1438) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 29, 23, 44, 29, 117, DateTimeKind.Local).AddTicks(1441), new DateTime(2021, 11, 29, 23, 44, 29, 117, DateTimeKind.Local).AddTicks(1442) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 29, 23, 44, 29, 117, DateTimeKind.Local).AddTicks(4506), new DateTime(2021, 11, 29, 23, 44, 29, 117, DateTimeKind.Local).AddTicks(4511) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 29, 23, 44, 29, 117, DateTimeKind.Local).AddTicks(4514), new DateTime(2021, 11, 29, 23, 44, 29, 117, DateTimeKind.Local).AddTicks(4515) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 29, 23, 44, 29, 117, DateTimeKind.Local).AddTicks(4516), new DateTime(2021, 11, 29, 23, 44, 29, 117, DateTimeKind.Local).AddTicks(4517) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 29, 23, 44, 29, 117, DateTimeKind.Local).AddTicks(4518), new DateTime(2021, 11, 29, 23, 44, 29, 117, DateTimeKind.Local).AddTicks(4519) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "e10a8c4c-022f-404f-80ce-182809a119d0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "931c8fd2-5924-4262-bc57-b04689d0d35f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e229ddc-e500-48c2-b679-0bdae25db8f7", "AQAAAAEAACcQAAAAEHRzLLdwbw+tnZjTzTUIb9UhJw4VGWLVcRxaG8PXps1g+7F1Mq78jlXjK3GSOa0Xlg==", "d2bc3758-0f11-4e5f-bfee-51ef473f31fb" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 10, 48, 56, 681, DateTimeKind.Local).AddTicks(6930), new DateTime(2021, 11, 23, 10, 48, 56, 683, DateTimeKind.Local).AddTicks(5489) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 10, 48, 56, 683, DateTimeKind.Local).AddTicks(6458), new DateTime(2021, 11, 23, 10, 48, 56, 683, DateTimeKind.Local).AddTicks(6463) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 10, 48, 56, 684, DateTimeKind.Local).AddTicks(7864), new DateTime(2021, 11, 23, 10, 48, 56, 684, DateTimeKind.Local).AddTicks(7871) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 10, 48, 56, 684, DateTimeKind.Local).AddTicks(7875), new DateTime(2021, 11, 23, 10, 48, 56, 684, DateTimeKind.Local).AddTicks(7876) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 10, 48, 56, 685, DateTimeKind.Local).AddTicks(1490), new DateTime(2021, 11, 23, 10, 48, 56, 685, DateTimeKind.Local).AddTicks(1496) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 10, 48, 56, 685, DateTimeKind.Local).AddTicks(1499), new DateTime(2021, 11, 23, 10, 48, 56, 685, DateTimeKind.Local).AddTicks(1500) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 10, 48, 56, 685, DateTimeKind.Local).AddTicks(1502), new DateTime(2021, 11, 23, 10, 48, 56, 685, DateTimeKind.Local).AddTicks(1503) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 10, 48, 56, 685, DateTimeKind.Local).AddTicks(1504), new DateTime(2021, 11, 23, 10, 48, 56, 685, DateTimeKind.Local).AddTicks(1505) });
        }
    }
}
