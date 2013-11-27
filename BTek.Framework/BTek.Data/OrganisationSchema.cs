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
    
    public partial class OrganisationSchema
    {
        public OrganisationSchema()
        {
            this.InvitationSchemas = new HashSet<InvitationSchema>();
            this.LogBookSchemas = new HashSet<LogBookSchema>();
            this.MaterialSchemas = new HashSet<MaterialSchema>();
            this.MemberSchemas = new HashSet<MemberSchema>();
            this.TaskSchemas = new HashSet<TaskSchema>();
            this.ProjectSchemas = new HashSet<ProjectSchema>();
            this.RoleSchemas = new HashSet<RoleSchema>();
            this.StageSchemas = new HashSet<StageSchema>();
            this.UserScheduleSchemas = new HashSet<UserScheduleSchema>();
        }
    
        public int Id { get; set; }
        public System.Guid C_id { get; set; }
        public Nullable<System.DateTime> LastSvrUpdateDate { get; set; }
        public string Name { get; set; }
        public Nullable<int> OwnerId { get; set; }
        public Nullable<int> AddressId { get; set; }
        public Nullable<int> AccountType { get; set; }
        public Nullable<int> AccountStatus { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DateUpdated { get; set; }
        public Nullable<System.DateTime> DateExpires { get; set; }
    
        public virtual AddressSchema AddressSchema { get; set; }
        public virtual ICollection<InvitationSchema> InvitationSchemas { get; set; }
        public virtual ICollection<LogBookSchema> LogBookSchemas { get; set; }
        public virtual ICollection<MaterialSchema> MaterialSchemas { get; set; }
        public virtual ICollection<MemberSchema> MemberSchemas { get; set; }
        public virtual ICollection<TaskSchema> TaskSchemas { get; set; }
        public virtual UserSchema UserSchema { get; set; }
        public virtual ICollection<ProjectSchema> ProjectSchemas { get; set; }
        public virtual ICollection<RoleSchema> RoleSchemas { get; set; }
        public virtual ICollection<StageSchema> StageSchemas { get; set; }
        public virtual ICollection<UserScheduleSchema> UserScheduleSchemas { get; set; }
    }
}