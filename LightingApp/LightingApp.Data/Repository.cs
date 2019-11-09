using System;
using System.Collections.Generic;
using System.Text;
using LightingApp.Data.Models;

namespace LightingApp.Data
{
    public class Repository : IRepository
    {
        private readonly LightingContext lightingContext;

        public Repository(LightingContext lightingContext)
        {
            this.lightingContext = lightingContext;
        }

        public void AddRecord(Lighting lightingRecord)
        {
            lightingContext.Lightings.Add(lightingRecord);
            lightingContext.SaveChangesAsync();
        }
    }
}
