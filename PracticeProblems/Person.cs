using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public  class Person

    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
    }
    class Player : Person
    {
        public int ShirtNumber { get; set; }
        public string Position { get; set; }
    }
    class Coach : Person
    {
        public int YearsOfExperience { get; set; }
        public string Position { get; set; }
    }
    interface IManager
    {
        void InputPlayers(List<Player> players);
        void InputCoaches(List<Coach> coaches);
        void ShowPlayers();
        void ShowCoaches();
        void ChangePlayer(int playerCode, int option, int shirtNumber, double salary);
        int CountExperiencedCoaches();
        double SumSalaryOfStrikers();
        void ShowMaxSalary();
        void SortPlayersByShirtNumber();
        void SortExperiencedCoaches();
    }

    class Manager : IManager
    {
        private List<Player> players = new List<Player>();
        private List<Coach> coaches = new List<Coach>();

        public void InputPlayers(List<Player> players)
        {
            this.players = players;
        }

        public void InputCoaches(List<Coach> coaches)
        {
            this.coaches = coaches;
        }


        public void ShowPlayers()
        {
            foreach (var player in players)
            {
                Console.WriteLine($"Player: {player.Name}, Shirt Number: {player.ShirtNumber}, Salary: {player.Salary}");
            }
        }

        public void ShowCoaches()
        {
            foreach (var coach in coaches)
            {
                Console.WriteLine($"Coach: {coach.Name}, Years of Experience: {coach.YearsOfExperience}, Salary: {coach.Salary}");
            }
        }

        public void ChangePlayer(int playerCode, int option, int shirtNumber, double salary)
        {
            var player = players.FirstOrDefault(p => p.Code == playerCode);
            if (player != null)
            {
                if (option == 0)
                {
                    player.ShirtNumber = shirtNumber;
                }
                else
                {
                    player.Salary = salary;
                }
            }
        }

        public int CountExperiencedCoaches()
        {
            return coaches.Count(c => c.YearsOfExperience >= 3);
        }

        public double SumSalaryOfStrikers()
        {
            return players.Where(p => p.Position == "Striker").Sum(p => p.Salary);
            
        }

        public void ShowMaxSalary()
        {
            var maxSalaryPerson = players.Concat<Person>(coaches).OrderByDescending(p => p.Salary).FirstOrDefault();
            if (maxSalaryPerson != null)
            {
                Console.WriteLine($"Person with max salary: {maxSalaryPerson.Name}, Salary: {maxSalaryPerson.Salary}");
            }
        }

        public void SortPlayersByShirtNumber()
        {
            players.Sort((p1, p2) => p1.ShirtNumber.CompareTo(p2.ShirtNumber));
        }

        public void SortExperiencedCoaches()
        {
            coaches.Where(c => c.YearsOfExperience >= 3).OrderByDescending(c => c.Salary).ToList();
        }
    }
    class CheckData
    {
        public static bool CheckNull(string value)
        {
            return !string.IsNullOrEmpty(value);
        }

        public static bool CheckNumber(double value)
        {
            return value >= 0; 
        }
    }
}


