
namespace HRMS_v2.Interface
{
    public interface IOrganization
    {
        /// <summary>
        /// Interface class for access the method in BusinessLogic Layer
        /// </summary>
        /// <param name="organization_code"></param>
        /// <param name="organization_email"></param>
        /// <param name="organization_contact"></param>
        /// <returns></returns>
        int check_organization_details_exists(string organization_code, string organization_email, string organization_contact);

        /// <summary>
        /// Interface class for access the method in BusinessLogic Layer
        /// </summary>
        /// <param name="organization_Id"></param>
        /// <returns></returns>
        bool delete_organization_details(int organization_Id);
    }
}