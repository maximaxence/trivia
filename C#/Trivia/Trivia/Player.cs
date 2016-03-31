using System;
using System.Collections.Generic;

namespace UglyTrivia
{
    internal class Player
    {
        public Player(string playerName)
        {
            Name = playerName;
            Purse = 0;
            Place = 0;
            inPenaltyBox = false;
        }

        public string Name { get; private set; }
        public int Purse { get; private set; }
        public int Place { get; private set; }
        public bool inPenaltyBox { get; private set; }

        public void MovePlace(int roll)
        {
            Place += roll;
            if (Place > 11) Place = Place - 12;
        }

        public void AddPurse()
        {
            Purse++;
        }

        public void TrueinPenaltyBox()
        {
            inPenaltyBox = true;
        }

        public class Players
        {
            List<Player> players = new List<Player>();

            public List<Player> add(Player player)
            {
                players.Add(player);
                return players;
            }

            public Player Player(int numPlayer)
            {
                return players[numPlayer];
            }
        }
    }
}