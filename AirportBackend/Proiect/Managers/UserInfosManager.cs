using Proiect.Entities;
using Proiect.Models;
using Proiect.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Managers
{
    public class UserInfosManager : IUserInfosManager
    {
        private readonly IUserInfosRepository userInfosRepository;

        public UserInfosManager(IUserInfosRepository userInfosRepository)
        {
            this.userInfosRepository = userInfosRepository;
        }

        public List<UserInfo> GetUserInfos()
        {
            return userInfosRepository.GetUserInfos().ToList();
        }

        public void Create(UserInfoCreationModel model)
        {
            var newUserInfo = new UserInfo
            {
                Id = model.Id,
                Name = model.Name,
                DateOfBirth = model.DateOfBirth,
                Address = model.Address

            };

            userInfosRepository.Create(newUserInfo);
        }
        public void Update(UserInfoCreationModel model)
        {
            var userInfo = GetUserInfoById(model.Id);

            userInfo.Id = model.Id;
            userInfo.Name = model.Name;
            userInfo.DateOfBirth = model.DateOfBirth;
            userInfo.Address = model.Address;

            userInfosRepository.Update(userInfo);
        }

        public void Delete(string id)
        {
            var userInfo = GetUserInfoById(id);

            userInfosRepository.Delete(userInfo);
        }

        public List<string> GetUserInfosIds()
        {
            var userInfos = userInfosRepository.GetUserInfos();
            var idList = userInfos.Select(x => x.Id)
                .ToList();

            return idList;
        }

        public UserInfo GetUserInfoById(string id)
        {
            var userInfo = userInfosRepository.GetUserInfos()
                .FirstOrDefault(x => x.Id == id);

            return userInfo;
        }

      
    }
}
