using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTek.BusinessObjects.Entities
{
    public class InvitationSchemaModel
    {
        public int Id { get; set; }
        public System.Guid C_id { get; set; }
        public Nullable<System.DateTime> LastSvrUpdateDate { get; set; }
        public Nullable<int> OrgId { get; set; }
        public Nullable<int> SenderId { get; set; }
        public Nullable<int> RoleId { get; set; }
        public Nullable<int> MemberId { get; set; }
        public string RecipientEmail { get; set; }
        public Nullable<int> RecipientId { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DateSent { get; set; }
        public Nullable<System.DateTime> DateExpires { get; set; }
        public string Message { get; set; }

        public virtual MemberSchemaModel MemberSchema { get; set; }
        public virtual OrganisationSchemaModel OrganisationSchema { get; set; }
        public virtual UserSchemaModel UserSchema { get; set; }
        public virtual RoleSchemaModel RoleSchema { get; set; }
        public virtual UserSchemaModel UserSchema1 { get; set; }
    }
}
