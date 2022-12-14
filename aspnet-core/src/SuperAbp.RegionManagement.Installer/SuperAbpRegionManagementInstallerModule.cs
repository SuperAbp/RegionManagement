using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace SuperAbp.RegionManagement;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class SuperAbpRegionManagementInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<SuperAbpRegionManagementInstallerModule>();
        });
    }
}
