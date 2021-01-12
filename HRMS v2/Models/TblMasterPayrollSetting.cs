using System;
using System.Collections.Generic;

#nullable disable

namespace HRMS_v2.Models
{
    public partial class TblMasterPayrollSetting
    {
        public int PayrollPolicyId { get; set; }
        public int OrganizationId { get; set; }
        public string PayrollPolicyName { get; set; }
        public decimal BasicPercentage { get; set; }
        public decimal HraPercentage { get; set; }
        public decimal DaPercentage { get; set; }
        public decimal? SpecialAllowance { get; set; }
        public decimal? ProfessionalTax { get; set; }
        public decimal? PfEmployeeAmount { get; set; }
        public bool DelFlag { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
