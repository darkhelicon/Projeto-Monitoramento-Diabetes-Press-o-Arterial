using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Interfaces
{
    public interface IHiperRepository
    {
        void Add(HiperEntity entity);
        void Update(HiperEntity entity);
        List<HiperEntity> GetFromPerson(int personId);
        List<HiperEntity> GetToday(int personId);
        List<HiperEntity> GetYesterday(int personId);
        List<HiperEntity> GetLastWeek(int personId);
        List<HiperEntity> GetLastMonth(int personId);
    }
}
