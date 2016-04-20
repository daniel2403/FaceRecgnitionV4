using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceRecgnitionV4
{
    public partial class LoginFallido : Form
    {
        #region Declaración de Variables y Objetos
        private Exception _exception;

        DSdatosTableAdapters.PrincipalTableAdapter _tabla = new DSdatosTableAdapters.PrincipalTableAdapter();
        #endregion

        public LoginFallido()
        {
            InitializeComponent();
        }

        #region Cargar los datos a la forma
        private void LoginFallido_Shown(object sender, EventArgs e)
        {
            try
            {
                bwProceso.RunWorkerAsync();
            }

            catch (Exception exception)
            {
                MessageBox.Show(string.Format("Ocurrió un problema. \n{0}", exception), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bwProceso_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (_exception == null)
                {
                    bloquearControles();
                }
            }

            catch (Exception exception)
            {
                if (_exception == null) _exception = exception;
            }
        }

        private void bwProceso_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (_exception == null)
                {
                    bloquearControles();
                }
            }

            catch (Exception exception)
            {
                if (_exception == null) _exception = exception;
            }
        }

        private void bloquearControles()
        {
            BeginInvoke((MethodInvoker)delegate
            {
                txtUsuario.Enabled = !bwProceso.IsBusy;
                txtContraseña.Enabled = !bwProceso.IsBusy;
                lnkInicioFallido.Enabled = !bwProceso.IsBusy;
                cmdIniciarSesion.Enabled = !bwProceso.IsBusy;
                lblEresNuevo.Enabled = !bwProceso.IsBusy;
                lblRegistrate.Enabled = !bwProceso.IsBusy;
                lnkInicioFallido.Enabled = !bwProceso.IsBusy;
            });
        }
        #endregion

        #region Iniciar Sesión
        private void cmdIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                if (dxValidationProvider.Validate())
                {
                    if (Convert.ToInt32(_tabla.VerificarUsuarioYContraseña(txtUsuario.Text, txtContraseña.Text)) == 1)
                    {
                        Default def = new Default(txtUsuario.Text);

                        def.Show();
                        this.Dispose();

                    }

                    else
                    {
                        MessageBox.Show(string.Format("Ocurrió un problema. \nEspecifica un usuario y/o contraseña válidos."), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            catch (Exception exception)
            {
                MessageBox.Show(string.Format("Ocurrió un problema. \n{0}", exception), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void LoginFallido_Load(object sender, EventArgs e)
        {

        }

        private void lnkInicioFallido_Click(object sender, EventArgs e)
        {
            try
            {
                Login login = new Login();

                login.Show();
                this.Dispose();
            }

            catch (Exception exception)
            {
                MessageBox.Show(string.Format("Ocurrió un problema. \n{0}", exception), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Login login = new Login();

                login.Show();
                this.Dispose();
            }

            catch (Exception exception)
            {
                MessageBox.Show(string.Format("Ocurrió un problema. \n{0}", exception), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
