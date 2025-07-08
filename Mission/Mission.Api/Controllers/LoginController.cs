using Microsoft.AspNetCore.Mvc;
using Mission.Entities.ViewModels;
using Mission.Entities.ViewModels.Login;
<<<<<<< HEAD
using Mission.Entities.ViewModels.User;
=======
>>>>>>> 0658e5ba63fccb12db896632d6930c5055d95686
using Mission.Services.IService;

namespace Mission.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController(IUserService userService) : ControllerBase
    {
        private readonly IUserService _userService = userService;

        [HttpPost]
<<<<<<< HEAD
        [Route("LoginUser")]        
=======
        [Route("LoginUser")]
>>>>>>> 0658e5ba63fccb12db896632d6930c5055d95686
        public async Task<IActionResult> LoginUser(UserLoginRequestModel model) 
        {
            var response = await _userService.LogiUser(model);

            if (response.Result == ResponseStatus.Error)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
<<<<<<< HEAD

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> RegisterUser(AddUserRequestModel model)
        {
            var response = await _userService.RegisterUserAsync(model);

            var result = new ResponseResult();

            if (!response)
            {
                result.Message = "User already exist with same email address";
                result.Result = ResponseStatus.Error;
                return BadRequest(result);
            }

            result.Result = ResponseStatus.Success;
            return Ok(result);
        }

        [HttpGet]
        [Route("LoginUserDetailById/{userId:int}")]
        public async Task<IActionResult> GetLoginUserDetailById(int userId)
        {
            var response = await _userService.GetLoginUserDetailById(userId);

            var result = new ResponseResult();

            if (response == null)
            {
                result.Message = "User not found";
                result.Result = ResponseStatus.Error;
                return NotFound(result);
            }

            result.Data = response;
            result.Result = ResponseStatus.Success;
            return Ok(result);
        }

        [HttpPost]
        [Route("UpdateUser")]
        public async Task<IActionResult> UpdateUser(UpdateUserRequestModel model)
        {
            var response = await _userService.UpdateUserAsync(model);

            if (response.Message == "User not found")
            {
                return NotFound(response);
            }

            if (response.Result == ResponseStatus.Error)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
=======
>>>>>>> 0658e5ba63fccb12db896632d6930c5055d95686
    }
}
