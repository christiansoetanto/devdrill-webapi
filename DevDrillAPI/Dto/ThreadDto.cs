﻿using System;
using System.Collections.Generic;

namespace DevDrillAPI.Dto
{
    public class ThreadDto

    {
        public int ThreadId { get; set; }
        public DateTime InsertDate { get; set; }
        public string Topic { get; set; }
        public int Upvote { get; set; }
        public int ReplyCount { get; set; }
        public UserDto User { get; set; }
        public int DiscussionId { get; set; }
        public string Detail { get; set; }
        
    }

   
}