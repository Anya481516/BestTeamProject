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
        }
    }
}
