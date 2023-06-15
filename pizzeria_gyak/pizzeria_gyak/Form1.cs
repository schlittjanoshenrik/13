using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace pizzeria_gyak
{
    public partial class Form1 : Form
    {
        
        public static string fajlnev { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_adat_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog ar = new OpenFileDialog();
            if (ar.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = ar.FileName;
                // Itt folytathatod a kiválasztott fájlhoz kapcsolódó műveletekkel
            }*/
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fajlnev = openFileDialog1.FileName;
                
            }
            this.Hide();
            Form2 box = new Form2();
            box.ShowDialog();
            box.Dispose();
            this.Close();
            //this.Show();

        }
    }
}
