﻿using Common;
using Repository.Entity;

namespace APIHM.Services.Interfaces
{
    public interface IHiperService
    {
        //    int AddPerson(PersonModel model);
        ////    void UpdatePerson(PersonModel model);
        //    object HiperPeriod(DataModel dataModel);
        List<HiperEntity> HiperPeriod(DataModel dataModel);
    }
}
