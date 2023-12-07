using Repository.Context;
using Repository.Entity;
using Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        protected EFContext _dataContext;

        public PersonRepository(EFContext dataContext)
        {
            _dataContext = dataContext;
        }

        public int Add(PersonEntity entity)
        {
            _dataContext.Add(entity);
            _dataContext.SaveChanges();
            return entity.Id;
        }
        public void Update(PersonEntity entity)
        {
            _dataContext.Add(entity);
            _dataContext.SaveChanges();
        }
        public PersonEntity Get(int personId)
        {
            return _dataContext.Persons.Where(c => c.Id == personId).FirstOrDefault();
        }
    }
}
