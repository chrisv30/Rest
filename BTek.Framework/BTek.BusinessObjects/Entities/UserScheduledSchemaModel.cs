using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTek.BusinessObjects.Entities
{
    public class UserScheduledSchemaModel
    {
        public int Id { get; set; }
        public Nullable<System.Guid> C_id { get; set; }
        public Nullable<System.DateTime> LastSvrUpdateDate { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> OrganisationId { get; set; }
        public Nullable<int> ScheduleId { get; set; }

        public virtual OrganisationSchemaModel OrganisationSchema { get; set; }
        public virtual ScheduleSchemaModel ScheduleSchema { get; set; }
        public virtual UserSchemaModel UserSchema { get; set; }
    }
}
