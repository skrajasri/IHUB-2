using System;
using System.Collections.Generic;

#nullable disable

namespace Intra_Hub_v2.Models
{
    public partial class TblLogin
    {
        public int LoginId { get; set; }
        public string OrganizationCode { get; set; }
        public string LoginEmployeeCode { get; set; }
        public string LoginPassword { get; set; }
        public DateTime LastSignIn { get; set; }
        public bool DelFlag { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
