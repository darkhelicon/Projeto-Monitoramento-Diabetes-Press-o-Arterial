using Common;
using Repository.Entity;
using Repository;
using Repository.Repositories;
using APIHM.Services.Interfaces;
using Repository.Repositories.Interfaces;

namespace APIHM.Services
{
    public class GlicoService : IGlicoService
    {
        public readonly IGlicoRepository glicoRepository;

        public GlicoService(IGlicoRepository glicoRepository)
        {
            this.glicoRepository = glicoRepository;
        }

        //public int AddHiper(PersonModel model)
        //{
        //    //PersonEntity entity = new PersonEntity()
        //    //{
        //    //    Username = model.Username,
        //    //    Email = model.Email,
        //    //    hasG = model.HasG,
        //    //    hasH = model.HasH,
        //    //    Date = DateTime.UtcNow,
        //    //};
        //    //return hiperRepository.Add(entity);
        //}
        //public void UpdateHiper(PersonModel model)
        //{
        //    //    PersonEntity entity = new PersonEntity()
        //    //    {
        //    //        Id = model.Id,
        //    //        Username = model.Username,
        //    //        Email = model.Email,
        //    //        hasG = model.HasG,
        //    //        hasH = model.HasH
        //    //    };
        //    //    hiperRepository.Update(entity);
        //}
        //public List<HiperEntity> HiperPeriod(DataModel dataModel)
        //{
        //    if (dataModel.Days == Days.Hoje)
        //    {
        //        return hiperRepository.GetToday(dataModel.PersonId).ToList();
        //    }
        //    else if (dataModel.Days == Days.Ontem)
        //    {
        //        return hiperRepository.GetYesterday(dataModel.PersonId).ToList();
        //    }
        //    else if (dataModel.Days == Days.UltimaSemana)
        //    {
        //        return hiperRepository.GetLastWeek(dataModel.PersonId).ToList();
        //    }
        //    else if (dataModel.Days == Days.UltimoMes)
        //    {
        //        return hiperRepository.GetLastMonth(dataModel.PersonId).ToList();
        //    }
        //    else
        //    {
        //        throw new Exception("Não existem dados para esse período");
        //    }
        //}
        //public List<HiperEntity> GetTodayCategorias(DataModel dataModel)
        //{
        //    if (dataModel.Days == Days.Hoje)
        //    {
        //        return hiperRepository.GetToday(dataModel.PersonId).ToList();
        //    }
        //    else if (dataModel.Days == Days.Ontem)
        //    {
        //        return hiperRepository.GetYesterday(dataModel.PersonId).ToList();
        //    }
        //    else if (dataModel.Days == Days.UltimaSemana)
        //    {
        //        return hiperRepository.GetLastWeek(dataModel.PersonId).ToList();
        //    }
        //    else if (dataModel.Days == Days.UltimoMes)
        //    {
        //        return hiperRepository.GetLastMonth(dataModel.PersonId).ToList();
        //    }
        //    else
        //    {
        //        throw new Exception("Não existem dados para esse período");
        //    }
        //}
    }
}
