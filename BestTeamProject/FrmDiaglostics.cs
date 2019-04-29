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
    public partial class FrmDiaglostics : Form
    {
        public FrmDiaglostics()
        {
            InitializeComponent();
        }

        public void allTimeTrue()
        {
            rdb0910.Enabled = true;
            rdb1011.Enabled = true;
            rdb1112.Enabled = true;
            rdb1213.Enabled = true;
            rdb1314.Enabled = true;
            rdb1415.Enabled = true;
            rdb1516.Enabled = true;
            rdb1617.Enabled = true;
            rdb1718.Enabled = true;
            rdb1819.Enabled = true;
            rdb1920.Enabled = true;
            rdb2021.Enabled = true;
        }

        private void btnPognaliVyberem_Click(object sender, EventArgs e)
        {
            // проверим сначала всякие ошибочки
            if (dtpDate.Value.Date < DateTime.Today)
                MessageBox.Show("Введите корректную дату");
            //else if (dtpDate.Value.Date == DateTime.Today)
            //{
            //    int hour = DateTime.Now.Hour;
            //    if (hour > 19)
            //        MessageBox.Show("Сегодня вы уже не можете записаться, выберите пожалуйста дату начиная с завтрашнего дня");
            //    else if (hour > 18)
            //    {
            //        for (int i = 0; i < hour - 7; i++)
            //        {
            //            // тут тоже с рисовкой чтото с drow лалала :(((
            //            lbxTime.Items[i].BackColor = Color.Red;
            //        }
            //    }
            //}
            // записать инфу о клиетне, машине и времени
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            // радиакнопки заменить надо на чтото (поискать в инете, чтобы прорисовка норм была)
            allTimeTrue();
            if (dtpDate.Value.Date == DateTime.Today)
            {
                int hour = DateTime.Now.Hour;
                {
                    if (hour < 7)
                        rdb0910.Enabled = true;
                    if (hour > 7)
                        rdb0910.Enabled = false;
                    if (hour > 8)
                        rdb1011.Enabled = false;
                    if (hour > 9)
                        rdb1112.Enabled = false;
                    if (hour > 10)
                        rdb1213.Enabled = false;
                    if (hour > 11)
                        rdb1314.Enabled = false;
                    if (hour > 12)
                        rdb1415.Enabled = false;
                    if (hour > 13)
                        rdb1516.Enabled = false;
                    if (hour > 14)
                        rdb1617.Enabled = false;
                    if (hour > 15)
                        rdb1718.Enabled = false;
                    if (hour > 16)
                        rdb1819.Enabled = false;
                    if (hour > 17)
                        rdb1920.Enabled = false;
                    if (hour > 18)
                    {
                        rdb2021.Enabled = false;
                        MessageBox.Show("Сегодня вы уже не можете записаться, выберите пожалуйста дату начиная с завтрашнего дня");
                    }
                       
                }
            }
        }
    }
}
