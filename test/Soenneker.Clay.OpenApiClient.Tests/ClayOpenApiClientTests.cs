using Soenneker.Tests.HostedUnit;

namespace Soenneker.Clay.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class ClayOpenApiClientTests : HostedUnitTest
{
    public ClayOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
