using Proiect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Repositories
{
    public class UserInfosRepository : IUserInfosRepository
    {
        private readonly ProiectContext db;

        public UserInfosRepository(ProiectContext db)
        {
            this.db = db;
        }
        public IQueryable<UserInfo> GetUserInfos()
        {
            var userInfos = db.UserInfos;

            return userInfos;
        }

        public void Create(UserInfo userInfo)
        {
            db.UserInfos.Add(userInfo);

            db.SaveChanges();
        }

        public void Update(UserInfo userInfo)
        {
            db.UserInfos.Update(userInfo);

            db.SaveChanges();
        }

        public void Delete(UserInfo userInfo)
        {
            db.UserInfos.Remove(userInfo);

            db.SaveChanges();
        }

        public IQueryable<string> GetUserInfosIds()
        {
            var userinfosIds = db.UserInfos
                .Select(x => x.Id);

            return userinfosIds;
        }
    }
}
