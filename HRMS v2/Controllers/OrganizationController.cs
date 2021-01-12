using Microsoft.AspNetCore.Mvc;
using HRMS_v2.Interface;
using HRMS_v2.ViewModel.InModel;
using HRMS_v2.ViewModel.OutModel;
using HRMS_v2.Helper;
using CommonLibrary.LogMethod;
using System;

namespace HRMS.Controllers
{
    //Define the end point for the organization api
    [Route("api/v1/[controller]/{action}")]
    [ApiController]
    public class OrganizationController : ControllerBase
    {
        LogModel logModel = new LogModel();
        Log log = new Log();
        private readonly IOrganization _organization_details;
        public OrganizationController(IOrganization organization_details)
        {

            _organization_details = organization_details;
        }

        /// <summary>
        /// Function for checking the given organizational details already exists in organization table or not
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult check_by_key([FromQuery]API0006_InModel input)
        {
            try
            {
                IActionResult output = null;
                if (!ModelState.IsValid) 
                {
                    //Log the logType and message of the given request
                    logModel.LogType = LogTypes.Error;
                    logModel.Message = "BadRequest in organization delete method";
                    
                    //If ModelState is not Valid invoke the BadRequest method in ResponseGenerator class
                    output = ResponseGenerator.BadRequest(null, eResponseMessages.NoTokenInformation); 
                }
                else
                {
                    //If ModelState is Valid, invoke the method in business logic layer using interface
                    var response = _organization_details.check_organization_details_exists(input.organization_code, input.organization_email, input.organization_contact);

                    //Create a object using API0006_OutModel class
                    API0006_OutModel api0006_response_model = new API0006_OutModel();

                    if(response > 0)
                    {
                        //If given organization value already exists, set organization_status to true
                        api0006_response_model.organization_status = true;
                    }
                    else
                    {
                        //If given organization value not exists, set organization_status to false
                        api0006_response_model.organization_status = false;
                    }

                    //Log the logType and message of the given request
                    logModel.LogType = LogTypes.Information;
                    logModel.Message = "Success in organization validation method";


                    output = ResponseGenerator.Ok(api0006_response_model);
                    
                }

                //code for write the logmodel into log file
                log.LogWrite(logModel);

                return output;
            }
            catch(Exception ex)
            {
                //Log the logType and message of the given request
                logModel.LogType = LogTypes.Error;
                logModel.Message = ex.ToString();

                //code for write the logmodel into log file
                log.LogWrite(logModel);

                return ResponseGenerator.BadRequest(ex.ToString(), eResponseMessages.NoTokenInformation); 
            }
        }

        /// <summary>
        /// Function for checking the given organizational details already exists in organization table or not
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpDelete]
        public IActionResult delete([FromQuery]API0003_InModel input)
        {
            
            try
            {
                IActionResult output = null;
                if (!ModelState.IsValid) 
                {
                    //Log the logType and message of the given request
                    logModel.LogType = LogTypes.Error;
                    logModel.Message = "BadRequest in organization delete method";

                    //If ModelState is not Valid invoke the BadRequest method in ResponseGenerator class
                    output = ResponseGenerator.BadRequest(null, eResponseMessages.NoTokenInformation); 
                }
                else
                {
                    //If ModelState is Valid, invoke the method in business logic layer using interface
                    var api0003_response = _organization_details.delete_organization_details((int)input.organization_Id);
                    
                    if(api0003_response == true)
                    {
                        //Log the logType and message of the given request
                        logModel.LogType = LogTypes.Information;
                        logModel.Message = "Success in organization delete method.";

                        output = ResponseGenerator.Ok(null);
                    }
                    else
                    {
                        //Log the logType and message of the given request
                        logModel.LogType = LogTypes.Information;
                        logModel.Message = "Record not found or Error occured.";

                        output = ResponseGenerator.Ok(null, eResponseMessages.RecordNotFound); 
                    }
                }

                //code for write the logmodel into log file
                log.LogWrite(logModel);

                return output;
            }
            catch(Exception ex)
            {
                //Log the logType and message of the given request
                logModel.LogType = LogTypes.Error;
                logModel.Message = ex.ToString();

                //code for write the logmodel into log file
                log.LogWrite(logModel);

                return ResponseGenerator.BadRequest(ex.ToString(), eResponseMessages.NoTokenInformation); 
            }
        }
    }
}