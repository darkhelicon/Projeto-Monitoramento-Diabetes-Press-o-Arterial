using Common;
using Repository.Context;
using Repository.Entity;
using Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class GlicoRepository : IGlicoRepository
    {
        protected EFContext _dataContext;

        public GlicoRepository(EFContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Add(HiperEntity entity)
        {
            _dataContext.Add(entity);
            _dataContext.SaveChanges();
        }
        public void Update(HiperEntity entity)
        {
            _dataContext.Add(entity);
            _dataContext.SaveChanges();
        }
    }
}
