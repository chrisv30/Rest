using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTek.BusinessObjects.Entities
{
    public  class LocationSchemaModel
    {
        public int Id { get; set; }
        public System.Guid C_id { get; set; }
        public Nullable<System.DateTime> LastSvrUpdateDate { get; set; }
        public Nullable<int> UserId { get; set; }
        public System.DateTime Recorded { get; set; }
        public string Source { get; set; }
        public Nullable<int> Accuracy { get; set; }
        public Nullable<decimal> Altitude { get; set; }
        public Nullable<decimal> Bearing { get; set; }
        public Nullable<decimal> Speed { get; set; }
        public Nullable<decimal> xlon { get; set; }
        public Nullable<decimal> ylat { get; set; }

        public virtual UserSchemaModel UserSchema { get; set; }
    }
}
