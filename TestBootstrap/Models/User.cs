using System.ComponentModel.DataAnnotations;


namespace DiaryAppOlga.Models
{
    public class User
    {
        public string UserId { get; set; }
        [Required]
        public string LoginId { get; set; }
        [Required]
        public string Password_Id { get; set; }

        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        public int Age { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        ////[Required]
        [Phone]
        public int Phone { get; set; }

    }
}
