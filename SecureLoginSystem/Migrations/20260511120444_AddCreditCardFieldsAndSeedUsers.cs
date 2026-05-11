using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SecureLoginSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddCreditCardFieldsAndSeedUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreditCardNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cvc",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IsraeliId",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ValidDate",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreditCardNumber", "Cvc", "FirstName", "IsraeliId", "LastName", "PasswordHash", "Role", "Username", "ValidDate" },
                values: new object[,]
                {
                    { 1, "1234 5567 8901 2345", "123", "Israeli", "123456789", "Israeili", "A6xnQhbz4Vx2HuGl4lXwZ5U2I8iziLRFnhP5eNfIRvQ=", "Admin", "admin", "12/32" },
                    { 2, "1111 2222 3333 4444", "111", "David", "111222333", "Cohen", "D/4avRoIIVNTwjPW4AlhPpXuxCU4Mqdhryj/N6xaFQw=", "User", "user1", "11/30" },
                    { 3, "2222 3333 4444 5555", "222", "Noa", "222333444", "Levi", "7e4p+IJUO5VmILJtDuDn6VA5mxxCIvXeBeBkJbTJlek=", "User", "user2", "10/31" },
                    { 4, "3333 4444 5555 6666", "333", "Yossi", "333444555", "Mizrahi", "MYruP+2MnQQNNaf8H6d2+zEwODOqLeiFNU3fPUTY+2k=", "User", "user3", "09/29" },
                    { 5, "4444 5555 6666 7777", "444", "Maya", "444555666", "Peretz", "efBvj94zNGFznyIAkKI8sqefbXFL7hANDktK8kkpRhk=", "User", "user4", "08/28" },
                    { 6, "5555 6666 7777 8888", "555", "Omer", "555666777", "Biton", "wfMw0K/zHByHQD8eQ0e8whr/fBeZCHI1NfKzFyNwJSU=", "User", "user5", "07/30" },
                    { 7, "6666 7777 8888 9999", "666", "Dana", "666777888", "Avraham", "12l1cEYvdWK4PoEljeDx5Bgy6YBy5Ew27I7+xGeG4k4=", "User", "user6", "06/31" },
                    { 8, "7777 8888 9999 0000", "777", "Eli", "777888999", "Shalom", "QcmR62pmJCwEVBkSRCeBg85Yz0przTcveZ5LnMAYhq8=", "User", "user7", "05/29" },
                    { 9, "8888 9999 0000 1111", "888", "Roni", "888999000", "Malka", "KSaicx9LMSwImCys+AYesUv2XBqHzF1w6GTgecYiBzE=", "User", "user8", "04/30" },
                    { 10, "9999 0000 1111 2222", "999", "Tamar", "999000111", "Azulai", "iI3yWuNXckJKVgxxUqHeeURA4Opc/uYoKDM6RWpQbgU=", "User", "user9", "03/31" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "CreditCardNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Cvc",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsraeliId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ValidDate",
                table: "Users");
        }
    }
}
