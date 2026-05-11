using Microsoft.AspNetCore.Mvc.RazorPages;
using SecureLoginSystem.Data;
using SecureLoginSystem.Models;

namespace SecureLoginSystem.Pages
{
    public class AdminUsersModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public AdminUsersModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<User> Users { get; set; }

        public bool IsAdmin { get; set; }

        public void OnGet()
        {
            string role = HttpContext.Session.GetString("Role");

            if (role == "Admin")
            {
                IsAdmin = true;
                Users = _context.Users.ToList();
            }
            else
            {
                IsAdmin = false;
            }
        }
    }
}