using System.ComponentModel.DataAnnotations;


namespace Core.Entities.Concrete
{
    public class tbl_Users : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public bool UserStatus { get; set; }
    }
}

