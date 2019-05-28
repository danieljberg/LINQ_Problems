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
            foreach(var word in words)
            {
                if(word.Contains("th"))
                {
                    Console.WriteLine(word);
                }
            }
            Console.ReadLine();

            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            var distinctNames = names.Distinct();  //IEnumerable
            foreach (string name in distinctNames)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };

            var result = classGrades.Select(x => x.Split(',')).ToList();
            Console.WriteLine(result);
            foreach (string[] gradeString in result)
            {
                var gradeIntList = gradeString.Select(r => int.Parse(r)).ToList();
                gradeIntList.OrderBy(p => p).ToList().RemoveAt(0);
                int sumOfGrades = gradeIntList.Sum();
                int avgOfGrades = sumOfGrades / gradeIntList.Count;
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


        }
    }

