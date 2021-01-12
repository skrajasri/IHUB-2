using System;
using System.Collections.Generic;

#nullable disable

namespace HRMS_v2.Models
{
    public partial class TblMasterShiftPolicy
    {
        public int ShiftPolicyId { get; set; }
        public int OrganizationId { get; set; }
        public string ShiftPolicyName { get; set; }
        public string ShiftStartTime { get; set; }
        public string ShiftEndTime { get; set; }
        public int ShiftHours { get; set; }
        public bool DelFlag { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
