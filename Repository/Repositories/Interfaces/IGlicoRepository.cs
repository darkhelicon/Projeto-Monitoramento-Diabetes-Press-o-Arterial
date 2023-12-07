using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Interfaces
{
    public interface IGlicoRepository
    {
        void Add(HiperEntity entity);
        void Update(HiperEntity entity);
    }
}
