using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace prog._4
{
    internal class ArrayProcessorApp
    {
        public class ArrayProcessor
        {
            private List<int> array;

            public ArrayProcessor()
            {
                array = new List<int>();
            }

            public void ReadArrayFromFile(string filePath)
            {
                string[] lines = File.ReadAllLines(filePath);
                array = lines.Select(int.Parse).ToList();
            }

            public int CalculateUniqueNumbers()
            {
                return array.Distinct().Count();
            }

            public void WriteResultToFile(string filePath)
            {
                File.WriteAllText(filePath, $"Кількість унікальних цілих чисел: {CalculateUniqueNumbers()}");
            }
        }
    }
}
