using System.ComponentModel.DataAnnotations;
using FundingApp.Enums;
using Microsoft.AspNetCore.Identity;

namespace FundingApp.Models
{
    public class User : IdentityUser<Guid>
    {
        public User()
        {
            Bio = string.Empty;
            ProfilePictureUrl = string.Empty;
            Projects = new List<Project>();
            Pledges = new List<Pledge>();
            SentMessages = new List<Message>();
            ReceivedMessages = new List<Message>();
        }


        //[Key]
        //public Guid UserID { get; set; } = Guid.NewGuid();

        //[Required]
        //[MaxLength(50)]
        //public string Username { get; set; }

        //[Required]
        //[EmailAddress]
        //[MaxLength(100)]
        //public string Email { get; set; }

        //[Required]
        //public string PasswordHash { get; set; }

        [Required]
        [MaxLength(20)]
        public UserRole Role { get; set; } // Possible values: "backer", "creator", "admin"

        [Url]
        public string ProfilePictureUrl { get; set; }

        [MaxLength(500)]
        public string Bio { get; set; }

        public DateTime DateJoined { get; set; } = DateTime.UtcNow;

        public bool IsActive { get; set; } = true;

        // Navigation properties
        public ICollection<Project> Projects { get; set; }
       
        public ICollection<Pledge> Pledges { get; set; }

        public ICollection<Message> SentMessages { get; set; }

        public ICollection<Message> ReceivedMessages { get; set; }
    }
}
