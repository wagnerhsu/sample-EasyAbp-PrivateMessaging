﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyAbp.PrivateMessaging.Data
{
    public interface IPrivateMessagingDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
