using System;
using System.Collections.Generic;

#nullable disable

namespace HRMS_v2.Models
{
    public partial class TblEmployee
    {
        public int EmployeeId { get; set; }
        public int OrganizationId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeMiddleName { get; set; }
        public string EmployeeLastName { get; set; }
        public string Gender { get; set; }
        public DateTime EmployeeDob { get; set; }
        public int EmployeeDesignation { get; set; }
        public DateTime EmployeeDoj { get; set; }
        public DateTime? EmployeeDor { get; set; }
        public string EmpoyeeFatherName { get; set; }
        public string EmployeeMotherName { get; set; }
        public int EmployeeCurrentAddress { get; set; }
        public int EmployeePermenetAddress { get; set; }
        public string EmployeeContactNo { get; set; }
        public string EmployeeEmergencyNo { get; set; }
        public string EmployeePersonalEmail { get; set; }
        public string EmployeeOfficalEmail { get; set; }
        public int RoleId { get; set; }
        public string BiometricMappingId { get; set; }
        public bool DelFlag { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
