﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable enable

namespace Domain.Entities
{
    public partial class ChatMessage
    {
        public uint Id { get; set; }
        public int RoomId { get; set; }
        public int UserId { get; set; }
        public string Message { get; set; } = default!;
        public DateTime PostTime { get; set; }
    }
}