using AwsConsole;
using System;
using System.Reflection;

namespace ConsoleAws.Stamping
{
    public class ConsolePrinting : IStamping
    {
        public static void PrintProperties(object awsObj)
        {
            PrintProperties(awsObj, 0);
        }

        private static void PrintProperties(object awsObj, int indent)
        {

            if (awsObj == null) return;

            string indentString = new string(' ', indent);
            Type objType = awsObj.GetType();
            PropertyInfo[] properties = objType.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                object propValue = property.GetValue(awsObj, null);
                if (property.PropertyType.Assembly != objType.Assembly)
                {
                    Console.WriteLine("{0}{1}: {2}", indentString, property.Name, propValue);
                }
                else
                {
                    Console.WriteLine("{0}{1}:", indentString, property.Name);
                    PrintProperties(propValue, indent + 2);
                }
            }

            var convertito = (Aws)awsObj;
            foreach(var t in convertito.Reservations)
            {
                var element = t;
            }

        }


    }
}
