using System;
using System.Collections.Generic;

#nullable disable

namespace HRMS_v2.Models
{
    public partial class TblMasterLeaveSubPolicy
    {
        public int LeaveSubPolicyId { get; set; }
        public int OrganizationId { get; set; }
        public int LeavePolicyId { get; set; }
        public string LeaveType { get; set; }
        public string LeaveTypeShortName { get; set; }
        public double LeaveDays { get; set; }
        public double? CarryForwardDays { get; set; }
        public bool? CarryForwardFlag { get; set; }
        public bool PaidLeaveFlag { get; set; }
        public bool DelFlag { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
