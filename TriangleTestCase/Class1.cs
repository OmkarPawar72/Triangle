
/*
 * Name: Omkar Pawar
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;

namespace TriangleTestCase
{
    [TestFixture]
    public class Class1
    {
		//Only one (1) test for a valid equilateral triangle
		//1st Answer. 
		[Test]
        public void Equilateral_Triangle_Test_Case()
        {
            string expected = "Based on all sides being equal, the type of triangle is an EQUILATERAL";
			TestClassForTriangle tt = new TestClassForTriangle(15, 15, 15);

            string actual = tt.equilateral_triangle();
            Assert.AreEqual(expected,actual);
		}

		//Three (3) tests for a valid isosceles triangle
		//2nd Answer.
		[Test]
        public void Isosceles_Triangle_Test_Case()
        {
            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";
            TestClassForTriangle tt = new TestClassForTriangle(12, 12, 20);

            string actual = tt.equilateral_triangle();
            Assert.AreEqual(expected,actual);

		}

        //2nd B Answer.

        [Test]
        public void Isosceles_Triangle_Second_Test_Case()
        {
            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";
            TestClassForTriangle tt = new TestClassForTriangle(17, 22, 17);

            string actual=tt.equilateral_triangle();
            Assert.AreEqual(expected,actual);
        }

		//2nd C Answer. 

		[Test]
		public void Isosceles_Triangle_Third_Test_Case()
		{
			string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";
			TestClassForTriangle tt = new TestClassForTriangle(109, 109, 100);

			string actual = tt.equilateral_triangle();
			Assert.AreEqual(expected, actual);
		}


        //Five (5) tests for a valid scalene triangle
        //Ans 3 

        [Test]
        public void Scalene_Triangle_Test_Case()
        {
            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            TestClassForTriangle tt = new TestClassForTriangle(10,25,27);

            string actual=tt.equilateral_triangle();
            Assert.AreEqual(expected,actual);
        }

		//Ans 3 B 

		[Test]
		public void Scalene_Triangle_Second_Test_Case()
		{
			string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
			TestClassForTriangle tt = new TestClassForTriangle(20, 35, 30);

			string actual = tt.equilateral_triangle();
			Assert.AreEqual(expected, actual);
		}

		//Ans 3 C

		[Test]
		public void Scalene_Triangle_Third_Test_Case()
		{
			string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
			TestClassForTriangle tt = new TestClassForTriangle(30, 20, 27);

			string actual = tt.equilateral_triangle();
			Assert.AreEqual(expected, actual);
		}

		//Ans 3 D

		[Test]
		public void Scalene_Triangle_Fourth_Test_Case()
		{
			string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
			TestClassForTriangle tt = new TestClassForTriangle(40, 50, 55);

			string actual = tt.equilateral_triangle();
			Assert.AreEqual(expected, actual);
		}

		//Ans 3 E

		[Test]
		public void Scalene_Triangle_Fifth_Test_Case()
		{
			string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
			TestClassForTriangle tt = new TestClassForTriangle(50, 67, 73);

			string actual = tt.equilateral_triangle();
			Assert.AreEqual(expected, actual);
		}

		//Three (3) tests for verifying a zero length for one or more sides
		//Ans 4 A

		[Test]
		public void Fist_Varify_Zero_Test_Case()
		{
			string expected = "At least one side of your triangle has a zero length and is thus invalid";
			TestClassForTriangle tt = new TestClassForTriangle(0, 10, 20);

			string actual =tt.equilateral_triangle();
			Assert.AreEqual(expected, actual);
		}

		//Ans 4 B
		[Test]
		public void Second_Varify_Zero_Test_Case()
		{
			string expected = "At least one side of your triangle has a zero length and is thus invalid";
			TestClassForTriangle tt = new TestClassForTriangle(20, 25, 0);

			string actual = tt.equilateral_triangle();
			Assert.AreEqual(expected, actual);
		}

		//Ans 4 C
		[Test]
		public void Third_Varify_Zero_Test_Case()
		{
			string expected = "At least one side of your triangle has a zero length and is thus invalid";
			TestClassForTriangle tt = new TestClassForTriangle(60, 0, 50);

			string actual = tt.equilateral_triangle();
			Assert.AreEqual(expected, actual);
		}

		//Three (3) tests for verifying an invalid response (other than a zero length)
		//Ans 5 A 

		[Test]
		public void Invalid_Response_First_Test_Case()
		{
			string expected = "Based on the values entered, the triangle is INVALID";
			TestClassForTriangle tt = new TestClassForTriangle(10, 25, 75);

			string actual=tt.equilateral_triangle();
			Assert.AreEqual(expected, actual);
		}

		//Ans 5 B
		[Test]
		public void Invalid_Response_Second_Test_Case()
		{
			string expected = "Based on the values entered, the triangle is INVALID";
			TestClassForTriangle tt = new TestClassForTriangle(100, 20, 179);

			string actual = tt.equilateral_triangle();
			Assert.AreEqual(expected, actual);
		}

		//Ans 5 C
		[Test]
		public void Invalid_Response_Third_Test_Case()
		{
			string expected = "Based on the values entered, the triangle is INVALID";
			TestClassForTriangle tt = new TestClassForTriangle(75, 15, 5);

			string actual = tt.equilateral_triangle();
			Assert.AreEqual(expected, actual);
		}
	}
}
