
using System.Net;

namespace Core.Entities.Concrete
{
    public class PcInformation
    {
        public static string HostName { get; } = Dns.GetHostName();
        public static string IpAddress { get; } = Dns.GetHostByName(HostName).AddressList[0].ToString();
        public static string PcUserName { get; } = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
    }
}
