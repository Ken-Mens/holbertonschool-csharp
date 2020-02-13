using System;

 namespace Enemies
{
    ///<summary>Represents a Zombie</summary>
    public class Zombie
    {
        ///<summary>Health field of zombie.</summary>
        private int health;

        //<summary>Name field of zombie</summary>
        private string name = "(No name)";

        ///<summary>Constructor made for Zombie.</summary>
        public Zombie()
        {
            health = 0;
        }

    ///<summary>Constructor with health value for Zombie</summary>
        public Zombie (int value)
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
        ///<summary>Gets or sets name.</summary>
        public string Name
        {
            get {return (name);}
            set {name = value;}
        }
        ///<summary>Overrides ToString method.</summary>
           public override string ToString()
        {
            return String.Format("Zombie Name: {0} / Total Health: {1}", name, health);
        }
    }
}