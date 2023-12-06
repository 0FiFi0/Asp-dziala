using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class next : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3af4a2cd-a2c3-4d06-838d-96d02a69cdb9", "c3c8001b-aab7-4e8b-b59d-00a00bbd6abf" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3af4a2cd-a2c3-4d06-838d-96d02a69cdb9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3c8001b-aab7-4e8b-b59d-00a00bbd6abf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "00bbfd15-5853-4483-b00f-88b410f9e864", "00bbfd15-5853-4483-b00f-88b410f9e864", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6bd77c3a-d2f5-4359-95fe-d5bbf2f25452", 0, "7735c26d-aa90-4d21-9d3e-100d4a6a7376", "adamo@micros.com", true, false, null, "ADAMO@MICROS.COM", null, "AQAAAAEAACcQAAAAEMwzeItKhh7MT/HeaYmRnPzoRAgOjgd0eJOnlmVxcRBMLixnp4b2pgmyRnpjnUxANQ==", null, false, "58635eec-63e8-40fe-9655-e2cd91c36a2d", false, "adamo" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "00bbfd15-5853-4483-b00f-88b410f9e864", "6bd77c3a-d2f5-4359-95fe-d5bbf2f25452" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "00bbfd15-5853-4483-b00f-88b410f9e864", "6bd77c3a-d2f5-4359-95fe-d5bbf2f25452" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00bbfd15-5853-4483-b00f-88b410f9e864");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bd77c3a-d2f5-4359-95fe-d5bbf2f25452");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3af4a2cd-a2c3-4d06-838d-96d02a69cdb9", "3af4a2cd-a2c3-4d06-838d-96d02a69cdb9", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c3c8001b-aab7-4e8b-b59d-00a00bbd6abf", 0, "4e15c9a4-22d8-4837-b6f5-72a3a38babb2", "adamo@micros.com", true, false, null, null, null, "AQAAAAEAACcQAAAAEEIUDjzOfzCABlihYr/TZDw3UGJHZszy/1k0D26CQ/F2HTdzjfxb4B/A0Ry9C81V2A==", null, false, "edb67800-ede4-4f77-bc86-5196403a01ce", false, "adamo" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3af4a2cd-a2c3-4d06-838d-96d02a69cdb9", "c3c8001b-aab7-4e8b-b59d-00a00bbd6abf" });
        }
    }
}
