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
        List<Car> Cars = new List<Car>();
        Car car; // Данная машина выбранная
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Bd_Alupki.mdb;";
        public OleDbConnection myConnection;

        public FrmCatalog(string sql)
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();

            // текст запроса
            string query = "SELECT CarID, Make, Model, Year, Color, Power, MaxSpeed, FuelWaist, PlaceQuant, BoxVolume, FuelBoxVolume, Price, Photo FROM Машины" + sql;

            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);

            // получаем объект OleDbDataReader для чтения табличного результата запроса SELECT
            OleDbDataReader reader = command.ExecuteReader();

            // очищаем listBox1
            listBox1.Items.Clear();

            // в цикле построчно читаем ответ от БД
            while (reader.Read())
            {
                car = new Car();
                car.CarID = int.Parse(reader[0].ToString());
                car.Make = reader[1].ToString();
                car.Model = reader[2].ToString();
                car.Year = int.Parse(reader[3].ToString());
                car.Color = reader[4].ToString();
                car.Power = int.Parse(reader[5].ToString());
                car.MaxSpeed = int.Parse(reader[6].ToString());
                car.FuelWaist = double.Parse(reader[7].ToString());
                car.PlaceQuant = int.Parse(reader[8].ToString());
                car.BackVolume = int.Parse(reader[9].ToString());
                car.FuelBoxVolume = int.Parse(reader[10].ToString());
                car.Price = int.Parse(reader[11].ToString());
                car.Photo = car.CarID + ".png";
                
                Cars.Add(car);
            }

            // Добавляем в список
            foreach (Car c in Cars)
            {
                listBox1.Items.Add(c.ShowCar());
            }

            // закрываем OleDbDataReader
            reader.Close();
        }

        // купить машинку
        private void btnBuy_Click(object sender, EventArgs e)
        {
            int id = int.Parse((listBox1.SelectedItem.ToString()).Substring(0, 1));
            //MessageBox.Show(id.ToString());
            int id2 = 0;
            // найдем индекс машинки
            for (int i = 0; i < Cars.Count; i++)
            {
                if (Cars[i].CarID == id)
                    id2 = i;
            }
            FrmSale frmSale = new FrmSale(Cars[id2]);
            frmSale.Show();
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            int id = int.Parse((listBox1.SelectedItem.ToString()).Substring(0, 1));
            //MessageBox.Show(id.ToString());
            int id2 = 0;
            // найдем индекс машинки
            for (int i = 0; i < Cars.Count; i++)
            {
                if (Cars[i].CarID == id)
                    id2 = i;
            }
            FrmCaracteristics frmCharacteristics = new FrmCaracteristics(Cars[id2]);
            frmCharacteristics.Show();
        }

        

        // ФИЛЬТРЫ
        private void выбратьХарактеристикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFilters frmFilters = new FrmFilters();
            frmFilters.Show();
            this.Close();
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

        // после закрытия открыть прошлое окно
        private void FrmCatalog_Leave(object sender, EventArgs e)
        {
            FrmMain form = new FrmMain();
            form.ShowDialog();
        }
    }
}
