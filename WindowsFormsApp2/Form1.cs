using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        List<Thread> hilos;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

            hilos = new List<Thread>();
            this.Imagen1.Visible = false;
        }

        private void CicloInfinito()
        {
            Thread ciclo = new Thread(Animacion);
            ciclo.Start();
            this.hilos.Add(ciclo);
        }
        private void Animacion()
        {
            while(true)
            {
                Thread.Sleep(5000);
                this.Invoke(new MethodInvoker(() => { this.Imagen1.Visible = true; }));
                this.Invoke(new MethodInvoker(() => { this.Download.Text = "Descargar!!"; }));
                Thread.Sleep(5000);
                this.Invoke(new MethodInvoker(() => { this.Imagen1.Visible = false; }));
                this.Invoke(new MethodInvoker(() => { this.Download.Text = ""; }));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thrd = new Thread(Demo);
            thrd.IsBackground = true;
            thrd.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void Demo()
        {
            for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
            {
                label1.Text = i.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        int speed = 100;
        void MovePictureBox()
        {
            new Thread(
                () =>
                {
                    while (true)
                    {
                        if (checkBox1.Checked)
                        {
                            pictureBox1.Location = new Point(pictureBox1.Location.X - 1, pictureBox1.Location.Y);
                        }
                        else
                        {
                            pictureBox1.Location = new Point(pictureBox1.Location.X + 1, pictureBox1.Location.Y);
                        }
                        Thread.Sleep(speed);
                    }
                }
                ) { IsBackground = true }.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MovePictureBox();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out speed))
            {

            }
        }


        private void Imagen1_Click(object sender, EventArgs e)
        { }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(hilos[0].IsAlive)
            {
                hilos[0].Abort();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CicloInfinito();
        }
       

        private void temporizador_Tick(object sender, EventArgs e)
        {
            tiempo.Text = DateTime.Now.ToLongTimeString();
        }

       

        private Thread hiloSecundario;
        private void btnTiempo_Click(object sender, EventArgs e)
        {
            btnTiempo.Enabled = false;
            numCarga.Enabled = false;
            //Delgado que hace referencia la metodo que tiene que ejecutar el hilo 
            ThreadStart delegadoPS = new ThreadStart(TareaSecundaria);
            //Crear hilo
            hiloSecundario = new Thread(delegadoPS);
            //Ejecutar hilo
            hiloSecundario.Start();

            progreso.Value = 0;

            TareaSecundaria();
        }

        private delegate void SetValueDelegate(int prValue);


        private void SetValue_progreso(int hecho)
        {
            if (progreso.InvokeRequired)
            {
                SetValueDelegate delegado = new SetValueDelegate(SetValue_progreso);
                progreso.Invoke(delegado, new object[] { hecho });
            }

            else
                progreso.Value = hecho;
        }


        private int tphecho;

        private void SetEnabled_btnTiempo()
        {
            btnTiempo.Enabled = true;
        }

        private void SetEnabled_numCarga()
        {
            numCarga.Enabled = true;
        }

        void TareaSecundaria()
        {
            int hecho = 0;
            tphecho = 0;

            MethodInvoker delegado;


            while(hecho < numCarga.Value)
            {
                //aumentar el valor de carga 
                hecho += 1;
                tphecho = (int)(hecho / numCarga.Value * 100);
                if(tphecho > progreso.Value)
                {
                    SetValue_progreso(tphecho);
                } 
            }

            delegado = new MethodInvoker(SetEnabled_btnTiempo);
            btnTiempo.Invoke(delegado);

            delegado = new MethodInvoker(SetEnabled_numCarga);
            numCarga.Invoke(delegado);
        }

        private void btnTiempo_Click_1(object sender, EventArgs e)
        {

        }
    }
}
