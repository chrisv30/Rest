using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTek.BusinessObjects.Entities
{
    public partial class ProjectSchemaModel
    {
        public ProjectSchemaModel()
        {
            this.LogBookSchemas = new HashSet<LogBookSchemaModel>();
            this.MaterialSchemas = new HashSet<MaterialSchemaModel>();
            this.TaskSchemas = new HashSet<TaskSchemaModel>();
            this.StageSchemas = new HashSet<StageSchemaModel>();
        }

        public int Id { get; set; }
        public System.Guid C_id { get; set; }
        public System.DateTime LastSvrUpdateDate { get; set; }
        public Nullable<int> OrgId { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Status { get; set; }
        public string CustFirstName { get; set; }
        public string CustLastName { get; set; }
        public string CustEmail { get; set; }
        public string CustPhone { get; set; }
        public Nullable<int> CustAddressId { get; set; }
        public Nullable<int> SiteAddressId { get; set; }
        public Nullable<decimal> QuotedValue { get; set; }
        public Nullable<decimal> QuotedHrs { get; set; }
        public Nullable<decimal> ActualHrs { get; set; }
        public Nullable<decimal> Margin { get; set; }

        public virtual AddressSchemaModel AddressSchema { get; set; }
        public virtual AddressSchemaModel AddressSchema1 { get; set; }
        public virtual ICollection<LogBookSchemaModel> LogBookSchemas { get; set; }
        public virtual ICollection<MaterialSchemaModel> MaterialSchemas { get; set; }
        public virtual OrganisationSchemaModel OrganisationSchema { get; set; }
        public virtual ICollection<TaskSchemaModel> TaskSchemas { get; set; }
        public virtual ICollection<StageSchemaModel> StageSchemas { get; set; }
    }
}
