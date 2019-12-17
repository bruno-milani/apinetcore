using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class SeedUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "DateOfBird", "Email", "Name", "Password", "UpdateAt" },
                values: new object[] { new Guid("70d29139-6de9-484f-b6d0-082dd70dc9c5"), new DateTime(2019, 12, 16, 22, 31, 17, 427, DateTimeKind.Utc).AddTicks(9022), new DateTime(1996, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@api.com", "AdminAPI", "admin123", new DateTime(2019, 12, 16, 22, 31, 17, 428, DateTimeKind.Utc).AddTicks(294) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("70d29139-6de9-484f-b6d0-082dd70dc9c5"));
        }
    }
}
