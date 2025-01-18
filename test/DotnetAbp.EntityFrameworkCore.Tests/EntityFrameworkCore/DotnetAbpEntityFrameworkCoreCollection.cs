using Xunit;

namespace DotnetAbp.EntityFrameworkCore;

[CollectionDefinition(DotnetAbpTestConsts.CollectionDefinitionName)]
public class DotnetAbpEntityFrameworkCoreCollection : ICollectionFixture<DotnetAbpEntityFrameworkCoreFixture>
{

}
