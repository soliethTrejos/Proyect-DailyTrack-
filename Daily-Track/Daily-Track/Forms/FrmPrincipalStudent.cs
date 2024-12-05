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
    public partial class FrmPrincipalStudent : Form
    {
        public FrmPrincipalStudent()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmStudents students = new FrmStudents();
            students.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmReservation reservation = new FrmReservation();
            reservation.Show();
            this.Hide();
        }
    }
}
