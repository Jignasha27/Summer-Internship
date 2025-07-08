<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations;
using Mission.Entities.ViewModels;
using Mission.Entities.ViewModels.Login;
using Mission.Entities.ViewModels.User;
=======
﻿using Mission.Entities.ViewModels;
using Mission.Entities.ViewModels.Login;
>>>>>>> 0658e5ba63fccb12db896632d6930c5055d95686
using Mission.Repositories.IRepository;
using Mission.Services.IService;

namespace Mission.Services.Service
{
<<<<<<< HEAD
    public class UserService(IUserRepository userRepository, JwtService jwtService) : IUserService
    {
        private readonly IUserRepository _userRepository = userRepository;
        private readonly JwtService _jwtService = jwtService;

        public async Task<List<UserResponseModel>> GetUsersAsync()
        {
            return await _userRepository.GetUsersAsync();
        }

        public async Task<bool> RegisterUserAsync(AddUserRequestModel model)
        {
            return await _userRepository.RegisterUserAsync(model);
        }

        public async Task<UserResponseModel?> GetLoginUserDetailById(int userId)
        {
            return await _userRepository.GetLoginUserDetailById(userId);
        }

        public async Task<bool> DeleteUser(int userId)
        {
            return await _userRepository.DeleteUser(userId);
        }

        public async Task<ResponseResult> UpdateUserAsync(UpdateUserRequestModel model)
        {
            var (response, message) = await _userRepository.UpdateUserAsync(model);

            var result = new ResponseResult()
            {
                Message = message
            };

            if (!response)
                result.Result = ResponseStatus.Error;
            else
                result.Result = ResponseStatus.Success;

            return result;
        }

=======
    public class UserService(IUserRepository userRepository) : IUserService
    {
        private readonly IUserRepository _userRepository = userRepository;
>>>>>>> 0658e5ba63fccb12db896632d6930c5055d95686
        public async Task<ResponseResult> LogiUser(UserLoginRequestModel model)
        {
            var (response, message) = await _userRepository.LogiUser(model);

            var result = new ResponseResult()
            {
<<<<<<< HEAD
=======
                Data = response,
>>>>>>> 0658e5ba63fccb12db896632d6930c5055d95686
                Message = message
            };

            if (response == null)
            {
                result.Result = ResponseStatus.Error;
            }
            else
            {
<<<<<<< HEAD
                result.Data = _jwtService.GenerateJwtToken(response);
=======

>>>>>>> 0658e5ba63fccb12db896632d6930c5055d95686
                result.Result = ResponseStatus.Success;
            }

            return result;
        }
    }
}
