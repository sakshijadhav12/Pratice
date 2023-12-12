
using System.Drawing;
namespace PracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArrayPractice arrayPractice = new ArrayPractice();
            //arrayPractice.PrintArray();
            //arrayPractice.CopyArray();
            //arrayPractice.CountFrequency();
            //arrayPractice.SortArray();
            //arrayPractice.SecondLargest();
            //arrayPractice.FindOddValues();
            // arrayPractice.MatrixSubtraction();
            //arrayPractice.SumOfLeftDiagonal();
            //arrayPractice.Determinantofmatrix();
            //arrayPractice.SmallestInteger();

            DateTimeExercise dateTimeExercise = new DateTimeExercise();
            //dateTimeExercise.DisplayDateTime();
            //dateTimeExercise.AddValuestoDateAndTime();
            // dateTimeExercise.Conversion();
            //dateTimeExercise.DateTimeEqivalent();

            StringExcercie stringExcercie = new StringExcercie();
            //stringExcercie.CompareString();
            //stringExcercie.SortString();
            //stringExcercie.IsAlphabet();

            DictionaryProblems problems = new DictionaryProblems();
            //problems.Display();
            //problems.CountFrequency();
            ////problems.SortByKey();
            //problems.SortByValue();
            //problems.FindPrimeNo();
            //problems.FindEven();
            //Football football = new Football();
           // football.paly();

            SearchingAndSorting searchingAndSorting = new SearchingAndSorting();
            // searchingAndSorting.Shellsort();
            //searchingAndSorting.Mergesort();
            //searchingAndSorting.CountingSort();
            //searchingAndSorting.bubblesort();
            // searchingAndSorting.HeapSort();
           // searchingAndSorting.BogoSort();
            searchingAndSorting.SelectionSort();

           //Rectangle  rectangle = new Rectangle();
           // Console.WriteLine("Enter the lenght");
           // double len = Convert.ToDouble(Console.ReadLine());
           // Console.WriteLine("Enter the Width");
           // double widhth = Convert.ToDouble(Console.ReadLine());
           // rectangle.Set(len, widhth);
           // rectangle.getLen();
           // rectangle.getWidth();
           // rectangle.Calculate();
           // rectangle.show();


            Manager manager = new Manager();
           List<Player> players = new List<Player>();
           List<Coach> coaches = new List<Coach>();

           players.Add(new Player { Code = 1, Name = "Player1", ShirtNumber = 10, Salary = 50000, Position = "Striker" });
            players.Add(new Player { Code = 2, Name = "Player2", ShirtNumber = 11, Salary = 40000, Position = "Striker" });
            players.Add(new Player { Code = 3, Name = "Player3", ShirtNumber = 5, Salary = 60000, Position = "Defender" });

           coaches.Add(new Coach { Code = 101, Name = "Coach1", YearsOfExperience = 4, Salary = 80000, Position = "Head Coach" });
            coaches.Add(new Coach { Code = 102, Name = "Coach2", YearsOfExperience = 2, Salary = 70000, Position = "Coach" });

            manager.InputPlayers(players);
           manager.InputCoaches(coaches);

            ShowMenu(manager);
        }

        static void ShowMenu(Manager manager)
        {
            int choice;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Show Players");
                Console.WriteLine("2. Show Coaches");
                Console.WriteLine("3. Change Player Information");
                Console.WriteLine("4. Count Experienced Coaches");
                Console.WriteLine("5. Sum Salary of Strikers");
                Console.WriteLine("6. Show Person with Max Salary");
                Console.WriteLine("7. Sort Players by Shirt Number");
                Console.WriteLine("8. Sort Experienced Coaches by Salary (Descending)");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice: ");
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            manager.ShowPlayers();
                            break;
                        case 2:
                            manager.ShowCoaches();
                            break;
                        case 3:

                            break;
                        case 4:
                            Console.WriteLine($"Number of experienced coaches:");
                            manager.CountExperiencedCoaches();
                            break;
                        case 5:
                            Console.WriteLine($"Sum of salary of strikers: ");
                            manager.SumSalaryOfStrikers();
                            break;
                        case 6:
                            manager.ShowMaxSalary();
                            break;
                        case 7:
                            manager.SortPlayersByShirtNumber();
                            Console.WriteLine("Players sorted by shirt number.");
                            break;
                        case 8:
                            manager.SortExperiencedCoaches();

                            break;
                        case 0:
                            Console.WriteLine("Exiting the program. Goodbye!");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }


            } while (choice != 0);
        }
    }

}