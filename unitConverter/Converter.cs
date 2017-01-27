using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace unitConverter
{
   
    public class Converter
    {
        public static Dictionary<string, Converter> conversions = new Dictionary<string, Converter>();

        public static double Gs2Kgs(double input)
        {
            return input / 1000;
        }
        public static double Gs2Lbs(double input)
        {
            return input * 453.592;
        }
        public static double Gs2Ozs(double input)
        {
            return input * 0.035274;
        }
        public static double Gs2Gs(double input)
        {
            return 1 * input; 
        }

    }
}
