using APIHM.Services.Interfaces;
using Common;
using Repository;
using Repository.Entity;
using Repository.Repositories.Interfaces;

namespace APIHM.Services
{
    public class UserService : IUserService
    {
        public readonly IUserRepository repository;
        public readonly IPersonRepository _personrepository;

        public UserService(IUserRepository repository, IPersonRepository personrepository)
        {
            this.repository = repository;
            this._personrepository = personrepository;
        }

        public void AddUser(UserModel model)
        {
            UserEntity entity = new UserEntity()
            {
                PersonId = model.PersonId,
                Password = model.Password
            };   
            repository.Add(entity);
        }
        public void UpdateUser(UserModel model)
        {
            UserEntity entity = new UserEntity()
            {
                Id = model.Id,
                PersonId = model.PersonId,
                Password = model.Password
            };   
            repository.Update(entity);
        }
        public UserModel Login(LoginModel model)
        {
            UserEntity entity = new UserEntity()
            {
                Person = new PersonEntity()
                {
                    Email = model.Email,
                    Username = model.Username,
                },
                Password = model.Password,
            };

            entity = repository.GetValidateLogin(entity);

            if (entity != null)
            {
                var person = _personrepository.Get(entity.PersonId);
                model.Email = person.Email;
                model.Username = person.Username;
            }

            return null;
        }
    }
}
