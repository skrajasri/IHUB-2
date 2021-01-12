using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HRMS_v2.Models
{
    public partial class HRMSContext : DbContext
    {
        public HRMSContext()
        {
        }

        public HRMSContext(DbContextOptions<HRMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAttedancePolicyMapping> TblAttedancePolicyMappings { get; set; }
        public virtual DbSet<TblComboPolicyMapping> TblComboPolicyMappings { get; set; }
        public virtual DbSet<TblCombooff> TblCombooffs { get; set; }
        public virtual DbSet<TblEmployeAddress> TblEmployeAddresses { get; set; }
        public virtual DbSet<TblEmployee> TblEmployees { get; set; }
        public virtual DbSet<TblEmployeeAttendance> TblEmployeeAttendances { get; set; }
        public virtual DbSet<TblEmployeeBankDetail> TblEmployeeBankDetails { get; set; }
        public virtual DbSet<TblEmployeeBiomatricLog> TblEmployeeBiomatricLogs { get; set; }
        public virtual DbSet<TblEmployeeDocument> TblEmployeeDocuments { get; set; }
        public virtual DbSet<TblEmployeeMenuMapping> TblEmployeeMenuMappings { get; set; }
        public virtual DbSet<TblEmployeePayrollDetail> TblEmployeePayrollDetails { get; set; }
        public virtual DbSet<TblEmployeeReportingMapping> TblEmployeeReportingMappings { get; set; }
        public virtual DbSet<TblEmployeeSalary> TblEmployeeSalaries { get; set; }
        public virtual DbSet<TblEmployeeWebLogin> TblEmployeeWebLogins { get; set; }
        public virtual DbSet<TblHolidayPolicyMapping> TblHolidayPolicyMappings { get; set; }
        public virtual DbSet<TblLeave> TblLeaves { get; set; }
        public virtual DbSet<TblLeavePolicyMapping> TblLeavePolicyMappings { get; set; }
        public virtual DbSet<TblMasterAttendancePolicy> TblMasterAttendancePolicies { get; set; }
        public virtual DbSet<TblMasterComboPolicy> TblMasterComboPolicies { get; set; }
        public virtual DbSet<TblMasterHolidayList> TblMasterHolidayLists { get; set; }
        public virtual DbSet<TblMasterHolidayPolicy> TblMasterHolidayPolicies { get; set; }
        public virtual DbSet<TblMasterLeavePolicy> TblMasterLeavePolicies { get; set; }
        public virtual DbSet<TblMasterLeaveSubPolicy> TblMasterLeaveSubPolicies { get; set; }
        public virtual DbSet<TblMasterMenuList> TblMasterMenuLists { get; set; }
        public virtual DbSet<TblMasterPayrollSetting> TblMasterPayrollSettings { get; set; }
        public virtual DbSet<TblMasterPermissionPolicy> TblMasterPermissionPolicies { get; set; }
        public virtual DbSet<TblMasterShiftPolicy> TblMasterShiftPolicies { get; set; }
        public virtual DbSet<TblMasterWeekoffPolicy> TblMasterWeekoffPolicies { get; set; }
        public virtual DbSet<TblOrganization> TblOrganizations { get; set; }
        public virtual DbSet<TblOrganizationRole> TblOrganizationRoles { get; set; }
        public virtual DbSet<TblPermission> TblPermissions { get; set; }
        public virtual DbSet<TblShiftPolicyMapping> TblShiftPolicyMappings { get; set; }
        public virtual DbSet<TblWeekoffPolicyMapping> TblWeekoffPolicyMappings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=106.51.127.87;Database=HRMS;User ID=hrms;Password=hrms@123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblAttedancePolicyMapping>(entity =>
            {
                entity.HasKey(e => new { e.AttendancePolicyMappingId, e.OrganizationId, e.EmployeeId })
                    .HasName("PK__tbl_atte__BF2DB5653EE532D4");

                entity.ToTable("tbl_attedance_policy_mapping");

                entity.Property(e => e.AttendancePolicyMappingId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("attendance_policy_mapping_Id");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_Id");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_Id");

                entity.Property(e => e.AttendancePolicyId).HasColumnName("attendance_policy_Id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<TblComboPolicyMapping>(entity =>
            {
                entity.HasKey(e => new { e.ComboPolicyMappingId, e.OrganizationId, e.EmployeeId })
                    .HasName("PK__tbl_comb__091EB42BDA8FCBF4");

                entity.ToTable("tbl_combo_policy_mapping");

                entity.Property(e => e.ComboPolicyMappingId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("combo_policy_mapping_Id");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_Id");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_Id");

                entity.Property(e => e.ComboPolicyId).HasColumnName("combo_policy_Id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<TblCombooff>(entity =>
            {
                entity.HasKey(e => e.ComboId)
                    .HasName("PK__tbl_comb__18F6468B79BA15E1");

                entity.ToTable("tbl_combooff");

                entity.Property(e => e.ComboId).HasColumnName("combo_Id");

                entity.Property(e => e.ApprovedStatus).HasColumnName("approved_status");

                entity.Property(e => e.ComboEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("combo_end_date");

                entity.Property(e => e.ComboPolicyId).HasColumnName("combo_policy_Id");

                entity.Property(e => e.ComboStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("combo_start_date");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_Id");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_Id");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<TblEmployeAddress>(entity =>
            {
                entity.HasKey(e => e.AddressId)
                    .HasName("PK__tbl_empl__CAA247C8DDBDE6E3");

                entity.ToTable("tbl_employe_address");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("address1");

                entity.Property(e => e.Address2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("address2");

                entity.Property(e => e.Address3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("address3");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_Id");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_Id");

                entity.Property(e => e.PinCode).HasColumnName("pin_code");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("state");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<TblEmployee>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.OrganizationId, e.EmployeeCode });

                entity.ToTable("tbl_employee");

                entity.Property(e => e.EmployeeId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("employee_Id");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_Id");

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("employee_code");

                entity.Property(e => e.BiometricMappingId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("biometric_mapping_id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.EmployeeContactNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("employee_contact_no");

                entity.Property(e => e.EmployeeCurrentAddress).HasColumnName("employee_current_address");

                entity.Property(e => e.EmployeeDesignation).HasColumnName("employee_designation");

                entity.Property(e => e.EmployeeDob)
                    .HasColumnType("date")
                    .HasColumnName("employee_dob");

                entity.Property(e => e.EmployeeDoj)
                    .HasColumnType("date")
                    .HasColumnName("employee_doj");

                entity.Property(e => e.EmployeeDor)
                    .HasColumnType("date")
                    .HasColumnName("employee_dor");

                entity.Property(e => e.EmployeeEmergencyNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("employee_emergency_no");

                entity.Property(e => e.EmployeeFirstName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("employee_first_name");

                entity.Property(e => e.EmployeeLastName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("employee_last_name");

                entity.Property(e => e.EmployeeMiddleName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("employee_middle_name");

                entity.Property(e => e.EmployeeMotherName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("employee_mother_name");

                entity.Property(e => e.EmployeeOfficalEmail)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("employee_offical_email");

                entity.Property(e => e.EmployeePermenetAddress).HasColumnName("employee_permenet_address");

                entity.Property(e => e.EmployeePersonalEmail)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("employee_personal_email");

                entity.Property(e => e.EmpoyeeFatherName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("empoyee_father_name");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<TblEmployeeAttendance>(entity =>
            {
                entity.HasKey(e => new { e.AttendanceId, e.OrganizationId, e.EmployeeId, e.AttendanceYear, e.AttendanceMonth })
                    .HasName("PK__tbl_empl__B296D93B55B45DE3");

                entity.ToTable("tbl_employee_attendance");

                entity.Property(e => e.AttendanceId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("attendance_Id");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_Id");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_Id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.Day1)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Day10)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Day11)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Day12)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Day13)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Day14)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Day15)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Day16)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Day17)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Day18)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Day19)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Day2)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Day20)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Day21)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Day22)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Day23)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Day24)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Day25)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Day26)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Day27)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Day28)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Day29)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Day3)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Day30)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Day31)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Day4)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Day5)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Day6)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Day7)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Day8)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Day9)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<TblEmployeeBankDetail>(entity =>
            {
                entity.HasKey(e => e.EmployeeBankDetailsId)
                    .HasName("PK__tbl_empl__F2C68E6C5ADC3539");

                entity.ToTable("tbl_employee_bank_details");

                entity.Property(e => e.EmployeeBankDetailsId).HasColumnName("employee_bank_details_Id");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("account_name");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("account_number");

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("bank_name");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("branch_name");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_Id");

                entity.Property(e => e.IfscCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ifsc_code");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_Id");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<TblEmployeeBiomatricLog>(entity =>
            {
                entity.HasKey(e => e.LogEntryId)
                    .HasName("PK__tbl_empl__706632FF77F507BC");

                entity.ToTable("tbl_employee_biomatric_log");

                entity.Property(e => e.LogEntryId).HasColumnName("log_entry_Id");

                entity.Property(e => e.BiometricId)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("biometric_id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.LogEntryDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("log_entry_date_time");

                entity.Property(e => e.OrganizationCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("organization_code");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<TblEmployeeDocument>(entity =>
            {
                entity.HasKey(e => e.EmployeeDocumentId)
                    .HasName("PK__tbl_empl__A3E75CB80DCB598E");

                entity.ToTable("tbl_employee_document");

                entity.Property(e => e.EmployeeDocumentId).HasColumnName("employee_document_Id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.DocuemntFilePath)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("docuemnt_file_path");

                entity.Property(e => e.DocumentName)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("document_name");

                entity.Property(e => e.DocumentType).HasColumnName("document_type");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_Id");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_Id");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<TblEmployeeMenuMapping>(entity =>
            {
                entity.HasKey(e => e.MenuMappingId)
                    .HasName("PK__tbl_empl__34627EAF0C91B210");

                entity.ToTable("tbl_employee_menu_mapping");

                entity.Property(e => e.MenuMappingId).HasColumnName("menu_mapping_Id");

                entity.Property(e => e.BankName).HasColumnName("bank_name");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_Id");

                entity.Property(e => e.MenuId).HasColumnName("menu_Id");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_Id");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<TblEmployeePayrollDetail>(entity =>
            {
                entity.HasKey(e => e.EmployeePayrollDetailsId)
                    .HasName("PK__tbl_empl__191E55D0110E6869");

                entity.ToTable("tbl_employee_payroll_details");

                entity.Property(e => e.EmployeePayrollDetailsId).HasColumnName("employee_payroll_details_Id");

                entity.Property(e => e.BasicAmount)
                    .HasMaxLength(1)
                    .HasColumnName("basic_amount");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DaAmount)
                    .HasMaxLength(1)
                    .HasColumnName("da_amount");

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.EmployeeCross)
                    .HasMaxLength(1)
                    .HasColumnName("employee_cross");

                entity.Property(e => e.EmployeeCtc)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("employee_ctc");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_Id");

                entity.Property(e => e.HraAmount)
                    .HasMaxLength(1)
                    .HasColumnName("hra_amount");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_Id");

                entity.Property(e => e.PaySlipFilePath)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("pay_slip_file_path");

                entity.Property(e => e.PayrollMonth).HasColumnName("payroll_month");

                entity.Property(e => e.PayrollYear).HasColumnName("payroll_year");

                entity.Property(e => e.PfEmployee)
                    .HasMaxLength(1)
                    .HasColumnName("pf_employee");

                entity.Property(e => e.PfEmployeer)
                    .HasMaxLength(1)
                    .HasColumnName("pf_employeer");

                entity.Property(e => e.ProfessionalTax)
                    .HasMaxLength(1)
                    .HasColumnName("professional_tax");

                entity.Property(e => e.SpeicalAllowance)
                    .HasMaxLength(1)
                    .HasColumnName("speical_allowance");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<TblEmployeeReportingMapping>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeMappingId, e.OrganizationId, e.EmployeeId })
                    .HasName("PK__tbl_empl__C6D0DCB1091F3A56");

                entity.ToTable("tbl_employee_reporting_mapping");

                entity.Property(e => e.EmployeeMappingId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("employee_mapping_Id");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_Id");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_Id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.FirstLevelReporting).HasColumnName("first_level_reporting");

                entity.Property(e => e.SecondLevelReporting).HasColumnName("second_level_reporting");

                entity.Property(e => e.ThirdLevelReporting).HasColumnName("third_level_reporting");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<TblEmployeeSalary>(entity =>
            {
                entity.HasKey(e => e.EmployeeSalaryInfoId)
                    .HasName("PK__tbl_empl__5C5B7B90771F4775");

                entity.ToTable("tbl_employee_salary");

                entity.Property(e => e.EmployeeSalaryInfoId).HasColumnName("employee_salary_info_Id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_Id");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_Id");

                entity.Property(e => e.SalaryAnualCross)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("salary_anual_cross");

                entity.Property(e => e.SalaryAnualCtc)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("salary_anual_ctc");

                entity.Property(e => e.SalaryMonth).HasColumnName("salary_month");

                entity.Property(e => e.SalaryMonthCross)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("salary__month_cross");

                entity.Property(e => e.SalaryMonthCtc)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("Salary_month_ctc");

                entity.Property(e => e.SalaryYear).HasColumnName("salary_year");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<TblEmployeeWebLogin>(entity =>
            {
                entity.HasKey(e => e.LogEntryId)
                    .HasName("PK__tbl_empl__706632FF566C05C7");

                entity.ToTable("tbl_employee_web_login");

                entity.Property(e => e.LogEntryId).HasColumnName("log_entry_Id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_Id");

                entity.Property(e => e.LogEntryDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("log_entry_date_time");

                entity.Property(e => e.LogType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("log_type");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_Id");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<TblHolidayPolicyMapping>(entity =>
            {
                entity.HasKey(e => new { e.HolidayPolicyMappingId, e.OrganizationId, e.EmployeeId })
                    .HasName("PK__tbl_holi__E3D25386B0CE9DF7");

                entity.ToTable("tbl_holiday_policy_mapping");

                entity.Property(e => e.HolidayPolicyMappingId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("holiday_policy_mapping_Id");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_Id");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_Id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.HolidayPolicyId).HasColumnName("holiday_policy_Id");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<TblLeave>(entity =>
            {
                entity.HasKey(e => e.LeaveId)
                    .HasName("PK__tbl_leav__743C549440AC1E30");

                entity.ToTable("tbl_leave");

                entity.Property(e => e.LeaveId).HasColumnName("leave_Id");

                entity.Property(e => e.ApprovedStatus).HasColumnName("approved_status");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_Id");

                entity.Property(e => e.LeaveDays)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("leave_days");

                entity.Property(e => e.LeaveEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("leave_end_date");

                entity.Property(e => e.LeavePolicyId).HasColumnName("leave_policy_Id");

                entity.Property(e => e.LeaveStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("leave_start_date");

                entity.Property(e => e.LeaveTypeId).HasColumnName("leave_type_Id");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_Id");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<TblLeavePolicyMapping>(entity =>
            {
                entity.HasKey(e => new { e.LeavePolicyMappingId, e.OrganizationId, e.EmployeeId })
                    .HasName("PK__tbl_leav__F0BA63ECB7604EC2");

                entity.ToTable("tbl_leave_policy_mapping");

                entity.Property(e => e.LeavePolicyMappingId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("leave_policy_mapping_Id");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_Id");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_Id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.LeavePolicyId).HasColumnName("leave_policy_Id");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<TblMasterAttendancePolicy>(entity =>
            {
                entity.HasKey(e => new { e.AttendancePolicyId, e.OrganizationId });

                entity.ToTable("tbl_master_attendance_policy");

                entity.Property(e => e.AttendancePolicyId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("attendance_policy_Id");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_Id");

                entity.Property(e => e.AttendaceFlag).HasColumnName("attendace_flag");

                entity.Property(e => e.AttendacePolicyName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("attendace_policy_name");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.LoginType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("login_type");

                entity.Property(e => e.LopFlag).HasColumnName("lop_flag");

                entity.Property(e => e.LopHours).HasColumnName("lop_hours");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<TblMasterComboPolicy>(entity =>
            {
                entity.HasKey(e => new { e.ComboPolicyId, e.OrganizationId });

                entity.ToTable("tbl_master_combo_policy");

                entity.Property(e => e.ComboPolicyId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("combo_policy_Id");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_Id");

                entity.Property(e => e.ComboMinHours)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("combo_min_hours");

                entity.Property(e => e.ComboPolicyName)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("combo_policy_name");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<TblMasterHolidayList>(entity =>
            {
                entity.HasKey(e => new { e.HolidayPolicylistId, e.OrganizationId });

                entity.ToTable("tbl_master_holiday_list");

                entity.Property(e => e.HolidayPolicylistId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("holiday_policylist_Id");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.HolidayDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("holiday_date");

                entity.Property(e => e.HolidayMonth).HasColumnName("holiday_month");

                entity.Property(e => e.HolidayPolicyId).HasColumnName("holiday_policy_Id");

                entity.Property(e => e.HolidayYear).HasColumnName("holiday_year");

                entity.Property(e => e.Holidayname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("holidayname");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<TblMasterHolidayPolicy>(entity =>
            {
                entity.HasKey(e => new { e.HolidayPolicyId, e.OrganizationId });

                entity.ToTable("tbl_master_holiday_policy");

                entity.Property(e => e.HolidayPolicyId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("holiday_policy_Id");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.HolidayPolicyName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("holiday_policy_name");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<TblMasterLeavePolicy>(entity =>
            {
                entity.HasKey(e => new { e.LeavePolicyId, e.OrganizationId });

                entity.ToTable("tbl_master_leave_policy");

                entity.Property(e => e.LeavePolicyId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("leave_policy_id");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.LeavePolicyType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("leave_policy_type");

                entity.Property(e => e.LeaveType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("leave_type");

                entity.Property(e => e.LeaveTypeShortName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("leave_type_short_name");

                entity.Property(e => e.TotalLeaveDays).HasColumnName("total_leave_days");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<TblMasterLeaveSubPolicy>(entity =>
            {
                entity.HasKey(e => new { e.LeaveSubPolicyId, e.OrganizationId })
                    .HasName("PK_tbl_master_leave_sub_policy_1");

                entity.ToTable("tbl_master_leave_sub_policy");

                entity.Property(e => e.LeaveSubPolicyId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("leave_sub_policy_id");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_id");

                entity.Property(e => e.CarryForwardDays).HasColumnName("carry_forward_days");

                entity.Property(e => e.CarryForwardFlag).HasColumnName("carry_forward_flag");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.LeaveDays).HasColumnName("leave_days");

                entity.Property(e => e.LeavePolicyId).HasColumnName("leave_policy_id");

                entity.Property(e => e.LeaveType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("leave_type");

                entity.Property(e => e.LeaveTypeShortName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("leave_type_short_name");

                entity.Property(e => e.PaidLeaveFlag).HasColumnName("paid_leave_flag");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<TblMasterMenuList>(entity =>
            {
                entity.HasKey(e => new { e.MenuId, e.OrganizationId });

                entity.ToTable("tbl_master_menu_list");

                entity.Property(e => e.MenuId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("menu_Id");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_Id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.MenuName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("menu_name");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<TblMasterPayrollSetting>(entity =>
            {
                entity.HasKey(e => new { e.PayrollPolicyId, e.OrganizationId });

                entity.ToTable("tbl_master_payroll_setting");

                entity.Property(e => e.PayrollPolicyId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("payroll_policy_Id");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_Id");

                entity.Property(e => e.BasicPercentage)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("basic_percentage");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DaPercentage)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("da_percentage");

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.HraPercentage)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("hra_percentage");

                entity.Property(e => e.PayrollPolicyName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("payroll_policy_name");

                entity.Property(e => e.PfEmployeeAmount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("pf_employee_amount");

                entity.Property(e => e.ProfessionalTax)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("professional_tax");

                entity.Property(e => e.SpecialAllowance)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("special_allowance");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<TblMasterPermissionPolicy>(entity =>
            {
                entity.HasKey(e => new { e.PermissionPolicyId, e.OrganizationId });

                entity.ToTable("tbl_master_permission_policy");

                entity.Property(e => e.PermissionPolicyId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("permission_policy_Id");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_Id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.PemissionCount).HasColumnName("pemission_count");

                entity.Property(e => e.PemissionMins).HasColumnName("pemission_mins");

                entity.Property(e => e.PemissionPolicyType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pemission_policy_type");

                entity.Property(e => e.PermissionPolicyName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("permission_policy_name");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<TblMasterShiftPolicy>(entity =>
            {
                entity.HasKey(e => new { e.ShiftPolicyId, e.OrganizationId });

                entity.ToTable("tbl_master_shift_policy");

                entity.Property(e => e.ShiftPolicyId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("shift_policy_Id");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_Id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.ShiftEndTime)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("shift_end_time");

                entity.Property(e => e.ShiftHours).HasColumnName("shift_hours");

                entity.Property(e => e.ShiftPolicyName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("shift_policy_name");

                entity.Property(e => e.ShiftStartTime)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("shift_start_time");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<TblMasterWeekoffPolicy>(entity =>
            {
                entity.HasKey(e => new { e.WeekoffPolicyId, e.OrganizationId });

                entity.ToTable("tbl_master_weekoff_policy");

                entity.Property(e => e.WeekoffPolicyId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("weekoff_policy_Id");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.Property(e => e.WeekoffDays)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("weekoff_days");

                entity.Property(e => e.WeekoffPolicyName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("weekoff_policy_name");
            });

            modelBuilder.Entity<TblOrganization>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationId, e.OrganizationCode });

                entity.ToTable("tbl_organization");

                entity.Property(e => e.OrganizationId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("organization_Id");

                entity.Property(e => e.OrganizationCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("organization_code");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.OrganizationAddress1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("organization_address1");

                entity.Property(e => e.OrganizationAddress2)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("organization_address2");

                entity.Property(e => e.OrganizationContact)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("organization_contact");

                entity.Property(e => e.OrganizationEmail)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("organization_email");

                entity.Property(e => e.OrganizationLogo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("organization_logo");

                entity.Property(e => e.OrganizationName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("organization_name");

                entity.Property(e => e.OrganizationType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("organization_type");

                entity.Property(e => e.PinCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("pin_code");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("state");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<TblOrganizationRole>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.OrganizationId });

                entity.ToTable("tbl_organization_role");

                entity.Property(e => e.RoleId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("role_id");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("role_name");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<TblPermission>(entity =>
            {
                entity.HasKey(e => e.PemissionId)
                    .HasName("PK__tbl_perm__101DF0C7311746E7");

                entity.ToTable("tbl_permission");

                entity.Property(e => e.PemissionId).HasColumnName("pemission_Id");

                entity.Property(e => e.ApprovedStatus).HasColumnName("approved_status");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_Id");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_Id");

                entity.Property(e => e.PemissionPolicyId).HasColumnName("pemission_policy_Id");

                entity.Property(e => e.PermissionStartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("permission_start_time");

                entity.Property(e => e.PesmissionEndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("pesmission_end_time");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<TblShiftPolicyMapping>(entity =>
            {
                entity.HasKey(e => new { e.ShiftPolicyMappingId, e.OrganizationId, e.EmployeeId })
                    .HasName("PK__tbl_shif__2438ADB84CDDD8C7");

                entity.ToTable("tbl_shift_policy_mapping");

                entity.Property(e => e.ShiftPolicyMappingId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("shift_policy_mapping_Id");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_Id");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_Id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.ShiftPolicyId).HasColumnName("shift_policy_Id");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<TblWeekoffPolicyMapping>(entity =>
            {
                entity.HasKey(e => new { e.WeekoffPolicyMappingId, e.OrganizationId, e.EmployeeId })
                    .HasName("PK__tbl_week__A44F72CBD121D624");

                entity.ToTable("tbl_weekoff_policy_mapping");

                entity.Property(e => e.WeekoffPolicyMappingId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("weekoff_policy_mapping_Id");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_Id");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_Id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.Property(e => e.WeekoffPolicyId).HasColumnName("weekoff_policy_Id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
