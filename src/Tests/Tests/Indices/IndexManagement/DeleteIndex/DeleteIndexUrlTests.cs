﻿using System.Threading.Tasks;
using Elastic.Elasticsearch.Xunit.XunitPlumbing;
using Nest;
using Tests.Domain;
using Tests.Framework;
using static Nest.Indices;
using static Tests.Framework.UrlTester;

namespace Tests.Indices.IndexManagement.DeleteIndex
{
	public class DeleteIndexUrlTests
	{
		[U] public async Task Urls()
		{
			var indices = Index<Project>().And<Developer>();
			var index = "project%2Cdevs";
			await DELETE($"/{index}")
					.Fluent(c => c.DeleteIndex(indices, s => s))
					.Request(c => c.DeleteIndex(new DeleteIndexRequest(indices)))
					.FluentAsync(c => c.DeleteIndexAsync(indices))
					.RequestAsync(c => c.DeleteIndexAsync(new DeleteIndexRequest(indices)))
				;
		}
	}
}
