using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace OperatorOverloading.DBL
{
    public class CurrencyConverter : ICurrencyConverter
    {
        public double GetConversionRate(string initialCurrency, string finalCurrency)
        {
            int count=0;
            if (finalCurrency == "USD")
            {
                string temp = finalCurrency;
                finalCurrency = initialCurrency;
                initialCurrency = finalCurrency;
                count++;
            }
            StreamReader file = new StreamReader(@"D:\exchange rate.txt");
            string line = file.ReadToEnd();
            line = line.Replace('}', '\0').Replace('\"', '\0').Replace("USD", "");
            Parsing parse = new Parsing();
            double rate;
            string[] parsedString = parse.ParseIt(line);
            rate = FetchRate(parsedString, finalCurrency);
            if (count == 1)
            {
                rate = 1 / rate;
            }
            return rate;

        }
        public double FetchRate(string[] finalString, string final)
        {
            double fetchedRate;
            for (int i = 0; i < finalString.Length; i++)
            {
                if (finalString[i].Contains(final))
                {
                    string[] tempString = finalString[i].Split(':');
                    //tempString[1] = tempString[1].Remove(tempString[1].Length - 2, 2);
                    if (double.TryParse(tempString[1], out fetchedRate) == false)
                        throw new Exception("could not fetch the exchange rate");
                    return fetchedRate;
                }
                
            }
            throw new Exception("Invalid Currency entered");
        }
    }
}
