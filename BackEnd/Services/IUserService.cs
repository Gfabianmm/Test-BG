using AutoMapper;
using BackEnd.Controllers;
using BackEnd.DataAccess;
using BackEnd.DataBase.Entity;
using BackEnd.Domain.UserProfile;
using BackEnd.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Security.Cryptography;

namespace BackEnd.Services
{
    public interface IUserService
    {
        Task<QueryResultResource<UserResource>> Get(UserQueryResource filter);
        Task<UserResource> GetId(int id);
        Task<User> Post([FromBody] UserResourceSave value);
        Task<bool> Put(int id, [FromBody] UserResourceSave value);
        Task<bool> Delete(int id);
    }

    public class UserService : IUserService, IAutomaticImplementation
    {
        private readonly IUserDA _userDA;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<IUserService> _logger;
        public UserService(IUserDA userDA, IMapper mapper, IUnitOfWork unitOfWork, ILogger<IUserService> logger)
        {
            _userDA = userDA;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<QueryResultResource<UserResource>> Get(UserQueryResource filter)
        {
            var query = _mapper.Map<UserQuery>(filter);
            var resultado = await _userDA.GetAll(query);
            return _mapper.Map<QueryResultResource<UserResource>>(resultado);

        }

        public async Task<UserResource> GetId(int id)
        {
            return _mapper.Map<UserResource>(await _userDA.GetById(id));
        }

        public async Task<User> Post([FromBody] UserResourceSave value)
        {
            var _obj = _mapper.Map<User>(value);
            _obj.Password = HashKey(_obj.Password);
            _obj.CreatedAt = DateTime.Now;
            _userDA.Add(_obj);

            await _unitOfWork.Complete();

            return _obj;

        }

        public async Task<bool> Put(int id, [FromBody] UserResourceSave value)
        {
            var _obj = await _userDA.GetById(id);

            if (_obj == null)
                return false;
            if (string.IsNullOrEmpty(value.Password))
                value.Password = _obj.Password;


            if (value.Password != _obj.Password)
                value.Password = HashKey(value.Password);

            _mapper.Map(value, _obj);
            _obj.ModifiedAt = DateTime.Now;

            _userDA.Update(_obj);
            await _unitOfWork.Complete();
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            var _obj = await _userDA.GetById(id);

            if (_obj == null)
                return false;

            _userDA.Delete(_obj);
            await _unitOfWork.Complete();

            return true;
        }


        private string HashKey(string key)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] keyBytes = Encoding.UTF8.GetBytes(key);
                byte[] hashBytes = sha256.ComputeHash(keyBytes);
                string hashedKey = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                return hashedKey;
            }
        }
    }
}
