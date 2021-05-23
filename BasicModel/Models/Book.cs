using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicModel.Models
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public String Discription { get; set; }
        public String picUrl { get; set; }
    }
}
