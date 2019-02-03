using System;
using System.Collections.Generic;
using System.Text;

namespace UEPP
{
    class Player : PlayerIdentificationData
    {   
        private List<Card> cardList;
        
        Player(string name, int playerId, int amountOfWins, string playerColor) : base(name, playerId, amountOfWins, playerColor)
        {
            
        }
    }
}
