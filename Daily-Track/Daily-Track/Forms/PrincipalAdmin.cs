using Daily_Track.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daily_Track.Forms
{
    public partial class PrincipalAdmin : Form
    {
        public PrincipalAdmin()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEventos addEventos = new AddEventos();
            addEventos.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void PrincipalAdmin_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //manda un mesaje de confirmacion
            MessageBox.Show("Ya se ha enviado la notificación a los estudiantes.");
        }

        private void lbEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            //mostrar los eventos del listbox de AddEventos
            if (lbshow.SelectedItem != null)
            {
                string eventoSeleccionado = lbshow.SelectedItem.ToString();
                MessageBox.Show($"Evento seleccionado: {eventoSeleccionado}");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnOpenReport_Click(object sender, EventArgs e)
        {
            frmReportParticipation reportForm = new frmReportParticipation();

            reportForm.ShowDialog();
        }
    }
}
 