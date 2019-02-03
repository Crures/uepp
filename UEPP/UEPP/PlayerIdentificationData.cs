using System;
using System.Collections.Generic;
using System.Text;

namespace UEPP
{
    class PlayerIdentificationData
    {
        protected string name;
        protected int playerId;
        protected int amountOfWins;
        protected string playerColor;

        protected PlayerIdentificationData(string name, int playerId, int amountOfWins, string playerColor)
        {
            this.name = name;
            this.playerId = playerId;
            this.amountOfWins = amountOfWins;
            this.playerColor = playerColor;
        }
    }
}
