using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Typing.DataAccess.Data.Repository.IRepository;
using Typing.Models;

namespace Typing.DataAccess.Data.Repository
{
    class UserRepository : Repository<User>, IUserRepository
    {
        private readonly ApplicationDbContext _db;

        public UserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(User user)
        {
            //retrive the DB obj, go out to DB ain the user table and get the frist or defualt user that comes back
            //string = s  local instance pf ID = user Id in the databse 
            var objFromDb = _db.User.FirstOrDefault(s => s.Id == user.Id);

            //mapping the changes individualy 
            objFromDb.UserName = user.UserName;
            objFromDb.Score = user.Score;
            objFromDb.HashedPassword = user.HashedPassword;
            objFromDb.UserSalt = user.UserSalt;

            _db.SaveChanges();
        }
    }
}
