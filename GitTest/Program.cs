﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
	public class Program
	{
		private static void NewMethod()
		{
			//do something
			//do something
		}

		static void Main(string[] args)
		{
			//add New Method
			NewMethod();
			//remove mergeFail() call at start
			Console.WriteLine("Git Test!");
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
