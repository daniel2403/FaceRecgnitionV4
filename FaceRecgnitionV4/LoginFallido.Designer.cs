namespace FaceRecgnitionV4
{
    partial class LoginFallido
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
            DevExpress.XtraEditors.PanelControl pcInferior;
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.lnkAqui = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.lblRegistrate = new DevExpress.XtraEditors.LabelControl();
            this.lblEresNuevo = new DevExpress.XtraEditors.LabelControl();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.txtContraseña = new DevExpress.XtraEditors.TextEdit();
            this.cmdIniciarSesion = new DevExpress.XtraEditors.SimpleButton();
            this.lnkInicioFallido = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.bwProceso = new System.ComponentModel.BackgroundWorker();
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            pcInferior = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(pcInferior)).BeginInit();
            pcInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContraseña.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pcInferior
            // 
            pcInferior.Appearance.BackColor = System.Drawing.SystemColors.Control;
            pcInferior.Appearance.Options.UseBackColor = true;
            pcInferior.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            pcInferior.Controls.Add(this.btnCancelar);
            pcInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            pcInferior.Location = new System.Drawing.Point(0, 144);
            pcInferior.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            pcInferior.LookAndFeel.UseDefaultLookAndFeel = false;
            pcInferior.Name = "pcInferior";
            pcInferior.Size = new System.Drawing.Size(371, 42);
            pcInferior.TabIndex = 1;
            // 
            // lnkAqui
            // 
            this.lnkAqui.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkAqui.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAqui.Appearance.LinkColor = System.Drawing.Color.White;
            this.lnkAqui.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkAqui.Location = new System.Drawing.Point(191, 118);
            this.lnkAqui.Name = "lnkAqui";
            this.lnkAqui.Size = new System.Drawing.Size(25, 16);
            this.lnkAqui.TabIndex = 2;
            this.lnkAqui.Text = "aquí";
            // 
            // lblRegistrate
            // 
            this.lblRegistrate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRegistrate.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrate.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblRegistrate.Location = new System.Drawing.Point(96, 116);
            this.lblRegistrate.Name = "lblRegistrate";
            this.lblRegistrate.Size = new System.Drawing.Size(89, 22);
            this.lblRegistrate.TabIndex = 1;
            this.lblRegistrate.Text = "Regístrate";
            // 
            // lblEresNuevo
            // 
            this.lblEresNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEresNuevo.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEresNuevo.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEresNuevo.Location = new System.Drawing.Point(11, 122);
            this.lblEresNuevo.Name = "lblEresNuevo";
            this.lblEresNuevo.Size = new System.Drawing.Size(79, 16);
            this.lblEresNuevo.TabIndex = 0;
            this.lblEresNuevo.Text = "¿Eres nuevo?";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(84, 41);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtUsuario.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.Properties.Appearance.Options.UseBackColor = true;
            this.txtUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtUsuario.Properties.Appearance.Options.UseForeColor = true;
            this.txtUsuario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtUsuario.Size = new System.Drawing.Size(275, 22);
            this.txtUsuario.TabIndex = 2;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Especifica un usuario";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            conditionValidationRule1.Value1 = "";
            this.dxValidationProvider.SetValidationRule(this.txtUsuario, conditionValidationRule1);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(84, 67);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtContraseña.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtContraseña.Properties.Appearance.Options.UseBackColor = true;
            this.txtContraseña.Properties.Appearance.Options.UseFont = true;
            this.txtContraseña.Properties.Appearance.Options.UseForeColor = true;
            this.txtContraseña.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtContraseña.Properties.PasswordChar = '⬤';
            this.txtContraseña.Properties.UseSystemPasswordChar = true;
            this.txtContraseña.Size = new System.Drawing.Size(275, 22);
            this.txtContraseña.TabIndex = 3;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Especifica una contraseña";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            conditionValidationRule2.Value1 = "";
            this.dxValidationProvider.SetValidationRule(this.txtContraseña, conditionValidationRule2);
            // 
            // cmdIniciarSesion
            // 
            this.cmdIniciarSesion.Appearance.BackColor = System.Drawing.Color.Tomato;
            this.cmdIniciarSesion.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIniciarSesion.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cmdIniciarSesion.Appearance.Options.UseBackColor = true;
            this.cmdIniciarSesion.Appearance.Options.UseFont = true;
            this.cmdIniciarSesion.Appearance.Options.UseForeColor = true;
            this.cmdIniciarSesion.Location = new System.Drawing.Point(285, 93);
            this.cmdIniciarSesion.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.cmdIniciarSesion.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdIniciarSesion.Name = "cmdIniciarSesion";
            this.cmdIniciarSesion.Size = new System.Drawing.Size(75, 20);
            this.cmdIniciarSesion.TabIndex = 4;
            this.cmdIniciarSesion.Text = "Continuar";
            this.cmdIniciarSesion.Click += new System.EventHandler(this.cmdIniciarSesion_Click);
            // 
            // lnkInicioFallido
            // 
            this.lnkInicioFallido.Appearance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkInicioFallido.Appearance.LinkColor = System.Drawing.Color.Blue;
            this.lnkInicioFallido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkInicioFallido.Location = new System.Drawing.Point(12, 122);
            this.lnkInicioFallido.Name = "lnkInicioFallido";
            this.lnkInicioFallido.Size = new System.Drawing.Size(112, 14);
            this.lnkInicioFallido.TabIndex = 6;
            this.lnkInicioFallido.Text = "No puedo iniciar sesión";
            this.lnkInicioFallido.Click += new System.EventHandler(this.lnkInicioFallido_Click);
            // 
            // bwProceso
            // 
            this.bwProceso.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwProceso_DoWork);
            this.bwProceso.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwProceso_RunWorkerCompleted);
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
            this.btnCancelar.Size = new System.Drawing.Size(75, 20);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(12, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 16);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Usuario";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(12, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 16);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Contraseña";
            // 
            // LoginFallido
            // 
            this.AcceptButton = this.cmdIniciarSesion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(371, 186);
            this.ControlBox = false;
            this.Controls.Add(this.lnkInicioFallido);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lnkAqui);
            this.Controls.Add(this.lblRegistrate);
            this.Controls.Add(this.lblEresNuevo);
            this.Controls.Add(this.cmdIniciarSesion);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(pcInferior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginFallido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesión";
            this.Load += new System.EventHandler(this.LoginFallido_Load);
            this.Shown += new System.EventHandler(this.LoginFallido_Shown);
            ((System.ComponentModel.ISupportInitialize)(pcInferior)).EndInit();
            pcInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContraseña.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.HyperlinkLabelControl lnkAqui;
        private DevExpress.XtraEditors.LabelControl lblRegistrate;
        private DevExpress.XtraEditors.LabelControl lblEresNuevo;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.TextEdit txtContraseña;
        private DevExpress.XtraEditors.SimpleButton cmdIniciarSesion;
        private DevExpress.XtraEditors.HyperlinkLabelControl lnkInicioFallido;
        private System.ComponentModel.BackgroundWorker bwProceso;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}