using Proiect.Entities;
using Proiect.Models;
using Proiect.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Managers
{
    public interface IUserInfosManager
    {
        List<UserInfo> GetUserInfos();      //gets all UserInfos
        List<string> GetUserInfosIds();   //gets all ids from UserInfo
        UserInfo GetUserInfoById(string id);    //gets an UserInfo by id
        void Create(UserInfoCreationModel model);
        void Update(UserInfoCreationModel model);
        void Delete(string id);
    }
}
