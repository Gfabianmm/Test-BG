using BackEnd.DataBase;
using BackEnd.DataBase.Entity;
using BackEnd.Domain.UserProfile;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace BackEnd.DataAccess
{

    public interface IUserDA
    {
        void Add(User obj);
        Task<QueryResult<User>> GetAll(UserQuery queryObj);
        abstract Task<User?> GetById(int id);
        void Update(User obj);
        void Delete(User obj);
    }
    public class UserDA : IUserDA, IAutomaticImplementation
    {
        private readonly DBTestBGContext _dBContext;

        public UserDA(DBTestBGContext dBContext)
        {
            _dBContext = dBContext;
        }

        public async Task<QueryResult<User>> GetAll(UserQuery queryObj)
        {
            var result = new QueryResult<User>();
            var query = _dBContext.Users.AsQueryable();

            query = query.Where(v => !v.Deleted);

            if (!string.IsNullOrEmpty(queryObj.Names))
                query = query.Where(v => v.Names == queryObj.Names);

            if (!string.IsNullOrEmpty(queryObj.Password))
                query = query.Where(v => v.Names == queryObj.Password);

            if (!string.IsNullOrEmpty(queryObj.Mail))
                query = query.Where(v => v.Names == queryObj.Mail);


            var columnsMap = new Dictionary<string, Expression<Func<User, object>>>
            {
                ["Id"] = v => v.Id
            };

            if(string.IsNullOrEmpty(queryObj.SortBy))
                queryObj.SortBy="Id";

            query = query.ApplyOrdering(queryObj, columnsMap);
            query = query.ApplyPagging(queryObj);

            result.TotalItems = await query.CountAsync();
            result.Items = query.ToList();

            return result;
        }

        public async Task<User?> GetById(int id)
        {
            return await _dBContext.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public void Add(User obj)
        {
            _dBContext.Add(obj);
        }

        public void Update(User obj)
        {
            _dBContext.Update(obj);
        }

        public void Delete(User obj)
        {
            _dBContext.Remove(obj);
        }
    }
}
