﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.model
{
    public class books
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? ISBN { get; set; }
        public string? Author { get; set; }
        public string? Status { get; set; }
        public string? Iduser { get; set; }
    }
}
