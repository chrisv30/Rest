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
    
    public partial class UserSchema
    {
        public UserSchema()
        {
            this.InvitationSchemas = new HashSet<InvitationSchema>();
            this.InvitationSchemas1 = new HashSet<InvitationSchema>();
            this.LocationSchemas = new HashSet<LocationSchema>();
            this.LogBookSchemas = new HashSet<LogBookSchema>();
            this.MemberSchemas = new HashSet<MemberSchema>();
            this.OrganisationSchemas = new HashSet<OrganisationSchema>();
            this.TaskSchemas = new HashSet<TaskSchema>();
            this.TaskSchemas1 = new HashSet<TaskSchema>();
            this.UserScheduleSchemas = new HashSet<UserScheduleSchema>();
        }
    
        public int Id { get; set; }
        public System.Guid C_id { get; set; }
        public Nullable<int> AddressId { get; set; }
        public System.DateTime LastSvrUpdateDate { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public Nullable<int> WPUserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public Nullable<int> AccountType { get; set; }
        public Nullable<int> AccountStatus { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public Nullable<System.DateTime> DateExpires { get; set; }
    
        public virtual AddressSchema AddressSchema { get; set; }
        public virtual ICollection<InvitationSchema> InvitationSchemas { get; set; }
        public virtual ICollection<InvitationSchema> InvitationSchemas1 { get; set; }
        public virtual ICollection<LocationSchema> LocationSchemas { get; set; }
        public virtual ICollection<LogBookSchema> LogBookSchemas { get; set; }
        public virtual ICollection<MemberSchema> MemberSchemas { get; set; }
        public virtual ICollection<OrganisationSchema> OrganisationSchemas { get; set; }
        public virtual ICollection<TaskSchema> TaskSchemas { get; set; }
        public virtual ICollection<TaskSchema> TaskSchemas1 { get; set; }
        public virtual ICollection<UserScheduleSchema> UserScheduleSchemas { get; set; }
    }
}
