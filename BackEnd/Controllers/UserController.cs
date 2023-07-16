using AutoMapper;
using BackEnd.DataAccess;
using BackEnd.DataBase.Entity;
using BackEnd.Domain;
using BackEnd.Domain.UserProfile;
using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {


        private readonly IUserDA _userDA;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;

        public UserController(IUserDA userDA, IMapper mapper, IUnitOfWork unitOfWork, ILogger<UserController> logger)
        {
            _userDA = userDA;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }


        [HttpGet]
        public async Task<ActionResult<QueryResult<UserResource>>> Get([FromQuery] UserQueryResource filter)
        {

            try
            {
                var query = _mapper.Map<UserQuery>(filter);
                var resultado = await _userDA.GetAll(query);
                return Ok(_mapper.Map<QueryResultResource<UserResource>>(resultado));
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
                return Ok(_mapper.Map<UserResource>(await _userDA.GetById(id)));

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, nameof(GetId));
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] UserResourceSave value)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var _obj = _mapper.Map<User>(value);

                _obj.CreatedAt = DateTime.Now;
                _userDA.Add(_obj);

                await _unitOfWork.Complete();

                return CreatedAtAction(nameof(GetId), new { Id = _obj.Id }, null);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, nameof(Post));
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UserResourceSave value)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var _obj = await _userDA.GetById(id);

                if (_obj == null)
                    return NotFound();

                _mapper.Map(value, _obj);
                _obj.ModifiedAt = DateTime.Now;

                _userDA.Update(_obj);
                await _unitOfWork.Complete();

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, nameof(Put));
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }

        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var _obj = await _userDA.GetById(id);

                if (_obj == null)
                    return NotFound();

                _userDA.Delete(_obj);
                await _unitOfWork.Complete();

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, nameof(Delete));
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }

        }
    }
}
