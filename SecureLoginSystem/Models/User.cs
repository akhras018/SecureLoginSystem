using System.ComponentModel.DataAnnotations;

namespace SecureLoginSystem.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Username is required")]
        
        public string Username { get; set; }

        public string PasswordHash { get; set; }

        [Required(ErrorMessage = "Role is required")]
        [RegularExpression(@"^(Admin|User)$",
            ErrorMessage = "Role must be Admin or User")]
        public string Role { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [RegularExpression(@"^[A-Za-zא-ת]{2,30}$",
            ErrorMessage = "First name must contain only letters and be 2-30 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [RegularExpression(@"^[A-Za-zא-ת]{2,30}$",
            ErrorMessage = "Last name must contain only letters and be 2-30 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Israeli ID is required")]
        [RegularExpression(@"^\d{9}$",
            ErrorMessage = "Israeli ID must contain exactly 9 digits")]
        public string IsraeliId { get; set; }

        [Required(ErrorMessage = "Credit card number is required")]
        [RegularExpression(@"^\d{4}\s\d{4}\s\d{4}\s\d{4}$",
            ErrorMessage = "Credit card number must be in this format: 1234 5567 8901 2345")]
        public string CreditCardNumber { get; set; }

        [Required(ErrorMessage = "Valid date is required")]
        [RegularExpression(@"^(0[1-9]|1[0-2])\/\d{2}$",
            ErrorMessage = "Valid date must be in MM/YY format")]
        public string ValidDate { get; set; }

        [Required(ErrorMessage = "CVC is required")]
        [RegularExpression(@"^\d{3}$",
            ErrorMessage = "CVC must contain exactly 3 digits")]
        public string Cvc { get; set; }
    }
}