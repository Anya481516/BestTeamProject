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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }

        // Вызываетсч окно руководства пользователя
        private void какПользоватьсяToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmHelp frmHelp = new FrmHelp();
            frmHelp.ShowDialog();
        }

        // Вызывается окно на запись на диагностику
        private void btnPognaliPochinim_Click(object sender, EventArgs e)
        {
            FrmDiaglostics frmDiagnostics = new FrmDiaglostics();
            frmDiagnostics.ShowDialog();
        }

        // Вызывается окно каталога автомобилей
        private void btnPognaliVyberem_Click(object sender, EventArgs e)
        {
            FrmCatalog frmCatalog = new FrmCatalog();
            frmCatalog.ShowDialog();
        }

        // Закрыть приложение
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
