using DotnetAbp.Samples;
using Xunit;

namespace DotnetAbp.EntityFrameworkCore.Domains;

[Collection(DotnetAbpTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<DotnetAbpEntityFrameworkCoreTestModule>
{

}
