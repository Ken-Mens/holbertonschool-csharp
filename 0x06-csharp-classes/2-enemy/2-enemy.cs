using System;

namespace Enemies
{
    ///<summary>Represents a Zombie</summary>
    public class Zombie
    {
        ///<summary>Health field of zombie.</summary>
        public int health;

        ///<summary>Constructor made for Zombie.</summary>
        public Zombie()
        {
            health = 0;
        }

        public Zombie(int value)
        {
             if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            else
                health = value;
        }
    }
}