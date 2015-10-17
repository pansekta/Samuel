using System.Data;

namespace Samuel
{
    interface IServiceApi
    {
      void CreateNewAccount(string firstName, string lastName, string userName, string password);
      DataTable GetUserDetails(string userName);
      bool UserAuthentication(string userName, string passsword);
      DataTable GetDepartmentDetails();
    }
}
