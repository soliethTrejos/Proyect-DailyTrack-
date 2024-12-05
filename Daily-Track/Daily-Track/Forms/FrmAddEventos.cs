using System;
using Daily_Track.Models;
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
    public partial class FrmAddEventos : Form
    {
        public FrmAddEventos()
        {
            InitializeComponent();
            List<string> eventos = new List<string>();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmPrincipalAdmin principalAdmin = new FrmPrincipalAdmin();
            principalAdmin.Show();
            this.Hide();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //que el usuario pieda agrega evento 
            MessageBox.Show("Agregue un evento");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbEvents.SelectedItem != null)
            {
                string eventoSeleccionado = lbEvents.SelectedItem.ToString();
                MessageBox.Show($"Evento seleccionado: {eventoSeleccionado}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Agregar el evento ingresado por el usuario al ListBox
            string evento = tbID.Text;
            string fecha = dtpDay.Text;
            string hora =tbHours.Text;
            string lugar = tbpalce.Text;
            string tipo = tbTipe.Text;
            string descripcion = tbDescripcion.Text;
            string eventoCompleto = $"{evento} - {fecha} - {hora} - {lugar} - {tipo} - {descripcion}";
            lbEvents.Items.Add(eventoCompleto);
            MessageBox.Show("Evento agregado correctamente");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {
            //solo numero y delimitado 
            if (!System.Text.RegularExpressions.Regex.IsMatch(tbID.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor, ingrese solo números.");
                tbID.Text = string.Empty;
            }
            // Limitar el campo de texto a un máximo de 5 caracteres
            if (tbID.Text.Length > 5)
            {
                MessageBox.Show("El ID no puede tener más de 5 numeros.");
                tbID.Text = tbID.Text.Substring(0, 5);
                tbID.SelectionStart = tbID.Text.Length;
            }
        }
    }
}
