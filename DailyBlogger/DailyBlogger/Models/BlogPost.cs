﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace DailyBlogger.Models
{
    public class BlogPost
    {
        [Key]
        public int id { get; set; }
        public string blogTitle { get; set; }
        
        public string content { get; set; }
        public DateTime blogDate { get; set;}


    }
}
