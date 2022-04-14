using System;
namespace Pirates
{
    public class Pirate
	{
		public string Name { get; set; }
		public int GoldAmount { get; set; }

		private int healthPoints = 10;
		public int HealthPoints
		{
			get { return healthPoints; }
			set
			{
				if (value >= 0)
                {
					healthPoints = value;
				}
                else
                {
					healthPoints = 0;
				}
			}
		}

		public bool HasWoodenLeg { get; set; }

		public Pirate(string name)
		{
			Name = name;
		}

		public virtual void Work()
		{
			GoldAmount++;
			HealthPoints--;
		}

		public virtual void Party()
		{
			HealthPoints++;
		}

		public virtual string toString()
        {
			if (this.HasWoodenLeg)
            {
				return $"Hello, I'm {Name}. I have a wooden leg and {GoldAmount} golds.";
			}
			else
            {
				return $"Hello, I'm {Name}. I still have my real legs and {GoldAmount} golds.";
			}
        }

		public virtual bool IsCaptain()
		{
			return false;
		}
	}
}

//A pirate has a name (name), an amount of gold (goldAmount) and health points (healthPoints), the default value of which is 10.

//Pirates can be only created by defining their names

//Pirates start with 0 amount of gold

//A pirate might be a captain and may have a wooden leg (hasWoodenLeg)

//You must create the following methods:

//if a pirate is a captain:

//work() which increases the amount of gold possessed by that pirate by 10 and decrease the HP by 5.
//party() which increases the HP by 10.
//if the pirate is not a captain:

//work() which increases the amount of gold by 1 and decreases the HP by 1.
//party() which increases the HP by 1.
//toString() method:

//if the pirate has a wooden leg, then the string that is returned by the function must look like this:

//Hello, I 'm Jack. I have a wooden leg and 20 golds.
//If not:

//Hello, I 'm Jack. I still have my real legs and 20 golds.