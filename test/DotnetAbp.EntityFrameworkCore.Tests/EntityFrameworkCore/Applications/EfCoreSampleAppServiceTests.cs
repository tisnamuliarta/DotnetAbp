using DotnetAbp.Samples;
using Xunit;

namespace DotnetAbp.EntityFrameworkCore.Applications;

[Collection(DotnetAbpTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<DotnetAbpEntityFrameworkCoreTestModule>
{

}
