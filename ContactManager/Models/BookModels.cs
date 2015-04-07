using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManager.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string author { get; set; }
        public int isbn { get; set; }
    }
}