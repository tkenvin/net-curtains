using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace curtains
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput = new XkcdColour
            {
                Value = args[0]
            };
            var colourNames = ReadCsvInput(".\\rgb.txt");
            var allOptions = colourNames
                .Select(xc => new
                {
                    Proximity = xc.Proximity(userInput),
                    Colour = xc
                });
            var smallestProx = allOptions
                .Min(p => p.Proximity);
            var closestOptions = allOptions
                .Where(p => p.Proximity == smallestProx)
                .Select(p => p.Colour);
            foreach (var option in closestOptions)
            {
                Console.WriteLine($"{option.Name} {option.Value}");
            }
        }

        static IEnumerable<XkcdColour> ReadCsvInput(string filename)
        {
            var xkcdColours = new List<XkcdColour>();
            var config = new CsvConfiguration(CultureInfo.CurrentCulture)
            {
                HeaderValidated = null,
                MissingFieldFound = null,
                IgnoreBlankLines = true,
                Delimiter = "\t"
            };
            using (var textReader = new StreamReader(filename))
            using (var csvReader = new CsvReader(textReader, config))
            {
                var moreRecords = csvReader.Read();
                while (moreRecords)
                {
                    xkcdColours.Add(csvReader.GetRecord<XkcdColour>());
                    moreRecords = csvReader.Read();
                }
            }
            return xkcdColours;
        }
    }
}
