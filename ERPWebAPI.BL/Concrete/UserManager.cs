using Core.Entities.Concrete;
using ERPWebAPI.BL.Abstract;
using ERPWebAPI.DAL.Abstract;


namespace ERPWebAPI.BL.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<OperationClaim> GetClaims(tbl_Users user)
        {
            return _userDal.GetClaims(user);
        }

        public void Add(tbl_Users user)
        {
            _userDal.Add(user);
        }

        public tbl_Users GetByUserName(string userName)
        {
            return _userDal.Get(u => u.UserName == userName && u.UserStatus == true);
        }
    }
}
