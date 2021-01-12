using System;
using System.Collections.Generic;

#nullable disable

namespace HRMS_v2.Models
{
    public partial class TblEmployeeSalary
    {
        public int EmployeeSalaryInfoId { get; set; }
        public int OrganizationId { get; set; }
        public int EmployeeId { get; set; }
        public int SalaryYear { get; set; }
        public int SalaryMonth { get; set; }
        public byte[] SalaryAnualCtc { get; set; }
        public byte[] SalaryMonthCtc { get; set; }
        public byte[] SalaryAnualCross { get; set; }
        public byte[] SalaryMonthCross { get; set; }
        public bool DelFlag { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
