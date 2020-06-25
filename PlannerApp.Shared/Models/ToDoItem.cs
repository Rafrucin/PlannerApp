using System;
using System.Collections.Generic;
using System.Text;

namespace PlannerApp.Shared.Models
{
    public class ToDoItem
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public bool isDone { get; set; }
        public DateTime EstimatedDate { get; set; }
        public DateTime achievedDate { get; set; }
        public string planId { get; set; }
        
        //public DateTime createdDate { get; set; }
        //public DateTime modifiedDate { get; set; }
        //public string userId { get; set; }
        //public bool isDeleted { get; set; }

    }

         
}
