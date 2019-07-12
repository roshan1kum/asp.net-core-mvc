using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace SportsApplication.Models
{
    public class Test
    {
        public int Id { get; set; }
        public int Date { get; set; }
        [DisplayName("Number of Participants")]
        public int number_participants{get;set;}
        [DisplayName("Test Type")]
        public string test_type { get; set; }
    }
}
