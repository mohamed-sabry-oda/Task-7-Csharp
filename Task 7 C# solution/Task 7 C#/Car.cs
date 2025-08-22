using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_C_
{
    internal class Car
    {
		#region problem 1
		#region Attributes
		private int id;
		private string brand;
		private int price;
		#endregion

		#region properties
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		public string Brand
		{
			get { return brand; }
			set { brand = value; }
		}

		public int Price
		{
			get { return price; }
			set { price = value; }
		}
		#endregion

		#region constructor
		public Car(int _Id, string _Brand, int _Price)
		{
			id = _Id;
			brand = _Brand;
			price = _Price;
		}

		public Car(int _Id, string _Brand)
		{
			id = _Id;
			brand = _Brand;
			price = 8000;
		}

		public Car(int _Id)
		{
			id = _Id;
			brand = "adidas";
			price = 8000;
		}

		public Car()
		{
			id = 1;
			brand = "bMW";
			price = 8000;
		}
		#endregion

		#region Methods
		public override string ToString()
		{
			return $"Id is {id} Brand is {brand} Price is {price}";
		}
		#endregion 
		#endregion
	}
}
