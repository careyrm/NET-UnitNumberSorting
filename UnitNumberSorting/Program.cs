using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using UnitNumberSorting.Utilities;

namespace UnitNumberSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var allLines = File.ReadAllLines(ConfigurationManager.AppSettings["DataFilePath"].ToString()).ToList();
            var sortedLines = SortUnitData.CustomSort(allLines);

            sortedLines.ToList().ForEach(x => Console.WriteLine(x));
            Console.ReadLine();
        }

        
    }
}
