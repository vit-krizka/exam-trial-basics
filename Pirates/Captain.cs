using System;
namespace Pirates
{
	public class Captain : Pirate
	{
		public Captain(string name) : base(name) { }

		public override void Work()
		{
			GoldAmount += 10;
			HealthPoints -= 5;
		}

		public override void Party()
		{
			HealthPoints += 10;
		}

		public override bool IsCaptain()
        {
			return true;
        }
	}
}

