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
    public partial class FrmFilters : Form
    {
        public FrmFilters()
        {
            InitializeComponent();
        }

        private void trbMinYear_Scroll(object sender, EventArgs e)
        {
            lblMinYear.Text = trbMinYear.Value.ToString();
        }

        private void trbMaxYear_Scroll(object sender, EventArgs e)
        {
            lblMaxYear.Text = trbMaxYear.Value.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        // тут все нормас
        private void trbMinPower_Scroll(object sender, EventArgs e)
        {
            txtMinPower.Text = trbMinPower.Value.ToString();
            if (Int32.Parse(txtMinPower.Text) > Int32.Parse(txtMaxPower.Text))
            {
                trbMinPower.Value = Int32.Parse(txtMaxPower.Text);
                txtMinPower.Text = trbMinPower.Value.ToString();
            }
        }

        // тут все нормас
        private void trbMaxPower_Scroll(object sender, EventArgs e)
        {
            txtMaxPower.Text = trbMaxPower.Value.ToString();
            if (Int32.Parse(txtMaxPower.Text) < Int32.Parse(txtMinPower.Text))
            {
                trbMaxPower.Value = Int32.Parse(txtMinPower.Text);
                txtMaxPower.Text = trbMaxPower.Value.ToString();
            }
        }

        // а когда меняем в текст боксе надо подумать как норм сделать йоу _______________________________
        private void txtMaxPower_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Int32.Parse(txtMaxPower.Text) < Int32.Parse(txtMinPower.Text))
                {
                    txtMaxPower.Text = txtMinPower.Text;
                    MessageBox.Show("Число должно быть от " + txtMinPower.Text + " до 300");
                    txtMaxPower.SelectAll();
                    trbMaxPower.Value = Int32.Parse(txtMinPower.Text);
                }
            }
        }

        private void txtMinPower_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Int32.Parse(txtMinPower.Text) > Int32.Parse(txtMaxPower.Text))
                {
                    txtMinPower.Text = txtMaxPower.Text;
                    MessageBox.Show("Число должно быть от 100 до " + txtMaxPower.Text);
                    txtMinPower.SelectAll();
                    trbMinPower.Value = Int32.Parse(txtMaxPower.Text);
                }
            }
        }
    }
}
