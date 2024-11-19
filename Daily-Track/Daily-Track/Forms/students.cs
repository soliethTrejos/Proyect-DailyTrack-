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
    public partial class students : Form
    {
        public students()
        {
            InitializeComponent();
        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {
            //solo numero 
            if (!System.Text.RegularExpressions.Regex.IsMatch(tbID.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor, ingrese solo números.");
                tbID.Text = string.Empty;
            }
            // Limitar el campo de texto a un máximo de 5 caracteres
            if (tbID.Text.Length > 5)
            {
                MessageBox.Show("El ID no puede tener más de 5 caracteres.");
                tbID.Text = tbID.Text.Substring(0, 5);
                tbID.SelectionStart = tbID.Text.Length; // Mover el cursor al final
            }

        }

        private void tbPaas_TextChanged(object sender, EventArgs e)
        {
            //Maximo de carracteres 
            if (tbPaas.Text.Length > 8)
            {
                MessageBox.Show("La contraseña no puede tener más de 8 caracteres.");
                tbPaas.Text = tbPaas.Text.Substring(0, 8);
                tbPaas.SelectionStart = tbPaas.Text.Length; // Mover el cursor al final
            }
            //Minimo de carracteres
            if (tbPaas.Text.Length < 8)
            {
                MessageBox.Show("La contraseña no puede tener menos de 8 caracteres.");
                tbPaas.Text = tbPaas.Text.Substring(0, 8);
                tbPaas.SelectionStart = tbPaas.Text.Length; // Mover el cursor al final
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }
    }
}
