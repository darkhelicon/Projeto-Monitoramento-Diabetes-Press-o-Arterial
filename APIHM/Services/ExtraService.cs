using Common;
using Repository.Entity;
using Repository;
using Repository.Repositories;
using APIHM.Services.Interfaces;
using Repository.Repositories.Interfaces;

namespace APIHM.Services
{
    public class ExtraService : IExtraService
    {
        public readonly IExtraRepository extraRepository;

        public ExtraService(IExtraRepository extraRepository)
        {
            this.extraRepository = extraRepository;
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
    }
}
