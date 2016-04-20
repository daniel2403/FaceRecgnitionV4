namespace FaceRecgnitionV4
{
    partial class Default
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
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.pcSuperior = new DevExpress.XtraEditors.PanelControl();
            this.lblApellidoPaterno = new DevExpress.XtraEditors.LabelControl();
            this.lblNombre = new DevExpress.XtraEditors.LabelControl();
            this.lblUsuario = new DevExpress.XtraEditors.LabelControl();
            this.pcInferior = new DevExpress.XtraEditors.PanelControl();
            this.pcCentral = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lnkImagenes = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lcgImagenes = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.pcSuperior)).BeginInit();
            this.pcSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcInferior)).BeginInit();
            this.pcInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcCentral)).BeginInit();
            this.pcCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(285, 11);
            this.btnCancelar.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.btnCancelar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnCancelar.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 20);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pcSuperior
            // 
            this.pcSuperior.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcSuperior.Controls.Add(this.lblApellidoPaterno);
            this.pcSuperior.Controls.Add(this.lblNombre);
            this.pcSuperior.Controls.Add(this.lblUsuario);
            this.pcSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcSuperior.Location = new System.Drawing.Point(0, 0);
            this.pcSuperior.Name = "pcSuperior";
            this.pcSuperior.Size = new System.Drawing.Size(371, 101);
            this.pcSuperior.TabIndex = 0;
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoPaterno.Location = new System.Drawing.Point(12, 69);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(83, 18);
            this.lblApellidoPaterno.TabIndex = 3;
            this.lblApellidoPaterno.Text = "Ap. Paterno";
            // 
            // lblNombre
            // 
            this.lblNombre.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 18);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Appearance.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(12, 12);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(82, 27);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // pcInferior
            // 
            this.pcInferior.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcInferior.Controls.Add(this.btnCancelar);
            this.pcInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pcInferior.Location = new System.Drawing.Point(0, 367);
            this.pcInferior.Name = "pcInferior";
            this.pcInferior.Size = new System.Drawing.Size(371, 42);
            this.pcInferior.TabIndex = 4;
            // 
            // pcCentral
            // 
            this.pcCentral.Appearance.BackColor = System.Drawing.Color.White;
            this.pcCentral.Appearance.Options.UseBackColor = true;
            this.pcCentral.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcCentral.Controls.Add(this.labelControl1);
            this.pcCentral.Controls.Add(this.lnkImagenes);
            this.pcCentral.Controls.Add(this.layoutControl1);
            this.pcCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcCentral.Location = new System.Drawing.Point(0, 101);
            this.pcCentral.Name = "pcCentral";
            this.pcCentral.Size = new System.Drawing.Size(371, 266);
            this.pcCentral.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.AllowHtmlString = true;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(12, 243);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(204, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "¿Quieres capturar más imgaénes? ";
            // 
            // lnkImagenes
            // 
            this.lnkImagenes.Appearance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkImagenes.Appearance.LinkColor = System.Drawing.Color.Blue;
            this.lnkImagenes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkImagenes.Location = new System.Drawing.Point(222, 245);
            this.lnkImagenes.Name = "lnkImagenes";
            this.lnkImagenes.Size = new System.Drawing.Size(21, 14);
            this.lnkImagenes.TabIndex = 1;
            this.lnkImagenes.Text = "aquí";
            this.lnkImagenes.Click += new System.EventHandler(this.lnkImagenes_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Location = new System.Drawing.Point(12, 6);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.lcgImagenes;
            this.layoutControl1.Size = new System.Drawing.Size(346, 127);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lcgImagenes
            // 
            this.lcgImagenes.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgImagenes.GroupBordersVisible = false;
            this.lcgImagenes.Location = new System.Drawing.Point(0, 0);
            this.lcgImagenes.Name = "Root";
            this.lcgImagenes.Size = new System.Drawing.Size(346, 127);
            this.lcgImagenes.TextVisible = false;
            // 
            // Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 409);
            this.Controls.Add(this.pcCentral);
            this.Controls.Add(this.pcInferior);
            this.Controls.Add(this.pcSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Default";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Página Principal";
            this.Load += new System.EventHandler(this.Default_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcSuperior)).EndInit();
            this.pcSuperior.ResumeLayout(false);
            this.pcSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcInferior)).EndInit();
            this.pcInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcCentral)).EndInit();
            this.pcCentral.ResumeLayout(false);
            this.pcCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgImagenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.PanelControl pcSuperior;
        private DevExpress.XtraEditors.LabelControl lblApellidoPaterno;
        private DevExpress.XtraEditors.LabelControl lblNombre;
        private DevExpress.XtraEditors.LabelControl lblUsuario;
        private DevExpress.XtraEditors.PanelControl pcInferior;
        private DevExpress.XtraEditors.PanelControl pcCentral;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.HyperlinkLabelControl lnkImagenes;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup lcgImagenes;
    }
}