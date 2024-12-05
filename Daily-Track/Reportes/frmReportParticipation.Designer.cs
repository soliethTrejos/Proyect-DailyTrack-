namespace Daily_Track.Reportes
{
    partial class frmReportsEvents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportsEvents));
            this._dsEventos1 = new Daily_Track.Reportes._dsEventos();
            ((System.ComponentModel.ISupportInitialize)(this._dsEventos1)).BeginInit();
            this.SuspendLayout();
            // 
            // _dsEventos1
            // 
            this._dsEventos1.DataSetName = "dsEventos";
            this._dsEventos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmReportsEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Daily_Track.Properties.Resources.Fondos__1_;
            this.ClientSize = new System.Drawing.Size(731, 424);
            this.ForeColor = System.Drawing.Color.Cyan;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportsEvents";
            this.Text = "Reportes Eventos";
            ((System.ComponentModel.ISupportInitialize)(this._dsEventos1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private _dsEventos _dsEventos1;
    }
}