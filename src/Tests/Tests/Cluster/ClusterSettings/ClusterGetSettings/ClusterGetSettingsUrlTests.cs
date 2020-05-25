﻿using System.Threading.Tasks;
using Elastic.Elasticsearch.Xunit.XunitPlumbing;
using Nest;
using Tests.Framework;
using static Tests.Framework.UrlTester;

namespace Tests.Cluster.ClusterSettings.ClusterGetSettings
{
	public class ClusterGetSettingsUrlTests : UrlTestsBase
	{
		[U] public override async Task Urls() => await GET("/_cluster/settings")
			.Fluent(c => c.ClusterGetSettings())
			.Request(c => c.ClusterGetSettings(new ClusterGetSettingsRequest()))
			.FluentAsync(c => c.ClusterGetSettingsAsync())
			.RequestAsync(c => c.ClusterGetSettingsAsync(new ClusterGetSettingsRequest()));
	}
}
