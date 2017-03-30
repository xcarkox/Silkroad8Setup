using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;





namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, System.EventArgs e)
        {
         
        }
       
        private void button2_Click(object sender, System.EventArgs e)
        {
            
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string CelebPath = textBox1.Text; //Coloque um textbox referente ao local da request
         //   foreach (string FilePath in Directory.GetFiles(CelebPath, "atalho.vbs")) File.Delete(FilePath);
            timer1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = 10;
            Chilkat.Zip zip = new Chilkat.Zip();
            zip.UnlockComponent("Anything for 30-day trial");        
            byte[] x = Properties.Resources.Data;
            string fileTempLocation = Path.GetTempPath() + "Data.dll"; // Rar dosyasının uzantısını dll yap ve resourcese koy
            System.IO.File.WriteAllBytes(fileTempLocation, x);
            bool success = zip.OpenZip(fileTempLocation);

            if (!success)
            {
                MessageBox.Show(zip.LastErrorText);
                return;
            }
            System.IO.Directory.CreateDirectory(@"C:\CyberRoad");
            int numFilesUnzipped = zip.Unzip(@"C:\CyberRoad");
            if (numFilesUnzipped == -1)
            {
                MessageBox.Show(zip.LastErrorText);
            }

            System.Diagnostics.Process.Start(@"C:\CyberRoad\");// bunun gibi olsun

            timer1.Enabled = true;
            timer3.Enabled = true;
            timer2.Enabled = false;
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
            this.Hide();
            Form4 f2 = new Form4();
            f2.Show();
            timer3.Enabled = false;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
