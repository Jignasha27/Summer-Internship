using Mission.Entities.ViewModels;
using Mission.Entities.ViewModels.Login;
<<<<<<< HEAD
using Mission.Entities.ViewModels.User;
=======
>>>>>>> 0658e5ba63fccb12db896632d6930c5055d95686

namespace Mission.Services.IService
{
    public interface IUserService
    {
        Task<ResponseResult> LogiUser(UserLoginRequestModel model);
<<<<<<< HEAD

        Task<List<UserResponseModel>> GetUsersAsync();

        Task<bool> RegisterUserAsync(AddUserRequestModel model);

        Task<UserResponseModel?> GetLoginUserDetailById(int userId);

        Task<ResponseResult> UpdateUserAsync(UpdateUserRequestModel model);

        Task<bool> DeleteUser(int userId);
=======
>>>>>>> 0658e5ba63fccb12db896632d6930c5055d95686
    }
}
