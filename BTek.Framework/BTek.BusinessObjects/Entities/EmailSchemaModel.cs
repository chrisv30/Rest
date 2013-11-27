using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTek.BusinessObjects.Entities
{
    public class EmailSchemaModel
    {
        public int Id { get; set; }
        public System.Guid C_id { get; set; }
        public Nullable<System.DateTime> LastSvrUpdateDate { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
        public string Attachment { get; set; }
    }
}
