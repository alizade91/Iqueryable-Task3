using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.E3SClient.Entities
{
	public class Skills
	{

		[JsonProperty]
		public string expert { get; set; }

		[JsonProperty]
		public string advanced { get; set; }

		[JsonProperty]
		public string intermediate { get; set; }


		[JsonProperty]
		public string position { get; set; }

		[JsonProperty]
		public string primary { get; set; }

	}

	public class WorkHistory
	{
		[JsonProperty]
		public string position { get; set; }

		[JsonProperty]
		public string project { get; set; }

		[JsonProperty]
		public string startdate { get; set; }
	}



	[E3SMetaType("meta:people-suite:people-api:com.epam.e3s.app.people.api.data.pluggable.EmployeeEntity")]
	public class EmployeeEntity : E3SEntity
	{

		[JsonProperty]
		List<string> phone;

		[JsonProperty]
		Skills skill { get; set; }

		[JsonProperty]
		public string firstname { get; set; }

		[JsonProperty]
		public string lastname { get; set; }

		[JsonProperty]
		List<string> fullname { get; set; }

		[JsonProperty]
		List<string> country { get; set; }

		[JsonProperty]
		List<string> email { get; set; }

		[JsonProperty]
		public string manager { get; set; }

		[JsonProperty]
		public string superior { get; set; }

		[JsonProperty]
		public string project { get; set; }

		[JsonProperty]
		public string projectall { get; set; }

		[JsonProperty]
		public string office { get; set; }

		[JsonProperty]
		public string room { get; set; }

		[JsonProperty]
		public string status { get; set; }

		[JsonProperty]
		public string workstation { get; set; }

		[JsonProperty]
		public string nativename { get; set; }


		[JsonProperty]
		public double billable { get; set; }

		[JsonProperty]
		public double nonbillable { get; set; }
	}
}
