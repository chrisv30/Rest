using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTek.BusinessObjects.Entities
{
    public class StageSchemaModel
    {
        public StageSchemaModel()
        {
            this.MaterialSchemas = new HashSet<MaterialSchemaModel>();
        }

        public int Id { get; set; }
        public System.Guid C_id { get; set; }
        public Nullable<System.DateTime> LastSvrUpdateDate { get; set; }
        public Nullable<int> OrgId { get; set; }
        public Nullable<int> ProjectId { get; set; }
        public Nullable<decimal> Sequence { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> QuotedValue { get; set; }
        public Nullable<bool> ShowOnQuote { get; set; }
        public Nullable<System.DateTime> EstStartDate { get; set; }
        public Nullable<bool> IsComplete { get; set; }

        public virtual ICollection<MaterialSchemaModel> MaterialSchemas { get; set; }
        public virtual OrganisationSchemaModel OrganisationSchema { get; set; }
        public virtual ProjectSchemaModel ProjectSchema { get; set; }
    }
}
