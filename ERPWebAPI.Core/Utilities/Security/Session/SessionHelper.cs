using Core.Entities.Concrete;

namespace Core.Utilities.Security.Session
{
    public class SessionHelper : ISessionHelper
    {
        public void OpenSession(string formName, string userName, int userId, int employeeId)
        {
            SessionInformation.SessionId = Guid.NewGuid().ToString();
            SessionInformation.FormName = formName;
            SessionInformation.LoginName = userName;
            SessionInformation.LoginId = userId;
            SessionInformation.EmployeeId = employeeId;
            SessionInformation.Beginning = DateTime.Now;
        }

        public void CloseSession()
        {
            SessionInformation.Ending = DateTime.Now;
        }
    }
}
