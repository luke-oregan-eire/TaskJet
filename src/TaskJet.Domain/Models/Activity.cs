using System;
using System.Collections.Generic;
using System.Text;

namespace TaskJet.Domain.Models
{
    // A task is represented by this Activity class. This class is named Activity to avoid any confusion with the C# Task keyword.
    public class Activity : Entity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DueDate { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }


    }
}
