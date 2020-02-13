using System;

namespace Enemies
{
    ///<summary>Represents a Zombie</summary>
    public class Zombie
    {
        ///<summary>Health field of zombie.</summary>
        private int health;

        ///<summary>Constructor made for Zombie.</summary>
        public Zombie()
        {
            health = 0;
        }

    ///<summary>Constructor with health value for Zombie</summary>
        public Zombie(int value)
        {
             if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            else
                health = value;
        }
        ///<summary> Returns current health of zombie</summary>
        public int GetHealth()
        {
            return (health);
        }
    }
}