using BackEnd.DataBase;
using BackEnd.DataBase.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace BackEnd.DataAccess
{

    public interface IMovieDA
    {
        void Add(Movie obj);
        Task<QueryResult<Movie>> GetAll(MovieQuery queryObj);
        abstract Task<Movie?> GetById(int id);
        void Update(Movie obj);
        void Delete(Movie obj);
    }
    public class MovieDA : IMovieDA, IAutomaticImplementation
    {
        private readonly DBTestBGContext _dBContext;

        public MovieDA(DBTestBGContext dBContext)
        {
            _dBContext = dBContext;
        }

        public async Task<QueryResult<Movie>> GetAll(MovieQuery queryObj)
        {
            var result = new QueryResult<Movie>();
            var query = _dBContext.Movies
                .Include(a => a.MovieCategories).ThenInclude(a => a.Category)
                .Include(a => a.MovieGenres).ThenInclude(a => a.Genre)
                .Include(a => a.MovieActors).ThenInclude(a => a.Actor)
                .AsQueryable();

            query = query.Where(v => !v.Deleted);

            if (!string.IsNullOrEmpty(queryObj.Name))
                query = query.Where(v => v.Name == queryObj.Name);

            if (queryObj.CategoryId != 0)
                query = query.Where(v => v.MovieCategories.Where(b => b.CategoryId == queryObj.CategoryId).Count() > 1);

            if (queryObj.GenreId != 0)
                query = query.Where(v => v.MovieGenres.Where(b => b.GenreId == queryObj.GenreId).Count() > 1);


            var columnsMap = new Dictionary<string, Expression<Func<Movie, object>>>
            {
                ["Id"] = v => v.Id
            };

            if (string.IsNullOrEmpty(queryObj.SortBy))
                queryObj.SortBy = "Id";

            query = query.ApplyOrdering(queryObj, columnsMap);
            query = query.ApplyPagging(queryObj);

            result.TotalItems = await query.CountAsync();
            result.Items = query.ToList();

            return result;
        }

        public async Task<Movie?> GetById(int id)
        {
            return await _dBContext.Movies.FirstOrDefaultAsync(x => x.Id == id);
        }

        public void Add(Movie obj)
        {
            _dBContext.Add(obj);
        }

        public void Update(Movie obj)
        {
            _dBContext.Update(obj);
        }

        public void Delete(Movie obj)
        {
            _dBContext.Remove(obj);
        }
    }
}
