using LightingApp.Data;
using LightingApp.Data.Models;
using LightingApp.Models;
using LightingApp.Services;
using Moq;
using Xunit;

namespace LightningApp.Tests
{
    public class LightingServiceTests
    {
        [Fact]
        public void AddRecord_WhenCalled_CallsRepositoryWithData()
        {
            var lightingRecord = new LightingViewModel()
            {
                Name = "Name",
                EmailAddress = "ermail@address.com",
                AcceptableLighting = true,
                BrightnessLevel = 4,
                AddressNameOrNumber = "177",
                AddressLine1 = "Town Street",
                AddressLine2 = "Headingley",
                AddressTown = "Leeds",
                AddressPostcode = "LS2 1AA"
            };

            var expectedDateModel = new Lighting()
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
            };

            var mockRepository = new Mock<IRepository>();
            mockRepository.Setup(x => x.AddRecord(It.IsAny<Lighting>()));

            var lightingService = new LightingService(mockRepository.Object);

            lightingService.AddRecord(lightingRecord);

            mockRepository.Verify(x =>
                x.AddRecord(It.Is<Lighting>(m =>
                    m.Name == expectedDateModel.Name &&
                    m.EmailAddress == expectedDateModel.EmailAddress &&
                    m.AcceptableLighting == expectedDateModel.AcceptableLighting &&
                    m.BrightnessLevel == expectedDateModel.BrightnessLevel &&
                    m.AddressNameOrNumber == expectedDateModel.AddressNameOrNumber &&
                    m.AddressLine1 == expectedDateModel.AddressLine1 &&
                    m.AddressLine2 == expectedDateModel.AddressLine2 &&
                    m.AddressTown == expectedDateModel.AddressTown &&
                    m.AddressPostcode == expectedDateModel.AddressPostcode)),
                Times.Once);
        }
    }
}
