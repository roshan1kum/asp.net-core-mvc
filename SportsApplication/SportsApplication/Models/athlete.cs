using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace SportsApplication.Models
{
    public class athlete
    {
        public int Id { get; set; }
        [DisplayName("Ranking")]
        public String Name { get; set; }
        [DisplayName("Disptance(meter")]
        public int Distance { get; set; }
        [DisplayName("Fitness rating")]
        public string FitnessRating { get; set; }
    }
}
