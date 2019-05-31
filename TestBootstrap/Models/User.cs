using System.ComponentModel.DataAnnotations;


namespace TestBootstrap.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        public string LoginId { get; set; }
        [Required]
        public string Password_Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int Phone { get; set; }

    }
}
