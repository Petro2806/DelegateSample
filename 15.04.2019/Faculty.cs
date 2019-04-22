using System;
using System.Collections.Generic;
using System.Text;

namespace _15._04._2019
{
	class Faculty
	{
		public delegate void DeanStateHandler(string Message);
		public event DeanStateHandler ChangeDean;

		public string Name { get; set; }
		public int NumbOfStudents { get; set; }
		private string DeanSurName;

		public string DeanSurname
		{
			get { return DeanSurName; }
			set{
				if (ChangeDean != null)
					ChangeDean($"Dean {DeanSurName} changed to {value}");
				DeanSurName = value;
			}
		}

		public Faculty(string name="",int numbofstudents=0,string deansurname="")
		{
			Name = name;
			NumbOfStudents = numbofstudents;
			DeanSurname = deansurname;
		}
	}
}
