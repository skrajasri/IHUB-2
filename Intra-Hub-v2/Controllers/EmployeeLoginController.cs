using Microsoft.AspNetCore.Mvc;
using Intra_Hub_v2.Interface;
using Intra_Hub_v2.ViewModel.InModel;
using Intra_Hub_v2.ViewModel.OutModel;
using System.Collections.Generic;
using Intra_Hub_v2.Helper;

namespace HRMS.Controllers
{
    //Define the end point of the Api
    [Route("api/v1/login")]
    [ApiController]
    public class Organization_ValidationController : ControllerBase
    {

        private readonly IEmployeeLogin _employee_login;
        public Organization_ValidationController(IEmployeeLogin employee_login)
        {

            _employee_login = employee_login;
        }

        /// <summary>
        /// Function for getting the details of the login employee
        /// </summary>
        /// <param name="api0001_inValue"></param>
        /// <returns></returns>
        [HttpGet]
        public List<API0001_OutModel> Get([FromQuery]API0001_InModel api0001_inValue)
        {
            var api0001_response = _employee_login.getLoginDetails(api0001_inValue);
            return api0001_response;
        }
    }
}