using System;
using System.IO;
using System.Collections.Generic;
namespace CSV
{
	class ANN
	{
		private  double w1=0.5;
		private double w2=0.5;
		public double learning_rate;

		public void Weight(object []a)
		{

		}
	}
	
	class Parse
	{
		public List<object[]> file_parse = new List<object[]> ();

		public Parse(StreamReader sr)
		{

			while(!sr.EndOfStream)
			{
				string line = sr.ReadLine ();
				object[] data= line.Split(',');
				file_parse.Add (data);
			}
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			StreamReader sr= new StreamReader("/home/dextop/DataSet.csv");
			Parse parse = new Parse (sr);
			ANN ann = new ANN ();
			ann.Weight (parse.file_parse);

		}
	}
}
