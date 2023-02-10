using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21b_PRG2_AB1_Aufgabe2_Jerome_Folger
{
    internal class Auto : Fahrzeug
    {
        public string CarLock { get; set; }
        public int NumberOfDoors { get; set; }
        public bool KeyInserted { get; set; }

        public Auto(string modelName, int maxFuelCapacity, int maxTempo, int numberOfDoors)
            : base(modelName, maxFuelCapacity, maxTempo)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override void StartEngine()
        {
            if(KeyInserted)
            {
                base.StartEngine();
            }
            else
            {
                Console.WriteLine("Schlüssel ist nicht eingesteckt");
            }
        }

        public override void StopEngine()
        {
            if (KeyInserted)
            {
                base.StopEngine();
            }
            else
            {
                Console.WriteLine("Schlüssel ist nicht eingesteckt");
            }
        }

        public void InsertKey(string key)
        {
            if(key == this.CarLock)
            {
                KeyInserted = true;
            }
            else
            {
                Console.WriteLine("Falscher schlüssel");
            }
        }

        public void RemoveKey(string key)
        {
            KeyInserted = false;
        }

    }
}
