using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nominaApp
{
    abstract class Person
    {
        public override string ToString()
        {
			return "No todas las personas son empleados :o";
        }


        private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string imagePath;

		public string ImagePath
		{
			get { return imagePath; }
			set { imagePath = value; }
		}
	}
}
