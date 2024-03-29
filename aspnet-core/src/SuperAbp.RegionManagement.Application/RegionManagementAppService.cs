﻿using SuperAbp.RegionManagement.Localization;
using Volo.Abp.Application.Services;

namespace SuperAbp.RegionManagement;

public abstract class RegionManagementAppService : ApplicationService
{
    protected RegionManagementAppService()
    {
        LocalizationResource = typeof(RegionManagementResource);
        ObjectMapperContext = typeof(SuperAbpRegionManagementApplicationModule);
    }
}
