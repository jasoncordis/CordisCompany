//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CordisCompany.Models
{
    using System;
    using System.Collections.Generic;
    
    //The message model is designed for messages sent within Cordis Company that have a unique sender, a message with attachments, and a send date.
    public partial class message
    {
        public int ID { get; set; }
        public string sender { get; set; }
        public string email { get; set; }
        public string edate { get; set; }
    }
}
