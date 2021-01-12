using System;
using System.Collections.Generic;

#nullable disable

namespace HRMS_v2.Models
{
    public partial class TblMasterHolidayList
    {
        public int HolidayPolicylistId { get; set; }
        public int OrganizationId { get; set; }
        public int HolidayPolicyId { get; set; }
        public string HolidayDate { get; set; }
        public int HolidayYear { get; set; }
        public int HolidayMonth { get; set; }
        public string Holidayname { get; set; }
        public bool DelFlag { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
