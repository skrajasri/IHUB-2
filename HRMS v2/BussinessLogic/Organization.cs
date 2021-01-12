using System.Linq;
using HRMS_v2.Interface;
using HRMS_v2.Helper;

namespace HRMS_v2.BussinessLogic
{
    public class Organization : IOrganization
    {
        /// <summary>
        /// Method for check given organizational details is exits or not
        /// </summary>
        /// <param name="organization_code"></param>
        /// <param name="organization_email"></param>
        /// <param name="organization_contact"></param>
        /// <returns></returns>
        public int check_organization_details_exists(string organization_code, string organization_email, string organization_contact)
        {
            try
            {
                //Connection string for connecting the database
                var DbContent = DB_config.db_conection();
                
                //Query for checking the given organization details exists or not
                var contractid = (from cn in DbContent.TblOrganizations
                                    where cn.OrganizationCode == organization_code && cn.OrganizationEmail == organization_email && cn.OrganizationContact == organization_contact
                                    select new {
                                        cn.OrganizationId
                                    }).Count();

                return contractid;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Method for Update the del_flag in organization table
        /// </summary>
        /// <param name="organization_Id"></param>
        /// <returns></returns>
        public bool delete_organization_details(int organization_Id)
        {
            try
            {
                //Connection string for connecting the database
                var DbContent = DB_config.db_conection();

                // Query for update the del_flag value as true in organization table
                var contractid = DbContent.TblOrganizations.First(i => i .OrganizationId == organization_Id);
                contractid.DelFlag = true;
                //code for save the changes to the database
                DbContent.SaveChanges();

                return true;
            }
            catch{
                return false;
            }
        }
    }
}