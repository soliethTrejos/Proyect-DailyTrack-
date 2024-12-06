﻿using Daily_Track.Dao;
using Daily_Track.Models;
using Daily_Track.Reportes;
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
    public partial class FrmPrincipalAdmin : Form
    {
        public FrmPrincipalAdmin()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmAdmin admin = new FrmAdmin();
            admin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAddEventos addEventos = new FrmAddEventos();
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
            //muestra los reportes de los eventos
            List<Events> eventos = new EventDao().GetAllEvents();
            frmReportesEventos reportesEventos = new frmReportesEventos(eventos);
            reportesEventos.Show();
            this.Hide();

        }

        private void lbEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnOpenReport_Click(object sender, EventArgs e)
        {
           
        }

     

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            ;
        }
    }
}
 