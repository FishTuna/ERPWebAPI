

using Core.Entities;

namespace ERPWebAPI.EL.Dtos
{
    public class UserForRegisterDto : IDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
