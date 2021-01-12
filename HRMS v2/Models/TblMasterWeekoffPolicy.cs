using System;
using System.Collections.Generic;

#nullable disable

namespace HRMS_v2.Models
{
    public partial class TblMasterWeekoffPolicy
    {
        public int WeekoffPolicyId { get; set; }
        public int OrganizationId { get; set; }
        public string WeekoffPolicyName { get; set; }
        public string WeekoffDays { get; set; }
        public bool DelFlag { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
