using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaculdadeProjeto
{
    public partial class menuPrincipal : Form
    {
        public menuPrincipal()
        {
            InitializeComponent();
        }

        private void verAgendaToolStripMenuItem_Click(object sender, EventArgs e) // ver agenda
        {
            ver_agenda frm = new ver_agenda();
            frm.Show();
        }

        private void agendarToolStripMenuItem_Click(object sender, EventArgs e) // agendar
        {
            cadastro_Servico frm = new cadastro_Servico();
            frm.Show();
        }

        private void editarAgendaToolStripMenuItem_Click(object sender, EventArgs e)// editar agenda
        {
            menu frm = new menu();
            frm.Show();
        }

        private void menuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
