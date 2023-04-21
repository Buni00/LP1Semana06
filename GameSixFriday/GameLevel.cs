using System;

namespace GameSixFriday
{       
    public enum Difficulty
    {
        Easy,
        Normal,
        Hard
    }
    public class GameLevel
    {
        

        private int nRooms;
        private Difficulty difficulty;
        private Foe[] foes;

        public GameLevel(int nRooms, Difficulty difficulty)
        {
            this.nRooms = nRooms;
            this.difficulty = difficulty;
            this.foes = new Foe[nRooms];
        }

        public void SetFoeInRoom(int roomIndex, Foe foe)
        {
            if (roomIndex < nRooms)
            {
                if ( foes[roomIndex]== null)
                {
                    foes[roomIndex] = foe;
                }
            }
            else
            {
                Console.WriteLine("Only one foe per Room, no overbooking here");
            }
        }


        


    }
}