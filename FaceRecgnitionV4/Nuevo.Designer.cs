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
            this.lblCantidadImagenes = new DevExpress.XtraEditors.LabelControl();
            this.lblImagenesCapturadas = new DevExpress.XtraEditors.LabelControl();
            this.btnApagar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapturar = new DevExpress.XtraEditors.SimpleButton();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.btnPrender = new DevExpress.XtraEditors.SimpleButton();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // Wizard
            // 
            this.Wizard.Appearance.ExteriorPageTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wizard.Appearance.ExteriorPageTitle.Options.UseFont = true;
            this.Wizard.Appearance.PageTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wizard.Appearance.PageTitle.Options.UseFont = true;
            this.Wizard.CancelText = "Cancelar";
            this.Wizard.Controls.Add(this.PaginaInicial);
            this.Wizard.Controls.Add(this.Pagina1);
            this.Wizard.Controls.Add(this.PaginaFinal);
            this.Wizard.Controls.Add(this.Pagina2);
            this.Wizard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wizard.FinishText = "&Finalizar";
            this.Wizard.Location = new System.Drawing.Point(0, 0);
            this.Wizard.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.Wizard.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.Wizard.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Wizard.Margin = new System.Windows.Forms.Padding(2);
            this.Wizard.MinimumSize = new System.Drawing.Size(75, 81);
            this.Wizard.Name = "Wizard";
            this.Wizard.NextText = "&Siguiente >";
            this.Wizard.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.PaginaInicial,
            this.Pagina1,
            this.Pagina2,
            this.PaginaFinal});
            this.Wizard.PreviousText = "< &Atrás";
            this.Wizard.Size = new System.Drawing.Size(371, 409);
            this.Wizard.CancelClick += new System.ComponentModel.CancelEventHandler(this.Wizard_CancelClick);
            // 
            // PaginaInicial
            // 
            this.PaginaInicial.IntroductionText = "";
            this.PaginaInicial.Margin = new System.Windows.Forms.Padding(2);
            this.PaginaInicial.Name = "PaginaInicial";
            this.PaginaInicial.ProceedText = "Para continuar, pulsa clic en Siguiente";
            this.PaginaInicial.Size = new System.Drawing.Size(154, 227);
            this.PaginaInicial.Text = "Bienvenido al asistente de configuración";
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
            this.Pagina1.DescriptionText = "";
            this.Pagina1.Margin = new System.Windows.Forms.Padding(2);
            this.Pagina1.Name = "Pagina1";
            this.Pagina1.Size = new System.Drawing.Size(339, 264);
            this.Pagina1.Text = "Especificación de Información";
            this.Pagina1.PageValidating += new DevExpress.XtraWizard.WizardPageValidatingEventHandler(this.Pagina1_PageValidating);
            this.Pagina1.PageInit += new System.EventHandler(this.Pagina1_PageInit);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(12, 122);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(44, 16);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Usuario";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(98, 122);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtusuario.Properties.Appearance.Options.UseFont = true;
            this.txtusuario.Properties.Appearance.Options.UseForeColor = true;
            this.txtusuario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtusuario.Size = new System.Drawing.Size(229, 20);
            this.txtusuario.TabIndex = 5;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(12, 144);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(70, 16);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Contraseña ";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(98, 144);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtpassword.Properties.Appearance.Options.UseFont = true;
            this.txtpassword.Properties.Appearance.Options.UseForeColor = true;
            this.txtpassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtpassword.Properties.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(229, 20);
            this.txtpassword.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(11, 176);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(31, 16);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Color";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(12, 14);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(12, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(12, 46);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 16);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Nombre";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(12, 68);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 16);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Ap. Paterno";
            // 
            // txtColor
            // 
            this.txtColor.EditValue = System.Drawing.Color.Empty;
            this.txtColor.Location = new System.Drawing.Point(98, 176);
            this.txtColor.Margin = new System.Windows.Forms.Padding(2);
            this.txtColor.Name = "txtColor";
            this.txtColor.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtColor.Properties.Appearance.Options.UseFont = true;
            this.txtColor.Properties.Appearance.Options.UseForeColor = true;
            this.txtColor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtColor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtColor.Size = new System.Drawing.Size(229, 20);
            this.txtColor.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(12, 90);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 16);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Ap. Materno";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(98, 14);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Properties.Appearance.Options.UseForeColor = true;
            this.txtID.Properties.Appearance.Options.UseTextOptions = true;
            this.txtID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtID.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtID.Size = new System.Drawing.Size(229, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtMaterno
            // 
            this.txtMaterno.Location = new System.Drawing.Point(98, 90);
            this.txtMaterno.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterno.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtMaterno.Properties.Appearance.Options.UseFont = true;
            this.txtMaterno.Properties.Appearance.Options.UseForeColor = true;
            this.txtMaterno.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtMaterno.Size = new System.Drawing.Size(229, 20);
            this.txtMaterno.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(98, 46);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Properties.Appearance.Options.UseFont = true;
            this.txtNombre.Properties.Appearance.Options.UseForeColor = true;
            this.txtNombre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtNombre.Size = new System.Drawing.Size(229, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtPaterno
            // 
            this.txtPaterno.Location = new System.Drawing.Point(98, 68);
            this.txtPaterno.Margin = new System.Windows.Forms.Padding(2);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaterno.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtPaterno.Properties.Appearance.Options.UseFont = true;
            this.txtPaterno.Properties.Appearance.Options.UseForeColor = true;
            this.txtPaterno.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtPaterno.Size = new System.Drawing.Size(229, 20);
            this.txtPaterno.TabIndex = 3;
            // 
            // PaginaFinal
            // 
            this.PaginaFinal.FinishText = "";
            this.PaginaFinal.Margin = new System.Windows.Forms.Padding(2);
            this.PaginaFinal.Name = "PaginaFinal";
            this.PaginaFinal.ProceedText = "Para continuar, pulsa clic en Finalizar";
            this.PaginaFinal.Size = new System.Drawing.Size(154, 227);
            this.PaginaFinal.Text = "Finalizando el asistente de configuración";
            this.PaginaFinal.PageValidating += new DevExpress.XtraWizard.WizardPageValidatingEventHandler(this.PaginaFinal_PageValidating);
            // 
            // Pagina2
            // 
            this.Pagina2.Controls.Add(this.lblCantidadImagenes);
            this.Pagina2.Controls.Add(this.lblImagenesCapturadas);
            this.Pagina2.Controls.Add(this.btnApagar);
            this.Pagina2.Controls.Add(this.btnCapturar);
            this.Pagina2.Controls.Add(this.imageBox1);
            this.Pagina2.Controls.Add(this.btnPrender);
            this.Pagina2.Controls.Add(this.imageBox2);
            this.Pagina2.DescriptionText = "";
            this.Pagina2.Margin = new System.Windows.Forms.Padding(2);
            this.Pagina2.Name = "Pagina2";
            this.Pagina2.Size = new System.Drawing.Size(339, 264);
            this.Pagina2.Text = "Especificación de Imágenes";
            this.Pagina2.PageValidating += new DevExpress.XtraWizard.WizardPageValidatingEventHandler(this.Pagina2_PageValidating);
            // 
            // lblCantidadImagenes
            // 
            this.lblCantidadImagenes.Appearance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadImagenes.Location = new System.Drawing.Point(173, 218);
            this.lblCantidadImagenes.Margin = new System.Windows.Forms.Padding(2);
            this.lblCantidadImagenes.Name = "lblCantidadImagenes";
            this.lblCantidadImagenes.Size = new System.Drawing.Size(9, 14);
            this.lblCantidadImagenes.TabIndex = 20;
            this.lblCantidadImagenes.Text = " 0";
            // 
            // lblImagenesCapturadas
            // 
            this.lblImagenesCapturadas.Appearance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagenesCapturadas.Location = new System.Drawing.Point(186, 218);
            this.lblImagenesCapturadas.Margin = new System.Windows.Forms.Padding(2);
            this.lblImagenesCapturadas.Name = "lblImagenesCapturadas";
            this.lblImagenesCapturadas.Size = new System.Drawing.Size(104, 14);
            this.lblImagenesCapturadas.TabIndex = 19;
            this.lblImagenesCapturadas.Text = "imágenes capturadas";
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(215, 236);
            this.btnApagar.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.btnApagar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnApagar.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnApagar.Margin = new System.Windows.Forms.Padding(2);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 20);
            this.btnApagar.TabIndex = 17;
            this.btnApagar.Text = "Apagar";
            // 
            // btnCapturar
            // 
            this.btnCapturar.Enabled = false;
            this.btnCapturar.Location = new System.Drawing.Point(124, 236);
            this.btnCapturar.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.btnCapturar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnCapturar.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnCapturar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 20);
            this.btnCapturar.TabIndex = 18;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(45, 14);
            this.imageBox1.Margin = new System.Windows.Forms.Padding(2);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(245, 200);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox1.TabIndex = 15;
            this.imageBox1.TabStop = false;
            // 
            // btnPrender
            // 
            this.btnPrender.Location = new System.Drawing.Point(45, 236);
            this.btnPrender.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.btnPrender.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnPrender.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnPrender.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrender.Name = "btnPrender";
            this.btnPrender.Size = new System.Drawing.Size(75, 20);
            this.btnPrender.TabIndex = 16;
            this.btnPrender.Text = "Encender";
            this.btnPrender.Click += new System.EventHandler(this.btnPrender_Click);
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(60, 27);
            this.imageBox2.Margin = new System.Windows.Forms.Padding(2);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(63, 52);
            this.imageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox2.TabIndex = 21;
            this.imageBox2.TabStop = false;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // Nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 409);
            this.ControlBox = false;
            this.Controls.Add(this.Wizard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Nuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asistente de Configuración";
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
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl lblImagenesCapturadas;
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