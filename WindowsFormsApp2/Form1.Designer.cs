namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Imagen1 = new System.Windows.Forms.PictureBox();
            this.Download = new System.Windows.Forms.Label();
            this.tiempo = new System.Windows.Forms.Label();
            this.progreso = new System.Windows.Forms.ProgressBar();
            this.btnTiempo = new System.Windows.Forms.Button();
            this.temporizador = new System.Windows.Forms.Timer(this.components);
            this.Carga = new System.Windows.Forms.Label();
            this.numCarga = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCarga)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.button1.Location = new System.Drawing.Point(246, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.button2.Location = new System.Drawing.Point(306, 20);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(124, 131);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.checkBox1.Location = new System.Drawing.Point(75, 120);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Girar a la izquierda";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.button3.Location = new System.Drawing.Point(192, 102);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 55);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(285, 120);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(88, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tiempo
            // 
            this.tiempo.AutoSize = true;
            this.tiempo.Location = new System.Drawing.Point(220, 267);
            this.tiempo.Name = "tiempo";
            this.tiempo.Size = new System.Drawing.Size(49, 13);
            this.tiempo.TabIndex = 8;
            this.tiempo.Text = "00:00:00";
            this.tiempo.Click += new System.EventHandler(this.label2_Click);
            // 
            // progreso
            // 
            this.progreso.Location = new System.Drawing.Point(146, 296);
            this.progreso.Name = "progreso";
            this.progreso.Size = new System.Drawing.Size(193, 23);
            this.progreso.Step = 1;
            this.progreso.TabIndex = 9;
            // 
            // btnTiempo
            // 
            this.btnTiempo.Location = new System.Drawing.Point(204, 331);
            this.btnTiempo.Name = "btnTiempo";
            this.btnTiempo.Size = new System.Drawing.Size(75, 23);
            this.btnTiempo.TabIndex = 10;
            this.btnTiempo.Text = "Cargar";
            this.btnTiempo.UseVisualStyleBackColor = true;
            this.btnTiempo.Click += new System.EventHandler(this.btnTiempo_Click);
            // 
            // temporizador
            // 
            this.temporizador.Enabled = true;
            this.temporizador.Interval = 1000;
            this.temporizador.Tick += new System.EventHandler(this.temporizador_Tick);
            // 
            // Carga
            // 
            this.Carga.AutoSize = true;
            this.Carga.Location = new System.Drawing.Point(345, 306);
            this.Carga.Name = "Carga";
            this.Carga.Size = new System.Drawing.Size(35, 13);
            this.Carga.TabIndex = 11;
            this.Carga.Text = "Carga";
            // 
            // numCarga
            // 
            this.numCarga.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numCarga.Location = new System.Drawing.Point(386, 306);
            this.numCarga.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numCarga.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numCarga.Name = "numCarga";
            this.numCarga.Size = new System.Drawing.Size(74, 20);
            this.numCarga.TabIndex = 12;
            this.numCarga.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 366);
            this.Controls.Add(this.numCarga);
            this.Controls.Add(this.Carga);
            this.Controls.Add(this.btnTiempo);
            this.Controls.Add(this.progreso);
            this.Controls.Add(this.tiempo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCarga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label tiempo;
        private System.Windows.Forms.ProgressBar progreso;
        private System.Windows.Forms.Button btnTiempo;
        private System.Windows.Forms.Timer temporizador;
        private System.Windows.Forms.Label Carga;
        private System.Windows.Forms.NumericUpDown numCarga;
    }
}

