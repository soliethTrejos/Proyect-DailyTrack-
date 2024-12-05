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
    public partial class FrmStudents : Form
    {
        

        public FrmStudents()
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
            if (tbID.Text.Length > 7)
            {
                MessageBox.Show("El ID no puede tener más de 7 numeros.");
                tbID.Text = tbID.Text.Substring(0, 7);
                tbID.SelectionStart = tbID.Text.Length;
            }

        }

        private void tbPaas_TextChanged(object sender, EventArgs e)
        {
            // Limitar la contraseña a un máximo de 8 caracteres
            if (tbPaas.Text.Length > 8)
            {
                MessageBox.Show("La contraseña no puede tener más de 8 caracteres.");
                tbPaas.Text = tbPaas.Text.Substring(0, 8);
                tbPaas.SelectionStart = tbPaas.Text.Length; 
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void PbShowpass_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInto_Click(object sender, EventArgs e)
        {
            FrmPrincipalStusent principalStusent = new FrmPrincipalStusent();
            principalStusent.Show();
            this.Hide();
        }

        private void FrmStudents_Load(object sender, EventArgs e)
        {

        }
    }
}
