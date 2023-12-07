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
    public class HiperRepository : IHiperRepository
    {
        protected EFContext _dataContext;

        public HiperRepository(EFContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Add(HiperEntity entity)
        {
            if(entity.Sistolica < 90 && entity.Diastolica < 60) 
            {
                entity.Categoria = Categoria.Hipotensao;
            }else if(entity.Sistolica == 120 && entity.Diastolica == 80) 
            {
                entity.Categoria = Categoria.PressaoArterialNormal;
            }else if(entity.Sistolica > 120 && entity.Sistolica < 129 && entity.Diastolica < 80) 
            {
                entity.Categoria = Categoria.PreHipertensao;
            }else if(entity.Sistolica > 130 && entity.Sistolica < 139 && entity.Diastolica > 80 && entity.Diastolica < 90) 
            {
                entity.Categoria = Categoria.HipertensaoEstagioUm;
            }else if(entity.Sistolica >= 140 && entity.Diastolica > 90) 
            {
                entity.Categoria = Categoria.HipertensaoEstagioDois;
            }else if(entity.Sistolica > 180 && entity.Diastolica > 120) 
            {
                entity.Categoria = Categoria.CriseHipertensiva;
            }else if(entity.Sistolica > 180 || entity.Diastolica > 120) 
            {
                entity.Categoria = Categoria.CriseHipertensiva;
            }
            _dataContext.Add(entity);
            _dataContext.SaveChanges();
        }
        public void Update(HiperEntity entity)
        {
            _dataContext.Add(entity);
            _dataContext.SaveChanges();
        }
        public List<HiperEntity> GetFromPerson(int personId)
        {
            return _dataContext.Hiper.Where(c => c.PersonId == personId).ToList();
        }
        public List<HiperEntity> GetToday(int personId)
        {
            var date = DateTime.UtcNow;
            return _dataContext.Hiper.Where(c => c.PersonId == personId && c.Date.Date == date.Date).ToList();
        }
        public List<HiperEntity> GetYesterday(int personId)
        {
            var date = DateTime.UtcNow;
            return _dataContext.Hiper.Where(c => c.PersonId == personId && c.Date.Date > DateTime.UtcNow.AddDays(-1).Date && 
            c.Date.Date < date).ToList();
        }
        public List<HiperEntity> GetLastWeek(int personId)
        {
            var date = DateTime.UtcNow;
            return _dataContext.Hiper.Where(c => c.PersonId == personId && c.Date.Date > DateTime.UtcNow.AddDays(-7).Date &&
            c.Date.Date < date).ToList();
        }
        public List<HiperEntity> GetLastMonth(int personId)
        {
            var date = DateTime.UtcNow;
            return _dataContext.Hiper.Where(c => c.PersonId == personId && c.Date.Date > DateTime.UtcNow.AddDays(-30).Date &&
            c.Date.Date < date).ToList();
        }
        public List<HiperEntity> GetTodayCategorias(int personId)
        {
            var date = DateTime.UtcNow;
            return _dataContext.Hiper.Where(c => c.PersonId == personId && c.Date.Date == date.Date).ToList();
        }
    }
}
