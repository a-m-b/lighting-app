using LightingApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LightingApp.Data
{
    public interface IRepository
    {
        void AddRecord(Lighting lightingRecord);
    }
}
