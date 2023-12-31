﻿using BackEnd.Domain;
using BackEnd.Domain.UserProfile;
using BackEnd.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }


        [HttpGet]
        public async Task<ActionResult<QueryResultResource<UserResource>>> Get([FromQuery] UserQueryResource filter)
        {
            try
            {
                return Ok(await _userService.Get(filter));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, nameof(Get));
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<UserResource>> GetId(int id)
        {
            try
            {
                return Ok(await _userService.GetId(id));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, nameof(GetId));
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] UserResourceSave value)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                try
                {
                    new MailAddress(value.Mail);
                }
                catch
                {
                    return BadRequest("El formato del email no es válido");
                }


                var _obj = await _userService.Post(value);
                return CreatedAtAction(nameof(GetId), new { Id = _obj.Id }, null);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, nameof(Post));
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }


        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UserResourceSave value)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                try
                {
                    new MailAddress(value.Mail);
                }
                catch
                {
                    return BadRequest("El formato del email no es válido");
                }

                var _result = await _userService.Put(id, value);

                return _result ? NoContent() : NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, nameof(Put));
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var _result = await _userService.Delete(id);
                return _result ? NoContent() : NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, nameof(Delete));
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }

        }
    }
}
