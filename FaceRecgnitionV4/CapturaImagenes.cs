using Emgu.CV;
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
    public partial class CapturaImagenes : Form
    {
        string nombre;
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
                labels.Add(nombre);

                //Show face added in gray scale
                //imageBox2.Image = TrainedFace;

                //Write the number of triained faces in a file text for further load
                File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", trainingImages.ToArray().Length.ToString() + "%");

                //Write the labels of triained faces in a file text for further load
                for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
                {
                    trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/face" + i + ".bmp");
                    File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", labels.ToArray()[i - 1] + "%");
                }

                lblCantidadImagenes.Text = imagenesCapturadas.ToString();

                MessageBox.Show("Cara de " + nombre + " detectada y registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ocurrió un problema al detectar la cara.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Dispose();
            }

            catch (Exception exception)
            {
                MessageBox.Show(string.Format("Ocurrió un problema. \n{0}", exception), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public CapturaImagenes(string nombre)
        {
            InitializeComponent();

            this.nombre = nombre;
        }

        private void btnPrender_Click(object sender, EventArgs e)
        {
            face = new HaarCascade("haarcascade_frontalface_default.xml");
            grabber = new Capture();
            grabber.QueryFrame();
            Application.Idle += new EventHandler(FrameGrabber);
            btnCapturar.Enabled = true;
            btnPrender.Enabled = false;
        }

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
    }
}
