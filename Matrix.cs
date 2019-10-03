using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
	public class Matrix
	{
		public int m_Rows;
		public int m_Cols;
		public float[] m_Inputs;

		// The constructor will start with rows and columns
		public Matrix(int num_rows, int num_cols, ref float[] num_imputs)
		{
			m_Rows = num_cols;
			m_Cols = num_cols;
			m_Inputs = num_imputs;
		}


		// Basic multpily functions that will return floats
		public static Matrix Multiply(ref Matrix matrices)
		{
			
			return matrices;
		}

	}
}
