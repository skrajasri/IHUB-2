using System;
using System.Collections.Generic;

#nullable disable

namespace HRMS_v2.Models
{
    public partial class TblAttedancePolicyMapping
    {
        public int AttendancePolicyMappingId { get; set; }
        public int OrganizationId { get; set; }
        public int EmployeeId { get; set; }
        public int AttendancePolicyId { get; set; }
        public bool DelFlag { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
