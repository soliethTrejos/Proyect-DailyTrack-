using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Daily_Track.Reports
{
    public partial class frmReportParticipation : MetroFramework.Forms.MetroForm
    {
        public frmReportParticipation()
        {
            InitializeComponent();
            LoadReport();
        }

        private void FrmReportParticipation_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            var reportData = ParticipationReport.GetDailyParticipation();

            // Configuración del gráfico
            chartParticipation.Series.Clear();
            chartParticipation.Titles.Clear();

            Series series = new Series
            {
                Name = "Participación",
                ChartType = SeriesChartType.Pie
            };

            foreach (var data in reportData)
            {
                series.Points.AddXY(data.EventName, data.Participants);
            }

            chartParticipation.Series.Add(series);
            chartParticipation.Titles.Add("Participación de Estudiantes en Eventos");
        }

    }
}
