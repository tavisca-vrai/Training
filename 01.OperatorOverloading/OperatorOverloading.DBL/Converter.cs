using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OperatorOverloading.Parser;

namespace OperatorOverloading.DBL
{
    public class Converter : IParser
    { 
       public double GetConversionRate(string initialCurrency,string finalCurrency)
        {
           
            StreamReader file = new StreamReader(@"D:\exchange rate.txt");
            string line = file.ReadToEnd();
            line = line.Replace('}', '\0').Replace('\"', '\0').Replace("USD", "");
            Parsing parse = new Parsing();
            double rate;
            string[] parsedString = parse.ParseIt(line);
            return (rate = FetchRate(parsedString,finalCurrency));
            
        }
        public double FetchRate(string[] finalString,string final)
        {
             double fetchedRate;
           for(int i=0;i<finalString.Length;i++)
           {
               if (finalString[i].Contains(final))
               {
                   string[] tempString = finalString[i].Split(':');

                   if (tempString[1].Contains('\0'))
                   {
                       tempString[1] = tempString[1].Remove(tempString[1].Length - 2, 2);
                   }
                   if (double.TryParse(tempString[1], out fetchedRate) == false)
                       throw new Exception("could not fetch the exchange rate");
                   return fetchedRate;
               }
              
                   
            
           }
           throw new Exception("Invalid Currency entered");
            
    
        }
   
         }
            

    }

      
