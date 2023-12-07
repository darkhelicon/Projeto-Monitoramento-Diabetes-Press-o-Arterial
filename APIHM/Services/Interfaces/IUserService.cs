using Common;

namespace APIHM.Services.Interfaces
{
    public interface IUserService
    {
        void AddUser(UserModel model);
        UserModel Login(LoginModel user);
        void UpdateUser(UserModel model);
    }
}
