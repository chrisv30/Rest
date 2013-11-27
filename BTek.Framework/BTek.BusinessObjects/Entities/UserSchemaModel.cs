using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTek.BusinessObjects.Entities
{
    public class UserSchemaModel
    {
        public UserSchemaModel()
        {
            this.InvitationSchemas = new HashSet<InvitationSchemaModel>();
            this.InvitationSchemas1 = new HashSet<InvitationSchemaModel>();
            this.LocationSchemas = new HashSet<LocationSchemaModel>();
            this.LogBookSchemas = new HashSet<LogBookSchemaModel>();
            this.MemberSchemas = new HashSet<MemberSchemaModel>();
            this.OrganisationSchemas = new HashSet<OrganisationSchemaModel>();
            this.TaskSchemas = new HashSet<TaskSchemaModel>();
            this.TaskSchemas1 = new HashSet<TaskSchemaModel>();
            this.UserScheduleSchemas = new HashSet<UserScheduledSchemaModel>();
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

        public virtual AddressSchemaModel AddressSchema { get; set; }
        public virtual ICollection<InvitationSchemaModel> InvitationSchemas { get; set; }
        public virtual ICollection<InvitationSchemaModel> InvitationSchemas1 { get; set; }
        public virtual ICollection<LocationSchemaModel> LocationSchemas { get; set; }
        public virtual ICollection<LogBookSchemaModel> LogBookSchemas { get; set; }
        public virtual ICollection<MemberSchemaModel> MemberSchemas { get; set; }
        public virtual ICollection<OrganisationSchemaModel> OrganisationSchemas { get; set; }
        public virtual ICollection<TaskSchemaModel> TaskSchemas { get; set; }
        public virtual ICollection<TaskSchemaModel> TaskSchemas1 { get; set; }
        public virtual ICollection<UserScheduledSchemaModel> UserScheduleSchemas { get; set; }
    }
}
