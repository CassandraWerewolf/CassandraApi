﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable enable

namespace Domain.Entities
{
    public partial class SocialUser
    {
        public ushort SiteId { get; set; }
        public ushort UserId { get; set; }
        public string UserInfo { get; set; } = default!;
    }
}