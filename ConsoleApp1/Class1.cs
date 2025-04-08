using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Book
    {
        public string title{set; get;}
        public string auther { set; get; }
        public int ISBN{set; get;}
    }



    internal class EBook : Book
    {
        public double FileSize { get; set; }

    }
    internal class PrintedBook : Book
    {
        public double Page_count { get; set; }

    }
}
