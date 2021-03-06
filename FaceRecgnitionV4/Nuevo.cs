﻿using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceRecgnitionV4
{
    public partial class Nuevo : Form
    {
        public Nuevo()
        {
            InitializeComponent();
        }

        string _Nombre, _Usuario, _Paterno, _Materno, _Color, _Password, _R, _G, _B, _A;
        int _ID;
        //adaptadores a BD
        
        DSdatosTableAdapters.PrincipalTableAdapter P = new DSdatosTableAdapters.PrincipalTableAdapter();
        //Declararation of all variables, vectors and haarcascades
        Image<Bgr, Byte> currentFrame;
        Capture grabber;
        HaarCascade face;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> result, TrainedFace = null;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> NamePersons = new List<string>();
        int ContTrain, NumLabels, t;
        int imagenesCapturadas = 0;

        #region Pagina 1
        private void Pagina1_PageValidating(object sender, DevExpress.XtraWizard.WizardPageValidatingEventArgs e)
        {
            try
            {
                err.ClearErrors();
                if (txtID.Text == string.Empty)
                { err.SetError(txtID, "Campo requerido"); }
                if (txtNombre.Text == string.Empty)
                { err.SetError(txtNombre, "Campo requerido"); }
                if (txtPaterno.Text == string.Empty)
                { err.SetError(txtPaterno, "Campo requerido"); }
                if (txtMaterno.Text == string.Empty)
                { err.SetError(txtMaterno, "Campo requerido"); }
                if (txtColor.Text == string.Empty)
                { err.SetError(txtColor, "Campo requerido"); }
                if (txtpassword.Text == string.Empty)
                { err.SetError(txtpassword, "Campo requerido"); }


                if (P.ExisteUsuario(txtusuario.Text).HasValue)
                {
                    err.SetError(txtusuario, "El nombre de ususario ya existe");
                }
                if (txtusuario.Text == string.Empty)
                { err.SetError(txtusuario, "Campo requerido"); }


                if (err.HasErrors)
                { e.Valid = false; }
                else
                {
                    _ID = Convert.ToInt32(txtID.Text);
                    _Nombre = txtNombre.Text;
                    _Usuario = txtusuario.Text;
                    _Paterno = txtPaterno.Text;
                    _Materno = txtMaterno.Text;
                    _Color = txtColor.EditValue.ToString();
                    _R = txtColor.Color.R.ToString();
                    _G = txtColor.Color.G.ToString();
                    _B = txtColor.Color.B.ToString();
                    _A = txtColor.Color.A.ToString();
                    _Password = txtpassword.Text;

                }
                // e.Valid = true;//temporal
            }

            catch (Exception exception)
            {
                MessageBox.Show(string.Format("Ocurrió un problema. \n{0}", exception), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Pagina1_PageInit(object sender, EventArgs e)
        {
            try
            {
                var id = P.MaxID();
                if (id != null)
                {
                    txtID.Text = P.MaxID().ToString();
                }
                else { txtID.Text = "1"; }
            }

            catch (Exception exception)
            {
                MessageBox.Show(string.Format("Ocurrió un problema. \n{0}", exception), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Wizard_CancelClick(object sender, CancelEventArgs e)
        {
            try
            {
                Login login = new Login();

                login.Show();
                this.Hide();
            }

            catch (Exception exception)
            {
                MessageBox.Show(string.Format("Ocurrió un problema. \n{0}", exception), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Pagina2_PageValidating(object sender, DevExpress.XtraWizard.WizardPageValidatingEventArgs e)
        {
            try
            {
                Apagar();
            }

            catch (Exception exception)
            {
                MessageBox.Show(string.Format("Ocurrió un problema. \n{0}", exception), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        #region Pagina 2

        //Principales 
        private void btnPrender_Click(object sender, EventArgs e)
        {
            try
            {
                Prender();
            }

            catch (Exception exception)
            {
                MessageBox.Show(string.Format("Ocurrió un problema. \n{0}", exception), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                Apagar();
            }

            catch (Exception exception)
            {
                MessageBox.Show(string.Format("Ocurrió un problema. \n{0}", exception), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Nuevo_Load(object sender, EventArgs e)
        {
            try
            {
                //Load of previus trainned faces and labels for each image
                string Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
                string[] Labels = Labelsinfo.Split('%');
                NumLabels = Convert.ToInt16(Labels[0]);
                ContTrain = NumLabels;
                string LoadFaces;

                for (int tf = 1; tf < NumLabels + 1; tf++)
                {
                    LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
                    labels.Add(Labels[tf]);
                }
            }

            catch (Exception exception)
            {
                MessageBox.Show(string.Format("Ocurrió un problema. \n{0}", exception), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void btnCapturar_Click(object sender, EventArgs e)
        {
            try
            {
                imagenesCapturadas++;
                //Trained face counter
                ContTrain = ContTrain + 1;

                //Get a gray frame from capture device
                gray = grabber.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                //Face Detector
                MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
                face,
                1.2,
                10,
                Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                new Size(20, 20));

                //Action for each element detected
                foreach (MCvAvgComp f in facesDetected[0])
                {
                    TrainedFace = currentFrame.Copy(f.rect).Convert<Gray, byte>();
                    break;
                }

                //resize face detected image for force to compare the same size with the 
                //test image with cubic interpolation type method
                TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                trainingImages.Add(TrainedFace);
                labels.Add(txtusuario.Text);

                //Show face added in gray scale
                imageBox2.Image = TrainedFace;

                //Write the number of triained faces in a file text for further load
                File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", trainingImages.ToArray().Length.ToString() + "%");

                //Write the labels of triained faces in a file text for further load
                for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
                {
                    trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/face" + i + ".bmp");
                    File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", labels.ToArray()[i - 1] + "%");
                }

                lblCantidadImagenes.Text = imagenesCapturadas.ToString();

                MessageBox.Show("Cara de " + txtusuario.Text + " detectada y registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ocurrió un problema al detectar la cara.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        
        //Auxiliares

        void FrameGrabber(object sender, EventArgs e)
        {
            try
            {
                //label4.Text = "";
                NamePersons.Add("");


                //Get the current frame form capture device
                currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                //Convert it to Grayscale
                gray = currentFrame.Convert<Gray, Byte>();

                //Face Detector
                MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
              face,
              1.2,
              10,
              Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
              new Size(20, 20));

                //Action for each element detected
                foreach (MCvAvgComp f in facesDetected[0])
                {
                    t = t + 1;
                    result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                    //draw the face detected in the 0th (gray) channel with blue color
                    currentFrame.Draw(f.rect, new Bgr(Color.White), 1);

                }
                t = 0;
                imageBox1.Image = currentFrame;

                //Clear the list(vector) of names
                NamePersons.Clear();
            }

            catch (Exception exception)
            {
                MessageBox.Show(string.Format("Ocurrió un problema. \n{0}", exception), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Prender()
        {
            try
            {
                //Inicia la camara, Inicia el reconocimiento.


                //Carga el haar de reconocimiento de rostro
                face = new HaarCascade("haarcascade_frontalface_default.xml");
                grabber = new Capture();
                grabber.QueryFrame();
                Application.Idle += new EventHandler(FrameGrabber);
                btnCapturar.Enabled = true;
                btnPrender.Enabled = false;
                //comienza la captura
            }

            catch (Exception exception)
            {
                MessageBox.Show(string.Format("Ocurrió un problema. \n{0}", exception), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Apagar()
        {
            try
            {
                Application.Idle -= new EventHandler(FrameGrabber);
                btnPrender.Enabled = true;
                if (grabber != null)
                {
                    grabber.Dispose();
                }
                imageBox1.Image = null;

                btnCapturar.Enabled = false;
            }

            catch (Exception exception)
            {
                MessageBox.Show(string.Format("Ocurrió un problema. \n{0}", exception), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion


     
        private void PaginaFinal_PageValidating(object sender, DevExpress.XtraWizard.WizardPageValidatingEventArgs e)
        {
            try
            {
                P.Insertar(_ID, _Usuario, _Password, _Nombre, _Materno, _Paterno, _Color, 50, _R, _G, _B, _A);
                MessageBox.Show("El usuario ha sido registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Default def = new Default(_Usuario);
                def.Show();
                //Login login = new Login();

                //login.Show();
                //this.Hide();
            }

            catch (Exception exception)
            {
                MessageBox.Show(string.Format("Ocurrió un problema. \n{0}", exception), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
