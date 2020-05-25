﻿using System.Threading.Tasks;
using Elastic.Elasticsearch.Xunit.XunitPlumbing;
using Elasticsearch.Net;
using Nest;
using Tests.Framework;
using static Tests.Framework.UrlTester;

namespace Tests.XPack.Watcher.WatcherStats
{
	public class WatcherStatsUrlTests : UrlTestsBase
	{
		[U] public override async Task Urls()
		{
			await GET("/_xpack/watcher/stats")
					.Fluent(c => c.WatcherStats())
					.Request(c => c.WatcherStats(new WatcherStatsRequest()))
					.FluentAsync(c => c.WatcherStatsAsync())
					.RequestAsync(c => c.WatcherStatsAsync(new WatcherStatsRequest()))
				;

			await GET("/_xpack/watcher/stats/_all")
					.Fluent(c => c.WatcherStats(r => r.WatcherStatsMetric(WatcherStatsMetric.All)))
					.Request(c => c.WatcherStats(new WatcherStatsRequest(WatcherStatsMetric.All)))
					.FluentAsync(c => c.WatcherStatsAsync(r => r.WatcherStatsMetric(WatcherStatsMetric.All)))
					.RequestAsync(c => c.WatcherStatsAsync(new WatcherStatsRequest(WatcherStatsMetric.All)))
				;
		}
	}
}
