using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ForgingAhead.Models
{
    public class Quest
    {
        public string Name { get; set; }
        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }

        public List<Character> Characters { get; set; }
    }
}
