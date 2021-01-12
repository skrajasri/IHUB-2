using System;
using System.Collections.Generic;

#nullable disable

namespace HRMS_v2.Models
{
    public partial class TblMasterAttendancePolicy
    {
        public int AttendancePolicyId { get; set; }
        public int OrganizationId { get; set; }
        public string AttendacePolicyName { get; set; }
        public bool LopFlag { get; set; }
        public int LopHours { get; set; }
        public string LoginType { get; set; }
        public bool AttendaceFlag { get; set; }
        public bool DelFlag { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
