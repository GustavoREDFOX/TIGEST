using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIGEST
{
    public partial class Frm_TelaInicial : Form
    {
        public Frm_TelaInicial()
        {
            InitializeComponent();
        }

        private void Btn_Ativos_Click(object sender, EventArgs e)
        {
            Frm_RecursosAtivos recursosAtivos = new Frm_RecursosAtivos();

            var max = 100;

            Prb_LoadProcess.Maximum = max;
            
            for (int i = 10; i < 100; i++) {
                Thread.Sleep(1);
                Prb_LoadProcess.Value = i;
            }
            Thread.Sleep(100);
            recursosAtivos.Show();
            Thread.Sleep(500);
            this.Hide();
        }
    }
}
