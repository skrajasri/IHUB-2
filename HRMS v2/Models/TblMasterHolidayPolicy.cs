using System;
using System.Collections.Generic;

#nullable disable

namespace HRMS_v2.Models
{
    public partial class TblMasterHolidayPolicy
    {
        public int HolidayPolicyId { get; set; }
        public int OrganizationId { get; set; }
        public string HolidayPolicyName { get; set; }
        public bool DelFlag { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
