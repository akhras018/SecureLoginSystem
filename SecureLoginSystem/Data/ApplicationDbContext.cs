using Microsoft.EntityFrameworkCore;
using SecureLoginSystem.Models;
using System;
using System.Security.Cryptography;
using System.Text;

namespace SecureLoginSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(

                // ADMIN
                new User
                {
                    Id = 1,
                    Username = "admin",
                    PasswordHash = HashPassword("1234"),
                    Role = "Admin",
                    FirstName = "Israeli",
                    LastName = "Israeili",
                    IsraeliId = "123456789",
                    CreditCardNumber = "1234 5567 8901 2345",
                    ValidDate = "12/32",
                    Cvc = "123"
                },

                // USERS
                new User
                {
                    Id = 2,
                    Username = "user1",
                    PasswordHash = HashPassword("1111"),
                    Role = "User",
                    FirstName = "David",
                    LastName = "Cohen",
                    IsraeliId = "111222333",
                    CreditCardNumber = "1111 2222 3333 4444",
                    ValidDate = "11/30",
                    Cvc = "111"
                },

                new User
                {
                    Id = 3,
                    Username = "user2",
                    PasswordHash = HashPassword("2222"),
                    Role = "User",
                    FirstName = "Noa",
                    LastName = "Levi",
                    IsraeliId = "222333444",
                    CreditCardNumber = "2222 3333 4444 5555",
                    ValidDate = "10/31",
                    Cvc = "222"
                },

                new User
                {
                    Id = 4,
                    Username = "user3",
                    PasswordHash = HashPassword("3333"),
                    Role = "User",
                    FirstName = "Yossi",
                    LastName = "Mizrahi",
                    IsraeliId = "333444555",
                    CreditCardNumber = "3333 4444 5555 6666",
                    ValidDate = "09/29",
                    Cvc = "333"
                },

                new User
                {
                    Id = 5,
                    Username = "user4",
                    PasswordHash = HashPassword("4444"),
                    Role = "User",
                    FirstName = "Maya",
                    LastName = "Peretz",
                    IsraeliId = "444555666",
                    CreditCardNumber = "4444 5555 6666 7777",
                    ValidDate = "08/28",
                    Cvc = "444"
                },

                new User
                {
                    Id = 6,
                    Username = "user5",
                    PasswordHash = HashPassword("5555"),
                    Role = "User",
                    FirstName = "Omer",
                    LastName = "Biton",
                    IsraeliId = "555666777",
                    CreditCardNumber = "5555 6666 7777 8888",
                    ValidDate = "07/30",
                    Cvc = "555"
                },

                new User
                {
                    Id = 7,
                    Username = "user6",
                    PasswordHash = HashPassword("6666"),
                    Role = "User",
                    FirstName = "Dana",
                    LastName = "Avraham",
                    IsraeliId = "666777888",
                    CreditCardNumber = "6666 7777 8888 9999",
                    ValidDate = "06/31",
                    Cvc = "666"
                },

                new User
                {
                    Id = 8,
                    Username = "user7",
                    PasswordHash = HashPassword("7777"),
                    Role = "User",
                    FirstName = "Eli",
                    LastName = "Shalom",
                    IsraeliId = "777888999",
                    CreditCardNumber = "7777 8888 9999 0000",
                    ValidDate = "05/29",
                    Cvc = "777"
                },

                new User
                {
                    Id = 9,
                    Username = "user8",
                    PasswordHash = HashPassword("8888"),
                    Role = "User",
                    FirstName = "Roni",
                    LastName = "Malka",
                    IsraeliId = "888999000",
                    CreditCardNumber = "8888 9999 0000 1111",
                    ValidDate = "04/30",
                    Cvc = "888"
                },

                new User
                {
                    Id = 10,
                    Username = "user9",
                    PasswordHash = HashPassword("9999"),
                    Role = "User",
                    FirstName = "Tamar",
                    LastName = "Azulai",
                    IsraeliId = "999000111",
                    CreditCardNumber = "9999 0000 1111 2222",
                    ValidDate = "03/31",
                    Cvc = "999"
                }
            );
        }

        private static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }
    }
}