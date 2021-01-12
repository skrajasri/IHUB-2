using System;
using System.Collections.Generic;

#nullable disable

namespace HRMS_v2.Models
{
    public partial class TblEmployeeBiomatricLog
    {
        public int LogEntryId { get; set; }
        public string OrganizationCode { get; set; }
        public string BiometricId { get; set; }
        public DateTime LogEntryDateTime { get; set; }
        public bool DelFlag { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
