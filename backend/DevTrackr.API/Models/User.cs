using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevTrackr.API.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(100)]
        public string UserName { get; set; }

        public string UserEmail { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        // Navigation property for Tasks
        public ICollection<ProjectTask> Tasks { get; set; }

        // Navigation property for ProjectGoals
        public ICollection<ProjectGoal> Goals { get; set; }
    }
}