using System.ComponentModel.DataAnnotations;

namespace PlannerApp.Shared.Models
{
    public class ToDoItemRequest
    {
        public string Id { get; set; }

        [Required]
        [MaxLength (200)]
        public string Description { get; set; }
        
        public string PlanId { get; set; }
    }

         
}
