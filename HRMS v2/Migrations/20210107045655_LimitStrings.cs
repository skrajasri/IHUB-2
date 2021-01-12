using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HRMS_v2.Migrations
{
    public partial class LimitStrings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_attedance_policy_mapping",
                columns: table => new
                {
                    attendance_policy_mapping_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organization_Id = table.Column<int>(type: "int", nullable: false),
                    employee_Id = table.Column<int>(type: "int", nullable: false),
                    attendance_policy_Id = table.Column<int>(type: "int", nullable: false),
                    del_flag = table.Column<bool>(type: "bit", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_atte__BF2DB5653EE532D4", x => new { x.attendance_policy_mapping_Id, x.organization_Id, x.employee_Id });
                });

            migrationBuilder.CreateTable(
                name: "tbl_combo_policy_mapping",
                columns: table => new
                {
                    combo_policy_mapping_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organization_Id = table.Column<int>(type: "int", nullable: false),
                    employee_Id = table.Column<int>(type: "int", nullable: false),
                    combo_policy_Id = table.Column<int>(type: "int", nullable: false),
                    del_flag = table.Column<bool>(type: "bit", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_comb__091EB42BDA8FCBF4", x => new { x.combo_policy_mapping_Id, x.organization_Id, x.employee_Id });
                });

            migrationBuilder.CreateTable(
                name: "tbl_combooff",
                columns: table => new
                {
                    combo_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organization_Id = table.Column<int>(type: "int", nullable: false),
                    employee_Id = table.Column<int>(type: "int", nullable: false),
                    combo_policy_Id = table.Column<int>(type: "int", nullable: false),
                    combo_start_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    combo_end_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    approved_status = table.Column<bool>(type: "bit", nullable: true),
                    del_flag = table.Column<bool>(type: "bit", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_comb__18F6468B79BA15E1", x => x.combo_Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_employe_address",
                columns: table => new
                {
                    address_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organization_Id = table.Column<int>(type: "int", nullable: false),
                    employee_Id = table.Column<int>(type: "int", nullable: false),
                    address1 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    address2 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    address3 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    city = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    state = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    pin_code = table.Column<int>(type: "int", nullable: false),
                    del_flag = table.Column<bool>(type: "bit", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_empl__CAA247C8DDBDE6E3", x => x.address_id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_employee",
                columns: table => new
                {
                    employee_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organization_Id = table.Column<int>(type: "int", nullable: false),
                    employee_code = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    gender = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    employee_dob = table.Column<DateTime>(type: "date", nullable: false),
                    employee_offical_email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    employee_first_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    employee_middle_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    employee_last_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    employee_designation = table.Column<int>(type: "int", nullable: false),
                    employee_doj = table.Column<DateTime>(type: "date", nullable: false),
                    employee_dor = table.Column<DateTime>(type: "date", nullable: true),
                    empoyee_father_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    employee_mother_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    employee_current_address = table.Column<int>(type: "int", nullable: false),
                    employee_permenet_address = table.Column<int>(type: "int", nullable: false),
                    employee_contact_no = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    employee_emergency_no = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    employee_personal_email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    role_id = table.Column<int>(type: "int", nullable: false),
                    biometric_mapping_id = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    del_flag = table.Column<bool>(type: "bit", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_empl__2C6B611403CFCA71", x => new { x.employee_Id, x.organization_Id, x.employee_code, x.gender, x.employee_dob, x.employee_offical_email });
                });

            migrationBuilder.CreateTable(
                name: "tbl_employee_attendance",
                columns: table => new
                {
                    attendance_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organization_Id = table.Column<int>(type: "int", nullable: false),
                    employee_Id = table.Column<int>(type: "int", nullable: false),
                    AttendanceYear = table.Column<int>(type: "int", nullable: false),
                    AttendanceMonth = table.Column<int>(type: "int", nullable: false),
                    Day1 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Day2 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Day3 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Day4 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Day5 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Day6 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Day7 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Day8 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Day9 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Day10 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Day11 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Day12 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Day13 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Day14 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Day15 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Day16 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Day17 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Day18 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Day19 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Day20 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Day21 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Day22 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Day23 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Day24 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Day25 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Day26 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Day27 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Day28 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Day29 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Day30 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Day31 = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    del_flag = table.Column<bool>(type: "bit", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_empl__B296D93B55B45DE3", x => new { x.attendance_Id, x.organization_Id, x.employee_Id, x.AttendanceYear, x.AttendanceMonth });
                });

            migrationBuilder.CreateTable(
                name: "tbl_employee_bank_details",
                columns: table => new
                {
                    employee_bank_details_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organization_Id = table.Column<int>(type: "int", nullable: false),
                    employee_Id = table.Column<int>(type: "int", nullable: false),
                    account_name = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    bank_name = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    branch_name = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    ifsc_code = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    account_number = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    del_flag = table.Column<bool>(type: "bit", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_empl__F2C68E6C5ADC3539", x => x.employee_bank_details_Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_employee_biomatric_log",
                columns: table => new
                {
                    log_entry_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organization_code = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    biometric_id = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    log_entry_date_time = table.Column<DateTime>(type: "datetime", nullable: false),
                    del_flag = table.Column<bool>(type: "bit", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_empl__706632FF77F507BC", x => x.log_entry_Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_employee_document",
                columns: table => new
                {
                    employee_document_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organization_Id = table.Column<int>(type: "int", nullable: false),
                    employee_Id = table.Column<int>(type: "int", nullable: false),
                    document_name = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    document_type = table.Column<int>(type: "int", nullable: false),
                    docuemnt_file_path = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    del_flag = table.Column<bool>(type: "bit", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_empl__A3E75CB80DCB598E", x => x.employee_document_Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_employee_menu_mapping",
                columns: table => new
                {
                    menu_mapping_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organization_Id = table.Column<int>(type: "int", nullable: false),
                    employee_Id = table.Column<int>(type: "int", nullable: false),
                    menu_Id = table.Column<int>(type: "int", nullable: false),
                    bank_name = table.Column<int>(type: "int", nullable: false),
                    del_flag = table.Column<bool>(type: "bit", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_empl__34627EAF0C91B210", x => x.menu_mapping_Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_employee_payroll_details",
                columns: table => new
                {
                    employee_payroll_details_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organization_Id = table.Column<int>(type: "int", nullable: false),
                    employee_Id = table.Column<int>(type: "int", nullable: false),
                    payroll_month = table.Column<int>(type: "int", nullable: false),
                    payroll_year = table.Column<int>(type: "int", nullable: false),
                    employee_ctc = table.Column<byte[]>(type: "varbinary(1)", maxLength: 1, nullable: false),
                    employee_cross = table.Column<byte[]>(type: "varbinary(1)", maxLength: 1, nullable: true),
                    pf_employee = table.Column<byte[]>(type: "varbinary(1)", maxLength: 1, nullable: true),
                    pf_employeer = table.Column<byte[]>(type: "varbinary(1)", maxLength: 1, nullable: true),
                    professional_tax = table.Column<byte[]>(type: "varbinary(1)", maxLength: 1, nullable: true),
                    hra_amount = table.Column<byte[]>(type: "varbinary(1)", maxLength: 1, nullable: true),
                    da_amount = table.Column<byte[]>(type: "varbinary(1)", maxLength: 1, nullable: true),
                    basic_amount = table.Column<byte[]>(type: "varbinary(1)", maxLength: 1, nullable: true),
                    speical_allowance = table.Column<byte[]>(type: "varbinary(1)", maxLength: 1, nullable: true),
                    pay_slip_file_path = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    del_flag = table.Column<bool>(type: "bit", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_empl__191E55D0110E6869", x => x.employee_payroll_details_Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_employee_reporting_mapping",
                columns: table => new
                {
                    employee_mapping_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organization_Id = table.Column<int>(type: "int", nullable: false),
                    employee_Id = table.Column<int>(type: "int", nullable: false),
                    first_level_reporting = table.Column<int>(type: "int", nullable: false),
                    second_level_reporting = table.Column<int>(type: "int", nullable: true),
                    third_level_reporting = table.Column<int>(type: "int", nullable: true),
                    del_flag = table.Column<bool>(type: "bit", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_empl__C6D0DCB1091F3A56", x => new { x.employee_mapping_Id, x.organization_Id, x.employee_Id });
                });

            migrationBuilder.CreateTable(
                name: "tbl_employee_salary",
                columns: table => new
                {
                    employee_salary_info_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organization_Id = table.Column<int>(type: "int", nullable: false),
                    employee_Id = table.Column<int>(type: "int", nullable: false),
                    salary_year = table.Column<int>(type: "int", nullable: false),
                    salary_month = table.Column<int>(type: "int", nullable: false),
                    salary_anual_ctc = table.Column<byte[]>(type: "varbinary(1)", maxLength: 1, nullable: false),
                    Salary_month_ctc = table.Column<byte[]>(type: "varbinary(1)", maxLength: 1, nullable: false),
                    salary_anual_cross = table.Column<byte[]>(type: "varbinary(1)", maxLength: 1, nullable: false),
                    salary__month_cross = table.Column<byte[]>(type: "varbinary(1)", maxLength: 1, nullable: false),
                    del_flag = table.Column<bool>(type: "bit", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_empl__5C5B7B90771F4775", x => x.employee_salary_info_Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_employee_web_login",
                columns: table => new
                {
                    log_entry_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organization_Id = table.Column<int>(type: "int", nullable: false),
                    employee_Id = table.Column<int>(type: "int", nullable: false),
                    log_type = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    log_entry_date_time = table.Column<DateTime>(type: "datetime", nullable: false),
                    del_flag = table.Column<bool>(type: "bit", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_empl__706632FF566C05C7", x => x.log_entry_Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_holiday_policy_mapping",
                columns: table => new
                {
                    holiday_policy_mapping_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organization_Id = table.Column<int>(type: "int", nullable: false),
                    employee_Id = table.Column<int>(type: "int", nullable: false),
                    holiday_policy_Id = table.Column<int>(type: "int", nullable: false),
                    del_flag = table.Column<bool>(type: "bit", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_holi__E3D25386B0CE9DF7", x => new { x.holiday_policy_mapping_Id, x.organization_Id, x.employee_Id });
                });

            migrationBuilder.CreateTable(
                name: "tbl_leave",
                columns: table => new
                {
                    leave_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organization_Id = table.Column<int>(type: "int", nullable: false),
                    employee_Id = table.Column<int>(type: "int", nullable: false),
                    leave_type_Id = table.Column<int>(type: "int", nullable: false),
                    leave_policy_Id = table.Column<int>(type: "int", nullable: false),
                    leave_start_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    leave_end_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    leave_days = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    approved_status = table.Column<bool>(type: "bit", nullable: true),
                    del_flag = table.Column<bool>(type: "bit", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_leav__743C549440AC1E30", x => x.leave_Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_leave_policy_mapping",
                columns: table => new
                {
                    leave_policy_mapping_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organization_Id = table.Column<int>(type: "int", nullable: false),
                    employee_Id = table.Column<int>(type: "int", nullable: false),
                    leave_policy_Id = table.Column<int>(type: "int", nullable: false),
                    del_flag = table.Column<bool>(type: "bit", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_leav__F0BA63ECB7604EC2", x => new { x.leave_policy_mapping_Id, x.organization_Id, x.employee_Id });
                });

            migrationBuilder.CreateTable(
                name: "tbl_master_attendance_policy",
                columns: table => new
                {
                    attendance_policy_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organization_Id = table.Column<int>(type: "int", nullable: false),
                    attendace_policy_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    lop_flag = table.Column<bool>(type: "bit", nullable: false),
                    login_type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    attendace_flag = table.Column<bool>(type: "bit", nullable: false),
                    lop_hours = table.Column<int>(type: "int", nullable: false),
                    del_flag = table.Column<bool>(type: "bit", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_mast__820552CE3C6652C0", x => new { x.attendance_policy_Id, x.organization_Id, x.attendace_policy_name, x.lop_flag, x.login_type, x.attendace_flag });
                });

            migrationBuilder.CreateTable(
                name: "tbl_master_combo_policy",
                columns: table => new
                {
                    combo_policy_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organization_Id = table.Column<int>(type: "int", nullable: false),
                    combo_policy_name = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    combo_min_hours = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    del_flag = table.Column<bool>(type: "bit", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_mast__141AF1EA8DA91F84", x => new { x.combo_policy_Id, x.organization_Id, x.combo_policy_name, x.combo_min_hours });
                });

            migrationBuilder.CreateTable(
                name: "tbl_master_holiday_list",
                columns: table => new
                {
                    holiday_policylist_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organization_id = table.Column<int>(type: "int", nullable: false),
                    holiday_policy_Id = table.Column<int>(type: "int", nullable: false),
                    holiday_date = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    holiday_year = table.Column<int>(type: "int", nullable: false),
                    holiday_month = table.Column<int>(type: "int", nullable: false),
                    holidayname = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    del_flag = table.Column<bool>(type: "bit", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_mast__87570F718E0B3FDA", x => new { x.holiday_policylist_Id, x.organization_id, x.holiday_policy_Id, x.holiday_date, x.holiday_year, x.holiday_month });
                });

            migrationBuilder.CreateTable(
                name: "tbl_master_holiday_policy",
                columns: table => new
                {
                    holiday_policy_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organization_id = table.Column<int>(type: "int", nullable: false),
                    holiday_policy_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    del_flag = table.Column<bool>(type: "bit", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_mast__2198DBB52A9AD866", x => new { x.holiday_policy_Id, x.organization_id, x.holiday_policy_name });
                });

            migrationBuilder.CreateTable(
                name: "tbl_master_leave_policy",
                columns: table => new
                {
                    leave_policy_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organization_id = table.Column<int>(type: "int", nullable: false),
                    leave_policy_type = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    leave_type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    leave_type_short_name = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    total_leave_days = table.Column<int>(type: "int", nullable: false),
                    del_flag = table.Column<bool>(type: "bit", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_mast__459170E5590C09B5", x => new { x.leave_policy_id, x.organization_id, x.leave_policy_type, x.leave_type, x.leave_type_short_name });
                });

            migrationBuilder.CreateTable(
                name: "tbl_master_leave_sub_policy",
                columns: table => new
                {
                    leave_sub_policy_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organization_id = table.Column<int>(type: "int", nullable: false),
                    leave_policy_id = table.Column<int>(type: "int", nullable: false),
                    leave_type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    leave_type_short_name = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    leave_days = table.Column<double>(type: "float", nullable: false),
                    carry_forward_days = table.Column<double>(type: "float", nullable: true),
                    carry_forward_flag = table.Column<bool>(type: "bit", nullable: true),
                    paid_leave_flag = table.Column<bool>(type: "bit", nullable: false),
                    del_flag = table.Column<bool>(type: "bit", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_mast__CBFCAA9A9743027B", x => new { x.leave_sub_policy_id, x.organization_id, x.leave_policy_id, x.leave_type, x.leave_type_short_name });
                });

            migrationBuilder.CreateTable(
                name: "tbl_master_menu_list",
                columns: table => new
                {
                    menu_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organization_Id = table.Column<int>(type: "int", nullable: false),
                    menu_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    del_flag = table.Column<bool>(type: "bit", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_mast__8DEFE427BE56ECB6", x => new { x.menu_Id, x.organization_Id, x.menu_name });
                });

            migrationBuilder.CreateTable(
                name: "tbl_master_payroll_setting",
                columns: table => new
                {
                    payroll_policy_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organization_Id = table.Column<int>(type: "int", nullable: false),
                    payroll_policy_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    basic_percentage = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    del_flag = table.Column<bool>(type: "bit", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    hra_percentage = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    da_percentage = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    special_allowance = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    professional_tax = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    pf_employee_amount = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_mast__04A67A302B325933", x => new { x.payroll_policy_Id, x.organization_Id, x.payroll_policy_name, x.basic_percentage, x.del_flag, x.created_date });
                });

            migrationBuilder.CreateTable(
                name: "tbl_master_permission_policy",
                columns: table => new
                {
                    permission_policy_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organization_Id = table.Column<int>(type: "int", nullable: false),
                    permission_policy_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    pemission_policy_type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    pemission_count = table.Column<int>(type: "int", nullable: false),
                    pemission_mins = table.Column<int>(type: "int", nullable: false),
                    del_flag = table.Column<bool>(type: "bit", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_mast__656A89E58838D426", x => new { x.permission_policy_Id, x.organization_Id, x.permission_policy_name, x.pemission_policy_type, x.pemission_count });
                });

            migrationBuilder.CreateTable(
                name: "tbl_master_shift_policy",
                columns: table => new
                {
                    shift_policy_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organization_Id = table.Column<int>(type: "int", nullable: false),
                    shift_policy_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    shift_start_time = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    shift_end_time = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    shift_hours = table.Column<int>(type: "int", nullable: false),
                    del_flag = table.Column<bool>(type: "bit", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_mast__01138C4BEEDD7705", x => new { x.shift_policy_Id, x.organization_Id, x.shift_policy_name, x.shift_start_time, x.shift_end_time });
                });

            migrationBuilder.CreateTable(
                name: "tbl_master_weekoff_policy",
                columns: table => new
                {
                    weekoff_policy_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organization_id = table.Column<int>(type: "int", nullable: false),
                    weekoff_policy_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    weekoff_days = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    del_flag = table.Column<bool>(type: "bit", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_mast__9B7B7198C3966B62", x => new { x.weekoff_policy_Id, x.organization_id, x.weekoff_policy_name, x.weekoff_days });
                });

            migrationBuilder.CreateTable(
                name: "tbl_organization",
                columns: table => new
                {
                    organization_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organization_name = table.Column<int>(type: "int", nullable: false),
                    organization_email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    organization_contact = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    organization_code = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: false),
                    organization_type = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    organization_address1 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    organization_address2 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    city = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    state = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    pin_code = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    organization_logo = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    del_flag = table.Column<bool>(type: "bit", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_orga__EBE7D72C9F4C6DD6", x => new { x.organization_Id, x.organization_name, x.organization_email, x.organization_contact, x.organization_code });
                });

            migrationBuilder.CreateTable(
                name: "tbl_organization_role",
                columns: table => new
                {
                    role_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organization_id = table.Column<int>(type: "int", nullable: false),
                    role_name = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    del_flag = table.Column<bool>(type: "bit", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_orga__FB7A78DB82A7EC4E", x => new { x.role_id, x.organization_id, x.role_name });
                });

            migrationBuilder.CreateTable(
                name: "tbl_permission",
                columns: table => new
                {
                    pemission_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organization_Id = table.Column<int>(type: "int", nullable: false),
                    employee_Id = table.Column<int>(type: "int", nullable: false),
                    pemission_policy_Id = table.Column<int>(type: "int", nullable: false),
                    permission_start_time = table.Column<DateTime>(type: "datetime", nullable: false),
                    pesmission_end_time = table.Column<DateTime>(type: "datetime", nullable: false),
                    approved_status = table.Column<bool>(type: "bit", nullable: true),
                    del_flag = table.Column<bool>(type: "bit", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_perm__101DF0C7311746E7", x => x.pemission_Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_shift_policy_mapping",
                columns: table => new
                {
                    shift_policy_mapping_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organization_Id = table.Column<int>(type: "int", nullable: false),
                    employee_Id = table.Column<int>(type: "int", nullable: false),
                    shift_policy_Id = table.Column<int>(type: "int", nullable: false),
                    del_flag = table.Column<bool>(type: "bit", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_shif__2438ADB84CDDD8C7", x => new { x.shift_policy_mapping_Id, x.organization_Id, x.employee_Id });
                });

            migrationBuilder.CreateTable(
                name: "tbl_weekoff_policy_mapping",
                columns: table => new
                {
                    weekoff_policy_mapping_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organization_Id = table.Column<int>(type: "int", nullable: false),
                    employee_Id = table.Column<int>(type: "int", nullable: false),
                    weekoff_policy_Id = table.Column<int>(type: "int", nullable: false),
                    del_flag = table.Column<bool>(type: "bit", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_week__A44F72CBD121D624", x => new { x.weekoff_policy_mapping_Id, x.organization_Id, x.employee_Id });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_attedance_policy_mapping");

            migrationBuilder.DropTable(
                name: "tbl_combo_policy_mapping");

            migrationBuilder.DropTable(
                name: "tbl_combooff");

            migrationBuilder.DropTable(
                name: "tbl_employe_address");

            migrationBuilder.DropTable(
                name: "tbl_employee");

            migrationBuilder.DropTable(
                name: "tbl_employee_attendance");

            migrationBuilder.DropTable(
                name: "tbl_employee_bank_details");

            migrationBuilder.DropTable(
                name: "tbl_employee_biomatric_log");

            migrationBuilder.DropTable(
                name: "tbl_employee_document");

            migrationBuilder.DropTable(
                name: "tbl_employee_menu_mapping");

            migrationBuilder.DropTable(
                name: "tbl_employee_payroll_details");

            migrationBuilder.DropTable(
                name: "tbl_employee_reporting_mapping");

            migrationBuilder.DropTable(
                name: "tbl_employee_salary");

            migrationBuilder.DropTable(
                name: "tbl_employee_web_login");

            migrationBuilder.DropTable(
                name: "tbl_holiday_policy_mapping");

            migrationBuilder.DropTable(
                name: "tbl_leave");

            migrationBuilder.DropTable(
                name: "tbl_leave_policy_mapping");

            migrationBuilder.DropTable(
                name: "tbl_master_attendance_policy");

            migrationBuilder.DropTable(
                name: "tbl_master_combo_policy");

            migrationBuilder.DropTable(
                name: "tbl_master_holiday_list");

            migrationBuilder.DropTable(
                name: "tbl_master_holiday_policy");

            migrationBuilder.DropTable(
                name: "tbl_master_leave_policy");

            migrationBuilder.DropTable(
                name: "tbl_master_leave_sub_policy");

            migrationBuilder.DropTable(
                name: "tbl_master_menu_list");

            migrationBuilder.DropTable(
                name: "tbl_master_payroll_setting");

            migrationBuilder.DropTable(
                name: "tbl_master_permission_policy");

            migrationBuilder.DropTable(
                name: "tbl_master_shift_policy");

            migrationBuilder.DropTable(
                name: "tbl_master_weekoff_policy");

            migrationBuilder.DropTable(
                name: "tbl_organization");

            migrationBuilder.DropTable(
                name: "tbl_organization_role");

            migrationBuilder.DropTable(
                name: "tbl_permission");

            migrationBuilder.DropTable(
                name: "tbl_shift_policy_mapping");

            migrationBuilder.DropTable(
                name: "tbl_weekoff_policy_mapping");
        }
    }
}
