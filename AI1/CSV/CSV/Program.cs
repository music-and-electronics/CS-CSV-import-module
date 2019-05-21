﻿using System;
using System.IO;
using System.Collections.Generic;
namespace CSV
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			StreamReader sr= new StreamReader("/home/dextop/DataSet.csv");
			List<int[]> file_parse = new List<int[]> ();
			while(!sr.EndOfStream)
			{
				string line = sr.ReadLine ();
				string[] data= line.Split(',');
				int[] data_to_integer = new int[data.Length];
				for(int i=0;i<data.Length;i++)
				{
					if (data [i].Length > 3)
						break;
					else
					data_to_integer [i] = Int32.Parse (data [i]);
				}
				file_parse.Add (data_to_integer);
	
			}
			foreach(int [] a in file_parse)
			{
				for(int i=0;i<a.Length;i++)
				{
					Console.Write ($"{a [i]} ");
				}
				Console.WriteLine ();
			}




		}
	}
}
