using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_10_Josiah_Sarles.Models.ViewModels
{
    //View model used to get all the information needed in the index view
    public class BowlingListViewModel
    {
        public IEnumerable<Bowlers> bowlers { get; set; }

        public PagingInfo PagingInfo { get; set; }

        public IEnumerable<Teams> CurrentTeam { get; set; }
    }
}
