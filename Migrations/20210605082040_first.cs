using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CommonEmployeeAPI.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "varchar(50)", nullable: true),
                    FullName = table.Column<string>(type: "varchar(150)", nullable: true),
                    Password = table.Column<string>(type: "varchar(150)", nullable: true),
                    EmailId = table.Column<string>(type: "varchar(75)", nullable: true),
                    Gender = table.Column<string>(type: "char(1)", nullable: true),
                    Location = table.Column<string>(type: "varchar(100)", nullable: true),
                    Remarks = table.Column<string>(type: "varchar(512)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "Datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
