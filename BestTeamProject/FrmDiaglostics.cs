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
        public bool[] time_array = new bool[12];
        
        public FrmDiaglostics()
        {
            InitializeComponent();
            TimeToday();
            int hour = DateTime.Now.Hour;
            for (int i = 0; i < (hour - 8); i++)
            {
                time_array[i] = false;
            }
            drawTime();
            if (hour > 20) MessageBox.Show("Сегодня вы уже не можете записаться, \nвыберите пожалуйста дату начиная с завтрашнего дня");

            //txtName.Text = timeBox.SelectedIndex.ToString();
        }

        public void TimeToday()
        {
            for (int i = 0; i < 12; i++) //вместо этого цикла потом сделать считывание из бд на выбранную дату
            {                              //где есть время, там true
                time_array[i] = true;
            }
        }

        public void drawTime()
        {
            for (int i = 0; i < 12; i++)
            {
                if (time_array[i] == true)
                {
                    string[] s = { (i + 9).ToString(), ".00-", (i + 10).ToString(), ".00" };
                    string ss = string.Concat(s);
                    timeBox.Items.Add(ss);
                }
            }
        }

        private void btnPognaliVyberem_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string Phone = "";
            string Car = txtCar.Text;
            // проверим сначала всякие ошибочки
            if (dtpDate.Value.Date < DateTime.Today)
                MessageBox.Show("Введите корректную дату");
            if (Name.Length == 0)
            {
                MessageBox.Show("Введите Имя");
                txtName.Focus();

            }
            else if (Car.Length == 0)
            {
                MessageBox.Show("Введите Название машины");
                txtCar.Focus();
            }
            else if (timeBox.SelectedIndex == -1)
                MessageBox.Show("Выберите время!");
            else
            {
                try
                {
                    int value;
                    try { int.TryParse(txtTelephone.Text, out value); }
                    catch
                    {
                        MessageBox.Show("Номер должен состоять из  цифр");
                    }
                    if (txtTelephone.Text.Length != 11)
                    {
                        MessageBox.Show("Номер должен состоять из 11 цифр");
                        txtTelephone.Focus();
                    }
                    Phone = txtTelephone.Text;
                }
                catch { MessageBox.Show("Введите Номер телефона в формате (89603892716)"); txtTelephone.Focus(); }
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            timeBox.Items.Clear();

            if (dtpDate.Value.Date == DateTime.Today)
            {
                TimeToday();
                int hour = DateTime.Now.Hour;
                for (int i = 0; i < (hour - 8); i++)
                {
                    time_array[i] = false;
                }
                drawTime();
                if (hour > 20) MessageBox.Show("Сегодня вы уже не можете записаться, \nвыберите пожалуйста дату начиная с завтрашнего дня");

            }
            if (dtpDate.Value.Date > DateTime.Today)
            {
                TimeToday();
                drawTime();
                if (timeBox.Items.Count == 0) MessageBox.Show("На эту дату уже нет свободного времени");
            }
            if (dtpDate.Value.Date < DateTime.Today) MessageBox.Show("На эту дату уже нельзя записаться, \nвыберите пожалуйста дату начиная с завтрашнего дня");
        }
    }
}
