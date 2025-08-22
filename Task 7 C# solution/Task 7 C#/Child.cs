using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_C_
{
    internal class Child :Parent
    {
        private int Z;

        public int z
        {
            get { return Z; }
            set { Z = value; }
        }

        public Child(int _x,int _y, int _z) : base(_x,_y)
        { 
            Z = _z;
        }


        //product with new
        //public new int product()
        //{
        //    return base.product() * Z;
        //}


        //product with override
        public override int product()
        {
            return base.product() * Z;
        }
        public override string ToString()
        {
            return $"{x} {y} {Z}";
        }
    }
}
