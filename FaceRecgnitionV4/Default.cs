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
    public partial class Default : Form
    {
        DSdatosTableAdapters.PrincipalTableAdapter P = new DSdatosTableAdapters.PrincipalTableAdapter();
        DSdatos.PrincipalDataTable dt = new DSdatos.PrincipalDataTable();
        string Usuario, color;
        int R, G, B, A;


        public Default(string NombreUsuario)
        {
            InitializeComponent();

            Usuario = NombreUsuario;
            dt = P.GetDatosUsuario(NombreUsuario);
        }

        private void Default_Load(object sender, EventArgs e)
        {
            try
            {
                lblUsuario.Text = dt.Rows[0][1].ToString();
                lblNombre.Text = dt.Rows[0][3].ToString();
                lblApellidoPaterno.Text = dt.Rows[0][5].ToString();
                R = Convert.ToInt32(dt.Rows[0][8].ToString());
                G = Convert.ToInt32(dt.Rows[0][9].ToString());
                B = Convert.ToInt32(dt.Rows[0][10].ToString());
                A = Convert.ToInt32(dt.Rows[0][11].ToString());
                pcSuperior.BackColor = Color.FromArgb(A, R, G, B);
                pcSuperior.ForeColor = (contrastarColores(R, G, B, A) > 0.5) ? Color.White : Color.Black;
            }

            catch (Exception exception)
            {
                MessageBox.Show(string.Format("Ocurrió un problema. \n {0}", exception), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double contrastarColores(int R, int G, int B, int A)
        {
            return 1 - (0.299 * R + 0.587 * G + 0.114 * B) / 255;
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
