using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FundingApp.Models
{
    public class Message
    {
        [Key]
        public Guid MessageID { get; set; } = Guid.NewGuid();

        [Required]
        public Guid SenderID { get; set; }

        [ForeignKey("SenderID")]
        public User Sender { get; set; }

        [Required]
        public Guid ReceiverID { get; set; }

        [ForeignKey("ReceiverID")]
        public User Receiver { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime SentDate { get; set; } = DateTime.UtcNow;

        public bool IsRead { get; set; } = false;
    }
}
