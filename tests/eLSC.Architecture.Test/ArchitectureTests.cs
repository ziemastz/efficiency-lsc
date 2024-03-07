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
        var assembly = typeof(Domain.AssemblyReference).Assembly;

        var otherProjects = new[]
        {
            ApplicationNamespace,
            InfrastructureNamespace,
        };

        var result = Types.InAssembly(assembly)
            .ShouldNot()
            .HaveDependencyOnAll(otherProjects)
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    public void ApplicationShouldNotHaveDependencyOnOtherProject()
    {
        var assembly = typeof(Application.AssemblyReference).Assembly;

        var otherProjects = new[]
        {
            InfrastructureNamespace,
        };

        var result = Types.InAssembly(assembly)
            .ShouldNot()
            .HaveDependencyOnAll(otherProjects)
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }
}