﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProject.Models
{
    public class NoticeVideo
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Link { get; set; }
    }
}
