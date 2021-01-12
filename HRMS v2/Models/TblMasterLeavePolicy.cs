using System;
using System.Collections.Generic;

#nullable disable

namespace HRMS_v2.Models
{
    public partial class TblMasterLeavePolicy
    {
        public int LeavePolicyId { get; set; }
        public int OrganizationId { get; set; }
        public string LeavePolicyType { get; set; }
        public string LeaveType { get; set; }
        public string LeaveTypeShortName { get; set; }
        public int TotalLeaveDays { get; set; }
        public bool DelFlag { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
