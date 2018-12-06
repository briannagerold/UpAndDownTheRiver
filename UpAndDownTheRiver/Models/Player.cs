using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UpAndDownTheRiver.Models
{
    public class Player : IScore
    {
        String name;
        int gamesWon;
        int gamesPlayed;
        int score;
        int bid;
        int tricks;

        public void addScore()
        {
            if(bid == tricks)
            {
                if(bid == 0)
                {
                    score += 5;
                }
                else
                {
                    score = score + bid + 10;
                }
            }
            else
            {
                score = score - 10;
            }
        }

        public int getGamesPlayed()
        {
            return gamesPlayed;
        }

        public void setGamesPlayed(int gamesPlayed)
        {
            this.gamesPlayed = gamesPlayed;
        }

        public int getGamesWon()
        {
            return gamesWon;
        }

        public void setGamesWon(int gamesWon)
        {
            this.gamesWon = gamesWon;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getScore()
        {
            return score;
        }

        public void incGamesPlayed()
        {
            gamesPlayed++;
        }

        public void incGamesWon()
        {
            gamesWon++;
        }

        public void setBid(int bid)
        {
            this.bid = bid;
        }

        public void setTricks(int tricks)
        {
            this.tricks = tricks;
        }
    }
}