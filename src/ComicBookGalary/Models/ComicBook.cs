﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGalary.Models
{
    public class ComicBook
    {
        public int ID { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favortte { get; set; }
    }
}