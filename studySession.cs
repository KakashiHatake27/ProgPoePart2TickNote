//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProgPoeTickNotePart2
{
    using System;
    using System.Collections.Generic;
    
    public partial class studySession
    {
        public int sessionId { get; set; }
        public int userId { get; set; }
        public System.DateTime studyDate { get; set; }
        public string module { get; set; }
        public Nullable<int> hoursWorked { get; set; }
    
        public virtual module module1 { get; set; }
        public virtual userAccount userAccount { get; set; }
    }
}
