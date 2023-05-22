using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2201561017_Bilyana
{
    public class Team
    {
        private const int MinPlayers = 11;
        private const int MaxPlayers = 22;

        private Coach coach;
        private List<FootballPlayer> players;

        public Coach Coach
        {
            get { return coach; }
            set { coach = value; }
        }

        public List<FootballPlayer> Players
        {
            get { return players; }
            set
            {
                if (value.Count < MinPlayers || value.Count > MaxPlayers)
                {
                    throw new ArgumentException($"A team must have between {MinPlayers} and {MaxPlayers} players.");
                }

                players = value;
            }
        }

        public double AverageAge()
        {
            int totalAge = 0;
            foreach (var player in Players)
            {
                totalAge += player.Age;
            }

            return totalAge / (double)Players.Count;
        }
    }
}
