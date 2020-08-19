using System;
using System.Collections.Generic;
using System.Text;

namespace T40_Kuviot
{
    class Shapes
    {
		private List<Shape> shapelist = new List<Shape>();
		public List<Shape> ShapeList
		{
			get
			{
				return shapelist;
			}
		}

		public Shapes() { 
		}
	}
}
