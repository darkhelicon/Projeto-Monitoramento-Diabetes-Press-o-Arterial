using Common;

namespace APIHM.Services.Interfaces
{
    public interface IPersonService
    {
        int AddPerson(PersonModel model);
        void UpdatePerson(PersonModel model);
    }
}
