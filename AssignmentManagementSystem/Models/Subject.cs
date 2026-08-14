using System.Text.Json.Serialization;

namespace AssignmentManagementSystem.Models
{
    public class Subject
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int ClassId { get; set; }

        [JsonIgnore]
        public Class? Class { get; set; }
    }
}