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
    public partial class FrmSale : Form
    {
        Car car;

        public FrmSale()
        {
            InitializeComponent();
        }

        public FrmSale(Car car)
        {
            car = new Car(car);
            InitializeComponent();
        }

        private void btnShowCharacteristics_Click(object sender, EventArgs e)
        {
            FrmCaracteristics frmCharacteristics = new FrmCaracteristics(car);
            frmCharacteristics.Show();
        }
    }
}
