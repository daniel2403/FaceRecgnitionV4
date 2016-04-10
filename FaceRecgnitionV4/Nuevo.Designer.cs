namespace FaceRecgnitionV4
{
    partial class Nuevo
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
            this.Wizard = new DevExpress.XtraWizard.WizardControl();
            this.PaginaInicial = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.Pagina1 = new DevExpress.XtraWizard.WizardPage();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtusuario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtpassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtColor = new DevExpress.XtraEditors.ColorPickEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.txtMaterno = new DevExpress.XtraEditors.TextEdit();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtPaterno = new DevExpress.XtraEditors.TextEdit();
            this.PaginaFinal = new DevExpress.XtraWizard.CompletionWizardPage();
            this.Pagina2 = new DevExpress.XtraWizard.WizardPage();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.lblCantidadImagenes = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnApagar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapturar = new DevExpress.XtraEditors.SimpleButton();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.btnPrender = new DevExpress.XtraEditors.SimpleButton();
            this.err = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Wizard)).BeginInit();
            this.Wizard.SuspendLayout();
            this.Pagina1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtusuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaterno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaterno.Properties)).BeginInit();
            this.Pagina2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // Wizard
            // 
            this.Wizard.CancelText = "Cancelar";
            this.Wizard.Controls.Add(this.PaginaInicial);
            this.Wizard.Controls.Add(this.Pagina1);
            this.Wizard.Controls.Add(this.PaginaFinal);
            this.Wizard.Controls.Add(this.Pagina2);
            this.Wizard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wizard.FinishText = "&Finalizar";
            this.Wizard.Location = new System.Drawing.Point(0, 0);
            this.Wizard.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Wizard.Name = "Wizard";
            this.Wizard.NextText = "&Siguiente >";
            this.Wizard.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.PaginaInicial,
            this.Pagina1,
            this.Pagina2,
            this.PaginaFinal});
            this.Wizard.PreviousText = "< &Atrás";
            this.Wizard.Size = new System.Drawing.Size(402, 503);
            // 
            // PaginaInicial
            // 
            this.PaginaInicial.Name = "PaginaInicial";
            this.PaginaInicial.ProceedText = "Para continuar, pulsa clic en Siguiente";
            this.PaginaInicial.Size = new System.Drawing.Size(185, 325);
            // 
            // Pagina1
            // 
            this.Pagina1.Controls.Add(this.labelControl8);
            this.Pagina1.Controls.Add(this.txtusuario);
            this.Pagina1.Controls.Add(this.labelControl7);
            this.Pagina1.Controls.Add(this.txtpassword);
            this.Pagina1.Controls.Add(this.labelControl5);
            this.Pagina1.Controls.Add(this.labelControl1);
            this.Pagina1.Controls.Add(this.labelControl2);
            this.Pagina1.Controls.Add(this.labelControl3);
            this.Pagina1.Controls.Add(this.txtColor);
            this.Pagina1.Controls.Add(this.labelControl4);
            this.Pagina1.Controls.Add(this.txtID);
            this.Pagina1.Controls.Add(this.txtMaterno);
            this.Pagina1.Controls.Add(this.txtNombre);
            this.Pagina1.Controls.Add(this.txtPaterno);
            this.Pagina1.Name = "Pagina1";
            this.Pagina1.Size = new System.Drawing.Size(370, 329);
            this.Pagina1.PageValidating += new DevExpress.XtraWizard.WizardPageValidatingEventHandler(this.Pagina1_PageValidating);
            this.Pagina1.PageInit += new System.EventHandler(this.Pagina1_PageInit);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(55, 45);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(52, 16);
            this.labelControl8.TabIndex = 33;
            this.labelControl8.Text = "Usuario: ";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(118, 39);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(224, 22);
            this.txtusuario.TabIndex = 32;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(34, 179);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(74, 16);
            this.labelControl7.TabIndex = 31;
            this.labelControl7.Text = "Contraseña: ";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(118, 176);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Properties.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(224, 22);
            this.txtpassword.TabIndex = 30;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(15, 148);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(93, 16);
            this.labelControl5.TabIndex = 29;
            this.labelControl5.Text = "Color de fondo: ";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(91, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(17, 16);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "ID:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(54, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 16);
            this.labelControl2.TabIndex = 23;
            this.labelControl2.Text = "Nombre: ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(10, 101);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(98, 16);
            this.labelControl3.TabIndex = 25;
            this.labelControl3.Text = "Apellido Paterno:";
            // 
            // txtColor
            // 
            this.txtColor.EditValue = System.Drawing.Color.Empty;
            this.txtColor.Location = new System.Drawing.Point(118, 148);
            this.txtColor.Name = "txtColor";
            this.txtColor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtColor.Size = new System.Drawing.Size(224, 22);
            this.txtColor.TabIndex = 27;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(7, 126);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(101, 16);
            this.labelControl4.TabIndex = 28;
            this.labelControl4.Text = "Apellido Materno:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(117, 11);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(224, 22);
            this.txtID.TabIndex = 20;
            // 
            // txtMaterno
            // 
            this.txtMaterno.Location = new System.Drawing.Point(117, 123);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(224, 22);
            this.txtMaterno.TabIndex = 26;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(117, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(224, 22);
            this.txtNombre.TabIndex = 22;
            // 
            // txtPaterno
            // 
            this.txtPaterno.Location = new System.Drawing.Point(117, 95);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(224, 22);
            this.txtPaterno.TabIndex = 24;
            // 
            // PaginaFinal
            // 
            this.PaginaFinal.Name = "PaginaFinal";
            this.PaginaFinal.Size = new System.Drawing.Size(185, 325);
            this.PaginaFinal.PageValidating += new DevExpress.XtraWizard.WizardPageValidatingEventHandler(this.PaginaFinal_PageValidating);
            // 
            // Pagina2
            // 
            this.Pagina2.Controls.Add(this.imageBox2);
            this.Pagina2.Controls.Add(this.lblCantidadImagenes);
            this.Pagina2.Controls.Add(this.labelControl6);
            this.Pagina2.Controls.Add(this.btnApagar);
            this.Pagina2.Controls.Add(this.btnCapturar);
            this.Pagina2.Controls.Add(this.imageBox1);
            this.Pagina2.Controls.Add(this.btnPrender);
            this.Pagina2.Name = "Pagina2";
            this.Pagina2.Size = new System.Drawing.Size(370, 329);
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(215, 102);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(84, 64);
            this.imageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox2.TabIndex = 21;
            this.imageBox2.TabStop = false;
            // 
            // lblCantidadImagenes
            // 
            this.lblCantidadImagenes.Location = new System.Drawing.Point(343, 80);
            this.lblCantidadImagenes.Name = "lblCantidadImagenes";
            this.lblCantidadImagenes.Size = new System.Drawing.Size(11, 16);
            this.lblCantidadImagenes.TabIndex = 20;
            this.lblCantidadImagenes.Text = " 0";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(215, 80);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(128, 16);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "Imagenes capturadas:";
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(52, 175);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(29, 28);
            this.btnApagar.TabIndex = 17;
            this.btnApagar.Text = "X";
            // 
            // btnCapturar
            // 
            this.btnCapturar.Enabled = false;
            this.btnCapturar.Location = new System.Drawing.Point(215, 13);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(95, 46);
            this.btnCapturar.TabIndex = 18;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(18, 13);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(191, 156);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox1.TabIndex = 15;
            this.imageBox1.TabStop = false;
            // 
            // btnPrender
            // 
            this.btnPrender.Location = new System.Drawing.Point(18, 175);
            this.btnPrender.Name = "btnPrender";
            this.btnPrender.Size = new System.Drawing.Size(28, 28);
            this.btnPrender.TabIndex = 16;
            this.btnPrender.Text = "O";
            this.btnPrender.Click += new System.EventHandler(this.btnPrender_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // Nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 503);
            this.Controls.Add(this.Wizard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Nuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo";
            this.Load += new System.EventHandler(this.Nuevo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Wizard)).EndInit();
            this.Wizard.ResumeLayout(false);
            this.Pagina1.ResumeLayout(false);
            this.Pagina1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtusuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaterno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaterno.Properties)).EndInit();
            this.Pagina2.ResumeLayout(false);
            this.Pagina2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl Wizard;
        private DevExpress.XtraWizard.WelcomeWizardPage PaginaInicial;
        private DevExpress.XtraWizard.WizardPage Pagina1;
        private DevExpress.XtraWizard.CompletionWizardPage PaginaFinal;
        private DevExpress.XtraWizard.WizardPage Pagina2;
        private DevExpress.XtraEditors.LabelControl lblCantidadImagenes;
        private DevExpress.XtraEditors.SimpleButton btnPrender;
        private Emgu.CV.UI.ImageBox imageBox1;
        private DevExpress.XtraEditors.SimpleButton btnCapturar;
        private DevExpress.XtraEditors.SimpleButton btnApagar;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtPaterno;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.TextEdit txtMaterno;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ColorPickEdit txtColor;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtpassword;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtusuario;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private Emgu.CV.UI.ImageBox imageBox2;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider err;
    }
}