using System;
using System.Linq;
using AutoMapper;
using CryptSharp;
using Snippr.Data.Models;
using Snippr.Data.Repositories;
using Snippr.Domain;
using Snippr.Domain.Models.API;
using Snippr.Domain.Models.Business;

namespace Snippr.Services.Users
{
    public class UserService : IUserService
    {
        private readonly IElasticRepository _elasticRepository;

        public UserService(IElasticRepository elasticRepository)
        {
            _elasticRepository = elasticRepository;
        }

        public void Register(UserRequestModel userRequestModel)
        {
            var userIndexModel = Mapper.Map<UserIndexModel>(userRequestModel);

            //Verify the user doesn't exist
            if (UserExists(userIndexModel)) throw new Exception(Constants.Exceptions.UserExists);

            //Hash the password of the user using BCrypt (Blowfish)
            userIndexModel.HashedPassword = Crypter.Blowfish.Crypt(userRequestModel.Password);

            //Persist the user in the Elastic store
            _elasticRepository.Add(userIndexModel, Constants.IndexNames.DefaultUserIndex);
        }

        public void Login(User user)
        {
            throw new NotImplementedException();
        }

        private bool UserExists(UserIndexModel userIndexModel)
        {
            var users = _elasticRepository.Search<UserIndexModel>("emailAddress", userIndexModel.EmailAddress, Constants.IndexNames.DefaultUserIndex);
            return users.Any();
        }
    }
}
