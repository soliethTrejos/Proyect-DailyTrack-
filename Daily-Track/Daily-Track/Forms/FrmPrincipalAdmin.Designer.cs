namespace Daily_Track.Forms
{
    partial class FrmPrincipalAdmin
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
            this.label = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbshow = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnOpenReport = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(201)))), ((int)(((byte)(214)))));
            this.label.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(-2, 214);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(121, 18);
            this.label.TabIndex = 14;
            this.label.Text = "Administrador";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::Daily_Track.Properties.Resources.BOTONSalir;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(201)))), ((int)(((byte)(214)))));
            this.btnBack.Location = new System.Drawing.Point(13, 386);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 44);
            this.btnBack.TabIndex = 13;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.BackgroundImage = global::Daily_Track.Properties.Resources.eventos;
            this.btnAddEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEvent.Location = new System.Drawing.Point(282, 272);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(108, 118);
            this.btnAddEvent.TabIndex = 15;
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackgroundImage = global::Daily_Track.Properties.Resources.eventos;
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Location = new System.Drawing.Point(518, 272);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(108, 118);
            this.btnSend.TabIndex = 17;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(137)))), ((int)(((byte)(152)))));
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(277, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Añadir Evento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(137)))), ((int)(((byte)(152)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(500, 396);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(173, 42);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "Mandar notificacion del Evento";
            // 
            // lbshow
            // 
            this.lbshow.BackColor = System.Drawing.Color.White;
            this.lbshow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbshow.FormattingEnabled = true;
            this.lbshow.Location = new System.Drawing.Point(174, 123);
            this.lbshow.Name = "lbshow";
            this.lbshow.Size = new System.Drawing.Size(505, 130);
            this.lbshow.TabIndex = 21;
            this.lbshow.SelectedIndexChanged += new System.EventHandler(this.lbEvents_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(147, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(619, 31);
            this.label4.TabIndex = 22;
            this.label4.Text = "Daily Track-UAM: Calendario Universitario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(326, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Eventos Registrados ";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(690, 123);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(98, 45);
            this.btnShow.TabIndex = 29;
            this.btnShow.Text = "Mostrar  Evento ";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnOpenReport
            // 
            this.btnOpenReport.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnOpenReport.Location = new System.Drawing.Point(1, 357);
            this.btnOpenReport.Name = "btnOpenReport";
            this.btnOpenReport.Size = new System.Drawing.Size(106, 23);
            this.btnOpenReport.TabIndex = 30;
            this.btnOpenReport.Text = "Mostrar Reporte";
            this.btnOpenReport.UseSelectable = true;
            this.btnOpenReport.Click += new System.EventHandler(this.btnOpenReport_Click);
            // 
            // PrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Daily_Track.Properties.Resources.Fondosuserandadmin_;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenReport);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbshow);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnBack);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(137)))), ((int)(((byte)(152)))));
            this.Name = "PrincipalAdmin";
            this.Text = "PrincipalAdmin";
            this.Load += new System.EventHandler(this.PrincipalAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox lbshow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShow;
        private MetroFramework.Controls.MetroButton btnOpenReport;
    }
}