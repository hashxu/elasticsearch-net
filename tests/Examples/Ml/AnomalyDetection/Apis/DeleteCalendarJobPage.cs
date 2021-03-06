using Elastic.Xunit.XunitPlumbing;
using Nest;
using System.ComponentModel;

namespace Examples.Ml.AnomalyDetection.Apis
{
	public class DeleteCalendarJobPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		[Description("ml/anomaly-detection/apis/delete-calendar-job.asciidoc:38")]
		public void Line38()
		{
			// tag::1b0b29e5cd7550c648d0892378e93804[]
			var response0 = new SearchResponse<object>();
			// end::1b0b29e5cd7550c648d0892378e93804[]

			response0.MatchesExample(@"DELETE _ml/calendars/planned-outages/jobs/total-requests");
		}
	}
}