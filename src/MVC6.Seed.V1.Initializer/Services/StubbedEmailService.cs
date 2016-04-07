﻿using MVC6.Seed.V1.Framework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC6.Seed.V1.Initializer.Services
{
    public class StubbedEmailService : IEmailService
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            return Task.FromResult(0);
        }
    }
}
