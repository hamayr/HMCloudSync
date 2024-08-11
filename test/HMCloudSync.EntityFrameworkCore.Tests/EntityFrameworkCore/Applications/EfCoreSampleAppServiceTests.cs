using HMCloudSync.Samples;
using Xunit;

namespace HMCloudSync.EntityFrameworkCore.Applications;

[Collection(HMCloudSyncTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<HMCloudSyncEntityFrameworkCoreTestModule>
{

}
