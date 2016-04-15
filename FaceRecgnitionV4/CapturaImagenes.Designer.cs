namespace FaceRecgnitionV4
{
    partial class CapturaImagenes
    {
        /// <summary>
        /// Required designer vmariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being uvsed.
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
            this.btnApagar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapturar = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrender = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(198, 169);
            this.btnApagar.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.btnApagar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnApagar.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnApagar.Margin = new System.Windows.Forms.Padding(2);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 20);
            this.btnApagar.TabIndex = 23;
            this.btnApagar.Text = "Apagar";
            // 
            // btnCapturar
            // 
            this.btnCapturar.Enabled = false;
            this.btnCapturar.Location = new System.Drawing.Point(119, 169);
            this.btnCapturar.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.btnCapturar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnCapturar.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnCapturar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 20);
            this.btnCapturar.TabIndex = 24;
            this.btnCapturar.Text = "Capturar";
            // 
            // btnPrender
            // 
            this.btnPrender.Location = new System.Drawing.Point(40, 169);
            this.btnPrender.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.btnPrender.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnPrender.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnPrender.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrender.Name = "btnPrender";
            this.btnPrender.Size = new System.Drawing.Size(75, 20);
            this.btnPrender.TabIndex = 22;
            this.btnPrender.Text = "Encender";
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.btnCancelar);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 219);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(284, 42);
            this.panelControl2.TabIndex = 25;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(198, 11);
            this.btnCancelar.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.btnCancelar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnCancelar.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 20);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            // 
            // CapturaImagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.btnPrender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CapturaImagenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Captura de Imágenes";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnApagar;
        private DevExpress.XtraEditors.SimpleButton btnCapturar;
        private DevExpress.XtraEditors.SimpleButton btnPrender;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
    }
}