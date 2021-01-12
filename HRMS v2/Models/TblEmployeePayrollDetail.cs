using System;
using System.Collections.Generic;

#nullable disable

namespace HRMS_v2.Models
{
    public partial class TblEmployeePayrollDetail
    {
        public int EmployeePayrollDetailsId { get; set; }
        public int OrganizationId { get; set; }
        public int EmployeeId { get; set; }
        public int PayrollMonth { get; set; }
        public int PayrollYear { get; set; }
        public byte[] EmployeeCtc { get; set; }
        public byte[] EmployeeCross { get; set; }
        public byte[] PfEmployee { get; set; }
        public byte[] PfEmployeer { get; set; }
        public byte[] ProfessionalTax { get; set; }
        public byte[] HraAmount { get; set; }
        public byte[] DaAmount { get; set; }
        public byte[] BasicAmount { get; set; }
        public byte[] SpeicalAllowance { get; set; }
        public string PaySlipFilePath { get; set; }
        public bool DelFlag { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
