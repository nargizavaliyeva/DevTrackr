using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DevTrackr.API.Models;

namespace DevTrackr.API.Configurations
{
    public class TaskConfiguration : IEntityTypeConfiguration<ProjectTask>
    {
        public void Configure(EntityTypeBuilder<ProjectTask> builder)
        {
            builder.HasKey(x => x.TaskId);
            builder.Property(x => x.Title).IsRequired().HasMaxLength(200);

        }
    }
}