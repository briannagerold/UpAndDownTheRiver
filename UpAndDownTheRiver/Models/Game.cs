using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UpAndDownTheRiver.Models
{
    public class Game
    {
        int numPlayers;
        int round = 1;
        int cards = 1;
        Player dealer;
        int maxCards;
        Players players;

        public Game(Players players)
        {
            this.players = players;
            maxCards = 52 / players.getNumPlayers();
        }

        public int getCards()
        {
            if (round > maxCards)
            {
                cards = (maxCards * 2) + 1 - round;
            }
            else
            {
                cards = round;
            }
            return cards;
        }


        int cards;
        if (round > maxCards) {
            cards = maxCards* 2 + 1 - round;
        }
        else {
            cards = round;
        }
            
        if (totalTricks == cards) {     
            round++;
            lblRoundNum.setText(round + "");
            if (round > maxCards) {
                lblCardNum.setText((maxCards* 2 + 1 - round) + "");
            }
            else {
                lblCardNum.setText(round + "");
            }
            lblDealerName.setText(players[(round - 1) % totalNumPlayers].getName());
        
        
        
            if (round == (maxCards* 2 + 1)) {
                lblRound.setText("");
                lblRoundNum.setText("");
                lblCard.setText("");
                lblCardNum.setText("Game Over");
                lblDealer.setText("");
                lblDealerName.setText("");
            }
        
            for (int i = 0; i<totalNumPlayers; i++) {
                players[i].setScore();
            }
        
            txtScores.setText("Scores: \n");
            for (int i = 0; i<totalNumPlayers; i++){
                txtScores.append("\n" + players[i].getName() + ": " + players[i].getScore());
            }

    }
}