using FluentAssertions;
using NetArchTest.Rules;

namespace eLSC.Architecture.Test;


public class ArchitectureTests
{
    private const string DomainNamespace = "eLSC.Domain";
    private const string ApplicationNamespace = "eLSC.Application";
    private const string InfrastructureNamespace = "eLSC.Infrastructure";

    [Fact]
    public void DomainShouldNotHaveDependencyOnOtherProject()
    {
       // var assembly = typeof(Domain.Entities).Assembly;

        var otherProjects = new[]
        {
            DomainNamespace,
            ApplicationNamespace,
            InfrastructureNamespace,
        };

        var result = Types.InCurrentDomain()
            .ShouldNot()
            .NotHaveDependencyOnAny(otherProjects)
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }
}