using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class initializeContactApiDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 255, nullable: false),
                    MiddleName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(maxLength: 255, nullable: false),
                    Mobile = table.Column<string>(nullable: false),
                    WorkPhone = table.Column<string>(nullable: true),
                    HomePhone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: true),
                    Modified = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUser", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ContactUser",
                columns: new[] { "Id", "Created", "Email", "FirstName", "HomePhone", "LastName", "MiddleName", "Mobile", "Modified", "WorkPhone" },
                values: new object[] { 1, new DateTime(2019, 6, 13, 9, 18, 56, 265, DateTimeKind.Local).AddTicks(3597), "fred@revature.com", "Fred", null, "Belotte", null, "9876543212", null, null });

            migrationBuilder.InsertData(
                table: "ContactUser",
                columns: new[] { "Id", "Created", "Email", "FirstName", "HomePhone", "LastName", "MiddleName", "Mobile", "Modified", "WorkPhone" },
                values: new object[] { 2, new DateTime(2019, 6, 13, 9, 18, 56, 266, DateTimeKind.Local).AddTicks(6006), "carol.baxtor@revature.com", "Carol", null, "Baxtor", null, "9234567876", null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactUser");
        }
    }
}
