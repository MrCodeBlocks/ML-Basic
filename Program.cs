using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
	class Program
	{
		static void Main(string[] args)
		{
			float[] fInputs = { 1f, 2f };
			Matrix mat = new Matrix(1, 2, ref fInputs);
			Console.ReadKey();
		}
	}
}
