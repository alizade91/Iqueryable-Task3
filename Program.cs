using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	class Program
	{
		static void Main(string[] args)
		{
			var tests = new E3SProviderTests();
			Console.OutputEncoding = Encoding.UTF8;
			tests.WithoutProvider();
			tests.WithoutProviderNonGeneric();
			tests.WithProvider();
			tests.WithProviderTask1();
			tests.StartsEndsTask2();
			tests.AndMethodTask3();
			Console.ReadKey();
		}
	}
}
