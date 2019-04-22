using System;

namespace _15._04._2019
{
	class Program
	{
		static void Main(string[] args)
		{
			Faculty My = new Faculty("AMI", 900, "Dyak");
			My.ChangeDean += ShowMessage;
			My.DeanSurname = "Horlach";
			My.ChangeDean -= ShowMessage;
		}
		static void ShowMessage(string Message)
		{
			Console.WriteLine(Message);
		}
	}
}
