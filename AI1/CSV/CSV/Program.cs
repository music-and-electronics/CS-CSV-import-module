using System;
using System.IO;
using System.Collections.Generic;
namespace CSV
{
	class ANN
	{
        private double w1;
        private double w2;
		public double learning_rate=0.1;

		public void Weight(List<string[]> a)
		{
            Console.Write("Input the first weight: ");
            w1 = double.Parse(Console.ReadLine());
            Console.Write("Input the second weight: ");
            w2 = double.Parse(Console.ReadLine());
            double result;
            foreach (string[] array in a)
            {
                result = double.Parse(array[0]) * w1 + double.Parse(array[1]) * w2;
                double output = double.Parse(array[2]);
                while ((1 - learning_rate) > result / output)
                {
                    BackPropagation(result, output);
                    result = double.Parse(array[0]) * w1 + double.Parse(array[1]) * w2;
                }
            }

            Console.Write(w1);
            Console.WriteLine();
            Console.Write(w2);
		}
        void BackPropagation(double a, double b)
        {
            
                if (b != 0)
                {
                    w1 +=((b-a)/b) * w1;
                    w2 += ((b-a)/b) * w2;
                }

        }
	}
	
	class Parse
	{
		public List<string[]> file_parse = new List<string[]> ();

		public Parse(StreamReader sr)
		{
            while (!sr.EndOfStream)
			{
				string line = sr.ReadLine ();
				string[] data= line.Split(',');
                int exNum = 1;
                bool canConvert = int.TryParse(data[0], out exNum); 
                if(canConvert==true)
                file_parse.Add (data);
			}
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			StreamReader sr= new StreamReader("C:/Users/kjh97/source/repos/musicandelectronics/Csharp_CSV/AI1/CSV/CSV/DataSet.csv");
			Parse parse = new Parse (sr);
			ANN ann = new ANN ();
			ann.Weight (parse.file_parse);
		}
	}
}
