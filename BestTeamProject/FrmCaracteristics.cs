using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestTeamProject
{
    public partial class FrmCaracteristics : Form
    {
        Car myCar;
        public FrmCaracteristics()
        {
            InitializeComponent();
        }

        public FrmCaracteristics(Car car)
        {
            InitializeComponent();
            myCar = new Car(car);

            txtModel.Text = car.Make + " " + car.Model;
            txtYear.Text = car.Year.ToString();
            txtColor.Text = car.Color;
            txtPower.Text = car.Power.ToString();
            txtMaxSpeed.Text = car.MaxSpeed.ToString();
            txtFuelWaist.Text = car.FuelWaist.ToString();
            txtPlaceQuant.Text = car.PlaceQuant.ToString();
            txtBackVolume.Text = car.BackVolume.ToString();
            txtFuelBoxVolume.Text = car.FuelBoxVolume.ToString();
            txtPrice.Text = car.Price.ToString();

            pcbCar.Image = Image.FromFile(car.Photo);
        }
    }
}
