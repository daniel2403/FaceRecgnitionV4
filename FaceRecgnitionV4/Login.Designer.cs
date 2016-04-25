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
            this.pcInferior = new DevExpress.XtraEditors.PanelControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcInferior)).BeginInit();
            this.pcInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox1.Location = new System.Drawing.Point(9, 10);
            this.imageBox1.Margin = new System.Windows.Forms.Padding(2);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(351, 253);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // btnOn
            // 
            this.btnOn.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOn.Appearance.Options.UseFont = true;
            this.btnOn.Location = new System.Drawing.Point(9, 293);
            this.btnOn.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnOn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnOn.Margin = new System.Windows.Forms.Padding(2);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(75, 22);
            this.btnOn.TabIndex = 3;
            this.btnOn.Text = "Enceder";
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // btnOff
            // 
            this.btnOff.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOff.Appearance.Options.UseFont = true;
            this.btnOff.Location = new System.Drawing.Point(283, 293);
            this.btnOff.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnOff.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnOff.Margin = new System.Windows.Forms.Padding(2);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(75, 22);
            this.btnOff.TabIndex = 4;
            this.btnOff.Text = "Apagar";
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Appearance.Options.UseFont = true;
            this.btnIniciar.Enabled = false;
            this.btnIniciar.Location = new System.Drawing.Point(88, 293);
            this.btnIniciar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnIniciar.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(2);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 22);
            this.btnIniciar.TabIndex = 5;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lnkInicioFallo
            // 
            this.lnkInicioFallo.AutoSize = true;
            this.lnkInicioFallo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkInicioFallo.Location = new System.Drawing.Point(11, 350);
            this.lnkInicioFallo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkInicioFallo.Name = "lnkInicioFallo";
            this.lnkInicioFallo.Size = new System.Drawing.Size(119, 14);
            this.lnkInicioFallo.TabIndex = 13;
            this.lnkInicioFallo.TabStop = true;
            this.lnkInicioFallo.Text = "No puedo iniciar sesión";
            this.lnkInicioFallo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkInicioFallo_LinkClicked);
            // 
            // lnkNuevo
            // 
            this.lnkNuevo.AutoSize = true;
            this.lnkNuevo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkNuevo.Location = new System.Drawing.Point(194, 350);
            this.lnkNuevo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkNuevo.Name = "lnkNuevo";
            this.lnkNuevo.Size = new System.Drawing.Size(164, 14);
            this.lnkNuevo.TabIndex = 12;
            this.lnkNuevo.TabStop = true;
            this.lnkNuevo.Text = "¿Nuevo usuario? Regístrate aquí";
            this.lnkNuevo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNuevo_LinkClicked);
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(9, 267);
            this.progressBarControl1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.progressBarControl1.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.progressBarControl1.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.progressBarControl1.Properties.ShowTitle = true;
            this.progressBarControl1.Properties.TextOrientation = DevExpress.Utils.Drawing.TextOrientation.Horizontal;
            this.progressBarControl1.Size = new System.Drawing.Size(351, 22);
            this.progressBarControl1.TabIndex = 14;
            // 
            // pcInferior
            // 
            this.pcInferior.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.pcInferior.Appearance.Options.UseBackColor = true;
            this.pcInferior.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcInferior.Controls.Add(this.btnCancelar);
            this.pcInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pcInferior.Location = new System.Drawing.Point(0, 367);
            this.pcInferior.Name = "pcInferior";
            this.pcInferior.Size = new System.Drawing.Size(371, 42);
            this.pcInferior.TabIndex = 26;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(285, 11);
            this.btnCancelar.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.btnCancelar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnCancelar.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 22);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(371, 409);
            this.ControlBox = false;
            this.Controls.Add(this.pcInferior);
            this.Controls.Add(this.lnkInicioFallo);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.lnkNuevo);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.imageBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesión";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcInferior)).EndInit();
            this.pcInferior.ResumeLayout(false);
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
        private DevExpress.XtraEditors.PanelControl pcInferior;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
    }
}

