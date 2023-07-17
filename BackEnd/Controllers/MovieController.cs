using BackEnd.Domain;
using BackEnd.Domain.MovieProfile;
using BackEnd.Domain.UserProfile;
using BackEnd.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly ILogger<MovieController> _logger;
        private readonly IMovieService _movieService;

        public MovieController(ILogger<MovieController> logger, IMovieService userService)
        {
            _logger = logger;
            _movieService = userService;
        }


        [HttpGet]
        public async Task<ActionResult<QueryResultResource<MovieResource>>> Get([FromQuery] MovieQueryResource filter)
        {
            try
            {
                return Ok(await _movieService.Get(filter));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, nameof(Get));
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<MovieResource>> GetId(int id)
        {
            try
            {
                return Ok(await _movieService.GetId(id));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, nameof(GetId));
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] MovieResourceSave value)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                
                var _obj = await _movieService.Post(value);
                return CreatedAtAction(nameof(GetId), new { Id = _obj.Id }, null);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, nameof(Post));
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }


        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] MovieResourceSave value)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

             
                var _result = await _movieService.Put(id, value);

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
                var _result = await _movieService.Delete(id);
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
