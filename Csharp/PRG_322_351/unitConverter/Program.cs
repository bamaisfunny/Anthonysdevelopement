using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitConverter
{
    class Program
    {
        
        public delegate double convertgrams(double input);
        public static int grams;
        public static string convertTo;
        public double Gs2Kgs;
        public double Gs2Lbs;
        public double Gs2Ozs;
        public double Gs2Gs;
        static void Main(string[] args)
        {

            Dictionary<string, convertgrams> gramsMethods = new Dictionary<string,convertgrams>();
            Converter c = new Converter();
            Converter.conversions.Add("Gs2Kgs", c);
            Converter.conversions.Add("Gs2Lbs", c);
            Converter.conversions.Add("Gs2Ozs", c);
            Converter.conversions.Add("Gs2Gs", c);
           
            convertgrams cv1 = new convertgrams(Converter.Gs2Kgs);
            gramsMethods.Add("Gs2Kgs",cv1);
            convertgrams cv2 = new convertgrams(Converter.Gs2Lbs);
            gramsMethods.Add("Gs2Lbs",cv2);
            convertgrams cv3 = new convertgrams(Converter.Gs2Ozs);
            gramsMethods.Add("Gs2Ozs",cv3);
            convertgrams cv4 = new convertgrams(Converter.Gs2Gs);
            gramsMethods.Add("Gs2Gs", cv4);
            Console.WriteLine("what are the number of grams you are trying to convert?");
           Program.grams = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("What do you want to convert it to?");
           Console.WriteLine("Kgs");
           Console.WriteLine("Lbs");
           Console.WriteLine("Ozs");
           Console.WriteLine("Gs");
           Program.convertTo = Console.ReadLine();

            string convertSelect = ("Gs2" + Program.convertTo); 

           foreach (KeyValuePair<string, Converter> kvp in Converter.conversions)
           {
               if (convertSelect == kvp.Key)
               {
                   foreach (KeyValuePair<string, convertgrams> kvp2 in gramsMethods)
                   {
                       if (convertSelect == kvp.Key)
                       {
                           Console.WriteLine(kvp2.Value(Program.grams).ToString());
                       }
                       else
                       {
                           Console.WriteLine( "Somthing went wrong");
                       }
                   }
               }
           }
           Console.ReadKey();
        }
    }
}
