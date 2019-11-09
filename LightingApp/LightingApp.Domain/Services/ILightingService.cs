using LightingApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LightingApp.Domain.Services
{
    public interface ILightingService
    {
        void AddRecord(Lighting lightingRecord);
    }
}
