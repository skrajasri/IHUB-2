using System;
using System.Collections.Generic;

#nullable disable

namespace HRMS_v2.Models
{
    public partial class TblPermission
    {
        public int PemissionId { get; set; }
        public int OrganizationId { get; set; }
        public int EmployeeId { get; set; }
        public int PemissionPolicyId { get; set; }
        public DateTime PermissionStartTime { get; set; }
        public DateTime PesmissionEndTime { get; set; }
        public bool? ApprovedStatus { get; set; }
        public bool DelFlag { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
