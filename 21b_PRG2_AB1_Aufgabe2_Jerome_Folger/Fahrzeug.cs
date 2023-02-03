using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _21b_PRG2_AB1_Aufgabe2_Jerome_Folger
{
    internal class Fahrzeug
    {
        private int tankLevel = 0;
        public string model;
        private int fuelCapacity;
        private int currentKmh = 0;
        public int maxKmh;
        private bool engineRunning;

        public int TankLevel { get; set; }
        public Fahrzeug(string modelName, int maxFuelCapacity, int maxTempo) 
        {
            this.model = modelName;
            this.fuelCapacity = maxFuelCapacity;
            this.maxKmh = maxTempo;
        }

        public void Refuel(int addedFuelAmmount)
        {
            if (this.tankLevel + addedFuelAmmount >= this.fuelCapacity) {
                this.tankLevel = this.fuelCapacity;
                Console.WriteLine("Maximale Kapazität von {0}dl erreicht", this.fuelCapacity);
                return;
            }

            this.tankLevel += addedFuelAmmount;
            ReadGauge();
            return;
        }

        public void ReadGauge()
        {
            Console.WriteLine("Füllstand: {0}dl / {1}dl", this.tankLevel, this.fuelCapacity);
        }

        public virtual void StartEngine()
        {
            if(this.tankLevel >= 1) {
                this.engineRunning = true;
                Console.WriteLine("Motor läuft.");
            }
            else
            {
                Console.WriteLine("Der Tank ist leer.");
            }
        }

        public virtual void StopEngine()
        {
            if (this.engineRunning)
            {
                this.engineRunning = false;
            }
        }

        public virtual void Accelerate()
        {
            if (this.engineRunning)
            {
                string line = "";
                Console.WriteLine("Geschwindigkeit: ");
                for (int i = 0; i < this.maxKmh; i++)
                {
                    this.currentKmh++;
                    string backup = new string('\b', 7);
                    Console.Write(backup);
                    line = string.Format("{0}km/h", this.currentKmh);
                    Console.Write(line);
                    Thread.Sleep(12);
                }
            }
            else
            {
                Console.WriteLine("Motor läuft nicht");
            }
        }

        public virtual void Break()
        {
            if(this.currentKmh > 0)
            {
                string line = "";
                Console.WriteLine("\n\nGeschwindigkeit: ");
                for (int i = this.currentKmh; i > 0; i--)
                {
                    this.currentKmh--;
                    string backup = new string('\b', 7);
                    Console.Write(backup);
                    line = string.Format("{0}km/h", this.currentKmh);
                    Console.Write(line);
                    Thread.Sleep(9);
                }
                Console.WriteLine("\nFahrzeug steht still {0} kmh", this.currentKmh);
            }
        }
    }

}
