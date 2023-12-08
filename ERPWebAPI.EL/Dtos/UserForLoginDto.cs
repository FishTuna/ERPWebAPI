

using Core.Entities;

namespace ERPWebAPI.EL.Dtos
{
    public class UserForLoginDto : IDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
