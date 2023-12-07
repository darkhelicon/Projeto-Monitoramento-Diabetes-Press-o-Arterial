using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Interfaces
{
    public interface IPersonRepository
    {
        int Add(PersonEntity entity);
        void Update(PersonEntity entity);
        PersonEntity Get(int personId);
    }
}
