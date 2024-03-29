﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MockProject.Models
{
    public class Faculty
    {
        [Key] 
        public int Id { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        
        public virtual List<User> Users { get; set; }
        
    }
}