namespace Daily_Track
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.label1 = new System.Windows.Forms.Label();
            this.btnadministration = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnUam = new System.Windows.Forms.Button();
            this.btnUamV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(619, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daily Track-UAM: Calendario Universitario";
            // 
            // btnadministration
            // 
            this.btnadministration.BackgroundImage = global::Daily_Track.Properties.Resources.admin__1_1;
            this.btnadministration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnadministration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadministration.Location = new System.Drawing.Point(238, 161);
            this.btnadministration.Name = "btnadministration";
            this.btnadministration.Size = new System.Drawing.Size(160, 198);
            this.btnadministration.TabIndex = 1;
            this.btnadministration.UseVisualStyleBackColor = true;
            this.btnadministration.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.BackgroundImage = global::Daily_Track.Properties.Resources.user_interface__1_;
            this.btnStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Location = new System.Drawing.Point(497, 161);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(160, 198);
            this.btnStudent.TabIndex = 2;
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(241, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Administrador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(520, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estudiante";
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHelp.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.Black;
            this.btnHelp.Location = new System.Drawing.Point(35, 144);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(86, 32);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.Text = "Ayuda";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click_1);
            // 
            // btnUam
            // 
            this.btnUam.BackColor = System.Drawing.Color.Transparent;
            this.btnUam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUam.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUam.ForeColor = System.Drawing.Color.Black;
            this.btnUam.Location = new System.Drawing.Point(35, 216);
            this.btnUam.Name = "btnUam";
            this.btnUam.Size = new System.Drawing.Size(86, 32);
            this.btnUam.TabIndex = 6;
            this.btnUam.Text = "UamClass";
            this.btnUam.UseVisualStyleBackColor = false;
            this.btnUam.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnUamV
            // 
            this.btnUamV.BackColor = System.Drawing.Color.Transparent;
            this.btnUamV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUamV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUamV.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUamV.ForeColor = System.Drawing.Color.Black;
            this.btnUamV.Location = new System.Drawing.Point(35, 286);
            this.btnUamV.Name = "btnUamV";
            this.btnUamV.Size = new System.Drawing.Size(86, 32);
            this.btnUamV.TabIndex = 7;
            this.btnUamV.Text = "UamV";
            this.btnUamV.UseVisualStyleBackColor = false;
            this.btnUamV.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(89)))), ((int)(((byte)(98)))));
            this.BackgroundImage = global::Daily_Track.Properties.Resources.Fondosinicio;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUamV);
            this.Controls.Add(this.btnUam);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.btnadministration);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadministration;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnUam;
        private System.Windows.Forms.Button btnUamV;
    }
}