using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PlannerApp.Shared.Models
{
    public class ToDoItem
    {
        public string Id { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }
        public bool IsDone { get; set; }
        public DateTime? EstimatedDate { get; set; }
        public DateTime? AchievedDate { get; set; }
        public string PlanId { get; set; }
        
        //public DateTime createdDate { get; set; }
        //public DateTime modifiedDate { get; set; }
        //public string userId { get; set; }
        //public bool isDeleted { get; set; }

    }

         
}
