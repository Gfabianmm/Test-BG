using AutoMapper;
using BackEnd.DataAccess;
using BackEnd.DataBase.Entity;
using BackEnd.Domain;
using BackEnd.Domain.MovieProfile;

namespace BackEnd.Services
{
    public interface IMovieService
    {
        Task<QueryResultResource<MovieResource>> Get(MovieQueryResource filter);
        Task<MovieResource> GetId(int id);
        Task<Movie> Post(MovieResourceSave value);
        Task<bool> Put(int id, MovieResourceSave value);
        Task<bool> Delete(int id);
    }
    public class MovieService : IMovieService, IAutomaticImplementation
    {
        private readonly IMovieDA _movieDA;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<IUserService> _logger;
        public MovieService(IMovieDA userDA, IMapper mapper, IUnitOfWork unitOfWork, ILogger<IUserService> logger)
        {
            _movieDA = userDA;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<QueryResultResource<MovieResource>> Get(MovieQueryResource filter)
        {
            var query = _mapper.Map<MovieQuery>(filter);
            var resultado = await _movieDA.GetAll(query);
            return _mapper.Map<QueryResultResource<MovieResource>>(resultado);

        }

        public async Task<MovieResource> GetId(int id)
        {
            return _mapper.Map<MovieResource>(await _movieDA.GetById(id));
        }

        public async Task<Movie> Post(MovieResourceSave value)
        {
            var _obj = _mapper.Map<Movie>(value);
            _obj.CreatedAt = DateTime.Now;
            _movieDA.Add(_obj);

            await _unitOfWork.Complete();

            return _obj;

        }

        public async Task<bool> Put(int id, MovieResourceSave value)
        {
            var _obj = await _movieDA.GetById(id);

            if (_obj == null)
                return false;


            _mapper.Map(value, _obj);
            _obj.ModifiedAt = DateTime.Now;

            _movieDA.Update(_obj);
            await _unitOfWork.Complete();
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            var _obj = await _movieDA.GetById(id);

            if (_obj == null)
                return false;

            _movieDA.Delete(_obj);
            await _unitOfWork.Complete();

            return true;
        }

    }
}
