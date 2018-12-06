using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpAndDownTheRiver.Models
{
    interface IScore
    {       
        void addScore();

        void incGamesPlayed();
    }
}
