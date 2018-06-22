using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;
using BenchmarkDotNet.Attributes.Jobs;
using DevOps.Primitives.CSharp.Helpers.Common;
using DevOps.Primitives.SourceGraph;
using DevOps.Primitives.SourceGraph.Helpers.Common.Accounts;
using DevOps.Primitives.SourceGraph.Helpers.Consolidated;
using System.Collections.Generic;
using static DevOps.Primitives.SourceGraph.Helpers.Consolidated.Builders.CodeBuilder;
using static DevOps.Primitives.SourceGraph.Helpers.Consolidated.Builders.GitHubAccountBuilder;

namespace Benchmarks.Version12
{
    [SimpleJob(10), MemoryDiagnoser]
    [RPlotExporter, RankColumn]
    public class Tests
    {
        [Benchmark]
        public GitHubAccount GetAccount()
            => GitHub(
                new GitHubAccountSpecification("AccountName", "SecretString", "my@account.email", "My FullName", "2018 My Copyright", "https://me.com/nuget", "https://me.com/nuget/icon.png", "MyPackagePrefix"),
                new List<Code> { GetCode() });

        [Benchmark]
        public Code GetCode()
            => Class("MyProject", "My project description", "1.0.0", null, "MyTypeName",
                usingDirectiveList: UsingDirectiveLists.Create("System", "System.IO"),
                documentationCommentList: Comments.Summary("This is the class XML-doc summary comment"),
                attributeListCollection: AttributeLists.Create(Attributes.ProtoContract()),
                constructorList: ConstructorLists.Create(Constructors.Default("MyTypeName")),
                methodList: MethodLists.Create(Methods.PublicStatic("GetInt", "int", "5 + 5")),
                propertyList: PropertyLists.Create(Properties.Public("MyProperty", "string", "This is the property XML-doc summary comment", AttributeLists.Create(Attributes.ProtoMember(1)))));
    }
}
