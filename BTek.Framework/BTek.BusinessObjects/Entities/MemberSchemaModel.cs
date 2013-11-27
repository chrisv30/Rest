using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTek.BusinessObjects.Entities
{
    public class MemberSchemaModel
    {
        public MemberSchemaModel()
        {
            this.InvitationSchemas = new HashSet<InvitationSchemaModel>();
        }

        public int Id { get; set; }
        public System.Guid C_id { get; set; }
        public System.DateTime LastSvrUpdateDate { get; set; }
        public Nullable<int> OrgId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> RoleId { get; set; }
        public Nullable<int> ScheduleId { get; set; }
        public Nullable<bool> IsOwner { get; set; }
        public string Status { get; set; }

        public virtual ICollection<InvitationSchemaModel> InvitationSchemas { get; set; }
        public virtual OrganisationSchemaModel OrganisationSchema { get; set; }
        public virtual RoleSchemaModel RoleSchema { get; set; }
        public virtual ScheduleSchemaModel ScheduleSchema { get; set; }
        public virtual UserSchemaModel UserSchema { get; set; }
    }
}
