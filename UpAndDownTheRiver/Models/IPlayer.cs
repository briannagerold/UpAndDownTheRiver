using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpAndDownTheRiver.Models
{
    interface IPlayer
    {
        void setName(String name);
        String getName();

        int getGamesWon();
        void setGamesWon(int gamesWon); 

        int getGamesPlayed();
        void setGamesPlayed(int gamesPlayed);

        int getScore();

        void addScore(int bid, int tricks);

        void incGamesWon();

        void incGamesPlayed();
    }
}
