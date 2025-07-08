using Mission.Entities.ViewModels.Login;
<<<<<<< HEAD
using Mission.Entities.ViewModels.User;
=======
>>>>>>> 0658e5ba63fccb12db896632d6930c5055d95686

namespace Mission.Repositories.IRepository
{
    public interface IUserRepository
    {
        Task<(UserLoginResponseModel? response, string message)> LogiUser(UserLoginRequestModel model);
<<<<<<< HEAD

        Task<List<UserResponseModel>> GetUsersAsync();

        Task<bool> RegisterUserAsync(AddUserRequestModel model);

        Task<UserResponseModel?> GetLoginUserDetailById(int userId);

        Task<(bool response, string message)> UpdateUserAsync(UpdateUserRequestModel model);

        Task<bool> DeleteUser(int userId);
=======
>>>>>>> 0658e5ba63fccb12db896632d6930c5055d95686
    }
}
