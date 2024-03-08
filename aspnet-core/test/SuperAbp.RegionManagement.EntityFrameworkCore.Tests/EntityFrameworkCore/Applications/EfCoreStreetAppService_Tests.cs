﻿using SuperAbp.RegionManagement.Provinces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SuperAbp.RegionManagement.EntityFrameworkCore.Applications;

[Collection(RegionManagementTestConsts.CollectionDefinitionName)]
public class EfCoreStreetAppService_Tests : StreetAppService_Tests<RegionManagementEntityFrameworkCoreTestModule>
{
}