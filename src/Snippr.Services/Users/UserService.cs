using System;
using System.Linq;
using AutoMapper;
using CryptSharp;
using Snippr.Data.Models;
using Snippr.Data.Repositories;
using Snippr.Domain;
using Snippr.Domain.Models.API;

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
            if (UserExists(userIndexModel.EmailAddress)) throw new Exception(Constants.Exceptions.UserExists);

            //Hash the password of the user using BCrypt (Blowfish)
            userIndexModel.HashedPassword = Crypter.Blowfish.Crypt(userRequestModel.Password);

            //Persist the user in the Elastic store
            _elasticRepository.Add(userIndexModel, Constants.IndexNames.DefaultUserIndex);
        }

        public bool Login(LoginRequestModel loginRequestModel)
        {
            //Verify the user exists before attempting to login
            if(!UserExists(loginRequestModel.EmailAddress)) throw new Exception(Constants.Exceptions.UserDoesNotExist);

            //Retrieve the specified user
            var user = _elasticRepository.Search<UserIndexModel>("emailAddress", loginRequestModel.EmailAddress, Constants.IndexNames.DefaultUserIndex).FirstOrDefault();
            if(user == null) throw new Exception(Constants.Exceptions.UserDoesNotExist);

            //Hash the password and check it against the stored password for the user
            return Crypter.CheckPassword(loginRequestModel.Password, user.HashedPassword);
        }

        private bool UserExists(string emailAddress)
        {
            //Check if there are any users in the elastic store with the specified e-mail address
            var users = _elasticRepository.Search<UserIndexModel>("emailAddress", emailAddress, Constants.IndexNames.DefaultUserIndex);
            return users.Any();
        }
    }
}
