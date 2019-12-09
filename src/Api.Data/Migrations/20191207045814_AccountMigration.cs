using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AccountMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AccountId",
                table: "User",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AccountEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    AccountName = table.Column<string>(nullable: true),
                    AccountNumber = table.Column<string>(nullable: true),
                    ValueBalance = table.Column<double>(nullable: false),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountEntity", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_AccountId",
                table: "User",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_AccountEntity_AccountId",
                table: "User",
                column: "AccountId",
                principalTable: "AccountEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_AccountEntity_AccountId",
                table: "User");

            migrationBuilder.DropTable(
                name: "AccountEntity");

            migrationBuilder.DropIndex(
                name: "IX_User_AccountId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "User");
        }
    }
}
