using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTek.BusinessObjects.Entities
{
    public class MaterialSchemaModel
    {
        public int Id { get; set; }
        public System.Guid C_id { get; set; }
        public Nullable<System.DateTime> LastSvrUpdateDate { get; set; }
        public Nullable<int> OrgId { get; set; }
        public Nullable<int> ProjectId { get; set; }
        public Nullable<int> StageId { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> UnitCost { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<decimal> DeliveryCost { get; set; }
        public Nullable<decimal> TotalCost { get; set; }
        public Nullable<decimal> QuotedValue { get; set; }
        public Nullable<bool> IsOrdered { get; set; }
        public Nullable<bool> IsDelivered { get; set; }
        public Nullable<bool> ShowOnQuote { get; set; }

        public virtual OrganisationSchemaModel OrganisationSchema { get; set; }
        public virtual ProjectSchemaModel ProjectSchema { get; set; }
        public virtual StageSchemaModel StageSchema { get; set; }
    }
}
