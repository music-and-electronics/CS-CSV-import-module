using System;
using System.IO;
using System.Collections.Generic;
namespace CSV
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			StreamReader sr= new StreamReader("/home/dextop/DataSet.csv");
			List<string[]> file_parse = new List<string[]> ();
			while(!sr.EndOfStream)
			{
				string line = sr.ReadLine ();
				string[] data= line.Split(',');
				file_parse.Add (data);
			}

			foreach(string[] a in file_parse)
			{
				for(int i=0;i<a.Length;i++)
				{
					Console.Write (a [i]);
				}
				Console.WriteLine ();
			}

			
		}
	}
}
