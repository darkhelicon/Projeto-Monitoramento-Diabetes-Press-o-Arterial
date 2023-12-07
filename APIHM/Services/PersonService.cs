using Common;
using Repository.Entity;
using Repository;
using Repository.Repositories;
using APIHM.Services.Interfaces;
using Repository.Repositories.Interfaces;

namespace APIHM.Services
{
    public class PersonService : IPersonService
    {
        public readonly IPersonRepository personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        public int AddPerson(PersonModel model)
        {
            PersonEntity entity = new PersonEntity()
            {
                Username = model.Username,
                Email = model.Email,
                hasG = model.HasG,
                hasH = model.HasH,
                Date = DateTime.UtcNow,
            };
            return personRepository.Add(entity);
        }
        public void UpdatePerson(PersonModel model)
        {
            PersonEntity entity = new PersonEntity()
            {
                Id = model.Id,
                Username = model.Username,
                Email = model.Email,
                hasG = model.HasG,
                hasH = model.HasH
            };
            personRepository.Update(entity);
        }
    }
}
