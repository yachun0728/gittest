using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
	public class Program
	{
		static void Main(string[] args)
		{
			MergeFail();
			Console.WriteLine("Git Test!");

			MergeFail();
		}

		private static void MergeFail()
		{
			Console.WriteLine("Merge Fail");
		}
	}
}
