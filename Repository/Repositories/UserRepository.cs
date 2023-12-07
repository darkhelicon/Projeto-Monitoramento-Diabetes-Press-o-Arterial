using Repository.Context;
using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UserRepository : IUserRepository
    {
        protected EFContext _dataContext;

        public UserRepository(EFContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Add(UserEntity entity)
        {
            _dataContext.Add(entity);
            _dataContext.SaveChanges();
        }
        public void Update(UserEntity entity)
        {
            _dataContext.Add(entity);
            _dataContext.SaveChanges();
        }
        public UserEntity GetValidateLogin(UserEntity entity)
        {
            return _dataContext.Users.Include(c => c.Person).Where(c => c.Password == entity.Password &&
                    (c.Person.Email == entity.Person.Email ||
                    c.Person.Username == entity.Person.Username)).FirstOrDefault();
        }
    }
}
