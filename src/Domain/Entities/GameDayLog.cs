// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable enable

namespace Domain.Entities
{
    public partial class GameDayLog
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public string Phase { get; set; } = default!;
        public int Day { get; set; }
        public DateTime ChangeTime { get; set; }
    }
}