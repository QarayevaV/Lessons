using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_31._03._22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Type Conversion
            byte byteVal = byte.MaxValue;
            short shortVal = byteVal;

            short shortVal1 = short.MaxValue;
            int intVal = shortVal1;

            int intVal1 = int.MaxValue;
            long longVal = intVal1;

            long longVal1 = long.MaxValue;
            double doubleVal = longVal1;

            byte byteVar = byte.MaxValue;
            int takeByteVal = byteVar;

            //Explicit Type Conversion
            float floatVal1 = 288888888888775;
            long longVal2 = (long)floatVal1;

            decimal decimalVar = 785.01M;
            int takeDecimalVal = (int)decimalVar;

            long longVar = 200000;
            int takeLongVal = (int)longVar;

            double doubleVariable1 = double.MinValue;
            float takeDoubleVal = (float)doubleVariable1;

            int intVariable = 300;
            byte takeIntVal = (byte)intVariable;

            //Helper Classes (COnvert)

            string numberString = "150";
            int number = Convert.ToInt32(numberString);
            bool booleanVal = Convert.ToBoolean(numberString);
            byte byteNumVal = Convert.ToByte(numberString);
            ushort stringToUshortConvert = Convert.ToUInt16(numberString);
            char stringToCharCOnvert = Convert.ToChar(numberString);
            bool booleanVariable = true;
            string stringVar;
            stringVar = booleanVariable.ToString();




        }
    }
}
