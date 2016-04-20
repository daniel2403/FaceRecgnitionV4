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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //Declararation of all variables, vectors and haarcascades
        Image<Bgr, Byte> currentFrame;
        Capture grabber;
        HaarCascade face;
        HaarCascade eye;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> result, TrainedFace = null;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> NamePersons = new List<string>();
        int ContTrain, NumLabels, t;
        string name, names = null;

        private void btnOn_Click(object sender, EventArgs e)
        {
            Prender();
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            Apagar();
        }

        private void Form1_Load(object sender, EventArgs e)
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
            catch (Exception ex)
            {
                //MessageBox.Show(e.ToString());
                MessageBox.Show("Nothing in binary database, please add at least a face(Simply train the prototype with the Add Face Button).", "Triained faces load", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Prender()
        {
            //Inicia la camara, Inicia el reconocimiento.


            //Carga el haar de reconocimiento de rostro
            face = new HaarCascade("haarcascade_frontalface_default.xml");
            grabber = new Capture();
            grabber.QueryFrame();
            Application.Idle += new EventHandler(FrameGrabber);
            btnIniciar.Enabled = true;
            btnIniciar.Enabled = false;
            //comienza la captura
        }

        private void Apagar()
        {
            Application.Idle -= new EventHandler(FrameGrabber);
            btnOn.Enabled = true;
            if (grabber != null)
            {
                grabber.Dispose();
            }
            imageBox1.Image = null;
            progressBarControl1.EditValue = 0;
            btnIniciar.Enabled = false;
        }

        

        private void btnIniciar_Click(object sender, EventArgs e)
        {

        }

        private void lnkNuevo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Apagar();
            Nuevo N = new Nuevo();
            N.Show();
            
            this.Hide();
            
        }

        private void lnkInicioFallo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginFallido login = new LoginFallido();

            login.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que deseas cerrar la aplicación?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==  DialogResult.Yes)
            {
            }
        }

        int contador = 0;string NombreAuxiliar = "";
        void FrameGrabber(object sender, EventArgs e)
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


                if (trainingImages.ToArray().Length != 0)
                {
                    //TermCriteria for face recognition with numbers of trained images like maxIteration
                    MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);

                    //Eigen face recognizer
                    EigenObjectRecognizer recognizer = new EigenObjectRecognizer(
                       trainingImages.ToArray(),
                       labels.ToArray(),
                       2700,
                       ref termCrit);

                    name = recognizer.Recognize(result);
                    //Aun en investigaciones, pero parece que si es mayor a 3000 no reconoce a nadie
                    float Confidence = recognizer.GetEigenDistances(result)[0];
                    labelControl1.Text = Confidence.ToString();
                    if (Confidence < 30000)
                    {
                        if (NombreAuxiliar == "")
                        {
                            NombreAuxiliar = name;
                        }
                        //Draw the label for each face detected and recognized
                        currentFrame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.White));
                        if ((name == NombreAuxiliar) && NombreAuxiliar != "")
                        {
                            contador = contador + 5;
                            progressBarControl1.EditValue = contador;

                        }
                        else { contador = 0; NombreAuxiliar = ""; }
                        if (contador == 100)
                        {

                            //Si llega hasta aqui quiere decir que identifico a alguien
                            //Apagar();
                            FaceRecgnitionV4.Default d = new Default(name);
                            d.Show();
                            //  d.Show();
                            // this.Hide();



                        }
                    }
                    
                }
               
                NamePersons[t - 1] = name;
                NamePersons.Add("");


            }
            t = 0;

            //Names concatenation of persons recognized
            for (int nnn = 0; nnn < facesDetected[0].Length; nnn++)
            {
                names = names + NamePersons[nnn] + ", ";
            }
            //Show the faces procesed and recognized
            imageBox1.Image = currentFrame;
          
            names = "";
            //Clear the list(vector) of names
            NamePersons.Clear();

        }


       
        double CompareHist(Image<Bgr, Byte> img1, Image<Bgr, Byte> img2)
        {
            float[] BlueHist;
            float[] GreenHist;
            float[] RedHist;

            DenseHistogram ComparedHistoBlue = new DenseHistogram(64, new RangeF(0, 64));
            DenseHistogram ComparedHistoGreen = new DenseHistogram(64, new RangeF(0, 64));
            DenseHistogram ComparedHistoRed = new DenseHistogram(64, new RangeF(0, 64));

            Image<Gray, Byte> Comparedimg2Blue = img1[0];
            Image<Gray, Byte> Comparedimg2Green = img1[1];
            Image<Gray, Byte> Comparedimg2Red = img1[2];

            ComparedHistoBlue.Calculate(new Image<Gray, Byte>[] { Comparedimg2Blue }, true, null);
            ComparedHistoGreen.Calculate(new Image<Gray, Byte>[] { Comparedimg2Green }, true, null);
            ComparedHistoRed.Calculate(new Image<Gray, Byte>[] { Comparedimg2Red }, true, null);

            DenseHistogram HistoBlue = new DenseHistogram(64, new RangeF(0, 64));
            DenseHistogram HistoGreen = new DenseHistogram(64, new RangeF(0, 64));
            DenseHistogram HistoRed = new DenseHistogram(64, new RangeF(0, 64));

            Image<Gray, Byte> img2Blue = img2[0];
            Image<Gray, Byte> img2Green = img2[1];
            Image<Gray, Byte> img2Red = img2[2];

            HistoBlue.Calculate(new Image<Gray, Byte>[] { img2Blue }, true, null);

            BlueHist = new float[64];

            HistoBlue.MatND.ManagedArray.CopyTo(BlueHist, 0);

            HistoGreen.Calculate(new Image<Gray, Byte>[] { img2Green }, true, null);
            GreenHist = new float[64];
            HistoGreen.MatND.ManagedArray.CopyTo(GreenHist, 0);

            HistoRed.Calculate(new Image<Gray, Byte>[] { img2Red }, true, null);

            RedHist = new float[64];
            HistoRed.MatND.ManagedArray.CopyTo(RedHist, 0);

            //Comparing histograms

            double cBlue = CvInvoke.cvCompareHist(HistoBlue.Ptr, ComparedHistoBlue.Ptr, Emgu.CV.CvEnum.HISTOGRAM_COMP_METHOD.CV_COMP_CORREL);
            double cGreen = CvInvoke.cvCompareHist(HistoGreen.Ptr, ComparedHistoGreen.Ptr, Emgu.CV.CvEnum.HISTOGRAM_COMP_METHOD.CV_COMP_CORREL);
            double cRed = CvInvoke.cvCompareHist(HistoRed.Ptr, ComparedHistoRed.Ptr, Emgu.CV.CvEnum.HISTOGRAM_COMP_METHOD.CV_COMP_CORREL);
            double porcentaje = (cBlue * cGreen * cRed);
            return porcentaje;

        }
    }
}
