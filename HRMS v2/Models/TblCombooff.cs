using System;
using System.Collections.Generic;

#nullable disable

namespace HRMS_v2.Models
{
    public partial class TblCombooff
    {
        public int ComboId { get; set; }
        public int OrganizationId { get; set; }
        public int EmployeeId { get; set; }
        public int ComboPolicyId { get; set; }
        public DateTime ComboStartDate { get; set; }
        public DateTime ComboEndDate { get; set; }
        public bool? ApprovedStatus { get; set; }
        public bool DelFlag { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
