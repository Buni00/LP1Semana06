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
                else
                {
                    Console.WriteLine("Only one foe per Room, no overbooking here");
                }
            }
            else
            {
                Console.WriteLine("That room does not exist");
            }
            
        }


        public Difficulty GetDifficulty()
        {
            return difficulty;
        }

        public int GetNumRooms()
        {
            return nRooms;
        }

        public int GetNumFoes()
        {
            int count = 0;
            for (int i = 0; i < foes.Length; i++)
            {
                if (foes[i] != null)
                {
                    count++;
                }
            }
            return count;
        }

        public void PrintFoes()
        {
            for (int i = 0; i < foes.Length; i++)
    {
            if (foes[i] != null)
            {
                Console.WriteLine($"Room {i+1}: {foes[i].GetName()}");
            }
    }
        }
        

    }
}