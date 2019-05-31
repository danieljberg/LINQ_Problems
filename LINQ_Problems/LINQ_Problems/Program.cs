using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            foreach (var word in words)
            {
                if (word.Contains("th"))
                {
                    Console.WriteLine(word);
                }
            }
            Console.ReadLine();


            //USING LAMBDA 
            //List<string> words2 = new List<string> { "the", "bike", "this", "it", "tenth", "mathematics" };
            //var newList = words2.Where(m => m.Contains("th"));
            //foreach (var el in newList)
            //{
            //    Console.WriteLine(el);
            //}
            //Console.ReadLine();

            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            var distinctNames = names.Distinct();  //IEnumerable
            foreach (string name in distinctNames)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

            List<string> names2 = new List<string> { "Mike", "Brad", "Nevin", "Ian", "Mike", "Kim" };
            var resultList = names2.Distinct();


            //List<string> classGrades = new List<string>()
            //{
            //    "80,100,92,89,65",
            //    "93,81,78,84,69",
            //    "73,88,83,99,64",
            //    "98,100,66,74,55"
            //};

            //var result = classGrades.Select(x => x.Split(',')).ToList();
            //Console.WriteLine(result);
            //foreach (string[] gradeString in result)
            //{
            //    var gradeIntList = gradeString.Select(r => int.Parse(r)).ToList();
            //    var orderedList = gradeIntList.OrderBy(p => p).ToList().RemoveAt(0);
            //    int sumOfGrades = gradeIntList.Sum();
            //    int avgOfGrades = sumOfGrades / gradeIntList.Count;
            //}


            List<string> classGrades = new List<string>()
                {
                    "80,100,92,89,65",
                    "93,81,78,84,69",
                    "73,88,83,99,64",
                    "98,100,66,74,55"
                };

            List<double> averageOfaveragesList = new List<double>();

            for (int i = 0; i < classGrades.Count; i++)
            {
                var numericOrderOfGrades = classGrades[i].Split(',').Select(m => int.Parse(m)).OrderBy(q => q);
                var averageOfGrades = numericOrderOfGrades.Skip(1).Average();
                averageOfaveragesList.Add(averageOfGrades);
            }
            var averageOfaverages = averageOfaveragesList.Average();
            Console.WriteLine(averageOfaverages);
            Console.ReadLine();


            string input = "Terrill";
            var result = input.ToUpper().ToArray().OrderBy(a => a);
            var result2 = result.GroupBy(x => x, (key, values) => new { key, values = values.Count() });
            var resultString = "";
            foreach (var el in result2)
            {
                resultString += el.key.ToString() + el.values;
            }
            Console.WriteLine(resultString);
            Console.ReadLine();
        }

    }

}
            //var intResult = result.Select(r => r.Select(q => int.Parse(q)).ToList()).ToList();
            //Console.WriteLine(intResult);
            //Console.ReadLine();
           // intResult.Select(x => x.Select(y => y.OrderByDescending);
            //foreach (var gradeArray in result)

            //{

                
                //var numberToRemove = intResult.
                //foreach (var number in intResult)
                //{
                //    List<int> newGrades = new List<int>();
                //    if (number != numberToRemove)
                //    {
                //        newGrades.Add(number);
                //    }
                //}
                //intResult.RemoveAll(x => x==numberToRemove) //
                //intResult.
                //}

                //var newResult = gradeArray.Sum()
           
                //take in list of strings, drops lowest grade from each new list of strings, averages rest of grades (excluding min), averages averages


        
    

