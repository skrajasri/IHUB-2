using System;
using System.Collections.Generic;

#nullable disable

namespace HRMS_v2.Models
{
    public partial class TblEmployeeDocument
    {
        public int EmployeeDocumentId { get; set; }
        public int OrganizationId { get; set; }
        public int EmployeeId { get; set; }
        public string DocumentName { get; set; }
        public int DocumentType { get; set; }
        public string DocuemntFilePath { get; set; }
        public bool DelFlag { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
