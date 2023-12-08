
namespace Core.Entities.Concrete
{
    public class ApiDbConnectionInfo
    {

        public static string DbType { get; set; }
        public static string Server { get; set; }
        public static string DatabaseName { get; set; }
        public static string User { get; set; }
        public static string Password { get; set; }
        public static bool Encrypt { get; set; }
    }
}
