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
        string Usuario;
        public Default(string NombreUsuario)
        {
            InitializeComponent();
            Usuario = NombreUsuario;
            dt = P.GetDatosUsuario(NombreUsuario);
        }

        private void Default_Load(object sender, EventArgs e)
        {
            //A este punto ya deberia de tener los datos del usuario.
            //Hay que pintar los datos en la forma
        }
    }
}
