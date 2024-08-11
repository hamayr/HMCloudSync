using HMCloudSync.Samples;
using Xunit;

namespace HMCloudSync.EntityFrameworkCore.Domains;

[Collection(HMCloudSyncTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<HMCloudSyncEntityFrameworkCoreTestModule>
{

}
