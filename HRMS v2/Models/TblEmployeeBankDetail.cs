using System;
using System.Collections.Generic;

#nullable disable

namespace HRMS_v2.Models
{
    public partial class TblEmployeeBankDetail
    {
        public int EmployeeBankDetailsId { get; set; }
        public int OrganizationId { get; set; }
        public int EmployeeId { get; set; }
        public string AccountName { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string IfscCode { get; set; }
        public string AccountNumber { get; set; }
        public bool DelFlag { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
