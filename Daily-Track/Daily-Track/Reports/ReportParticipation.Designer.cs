namespace Daily_Track.Reports
{
    partial class frmReportParticipation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartParticipation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartParticipation)).BeginInit();
            this.SuspendLayout();
            // 
            // chartParticipation
            // 
            chartArea2.Name = "ChartArea1";
            this.chartParticipation.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartParticipation.Legends.Add(legend2);
            this.chartParticipation.Location = new System.Drawing.Point(13, 64);
            this.chartParticipation.Name = "chartParticipation";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartParticipation.Series.Add(series2);
            this.chartParticipation.Size = new System.Drawing.Size(552, 305);
            this.chartParticipation.TabIndex = 0;
            this.chartParticipation.Text = "chart1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(419, 375);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(122, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Actualizar reporte";
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmReportParticipation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 442);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.chartParticipation);
            this.Name = "frmReportParticipation";
            this.Text = "FrmReportParticipation";
            this.Load += new System.EventHandler(this.FrmReportParticipation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartParticipation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartParticipation;
        private MetroFramework.Controls.MetroButton btnRefresh;
    }
}