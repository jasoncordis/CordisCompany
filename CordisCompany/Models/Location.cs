using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CordisCompany.Models
{
    public class Location
    {
        public loc rentLoc { get; set; }
    }

    public enum loc
    {
        Hercules,
        Richmond,
        Vallejo

    }
}