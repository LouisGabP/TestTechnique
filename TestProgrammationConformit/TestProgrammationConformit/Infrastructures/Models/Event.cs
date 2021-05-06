using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TestProgrammationConformit.Infrastructures.Models
{
    public class Event
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        public string Description { get; set; }
        public string PersonName { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
