//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Phone_Book_Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_PHONE_BOOK
    {
        public long ID { get; set; }
        public string NAME { get; set; }
        public string SURNAME { get; set; }
        public Nullable<int> ID_PHONE_TYPE { get; set; }
        public Nullable<System.DateTime> DELETED_DATE { get; set; }
        public Nullable<System.DateTime> MODIFIED_DATE { get; set; }
        public Nullable<System.DateTime> INSERTED_DATE { get; set; }
        public string NUMBER { get; set; }
    
        public virtual T_PHONE_TYPE T_PHONE_TYPE { get; set; }
    }
}
