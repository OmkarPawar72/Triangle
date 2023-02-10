using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSolver
{
	public class TestClassForTriangle
	{
		int first;
		int second;
		int third;

		public TestClassForTriangle(int first, int second,int thrid)
		{
			this.first = first;
			this.second = second;
			this.third = thrid;
		}
		
		public string equilateral_triangle()
		{
			string final;

			if ((first == 0) || (second == 0) || (third == 0))
			{
				final = "At least one side of your triangle has a zero length and is thus invalid";
				return final;
			}

			if (((first + second) > third) && ((first + third) > second) && ((second + third) > first))
			{
				if (first == second && second == third)
				{
					final = "Based on all sides being equal, the type of triangle is an EQUILATERAL";
				}
				else if (first == second || first == third || second == third)
				{
					final = "Based on two sides being equal, the type of triangle is an ISOSCELES";
				}
				else
				{
					final = "Based on all three sides being different, the type of triangle is a SCALENE";
				}
			}
			else
			{
				final = "Based on the values entered, the triangle is INVALID";
			}
			return final;
		}
	}
}
