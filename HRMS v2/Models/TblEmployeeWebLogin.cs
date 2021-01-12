using System;
using System.Collections.Generic;

#nullable disable

namespace HRMS_v2.Models
{
    public partial class TblEmployeeWebLogin
    {
        public int LogEntryId { get; set; }
        public int OrganizationId { get; set; }
        public int EmployeeId { get; set; }
        public string LogType { get; set; }
        public DateTime LogEntryDateTime { get; set; }
        public bool DelFlag { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
