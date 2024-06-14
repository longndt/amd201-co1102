using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace web.Data.Migrations
{
    /// <inheritdoc />
    public partial class Forth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "role1", null, "Administrator", "ADMINISTRATOR" },
                    { "role2", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "user1", 0, "9126771a-c463-47fe-ba29-376ca2ed2a89", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEOxeC5NGGWGwkEpV5Acf3U54AfW7qNIbhiQ5QA4qTEUkag8s1YvAgY9nnku33dRCdg==", null, false, "f39ae276-a9fb-4eea-953b-662891e19299", false, "admin@gmail.com" },
                    { "user2", 0, "2d203d71-478e-43ba-8226-cd2a92e4f3fe", "user@gmail.com", true, false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAIAAYagAAAAEP/y7FVK7g+TO4+sczAwgct+1zJKyYBD1W5AOWWTlxzZpemhWHxVPa+/wU+i0+HWYQ==", null, false, "505efe80-2f8b-45af-aa83-715528e648f5", false, "user@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Laptop",
                columns: new[] { "Id", "Brand", "Color", "Image", "Model", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, "Apple", "Grey", "https://bizweb.dktcdn.net/100/444/581/products/macbook-m1-vs-intel-1536x1268-6c00654d-ad87-4caf-8b88-aa6c34048199.png?v=1656134590567", "Macbook Pro M2", 2345m, 10 },
                    { 2, "Dell", "Black", "https://thegioiso365.vn/wp-content/uploads/2023/04/Dell-xps-9530-3.png", "XPS15", 1999m, 15 },
                    { 3, "LG", "White", "https://product.hstatic.net/1000333506/product/pc-gram-17z90q-b-gallery-02_dd780c6249ec430b84f82ed466fffd6e.jpg", "Gram 17", 2024m, 22 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "role1", "user1" },
                    { "role2", "user2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "role1", "user1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "role2", "user2" });

            migrationBuilder.DeleteData(
                table: "Laptop",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Laptop",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Laptop",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "role1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "role2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2");
        }
    }
}
