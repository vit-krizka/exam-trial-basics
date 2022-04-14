using System;
namespace Pirates
{
	public class Ship
	{
		private List<Pirate> crew = new List<Pirate> { };

		public Ship() { }

		public void Add(Pirate pirate)
        {
            if (pirate.IsCaptain() && this.HasCaptian())
            {
                Console.WriteLine("This ship already has a captain. A new captain cannot be added.");
                //Mohlo by také házet chybu: throw new Exception("Only one captain for a ship please.")
            }
            else
            {
                crew.Add(pirate);
            }
        }

        public int getCrewSize()
		{
			return crew.Count;
		}

        public List<Pirate> getPoorPirates()
        {
            List<Pirate> poorPirates = new List<Pirate> { };

            foreach (var item in crew)
            {
                if (item.GoldAmount < 15 && item.HasWoodenLeg)
                {
                    poorPirates.Add(item);
                }
            }

            return poorPirates;
        }

        public void lastDayOnTheShip()
        {
            foreach (var item in crew)
            {
                item.Party();
            }
        }

        public void prepareForBattle()
        {
            for (int i = 0; i < 5; i++)
            {
                foreach (var item in crew)
                {
                    item.Work();
                }
            }

            lastDayOnTheShip();
        }

        private bool HasCaptian()
        {
            bool hasCaptain = false;

            foreach (var item in crew)
            {
                if (item.IsCaptain())
                {
                    hasCaptain = true;
                }
            }

            return hasCaptain;
        }
    }
}

//It should have a list of pirates.
//You must be able to add new pirates to the ship.It must have only one captain!
//You must create the following methods:
//getCrewSize() returns the number of pirates on the ship
//getPoorPirates() which returns a list of names containing the pirates that
//have a wooden leg and have less than 15 golds
//getGolds() which returns the sum of gold owned by the pirates of that particular ship
//lastDayOnTheShip() which calls the pirates' party() method.
//prepareForBattle() which calls the pirates' work() method 5 times, then the ship's lastDayOnTheShip() method.