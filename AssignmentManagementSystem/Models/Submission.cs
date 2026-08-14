namespace AssignmentManagementSystem.Models
{
    public class Submission
    {
        public int Id { get; set; }

        public string Answer { get; set; } = string.Empty;

        public DateTime SubmittedAt { get; set; }

        public string Status { get; set; } = "Submitted";

        public int? Marks { get; set; }

        public string? Feedback { get; set; }

        public int AssignmentId { get; set; }

        public Assignment? Assignment { get; set; } = null!;

        public int StudentId { get; set; }

        public User? Student { get; set; } = null!;
    }
}