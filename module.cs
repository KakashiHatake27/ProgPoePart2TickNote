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
    
    public partial class module
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public module()
        {
            this.studySessions = new HashSet<studySession>();
        }
    
        public string moduleCode { get; set; }
        public string moduleName { get; set; }
        public int userId { get; set; }
        public Nullable<int> credits { get; set; }
        public Nullable<int> classes { get; set; }
    
        public virtual userAccount userAccount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<studySession> studySessions { get; set; }
    }
}
