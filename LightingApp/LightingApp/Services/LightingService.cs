using LightingApp.Data;
using LightingApp.Data.Models;
using LightingApp.Models;

namespace LightingApp.Services
{
    public class LightingService : ILightingService
    {
        private readonly IRepository repository;

        public LightingService(IRepository repository)
        {
            this.repository = repository;
        }

        public void AddRecord(LightingViewModel lightingRecord)
        { 
            repository.AddRecord(new Lighting 
            {
                Name = lightingRecord.Name,
                EmailAddress = lightingRecord.EmailAddress,
                AcceptableLighting = lightingRecord.AcceptableLighting,
                BrightnessLevel = lightingRecord.BrightnessLevel,
                AddressNameOrNumber = lightingRecord.AddressNameOrNumber,
                AddressLine1 = lightingRecord.AddressLine1,
                AddressLine2 = lightingRecord.AddressLine2,
                AddressTown = lightingRecord.AddressTown,
                AddressPostcode = lightingRecord.AddressPostcode
            });
        }
    }
}
