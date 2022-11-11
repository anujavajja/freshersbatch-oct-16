using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class IEnumerable_Interface
    {
        class Player
        {
            public string Name { get; set; }
            public int Run { get; set; }
            public Player(string name, int run)
            {
                Name = name;
                Run = run;
            }
        }
        class Team : IEnumerable
        {
            private Player[] playerArray = new Player[4];
            public Team()
            {
                playerArray[0] = new Player("Virat", 29);
                playerArray[1] = new Player("Dhoni", 30);
                playerArray[2] = new Player("Rohit", 40);
                playerArray[3] = new Player("Yuvaraj", 30);
            }
            public System.Collections.IEnumerator GetEnumerator()
            {
                foreach (Player player in playerArray)
                {
                    Console.WriteLine("Name is{0} and Run is {1}", player.Name, player.Run);
                }
                return playerArray.GetEnumerator();
            }
            internal class Program
            {
                public static void Main(string[] args)
                {
                    Team India = new Team();

                    India.GetEnumerator();
                    Console.ReadLine();
                }
            }
        }
    }
}
