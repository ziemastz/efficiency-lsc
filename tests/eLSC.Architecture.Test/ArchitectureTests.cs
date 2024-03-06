
namespace eLSC.Architecture.Test;


public class ArchitectureTests
{
    private const string DomainNamespace = "eLSC.Domain";
    private const string ApplicationNamespace = "eLSC.Application";
    private const string InfrastructureNamespace = "eLSC.Infrastructure";

    [Fact]
    public void DomainShouldNotHaveDependencyOnOtherProject()
    {
        // arrange
        var assembly = typeof(eLSC.Domain.).Assembly;
        // act

        // assert
    }
}