using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestTeamProject
{
    public partial class FrmCatalog : Form
    {
        // https://www.youtube.com/watch?v=zCbsl3lNvnk
        Car car; // Данная машина выбранная
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Bd_Alupki.mdb;";
        public OleDbConnection myConnection;

        public FrmCatalog()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();

            // текст запроса
            string query = "SELECT CarID, Make, Model, Year, Color, Power, MaxSpeed, FuelWaist, PlaceQuant, FuelBoxVolume, Price, BoxVolume FROM Машины";

            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);

            // получаем объект OleDbDataReader для чтения табличного результата запроса SELECT
            OleDbDataReader reader = command.ExecuteReader();

            // очищаем listBox1
            listBox1.Items.Clear();

            // в цикле построчно читаем ответ от БД
            while (reader.Read())
            {
                // выводим данные столбцов текущей строки в listBox1
                listBox1.Items.Add(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString() + " " + reader[3].ToString() + " " + reader[4].ToString() + " " +
                    reader[5].ToString() + " " + reader[6].ToString() + " " + reader[7].ToString() + " " + reader[8].ToString() + " " + reader[9].ToString() + " " + reader[10].ToString() + " "
                    + reader[11].ToString() + " ");
            }

            // закрываем OleDbDataReader
            reader.Close();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            // купить машинку
            FrmSale frmSale = new FrmSale(car);
            frmSale.Show();
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            FrmCaracteristics frmCharacteristics = new FrmCaracteristics(car);
            frmCharacteristics.Show();
        }

        


        private void выбратьХарактеристикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFilters frmFilters = new FrmFilters();
            frmFilters.Show();
        }

        private void FrmCatalog_Load(object sender, EventArgs e)
        {
            //listView1.DataBindings
        }

        private void FrmCatalog_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        // тут надо машину инициализовывать
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int id = listBox1.
        }
    }
}
