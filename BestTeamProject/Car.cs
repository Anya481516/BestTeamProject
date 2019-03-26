using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestTeamProject
{
    public class Car
    {
        public String Make { get; set; }
        public String Model { get; set; }
        public int Year { get; set; }
        public String Color { get; set; }
        public int Power { get; set; }
        public int MaxSpeed { get; set; }
        public int AccTime { get; set; }
        public int FuelWaist { get; set; }
        public int PlaceQuant { get; set; }
        public int BackVolume { get; set; }
        public int FuelBoxVolume { get; set; }
        public int Price { get; set; }

        public Car()
        {
            Car car = new Car();
        }

        public Car(Car car)
        {
            Make = car.Make;
            Model = car.Model;
            Year = car.Year;
            Color = car.Color;
            Power = car.Power;
            MaxSpeed = car.MaxSpeed;
            AccTime = car.AccTime;
            FuelWaist = car.FuelWaist;
            PlaceQuant = car.PlaceQuant;
            BackVolume = car.BackVolume;
            FuelBoxVolume = car.FuelBoxVolume;
            Price = car.Price;
        }
    }
}
