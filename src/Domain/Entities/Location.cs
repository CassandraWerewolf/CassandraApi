﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable enable

namespace Domain.Entities
{
    public partial class Location
    {
        public uint Id { get; set; }
        public uint GameId { get; set; }
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public string? Comment { get; set; }
        public uint? SubgameId { get; set; }
        public uint? RoomId { get; set; }
        public DateTime Created { get; set; }
        public string Lock { get; set; } = default!;
        public string Visibility { get; set; } = default!;
    }
}