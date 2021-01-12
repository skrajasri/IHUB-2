using System.Collections.Generic;
using System.Linq;
using Intra_Hub_v2.Interface;
using Intra_Hub_v2.ViewModel.OutModel;
using Intra_Hub_v2.ViewModel.InModel;
using Intra_Hub_v2.Helper;

namespace Intra_Hub_v2.BussinessLogic
{
    public class EmployeeLogin : IEmployeeLogin
    {
        /// <summary>
        /// Method for get the details of the login employee
        /// </summary>
        /// <param name="api0001_inValue"></param>
        /// <returns></returns>
        public List<API0001_OutModel> getLoginDetails(API0001_InModel api0001_inValue)
        {
            try
            {
                //Connection string for connecting the database
                var DbContent = DB_config.db_conection();
                
                // Query for get the details of the login employee
                var loginDetails = (from cn in DbContent.TblLogins
                                    where cn.OrganizationCode == api0001_inValue.organization_code && cn.LoginEmployeeCode == api0001_inValue.employee_code && cn.LoginPassword == api0001_inValue.password
                                    select new API0001_OutModel()
                                    {
                                        employee_code = cn.LoginEmployeeCode,
                                        organization_code = cn.OrganizationCode
                                    }).ToList();

                return loginDetails;
            }
            catch
            {
                throw;
            }
        }
    }
}