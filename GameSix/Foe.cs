namespace GameSix
{
    public class Foe 
    {
        private string name;
        private float health;
        private float shield;

        public Foe(string name)
        {
            SetName(name);
            health =  100;
            shield = 0;
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
        



    }

}