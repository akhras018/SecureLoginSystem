using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace SecureLoginSystem.Pages
{
    public class VulnerableLoginModel : PageModel
    {
        private readonly IConfiguration _configuration;

        public VulnerableLoginModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string Message { get; set; }
        public string QueryUsed { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            string hashedPassword = HashPassword(Password);

            string connectionString = _configuration.GetConnectionString("DefaultConnection");

            string query =$"SELECT * FROM Users WHERE Username ='{Username}' AND PasswordHash ='{hashedPassword}'";

            QueryUsed = query;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string role = reader["Role"].ToString();
                    string username = reader["Username"].ToString();

                    HttpContext.Session.SetString("Username", username);
                    HttpContext.Session.SetString("Role", role);

                    if (role == "Admin")
                    {
                        return RedirectToPage("/AdminUsers");
                    }

                    Message = "Login successful. Welcome User.";
                }
                else
                {
                    Message = "Invalid username or password.";
                }
            }

            return Page();
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password ?? ""));
                return Convert.ToBase64String(bytes);
            }
        }
    }
}