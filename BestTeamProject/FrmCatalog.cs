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
    public partial class FrmCatalog : Form
    {
        Car car;

        public FrmCatalog()
        {
            InitializeComponent();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            // купить машинку
            FrmSale frmSale = new FrmSale();
            frmSale.Show();
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            FrmCaracteristics frmCharacteristics = new FrmCaracteristics(car);
            frmCharacteristics.Show();
        }

        // тут надо машину инициализовывать
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void выбратьХарактеристикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFilters frmFilters = new FrmFilters();
            frmFilters.Show();
        }
    }
}
