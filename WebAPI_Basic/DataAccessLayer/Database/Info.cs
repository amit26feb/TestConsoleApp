//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Info
    {
        public int Idx { get; set; }
        public string Name { get; set; }
        public Nullable<int> ParentId { get; set; }
        public string URL { get; set; }
        public string Description { get; set; }
        public bool UseIntegratedWindowsAuthentication { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string Comments { get; set; }
    }
}
