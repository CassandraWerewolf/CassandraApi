// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable enable

namespace Domain.Entities
{
    public partial class ItemOrder
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public uint GameId { get; set; }
        public uint ItemId { get; set; }
        public uint TargetId { get; set; }
        public string TargetType { get; set; } = default!;
        public string Status { get; set; } = default!;
        public DateTime LastUpdated { get; set; }
    }
}