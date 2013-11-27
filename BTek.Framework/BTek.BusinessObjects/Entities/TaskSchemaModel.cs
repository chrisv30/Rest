using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTek.BusinessObjects.Entities
{
    public partial class TaskSchemaModel
    {
        public int Id { get; set; }
        public System.Guid C_id { get; set; }
        public Nullable<System.DateTime> LastSvrUpdateDate { get; set; }
        public Nullable<int> CreatorId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CurrentOwnerId { get; set; }
        public Nullable<System.DateTime> LastUpdateDate { get; set; }
        public Nullable<int> OrganisationId { get; set; }
        public Nullable<int> ProjectId { get; set; }
        public Nullable<int> ProjectStageId { get; set; }
        public Nullable<System.DateTime> EstStartDate { get; set; }
        public Nullable<decimal> EstHours { get; set; }
        public Nullable<System.DateTime> ActStartDate { get; set; }
        public Nullable<decimal> ActHours { get; set; }
        public Nullable<decimal> Priority { get; set; }
        public string Status { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string History { get; set; }
        public Nullable<bool> NotifyNoShow { get; set; }
        public Nullable<bool> NotifyApproach { get; set; }
        public Nullable<decimal> MyTaskRating { get; set; }
        public Nullable<decimal> BossTaskRating { get; set; }
        public Nullable<decimal> CustTaskRating { get; set; }

        public virtual OrganisationSchemaModel OrganisationSchema { get; set; }
        public virtual ProjectSchemaModel ProjectSchema { get; set; }
        public virtual UserSchemaModel UserSchema { get; set; }
        public virtual UserSchemaModel UserSchema1 { get; set; }
    }
}
