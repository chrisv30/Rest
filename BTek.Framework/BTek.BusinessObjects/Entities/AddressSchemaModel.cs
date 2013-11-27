using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTek.BusinessObjects.Entities
{
    public class AddressSchemaModel
    {
        public AddressSchemaModel()
        {
            this.OrganisationSchemas = new HashSet<OrganisationSchemaModel>();
            this.ProjectSchemas = new HashSet<ProjectSchemaModel>();
            this.ProjectSchemas1 = new HashSet<ProjectSchemaModel>();
            this.UserSchemas = new HashSet<UserSchemaModel>();
        }

        public int Id { get; set; }
        public Nullable<System.Guid> C_id { get; set; }
        public Nullable<System.DateTime> LastSvrUpdateDate { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Suburb { get; set; }
        public string PostCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public Nullable<decimal> xlon { get; set; }
        public Nullable<decimal> ylat { get; set; }

        public virtual ICollection<OrganisationSchemaModel> OrganisationSchemas { get; set; }
        public virtual ICollection<ProjectSchemaModel> ProjectSchemas { get; set; }
        public virtual ICollection<ProjectSchemaModel> ProjectSchemas1 { get; set; }
        public virtual ICollection<UserSchemaModel> UserSchemas { get; set; }
    }
}
