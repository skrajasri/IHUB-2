using System;
using System.Collections.Generic;

#nullable disable

namespace HRMS_v2.Models
{
    public partial class TblMasterPermissionPolicy
    {
        public int PermissionPolicyId { get; set; }
        public int OrganizationId { get; set; }
        public string PermissionPolicyName { get; set; }
        public string PemissionPolicyType { get; set; }
        public int PemissionMins { get; set; }
        public int PemissionCount { get; set; }
        public bool DelFlag { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
