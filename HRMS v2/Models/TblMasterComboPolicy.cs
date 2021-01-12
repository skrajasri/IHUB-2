using System;
using System.Collections.Generic;

#nullable disable

namespace HRMS_v2.Models
{
    public partial class TblMasterComboPolicy
    {
        public int ComboPolicyId { get; set; }
        public int OrganizationId { get; set; }
        public string ComboPolicyName { get; set; }
        public string ComboMinHours { get; set; }
        public bool DelFlag { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
