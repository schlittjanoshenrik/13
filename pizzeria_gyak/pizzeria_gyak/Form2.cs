using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace pizzeria_gyak
{
    public partial class Form2 : Form
    {
        public static List<Pizzak> lista = new List<Pizzak>();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            var sr = new StreamReader(Form1.fajlnev);
            while (!sr.EndOfStream)
            {
                var sor = new Pizzak(sr.ReadLine());
                lista.Add(sor); 
            }
            sr.Close();
            checkBox1.Text = lista[0].nev + " (" + lista[0].kicsi + " Ft)" + " (" + lista[0].nagy+ " Ft)";
            checkBox2.Text = lista[1].nev + " (" + lista[1].kicsi + " Ft)" + " (" + lista[1].nagy + " Ft)";
            checkBox3.Text = lista[2].nev + " (" + lista[2].kicsi + " Ft)" + " (" + lista[2].nagy + " Ft)";
            checkBox4.Text = lista[3].nev + " (" + lista[3].kicsi + " Ft)" + " (" + lista[3].nagy + " Ft)";
            checkBox5.Text = lista[4].nev + " (" + lista[4].kicsi + " Ft)" + " (" + lista[4].nagy + " Ft)";


        }

        private void btn_kilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSzam_Click(object sender, EventArgs e)
        {
            if  (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked || checkBox5.Checked)
            {
                if (rbtnKicsi.Checked || rbtnNagy.Checked)
                {
                    
                    
                        int vegosszeg = 0;
                        if (rbtnKicsi.Checked)
                        {



                            if (checkBox1.Checked)
                            {
                                int osszeg = int.Parse(textBox10.Text) * lista[0].kicsi;
                                richTextBox1.Text += $"\n   {checkBox1.Text}     {osszeg} Ft";
                                vegosszeg += osszeg;

                            }
                            if (checkBox2.Checked)
                            {
                                int osszeg = int.Parse(textBox9.Text) * lista[1].kicsi;
                                richTextBox1.Text += $"\n   {checkBox2.Text}     {osszeg} Ft";
                                vegosszeg += osszeg;

                            }
                            if (checkBox3.Checked)
                            {
                                int osszeg = int.Parse(textBox8.Text) * lista[2].kicsi;
                                richTextBox1.Text += $"\n   {checkBox3.Text}     {osszeg} Ft";
                                vegosszeg += osszeg;

                            }
                            if (checkBox4.Checked)
                            {
                                int osszeg = int.Parse(textBox7.Text) * lista[3].kicsi;
                                richTextBox1.Text += $"\n   {checkBox4.Text}     {osszeg} Ft";
                                vegosszeg += osszeg;

                            }
                            if (checkBox5.Checked)
                            {
                                int osszeg = int.Parse(textBox6.Text) * lista[4].kicsi;
                                richTextBox1.Text += $"\n   {checkBox5.Text}     {osszeg} Ft";
                                vegosszeg += osszeg;

                            }
                            richTextBox1.Text += $"\n\nÖsszesen:                  {vegosszeg} Ft";
                        }
                        int vegosszeg2 = 0;
                        if (rbtnNagy.Checked)
                        {

                            if (checkBox1.Checked)
                            {
                                int osszeg = int.Parse(textBox10.Text) * lista[0].nagy;
                                richTextBox1.Text += $"\n   {checkBox1.Text}     {osszeg} Ft";
                                vegosszeg2 += osszeg;

                            }
                            if (checkBox2.Checked)
                            {
                                int osszeg = int.Parse(textBox9.Text) * lista[1].nagy;
                                richTextBox1.Text += $"\n   {checkBox2.Text}     {osszeg} Ft";
                                vegosszeg2 += osszeg;

                            }
                            if (checkBox3.Checked)
                            {
                                int osszeg = int.Parse(textBox8.Text) * lista[2].nagy;
                                richTextBox1.Text += $"\n   {checkBox3.Text}     {osszeg} Ft";
                                vegosszeg2 += osszeg;

                            }
                            if (checkBox4.Checked)
                            {
                                int osszeg = int.Parse(textBox7.Text) * lista[3].nagy;
                                richTextBox1.Text += $"\n   {checkBox4.Text}     {osszeg} Ft";
                                vegosszeg2 += osszeg;

                            }
                            if (checkBox5.Checked)
                            {
                                int osszeg = int.Parse(textBox6.Text) * lista[4].nagy;
                                richTextBox1.Text += $"\n   {checkBox5.Text}     {osszeg} Ft";
                                vegosszeg2 += osszeg;

                            }

                            //richTextBox1.Text += $"\n\nÖsszesen:                  {vegosszeg2} Ft";
int vegosszeg3 = vegosszeg2 + vegosszeg;
                    richTextBox1.Text += $"\n\nÖsszesen:                  {vegosszeg3} Ft";
                        }
                    

                }
                    else
                    {
                        MessageBox.Show("Méretet majd anyám választ te fasz", "Retard vagy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                
            }
            else
            {
                MessageBox.Show("Egy büdös kis cigány vagy","Faszom beléd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnTor_Click(object sender, EventArgs e)
        {
           
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            richTextBox1.Text = "";
            rbtnNagy.Checked = false;
            rbtnKicsi.Checked = false;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }
    }
}
