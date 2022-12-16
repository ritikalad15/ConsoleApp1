using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Collections
{
    public class Player:IComparable
    {
        private string name;
        private int runs;
        public Player(string name, int runs)
        {
            this.name = name;
            this.runs = runs;
        }

        public int CompareTo(object obj)
        {
            Player p= (Player)obj; 
            if (this.runs > p.runs)
            {
                return 1;
            }
            else if (this.runs < p.runs)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"{name} -> {runs}";
        }
    }

    public class Team : IEnumerable
    {
        private Player[] players;
        public Team()
        {
            players = new Player[5];
            players[0] = new Player("Rohit", 45);
            players[1] = new Player("Virat", 80);
            players[2] = new Player("Ishan", 79);
            players[3] = new Player("Ashwin", 33);
            players[4] = new Player("Hardik", 88);

        }
        public IEnumerator GetEnumerator()
        {
            return players.GetEnumerator();
        }

         static void Main(string[] args)
         {
            Team team = new Team();
            foreach (Player p in team)
            {
                Console.WriteLine(p);
           
            }


            Player players1 = new Player("Rohit", 53);
            Player players2 = new Player("Virat", 80);
            Player players3 = new Player("Ishan", 79);
            Player players4 = new Player("Ashwin", 53);
            Player players5 = new Player("Hardik", 88);

            int result = players2.CompareTo(players5);
            if (result == 1)
            {
                Console.WriteLine("Hardik has more runs than virat");
            }
            else if (result == -1)
            {
                Console.WriteLine("virat has less runs than hardik");
            }
            else
            {
                Console.WriteLine("hardik & virat has same score");
            }
         }
    }
}


    

