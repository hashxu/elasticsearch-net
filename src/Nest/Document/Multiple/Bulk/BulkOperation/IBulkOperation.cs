﻿using System;
using System.Runtime.Serialization;
using Elasticsearch.Net;
using Elasticsearch.Net.Utf8Json;

namespace Nest
{
	[InterfaceDataContract]
	public interface IBulkOperation
	{
		Type ClrType { get; }

		[DataMember(Name = "_id")]
		Id Id { get; set; }

		[DataMember(Name = "_index")]
		IndexName Index { get; set; }

		string Operation { get; }

		[DataMember(Name = "retry_on_conflict")]
		int? RetriesOnConflict { get; set; }

		[DataMember(Name = "routing")]
		Routing Routing { get; set; }

		[DataMember(Name = "version")]
		long? Version { get; set; }

		[DataMember(Name = "version_type")]
		VersionType? VersionType { get; set; }

		object GetBody();

		Id GetIdForOperation(Inferrer inferrer);

		Routing GetRoutingForOperation(Inferrer settingsInferrer);
	}
}
