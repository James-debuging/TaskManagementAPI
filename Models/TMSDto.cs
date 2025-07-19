using System.ComponentModel.DataAnnotations;

namespace TaskManagementAPI.Models
{
    public class TMSDto
    {
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public string Type { get; set; }
    }
}
