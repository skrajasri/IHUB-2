using System.ComponentModel.DataAnnotations;

namespace HRMS_v2.ViewModel.InModel
{
    /// <summary>
    /// Input Parameter Declaration for API0006
    /// </summary>
    public class API0006_InModel
    {
        [Required]
        public string organization_code { get; set; } 
        /// <summary>
        /// Regular Expression for email validation
        /// </summary>
        /// <value></value>
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Invalid Mail Address"), Required(ErrorMessage = "Organizational Email is Required")]
        public string organization_email { get; set; } 
        /// <summary>
        /// Regular Expresion for contact number
        /// </summary>
        /// <value></value>
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Invalid Contact Number"), Required(ErrorMessage = "Organization Contact Number is Required")]
        public string organization_contact { get; set; } 
    }
}

