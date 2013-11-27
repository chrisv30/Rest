using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTek.BusinessObjects.Entities
{
    public class ScheduleSchemaModel
    {
        public ScheduleSchemaModel()
        {
            this.MemberSchemas = new HashSet<MemberSchemaModel>();
            this.RoleSchemas = new HashSet<RoleSchemaModel>();
            this.UserScheduleSchemas = new HashSet<UserScheduledSchemaModel>();
        }

        public int Id { get; set; }
        public Nullable<System.Guid> C_id { get; set; }
        public System.DateTime LastSvrUpdateDate { get; set; }
        public string RepeatDays { get; set; }
        public Nullable<decimal> StartTimeMS { get; set; }
        public Nullable<decimal> EndTimeMS { get; set; }
        public Nullable<decimal> FrequencyMS { get; set; }

        public virtual ICollection<MemberSchemaModel> MemberSchemas { get; set; }
        public virtual ICollection<RoleSchemaModel> RoleSchemas { get; set; }
        public virtual ICollection<UserScheduledSchemaModel> UserScheduleSchemas { get; set; }
    }
}
