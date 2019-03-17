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
			ConflictResolve();
			Console.WriteLine("Git Test!");

			ConflictResolve();
		}

		private static void ConflictResolve()
		{
			Console.WriteLine("Program::ConflictResolve() be called");

			Console.WriteLine("Testing"); 
		}
	}
}
