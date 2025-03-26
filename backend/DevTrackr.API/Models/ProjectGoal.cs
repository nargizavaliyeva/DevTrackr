using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevTrackr.API.Models
{
    public class ProjectGoal
    {
        [Key]
        public int GoalId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime TargetDate { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}