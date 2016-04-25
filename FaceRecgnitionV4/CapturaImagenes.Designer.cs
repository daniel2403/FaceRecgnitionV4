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
            this.components = new System.ComponentModel.Container();
            this.btnApagar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapturar = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrender = new DevExpress.XtraEditors.SimpleButton();
            this.pcInferior = new DevExpress.XtraEditors.PanelControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.pcCentral = new DevExpress.XtraEditors.PanelControl();
            this.lblCantidadImagenes = new DevExpress.XtraEditors.LabelControl();
            this.lblImagenesCapturadas = new DevExpress.XtraEditors.LabelControl();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcInferior)).BeginInit();
            this.pcInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcCentral)).BeginInit();
            this.pcCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApagar
            // 
            this.btnApagar.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Appearance.Options.UseFont = true;
            this.btnApagar.Location = new System.Drawing.Point(285, 340);
            this.btnApagar.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.btnApagar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnApagar.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnApagar.Margin = new System.Windows.Forms.Padding(2);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 22);
            this.btnApagar.TabIndex = 23;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnCapturar
            // 
            this.btnCapturar.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapturar.Appearance.Options.UseFont = true;
            this.btnCapturar.Enabled = false;
            this.btnCapturar.Location = new System.Drawing.Point(90, 340);
            this.btnCapturar.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.btnCapturar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnCapturar.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnCapturar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 22);
            this.btnCapturar.TabIndex = 24;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnPrender
            // 
            this.btnPrender.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrender.Appearance.Options.UseFont = true;
            this.btnPrender.Location = new System.Drawing.Point(11, 340);
            this.btnPrender.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.btnPrender.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnPrender.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnPrender.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrender.Name = "btnPrender";
            this.btnPrender.Size = new System.Drawing.Size(75, 22);
            this.btnPrender.TabIndex = 22;
            this.btnPrender.Text = "Encender";
            this.btnPrender.Click += new System.EventHandler(this.btnPrender_Click);
            // 
            // pcInferior
            // 
            this.pcInferior.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcInferior.Controls.Add(this.btnCancelar);
            this.pcInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pcInferior.Location = new System.Drawing.Point(0, 367);
            this.pcInferior.Name = "pcInferior";
            this.pcInferior.Size = new System.Drawing.Size(371, 42);
            this.pcInferior.TabIndex = 25;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
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
            // pcCentral
            // 
            this.pcCentral.Appearance.BackColor = System.Drawing.Color.White;
            this.pcCentral.Appearance.Options.UseBackColor = true;
            this.pcCentral.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcCentral.Controls.Add(this.lblCantidadImagenes);
            this.pcCentral.Controls.Add(this.lblImagenesCapturadas);
            this.pcCentral.Controls.Add(this.btnApagar);
            this.pcCentral.Controls.Add(this.btnCapturar);
            this.pcCentral.Controls.Add(this.btnPrender);
            this.pcCentral.Controls.Add(this.imageBox1);
            this.pcCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcCentral.Location = new System.Drawing.Point(0, 0);
            this.pcCentral.Name = "pcCentral";
            this.pcCentral.Size = new System.Drawing.Size(371, 367);
            this.pcCentral.TabIndex = 26;
            // 
            // lblCantidadImagenes
            // 
            this.lblCantidadImagenes.Appearance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadImagenes.Location = new System.Drawing.Point(241, 312);
            this.lblCantidadImagenes.Margin = new System.Windows.Forms.Padding(2);
            this.lblCantidadImagenes.Name = "lblCantidadImagenes";
            this.lblCantidadImagenes.Size = new System.Drawing.Size(9, 14);
            this.lblCantidadImagenes.TabIndex = 23;
            this.lblCantidadImagenes.Text = " 0";
            // 
            // lblImagenesCapturadas
            // 
            this.lblImagenesCapturadas.Appearance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagenesCapturadas.Location = new System.Drawing.Point(254, 312);
            this.lblImagenesCapturadas.Margin = new System.Windows.Forms.Padding(2);
            this.lblImagenesCapturadas.Name = "lblImagenesCapturadas";
            this.lblImagenesCapturadas.Size = new System.Drawing.Size(104, 14);
            this.lblImagenesCapturadas.TabIndex = 22;
            this.lblImagenesCapturadas.Text = "imágenes capturadas";
            // 
            // imageBox1
            // 
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox1.Location = new System.Drawing.Point(11, 11);
            this.imageBox1.Margin = new System.Windows.Forms.Padding(2);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(349, 297);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox1.TabIndex = 21;
            this.imageBox1.TabStop = false;
            // 
            // CapturaImagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 409);
            this.ControlBox = false;
            this.Controls.Add(this.pcCentral);
            this.Controls.Add(this.pcInferior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CapturaImagenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Captura de Imágenes";
            ((System.ComponentModel.ISupportInitialize)(this.pcInferior)).EndInit();
            this.pcInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcCentral)).EndInit();
            this.pcCentral.ResumeLayout(false);
            this.pcCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnApagar;
        private DevExpress.XtraEditors.SimpleButton btnCapturar;
        private DevExpress.XtraEditors.SimpleButton btnPrender;
        private DevExpress.XtraEditors.PanelControl pcInferior;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.PanelControl pcCentral;
        private DevExpress.XtraEditors.LabelControl lblCantidadImagenes;
        private DevExpress.XtraEditors.LabelControl lblImagenesCapturadas;
        private Emgu.CV.UI.ImageBox imageBox1;
    }
}