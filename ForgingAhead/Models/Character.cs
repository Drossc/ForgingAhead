﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ForgingAhead.Models
{
    public class Character
    {
        public string Name { get; set; }
        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }
        public int Level { get; set; }
        public int Strenght { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        public List<Equipment> Equipment { get; set; }
        public List<Quest> Quests { get; set; }
    }
}
