using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Daily_Track.Models;
using Microsoft.Reporting.WebForms;
using Microsoft.Reporting.WinForms;
using ReportDataSource = Microsoft.Reporting.WinForms.ReportDataSource;

namespace Daily_Track.Reportes
{
    public partial class frmReportesEventos : Form
    {
        public frmReportesEventos(List<Events> events)
        {
            InitializeComponent();
            LoadReport(events);
        }

        private void LoadReport(List<Events> events)
        {
            DataTable eventTable = new DataTable();
            eventTable.Columns.Add("Name", typeof(string));
            eventTable.Columns.Add("Date", typeof(DateTime));
            eventTable.Columns.Add("TotalCupos", typeof(int));
            eventTable.Columns.Add("CuposReservados", typeof(int));
            foreach (var dsEventos in events)
            {
                DataRow row = dsEventos.NewRow();
                row["ID"] = dsEventos.ID;
                row["Name"] = dsEventos.Name;
                row["Date"] = dsEventos.Date;
                row["TotalCupos"] = dsEventos.TotalCupos;
                row["CuposReservados"] = dsEventos.CuposReservados;
                eventTable.Rows.Add(row);
            }

            // Configurar el ReportViewer
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("EventDataSet", eventTable);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void frmReportesEventos_Load(object sender, EventArgs e)
        {

            this.reportViewer2.RefreshReport();
        }
    }
}