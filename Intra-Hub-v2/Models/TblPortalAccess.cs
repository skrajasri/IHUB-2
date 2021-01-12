using System;
using System.Collections.Generic;

#nullable disable

namespace Intra_Hub_v2.Models
{
    public partial class TblPortalAccess
    {
        public int PortalId { get; set; }
        public string PortalName { get; set; }
        public string PortalUrl { get; set; }
        public bool DelFlag { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
