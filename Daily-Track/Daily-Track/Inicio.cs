using Daily_Track.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daily_Track
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Crea un vinculo a la ventana del UamClass
            System.Diagnostics.Process.Start("https://uvirtual.uam.edu.ni:442/uvirtual/");
        }

        private void btnHelp_Click_1(object sender, EventArgs e)
        {
            //Crea un vincculo a un video de ayuda
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=J2X5mJ3HDYE");
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            //llama a la ventana de Admin
            FrmAdmin admin = new FrmAdmin();
            admin.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://uamvirtual.uam.edu.ni/grado/login/index.php");
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            FrmStudents student = new FrmStudents();
            student.Show();
            this.Hide();

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
       
}
