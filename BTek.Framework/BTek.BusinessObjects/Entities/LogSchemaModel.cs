using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTek.BusinessObjects.Entities
{
    public class LogSchema
    {
        public int Id { get; set; }
        public System.Guid C_id { get; set; }
        public Nullable<System.DateTime> LastSvrUpdateDate { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<System.DateTime> Generated { get; set; }
        public string Object { get; set; }
        public string Method { get; set; }
        public string Severity { get; set; }
        public string Message { get; set; }
    }
}
