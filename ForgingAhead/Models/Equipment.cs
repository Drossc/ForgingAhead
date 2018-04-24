using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForgingAhead.Models
{
    public class Equipment
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public List<Character> Characters { get; set; }
    }
}
