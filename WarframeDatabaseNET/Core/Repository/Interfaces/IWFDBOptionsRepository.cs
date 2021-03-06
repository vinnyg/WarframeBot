﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarframeDatabaseNet.Core.Domain;
using WarframeDatabaseNet.Enums.MissionType;
using WarframeDatabaseNet.Enums.NodeType;

namespace WarframeDatabaseNet.Core.Repository.Interfaces
{
    public interface IWFDBOptionsRepository : IRepository<WFMiscIgnoreSettings>
    {
        int GetItemMinimum(WarframeItem item);
    }
}
