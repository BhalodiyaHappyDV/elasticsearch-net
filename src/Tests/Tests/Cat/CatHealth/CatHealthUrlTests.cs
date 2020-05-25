﻿using System.Threading.Tasks;
using Elastic.Elasticsearch.Xunit.XunitPlumbing;
using Nest;
using Tests.Framework;
using static Tests.Framework.UrlTester;

namespace Tests.Cat.CatHealth
{
	public class CatHealthUrlTests : UrlTestsBase
	{
		[U] public override async Task Urls() => await GET("/_cat/health")
			.Fluent(c => c.CatHealth())
			.Request(c => c.CatHealth(new CatHealthRequest()))
			.FluentAsync(c => c.CatHealthAsync())
			.RequestAsync(c => c.CatHealthAsync(new CatHealthRequest()));
	}
}
