using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTek.BusinessObjects.Entities
{
    public partial class RoleSchemaModel
    {
        public RoleSchemaModel()
        {
            this.InvitationSchemas = new HashSet<InvitationSchemaModel>();
            this.MemberSchemas = new HashSet<MemberSchemaModel>();
        }

        public int Id { get; set; }
        public System.Guid C_id { get; set; }
        public System.DateTime LastSvrUpdateDate { get; set; }
        public Nullable<int> OrganisationId { get; set; }
        public Nullable<int> ScheduleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> Rate { get; set; }
        public Nullable<bool> ModifyOrg { get; set; }
        public Nullable<bool> ModifyRole { get; set; }
        public Nullable<bool> ModifyPerson { get; set; }
        public Nullable<bool> ModifyLogbook { get; set; }
        public Nullable<bool> ModifyProject { get; set; }
        public Nullable<bool> ModifyStage { get; set; }
        public Nullable<bool> ModifyMaterial { get; set; }
        public Nullable<bool> ModifyTask { get; set; }
        public Nullable<bool> ModifyTool { get; set; }

        public virtual ICollection<InvitationSchemaModel> InvitationSchemas { get; set; }
        public virtual ICollection<MemberSchemaModel> MemberSchemas { get; set; }
        public virtual OrganisationSchemaModel OrganisationSchema { get; set; }
        public virtual ScheduleSchemaModel ScheduleSchema { get; set; }
    }
}
