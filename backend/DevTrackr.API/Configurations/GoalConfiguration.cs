using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevTrackr.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevTrackr.API.Configurations
{
    public class GoalConfiguration : IEntityTypeConfiguration<ProjectGoal>
    {
        public void Configure(EntityTypeBuilder<ProjectGoal> builder)
        {
            builder.HasKey(x => x.GoalId);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
        }
    }
}