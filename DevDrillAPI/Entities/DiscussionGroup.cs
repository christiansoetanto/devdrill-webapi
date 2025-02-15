﻿using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevDrillAPI.Entities
{
    public class DiscussionGroup

    {
        public int DiscussionGroupId { get; set; }
        public string Name { get; set; }
        public string PhotoUrl { get; set; }

        public List<Discussion> Discussions { get; set; }
    }

    public class DiscussionGroupModelBuilder : IEntityTypeConfiguration<DiscussionGroup>
    {
        public void Configure(EntityTypeBuilder<DiscussionGroup> entity)
        {
            entity.HasKey(e => e.DiscussionGroupId);
            entity.HasData(
                new
                {
                    DiscussionGroupId = 1,
                    Name = "Public Discussion",
                    PhotoUrl = ""
                }, 
                new
                {
                    DiscussionGroupId = 2,
                    Name = "Angular Discussion",
                    PhotoUrl = "angular.png"
                },
                new
                {
                    DiscussionGroupId = 3,
                    Name = "Node.js Discussion",
                    PhotoUrl = "nodejs.png"
                },
                new
                {
                    DiscussionGroupId = 4,
                    Name = "ASP.NET Core Discussion",
                    PhotoUrl = "netcore.png"
                },
                new
                {
                    DiscussionGroupId = 5,
                    Name = "Laravel discussion",
                    PhotoUrl = "angular.png"
                },
                new
                {
                    DiscussionGroupId = 6,
                    Name = "React.js discussion",
                    PhotoUrl = "react.png"
                },
                new
                {
                    DiscussionGroupId = 7,
                    Name = "Vue.js discussion",
                    PhotoUrl = "vuejs.png"
                },
                new
                {
                    DiscussionGroupId = 8,
                    Name = "Django discussion",
                    PhotoUrl = "django.png"
                },
                new
                {
                    DiscussionGroupId = 9,
                    Name = "Spring discussion",
                    PhotoUrl = "spring.png"
                }
            );
        }
    }
}