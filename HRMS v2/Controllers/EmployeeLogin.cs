using CommonLibrary;
using CommonLibrary.LogMethod;
using CommonLibrary.Mail;
using HRMS_v2.Helper;
using HRMS_v2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HRMS_v2.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class Employee : ControllerBase
    {
        [HttpGet]
        public async Task<string> Get()
        {
            var DbContent = DB_config.db_conection();

            TblOrganization tblOrganizations = new TblOrganization();
            tblOrganizations.City = "Erunakulam";
            DbContent.TblOrganizations.Add(tblOrganizations);

            //upload Multiple files
            List<string> s = new List<string>();
            s.Add("E:\\a.txt");
            s.Add("E:\\b.txt");
            s.Add("E:\\ac.txt");

            FileOperations.upload(s);

            //How to call Download method.
            FileDownloadBase64String fileinfo = await FileOperations.Download("b.txt");

            // Call Log implementation method.
            //
            LogModel logModel = new LogModel();

            logModel.LogType = LogTypes.Error;
            logModel.Message = "Success";

            Log log = new Log();
            log.LogWrite(logModel);

            // Maill function

            GMailServices gMailServices = new GMailServices();
            gMailServices.SendMail("boseramaa@gmail.com", "Test", "Hello Ramabose");


            // insert and update samples


            //var org = new TblOrganization
            //{
            //    OrganizationName = "",
            //    OrganizationCode = "",
            //    OrganizationEmail = "",
            //    OrganizationAddress1 = "",
            //    OrganizationContact = "",
            //    OrganizationType = "",
            //    OrganizationAddress2 = "",
            //    City = "",
            //    State = "",
            //    PinCode = "",
            //    OrganizationLogo = "",
            //    DelFlag = true,
            //    CreatedDate = DateTime.Now,
            //    UpdatedDate = DateTime.Now,

            //};

            //DbContent.TblOrganizations.Add(org);
            //DbContent.SaveChanges();

            return "Good";
        }
    }
}