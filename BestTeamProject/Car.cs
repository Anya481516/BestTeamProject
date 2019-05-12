using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestTeamProject
{
    public class Car
    {
        public int CarID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int Power { get; set; }
        public int MaxSpeed { get; set; }
        public double FuelWaist { get; set; }
        public int PlaceQuant { get; set; }
        public int BackVolume { get; set; }
        public int FuelBoxVolume { get; set; }
        public int Price { get; set; }
        public String Photo { get; set; }

        public Car()
        {
            //Car car = new Car();
        }

        public Car(Car car)
        {
            Make = car.Make;
            Model = car.Model;
            Year = car.Year;
            Color = car.Color;
            Power = car.Power;
            MaxSpeed = car.MaxSpeed;
            FuelWaist = car.FuelWaist;
            PlaceQuant = car.PlaceQuant;
            BackVolume = car.BackVolume;
            FuelBoxVolume = car.FuelBoxVolume;
            Price = car.Price;
            Photo = car.Photo;
        }

        public String ShowCar()
        {
            return CarID + " Модель:" + Make + " " + Model + ", Год Выпуска:" + Year + ", Цвет:" + Color + ", Цена --- $" + Price;
        }
    }
}
