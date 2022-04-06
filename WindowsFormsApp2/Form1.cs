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
                ){ IsBackground = true }.Start();
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
    }
}
