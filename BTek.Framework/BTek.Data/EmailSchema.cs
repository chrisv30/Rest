//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BTek.Data
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    
    public partial class EmailSchema
    {
        public int Id { get; set; }
        public System.Guid C_id { get; set; }
        public Nullable<System.DateTime> LastSvrUpdateDate { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
        public string Attachment { get; set; }
    }
}