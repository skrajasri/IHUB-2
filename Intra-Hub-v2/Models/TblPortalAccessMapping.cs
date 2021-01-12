using System;
using System.Collections.Generic;

#nullable disable

namespace Intra_Hub_v2.Models
{
    public partial class TblPortalAccessMapping
    {
        public int PortalMappingId { get; set; }
        public int OrganizationCode { get; set; }
        public string EmployeeCode { get; set; }
        public string PortalId { get; set; }
        public bool DelFlag { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
