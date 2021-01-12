using System;
using System.Collections.Generic;

#nullable disable

namespace HRMS_v2.Models
{
    public partial class TblEmployeeReportingMapping
    {
        public int EmployeeMappingId { get; set; }
        public int OrganizationId { get; set; }
        public int EmployeeId { get; set; }
        public int FirstLevelReporting { get; set; }
        public int? SecondLevelReporting { get; set; }
        public int? ThirdLevelReporting { get; set; }
        public bool DelFlag { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
