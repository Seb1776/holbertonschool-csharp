using System;

namespace Enemies
{
    ///<summary>Zombie class</summary>
    public class Zombie
    {
        ///<summary>Zombie health value</summary>
        public int health;
        ///<summary>Zombie name</summary>
        string name = "(No name)";

        ///<summary>Zombie constructor method</summary>
        public Zombie()
        {
            health = 0;
        }

        ///<summary>Initializes "value" and throws an exception if its below 0</summary>
            ///<param name="value">Value that will have the health</param>
        public Zombie(int value)
        {
            if (value <= 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            
            else
                health = value;
        }

        ///<summary>Returns the current Zombie "health" value</summary>
            ///<returns>Current Zombie health</returns>
        public int GetHealth()
        {
            return health;
        }

        ///<summary>Gets or Sets the Zombie name</summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        ///<summary>Overrieds ToString to return the string value of the Zombie</summary>
            ///<returns>String value of Zombie</returns>
        public override string ToString()
        {
            return string.Format("Zombie Name: {0} / Total Health: {1}", name, health);
        }
    }
}
