﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable enable

namespace Domain.Entities
{
    public partial class Post
    {
        public int ArticleId { get; set; }
        public uint GameId { get; set; }
        public uint UserId { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Text { get; set; } = default!;
        public int Page { get; set; }
        public int NumEdits { get; set; }
    }
}