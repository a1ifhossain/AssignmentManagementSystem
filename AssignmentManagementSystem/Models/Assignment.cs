using System.Text.Json.Serialization;

namespace AssignmentManagementSystem.Models
{
    public class Assignment
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public DateTime Deadline { get; set; }

        public int MaxMarks { get; set; }

        public string Status { get; set; } = string.Empty;

        public int TeacherId { get; set; }

        [JsonIgnore]
        public User? Teacher { get; set; }

        public int ClassId { get; set; }

        [JsonIgnore]
        public Class? Class { get; set; }

        public int SubjectId { get; set; }

        [JsonIgnore]
        public Subject? Subject { get; set; }
    }
}