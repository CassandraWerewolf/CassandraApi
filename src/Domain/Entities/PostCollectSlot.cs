﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable enable

namespace Domain.Entities
{
    public partial class PostCollectSlot
    {
        public long Id { get; set; }
        public uint? GameId { get; set; }
        public byte Minute { get; set; }
        public sbyte RunOrder { get; set; }
        public DateTime? LastDumped { get; set; }
    }
}