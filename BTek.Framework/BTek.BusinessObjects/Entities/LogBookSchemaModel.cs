using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTek.BusinessObjects.Entities
{
    public class LogBookSchemaModel
    {
        public int Id { get; set; }
        public System.Guid C_id { get; set; }
        public Nullable<System.DateTime> LastSvrUpdateDate { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> OrgId { get; set; }
        public Nullable<int> ProjectId { get; set; }
        public Nullable<int> AddressId { get; set; }
        public Nullable<System.DateTime> Started { get; set; }
        public Nullable<System.DateTime> Ended { get; set; }
        public Nullable<decimal> DurationMS { get; set; }
        public Nullable<decimal> DistSource { get; set; }
        public Nullable<decimal> DistTravelled { get; set; }
        public string Activity { get; set; }
        public Nullable<decimal> Confidence { get; set; }
        public Nullable<decimal> OdometerStart { get; set; }
        public Nullable<decimal> OdometerEnd { get; set; }
        public Nullable<bool> IsBusinessRelated { get; set; }
        public string Notes { get; set; }
        public string Source { get; set; }
        public Nullable<decimal> AvgAltitude { get; set; }
        public Nullable<decimal> MinAltitude { get; set; }
        public Nullable<decimal> MaxAltitude { get; set; }
        public Nullable<decimal> AvgSpeed { get; set; }
        public Nullable<decimal> MinSpeed { get; set; }
        public Nullable<decimal> MaxSpeed { get; set; }
        public Nullable<decimal> AvgAccuracy { get; set; }
        public Nullable<decimal> Updates { get; set; }
        public Nullable<decimal> Start_xlon { get; set; }
        public Nullable<decimal> Start_ylon { get; set; }
        public Nullable<decimal> End_xlon { get; set; }
        public Nullable<decimal> End_ylon { get; set; }
        public string Address_Street { get; set; }
        public string Address_Suburb { get; set; }
        public string Address_PostCode { get; set; }
        public string Address_State { get; set; }
        public string Address_Country { get; set; }

        public virtual OrganisationSchemaModel OrganisationSchema { get; set; }
        public virtual ProjectSchemaModel ProjectSchema { get; set; }
        public virtual UserSchemaModel UserSchema { get; set; }
    }
}
