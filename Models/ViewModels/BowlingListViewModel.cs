﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_10_Josiah_Sarles.Models.ViewModels
{
    public class BowlingListViewModel
    {
        public IEnumerable<Bowlers> bowlers { get; set; }

        //public PagingInfo PagingInfo { get; set; }
        //public string CurrentTeam { get; set; }

    }
}