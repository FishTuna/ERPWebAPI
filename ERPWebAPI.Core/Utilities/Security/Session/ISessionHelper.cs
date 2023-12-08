namespace Core.Utilities.Security.Session
{
    public interface ISessionHelper
    {
        public void OpenSession(string formName, string userName, int userId, int employeeId);
        public void CloseSession();
    }
}
