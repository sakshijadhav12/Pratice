using System.Collections.Generic;

namespace PracticeProblems
{
    public class DictionaryProblems
    {
        // To count frequency of each character

        public void Display()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            Console.Write("Enter a key: ");
            string key = Console.ReadLine();
            Console.Write("Enter an integer value: ");
            int value = Convert.ToInt32(Console.ReadLine());
            dictionary[key] = value;
            Console.WriteLine("Dictionary Contents:");
            foreach (var pair in dictionary)
            {
                Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
            }
            Console.ReadLine();

        }

        public void CountFrequency()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            Dictionary<char, int> charFrequency = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (charFrequency.ContainsKey(c))
                {
                    charFrequency[c]++;
                }
                else
                {
                    charFrequency[c] = 1;
                }
            }

            Console.WriteLine("Character Frequencies:");
            foreach (var pair in charFrequency)
            {
                Console.WriteLine($"Character: {pair.Key}, Frequency: {pair.Value}");
            }
        }

        public void SortByKey()
        {
            Dictionary<string, int> myDict = new Dictionary<string, int>
          {
             { "Mrunali", 10 },
             { "Anjali", 5 },
             { "sayali", 15 }
          };

            var sortedDictByKey = myDict.OrderBy(kvp => kvp.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            foreach (var kvp in sortedDictByKey)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

        }

        public void SortByValue()
        {
            Dictionary<string, int> myDict = new Dictionary<string, int>
             {
            { "Abc", 1 },
            { "gfghvbh", 50 },
             { "sakshi", 11 }
             };

            var sortedDictByValue = myDict.OrderBy(kvp => kvp.Value).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var kvp in sortedDictByValue)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
        }

        public void FindPrimeNo()
        {
            Dictionary<int, bool> primeNumbers = new Dictionary<int, bool>();
            for (int i = 1; i <= 50; i++)
            {
                primeNumbers[i] = false;
            }
            for (int i = 2; i <= Math.Sqrt(50); i++)
            {
                if (!primeNumbers[i])
                {
                    for (int j = i * i; j <= 50; j += i)
                    {
                        primeNumbers[j] = true;
                    }
                }
            }
            Console.WriteLine("Prime numbers between 1 and 50:");
            foreach (KeyValuePair<int, bool> pair in primeNumbers)
            {
                if (!pair.Value)
                {
                    Console.WriteLine(pair.Key);
                }
            }
        }

        public void FindEven()
        {
            Dictionary<int, int> Numbers = new Dictionary<int, int>();
            for (int i = 1; i <= 50; i++)
            {
                Numbers.Add(i, i);
            }

            Dictionary<int, int> EvenNumbers = Numbers
                .Where(pair => pair.Key % 2 == 0)
                .ToDictionary(pair => pair.Key, pair => pair.Value);

            Console.WriteLine("All Numbers:");
            foreach (var kvp in Numbers)
            {
                Console.Write($"{kvp.Key}, {kvp.Value} ");
            }

            Console.WriteLine("\nEven Numbers:");
            foreach (var kvp in EvenNumbers)
            {
                Console.Write($"{kvp.Key}, {kvp.Value} ");
            }
        }

    }
}



    

