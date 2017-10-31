using System;
using Task3.E3SClient.Entities;
using Task3.E3SClient;
using System.Configuration;
using System.Linq;

namespace Task3
{
	public class E3SProviderTests
	{
		public void WithoutProvider()
		{
			var client = new E3SQueryClient(ConfigurationManager.AppSettings["user"] , ConfigurationManager.AppSettings["password"]);
			var res = client.SearchFTS<EmployeeEntity>("workstation:(EPBYMINW6960)", 0, 1);

			foreach (var emp in res)
			{
				Console.WriteLine("{0} {1}", emp.nativename, emp.workstation);
			}
		}

		public void WithoutProviderNonGeneric()
		{
			var client = new E3SQueryClient(ConfigurationManager.AppSettings["user"], ConfigurationManager.AppSettings["password"]);
			var res = client.SearchFTS(typeof(EmployeeEntity), "workstation:(EPBYMINW6960)", 0, 10);

			foreach (var emp in res.OfType<EmployeeEntity>())
			{
				Console.WriteLine("{0} {1}", emp.nativename, emp.workstation);
			}
		}


		public void WithProvider()
		{
			var employees = new E3SEntitySet<EmployeeEntity>(ConfigurationManager.AppSettings["user"], ConfigurationManager.AppSettings["password"]);

			foreach (var emp in employees.Where(e => e.workstation == "EPBYMINW6960"))
			{
				Console.WriteLine("{0} {1}", emp.nativename, emp.workstation);
			}
        }

		public void WithProviderTask1()
		{
			var employees = new E3SEntitySet<EmployeeEntity>(ConfigurationManager.AppSettings["user"], ConfigurationManager.AppSettings["password"]);

			foreach (var emp in employees.Where(e => "EPBYMINW6960" == e.workstation))
			{
				Console.WriteLine("{0} {1}", emp.nativename, emp.workstation);
			}
		}

		public void StartsEndsTask2()
		{
			var employees = new E3SEntitySet<EmployeeEntity>(ConfigurationManager.AppSettings["user"], ConfigurationManager.AppSettings["password"]);

			foreach (var emp in employees.Where(e => e.workstation.Contains("EPBYMI")))
			{
				Console.WriteLine("{0} {1}", emp.nativename, emp.workstation);
			}
		}

		public void AndMethodTask3()
		{
			var employees = new E3SEntitySet<EmployeeEntity>(ConfigurationManager.AppSettings["user"], ConfigurationManager.AppSettings["password"]);

			foreach (var emp in employees.Where(e => e.workstation.StartsWith("EPBYMI") && e.firstname.EndsWith("ei") && e.office.Contains("Min")))
			{
				Console.WriteLine("{0} {1}", emp.nativename, emp.workstation);
			}
		}
	}
}
