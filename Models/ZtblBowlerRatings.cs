﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Assignment_10_Josiah_Sarles.Models
{
    public partial class ZtblBowlerRatings
    {
        public string BowlerRating { get; set; }
        public long? BowlerLowAvg { get; set; }
        public long? BowlerHighAvg { get; set; }
    }
}
