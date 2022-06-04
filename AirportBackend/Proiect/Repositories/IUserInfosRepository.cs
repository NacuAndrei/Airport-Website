using Proiect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Repositories
{
    public interface IUserInfosRepository
    {
         IQueryable<UserInfo> GetUserInfos();  //gets all Userinfos
         IQueryable<string> GetUserInfosIds(); //gets all ids from tickets
         void Create(UserInfo userInfo);
         void Update(UserInfo userInfo);
         void Delete(UserInfo userInfo);
        
    }
}
