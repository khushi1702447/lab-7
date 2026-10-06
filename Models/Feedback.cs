using System.ComponentModel.DataAnnotations;

namespace StudentFeedbackManagement.Models
{
    public class Feedback
    {
        [Required]
        public string StudentName { get; set; }

        [Required]
        public int Id { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public int Rating { get; set; }

        [Required]
        public string Comments { get; set; }
    }
}