using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectManager.Migrations
{
    public partial class Initial21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8a380884-b6a5-410f-a203-b6bc8c800720", 0, "55fd3dee-bab1-48b3-89db-0243a710af57", "admin@gmail.com", true, "admin", "1", true, null, "admin@GMAIL.COM", "admin@GMAIL.COM", "AQAAAAEAACcQAAAAEFhhunzOMEkTPwnYPadFmUidgnf3bJwf26H3K2s/bya/pr2nN4dnuhUx/WPtc4b9Ag==", null, false, "440e41d9-ee78-480c-aa3f-2d6e8fad8927", false, "admin@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a380884-b6a5-410f-a203-b6bc8c800720");
        }
    }
}
