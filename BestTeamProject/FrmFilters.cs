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
        public string priceSql;
        public string colorSql;
        string priceSql1 = " WHERE Price BETWEEN 1000000";
        string priceSql2 = " AND 3000000";
        string colorSqlBlack = "";
        string colorSqlGrey = "";
        string colorSqlRed = "";

        public FrmFilters()
        {
            InitializeComponent();
            this.BringToFront();
        }

        //// а когда меняем в текст боксе надо подумать как норм сделать йоу _______________________________
        //private void txtMaxPower_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        if (Int32.Parse(txtMaxPower.Text) < Int32.Parse(txtMinPower.Text))
        //        {
        //            txtMaxPower.Text = txtMinPower.Text;
        //            MessageBox.Show("Число должно быть от " + txtMinPower.Text + " до 300");
        //            txtMaxPower.SelectAll();
        //            trbMaxPower.Value = Int32.Parse(txtMinPower.Text);
        //        }
        //    }
        //}

        //private void txtMinPower_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        if (Int32.Parse(txtMinPower.Text) > Int32.Parse(txtMaxPower.Text))
        //        {
        //            txtMinPower.Text = txtMaxPower.Text;
        //            MessageBox.Show("Число должно быть от 100 до " + txtMaxPower.Text);
        //            txtMinPower.SelectAll();
        //            trbMinPower.Value = Int32.Parse(txtMaxPower.Text);
        //        }
        //    }
        //}

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (ckbBlack.Checked && ckbGrey.Checked && ckbRed.Checked)
            {
                colorSql = " AND Color in ('Black', 'Grey', 'Red')";
            }
            else if (ckbBlack.Checked && ckbGrey.Checked == false && ckbRed.Checked)
            {
                colorSql = " AND Color in ('Black', 'Red')";
            }
            else if (ckbBlack.Checked && ckbGrey.Checked && ckbRed.Checked == false)
            {
                colorSql = " AND Color in ('Black', 'Grey')";
            }
            else if (ckbBlack.Checked == false && ckbGrey.Checked && ckbRed.Checked)
            {
                colorSql = " AND Color in ('Grey', 'Red'";
            }
            else if (ckbBlack.Checked == false && ckbGrey.Checked == false && ckbRed.Checked)
            {
                colorSql = " AND Color LIKE 'Red'";
            }
            else if (ckbBlack.Checked == false && ckbGrey.Checked && ckbRed.Checked == false)
            {
                colorSql = " AND Color LIKE 'Grey'";
            }
            if (ckbBlack.Checked && ckbGrey.Checked == false && ckbRed.Checked == false)
            {
                colorSql = " AND Color LIKE 'Black'";
            }
            else if (ckbBlack.Checked == false && ckbGrey.Checked == false && ckbRed.Checked == false)
            {
                colorSql = "";
            }

            priceSql = priceSql1 + priceSql2;

            FrmCatalog frmCatalog = new FrmCatalog(priceSql + colorSql);
            frmCatalog.Show();
            this.Close();
        }

        
        private void tkbMinPrice_Scroll(object sender, EventArgs e)
        {
            txtMinPrice.Text = tkbMinPrice.Value.ToString();
            if (Int32.Parse(txtMinPrice.Text) > Int32.Parse(txtMaxPrice.Text))
            {
                tkbMinPrice.Value = Int32.Parse(txtMaxPrice.Text);
                txtMinPrice.Text = tkbMinPrice.Value.ToString();
            }
            priceSql1 = " WHERE Price BETWEEN " + txtMinPrice.Text + "000";
        }

        
        private void tkbMaxPrice_Scroll(object sender, EventArgs e)
        {
            txtMaxPrice.Text = tkbMaxPrice.Value.ToString();
            if (Int32.Parse(txtMaxPrice.Text) < Int32.Parse(txtMinPrice.Text))
            {
                tkbMaxPrice.Value = Int32.Parse(txtMinPrice.Text);
                txtMaxPrice.Text = tkbMaxPrice.Value.ToString();
            }
            priceSql2 = " AND " + txtMaxPrice.Text + "000";
        }
    }
}
