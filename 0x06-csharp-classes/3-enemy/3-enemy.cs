using System;

namespace Enemies
{
    ///<summary>Zombie class</summary>
    public class Zombie
    {
        ///<summary>Zombie health value</summary>
        public int health;

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
        public int GetHealth()
        {
            return health;
        }
    }
}
