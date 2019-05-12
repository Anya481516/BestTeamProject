using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Word = Microsoft.Office.Interop.Outlook;

namespace BestTeamProject
{
    public partial class FrmSale : Form
    {
        Car myCar;
        Person client;

        public FrmSale()
        {
            InitializeComponent();
        }

        public FrmSale(Car car)
        {
            InitializeComponent();
            myCar = new Car(car);

            pcbCar.Image = Image.FromFile(car.Photo);
        }

        private void btnShowCharacteristics_Click(object sender, EventArgs e)
        {
            FrmCaracteristics frmCharacteristics = new FrmCaracteristics(myCar);
            frmCharacteristics.Show();
        }

        private void btnBuyBuy_Click(object sender, EventArgs e)
        {
            client.FirstName = txtName.Text;
            client.LastName = txtLastName.Text;
            client.FatherName = txtThirdName.Text;
            client.DateOfBirth = dtpDateOfBirth.Value;
            client.Telephone = txtTelephone.Text;
            client.Address = txtAddress.Text;

            // надо в файл записать
            var wordApp = new Word.Application();
            
            //var wordDocument = wordApp.Docu
        }
    }
}
