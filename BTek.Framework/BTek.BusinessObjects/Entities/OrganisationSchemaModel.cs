using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTek.BusinessObjects.Entities
{
    public partial class OrganisationSchemaModel
    {
        public OrganisationSchemaModel()
        {
            this.InvitationSchemas = new HashSet<InvitationSchemaModel>();
            this.LogBookSchemas = new HashSet<LogBookSchemaModel>();
            this.MaterialSchemas = new HashSet<MaterialSchemaModel>();
            this.MemberSchemas = new HashSet<MemberSchemaModel>();
            this.TaskSchemas = new HashSet<TaskSchemaModel>();
            this.ProjectSchemas = new HashSet<ProjectSchemaModel>();
            this.RoleSchemas = new HashSet<RoleSchemaModel>();
            this.StageSchemas = new HashSet<StageSchemaModel>();
            this.UserScheduleSchemas = new HashSet<UserScheduledSchemaModel>();
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

        public virtual AddressSchemaModel AddressSchema { get; set; }
        public virtual ICollection<InvitationSchemaModel> InvitationSchemas { get; set; }
        public virtual ICollection<LogBookSchemaModel> LogBookSchemas { get; set; }
        public virtual ICollection<MaterialSchemaModel> MaterialSchemas { get; set; }
        public virtual ICollection<MemberSchemaModel> MemberSchemas { get; set; }
        public virtual ICollection<TaskSchemaModel> TaskSchemas { get; set; }
        public virtual UserSchemaModel UserSchema { get; set; }
        public virtual ICollection<ProjectSchemaModel> ProjectSchemas { get; set; }
        public virtual ICollection<RoleSchemaModel> RoleSchemas { get; set; }
        public virtual ICollection<StageSchemaModel> StageSchemas { get; set; }
        public virtual ICollection<UserScheduledSchemaModel> UserScheduleSchemas { get; set; }
    }
}
