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
    public partial class FrmReservation : Form
    {
        public FrmReservation()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmPrincipalStusent principalStusent = new FrmPrincipalStusent();
            principalStusent.Show();
            this.Hide();
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        // Método para agregar una reservación y mostrarla en el ListBox
        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            // Ejemplo de cómo agregar una reservación al ListBox
            string nuevaReservacion = "Reservación " + (lbReservation.Items.Count + 1);
            lbReservation.Items.Add(nuevaReservacion);
        }

        // Método para mostrar la reservación seleccionada
        private void lbEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbReservation.SelectedItem != null)
            {
                string reservacionSeleccionada = lbReservation.SelectedItem.ToString();
                MessageBox.Show("Reservación seleccionada: " + reservacionSeleccionada, "Detalle de Reservación");
            }
        }
    }
}
