﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstApproachEF.Models
{
    public class Book
    {
        public int BookID { get; set; }

        public string BookName { get; set; }

        public string Author { get; set; }
    }
}