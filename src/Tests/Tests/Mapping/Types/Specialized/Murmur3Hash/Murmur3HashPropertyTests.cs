﻿using System;
using Nest;
using Tests.Core.ManagedElasticsearch.Clusters;
using Tests.Domain;
using Tests.Framework;
using Tests.Framework.Integration;
using Tests.Framework.ManagedElasticsearch.Clusters;

namespace Tests.Mapping.Types.Specialized.Murmur3Hash
{
	public class Murmur3HashPropertyTests : PropertyTestsBase
	{
		public Murmur3HashPropertyTests(WritableCluster cluster, EndpointUsage usage) : base(cluster, usage) { }

		protected override object ExpectJson => new
		{
			properties = new
			{
				name = new
				{
					type = "murmur3"
				}
			}
		};

		protected override Func<PropertiesDescriptor<Project>, IPromise<IProperties>> FluentProperties => f => f
				.Murmur3Hash(s => s
					.Name(p => p.Name)
				);


		protected override IProperties InitializerProperties => new Properties
		{
			{ "name", new Murmur3HashProperty() }
		};
	}
}