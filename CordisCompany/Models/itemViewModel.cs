using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CordisCompany.Models
{
    public class itemViewModel
    {
        public int ID { get; set; }
        public string itemName { get; set; }
        public Nullable<int> reach1 { get; set; }
        public Nullable<int> reach2 { get; set; }
        public string imgString { get; set; }
        public string style { get; set; }
        public Nullable<int> progress { get; set; }
    }
}