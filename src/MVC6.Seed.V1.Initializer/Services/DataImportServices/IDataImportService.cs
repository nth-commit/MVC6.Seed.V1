﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC6.Seed.V1.Initializer.Services.DataImportServices
{
    public interface IDataImportService
    {
        T Deserialize<T>(string fileName);
    }
}
