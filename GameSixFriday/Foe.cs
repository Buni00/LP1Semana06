namespace GameSixFriday
{
    public class Foe 
    {
        private string name;
        private float health;
        private float shield;
        private static int powerUpCount;

        public Foe(string name)
        {
            SetName(name);
            health =  100;
            shield = 0;
        }


        public enum PowerUp
    {   
        Health,
        Shield
    }

        static Foe()
        {
            powerUpCount = 0;
        }

        public string GetName()
        {
            return name;
        }

        public string SetName(string name)
        {   
            name = name.Trim();
            this.name = name;
            

            return name;
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetShiled()
        {
            return shield;
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = - shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }

        public void PickUpPowerUp( PowerUp powerUp, float val)
        {
            if (powerUp == PowerUp.Health && health < 100)
            {
                health += val;
            }

            if (powerUp == PowerUp.Shield && health < 100)
            {
                shield += val;
            }

            powerUpCount ++;
        }

        public static int PowerUpCount
        {
            get { return powerUpCount; }
        }
        



    }

}