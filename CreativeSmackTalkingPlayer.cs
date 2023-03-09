using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public override int Roll()
        {
            List<string> Taunts = new List<string>{
                "Ha! Loser!",
                "You Stink!",
                "HAHAHAHAHAHAA",
                "Taunty McTauntFace"
            };
            // Return a random number between 1 and DiceSize
            Random taunt = new Random();
            int tauntIndex = taunt.Next(0, 4);

            Console.WriteLine($"{Name} vociferates {Taunts[tauntIndex]}");

            return new Random().Next(DiceSize) + 1;
        }

    }
}