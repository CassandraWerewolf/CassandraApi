﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable enable

namespace Domain.Entities
{
    public partial class MoveOrder
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public uint GameId { get; set; }
        public uint ExitId { get; set; }
        public string Status { get; set; } = default!;
        public DateTime LastUpdated { get; set; }
    }
}