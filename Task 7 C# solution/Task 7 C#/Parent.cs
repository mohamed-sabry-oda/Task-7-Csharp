using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_C_
{
	internal class Parent
	{
		private int X;
		private int Y;


		public int x
		{
			get { return X; }
			set { X = value; }
		}

		public int y
		{
			get { return Y; }
			set { Y = value; }
		}

		//constructor 

		public Parent(int _x, int _y)
		{
			X = _x;
			Y = _y;
		}


		//method
		public override string ToString()
		{
			return $"{X} {Y}";
		}


		//product 
		public virtual int product()
		{
			{
				return X * Y;
			}

		}
	}
}
