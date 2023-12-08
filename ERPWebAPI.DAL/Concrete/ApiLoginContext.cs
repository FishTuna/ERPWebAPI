using Core.Entities.Concrete;
using Core.Invocations;
using Microsoft.EntityFrameworkCore;

namespace ERPWebAPI.DAL.Concrete
{
    public class ApiLoginContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //optionsBuilder.UseSqlServer(@"server=YDC_ALIENWARE\AW_SQL2022;database=API_USERS;User ID = sa; Password = 3474399;Encrypt=False");
            optionsBuilder.UseSqlServer($"server={ApiDbConnectionInfo.Server};" +
                         $"database={PasswordCodder.Base64Decode(ApiDbConnectionInfo.DatabaseName)};" +
                         $"User ID = {PasswordCodder.Base64Decode(ApiDbConnectionInfo.User)}; " +
                         $"Password = {PasswordCodder.Base64Decode(ApiDbConnectionInfo.Password)};" +
                         $"Encrypt={ApiDbConnectionInfo.Encrypt}");
        }
        public DbSet<OperationClaim> tbl_OperationClaims { get; set; }
        public DbSet<tbl_Users> tbl_Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
