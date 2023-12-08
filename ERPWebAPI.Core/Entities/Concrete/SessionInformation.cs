
namespace Core.Entities.Concrete
{

    public class SessionInformation : IEntity
    {
        //public SessionInformation()
        //{

        //}
        public static string LoginName { get; set; }
        public static int LoginId { get; set; }
        public static int EmployeeId { get; set; }
        public static string FormName { get; set; }
        public static string SessionId { get; set; }
        public static DateTime Beginning { get; set; } = DateTime.Now;
        public static DateTime? Ending { get; set; }

    }
}
