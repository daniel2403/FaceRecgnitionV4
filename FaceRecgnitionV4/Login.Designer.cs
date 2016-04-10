namespace FaceRecgnitionV4
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.btnOn = new DevExpress.XtraEditors.SimpleButton();
            this.btnOff = new DevExpress.XtraEditors.SimpleButton();
            this.btnIniciar = new DevExpress.XtraEditors.SimpleButton();
            this.lnkInicioFallo = new System.Windows.Forms.LinkLabel();
            this.lnkNuevo = new System.Windows.Forms.LinkLabel();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(12, 12);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(273, 178);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // btnOn
            // 
            this.btnOn.Location = new System.Drawing.Point(12, 194);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(37, 36);
            this.btnOn.TabIndex = 3;
            this.btnOn.Text = "O";
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(55, 194);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(40, 36);
            this.btnOff.TabIndex = 4;
            this.btnOff.Text = "x";
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(104, 195);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(181, 35);
            this.btnIniciar.TabIndex = 5;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lnkInicioFallo
            // 
            this.lnkInicioFallo.AutoSize = true;
            this.lnkInicioFallo.Location = new System.Drawing.Point(12, 387);
            this.lnkInicioFallo.Name = "lnkInicioFallo";
            this.lnkInicioFallo.Size = new System.Drawing.Size(156, 17);
            this.lnkInicioFallo.TabIndex = 13;
            this.lnkInicioFallo.TabStop = true;
            this.lnkInicioFallo.Text = "No puedo iniciar sesion";
            // 
            // lnkNuevo
            // 
            this.lnkNuevo.AutoSize = true;
            this.lnkNuevo.Location = new System.Drawing.Point(184, 387);
            this.lnkNuevo.Name = "lnkNuevo";
            this.lnkNuevo.Size = new System.Drawing.Size(100, 17);
            this.lnkNuevo.TabIndex = 12;
            this.lnkNuevo.TabStop = true;
            this.lnkNuevo.Text = "Nuevo usuario";
            this.lnkNuevo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNuevo_LinkClicked);
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(14, 249);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.ShowTitle = true;
            this.progressBarControl1.Properties.TextOrientation = DevExpress.Utils.Drawing.TextOrientation.Horizontal;
            this.progressBarControl1.Size = new System.Drawing.Size(272, 42);
            this.progressBarControl1.TabIndex = 14;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 413);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.lnkInicioFallo);
            this.Controls.Add(this.lnkNuevo);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.imageBox1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private DevExpress.XtraEditors.SimpleButton btnOn;
        private DevExpress.XtraEditors.SimpleButton btnOff;
        private DevExpress.XtraEditors.SimpleButton btnIniciar;
        private System.Windows.Forms.LinkLabel lnkInicioFallo;
        private System.Windows.Forms.LinkLabel lnkNuevo;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
    }
}

