using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UpAndDownTheRiver.Models
{
    public class Players : IScore
    {
        List<Player> players;

        public Players(List<Player> players)
        {
            this.players = players;
        }

        public void addScore()
        {
            foreach (Player player in players)
            {
                player.addScore();
            }
        }

        public void incGamesPlayed()
        {
            foreach(Player player in players)
            {
                player.incGamesPlayed();
            }
        }

        public void addPlayer(Player player)
        {
            players.Add(player);
        }

        public int getNumPlayers()
        {
            return players.Count;
        }

    }
}