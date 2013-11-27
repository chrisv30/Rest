using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTek.BusinessObjects.Entities
{
    public partial class ServiceSchemaModel
    {
        public int Id { get; set; }
        public Nullable<System.Guid> C_id { get; set; }
        public Nullable<System.DateTime> LastSvrUpdateDate { get; set; }
        public string SystemName { get; set; }
        public string ServiceName { get; set; }
        public string Version { get; set; }
        public string LiveUrl { get; set; }
        public string DevUrl { get; set; }
        public string TestUrl { get; set; }
    }
}
