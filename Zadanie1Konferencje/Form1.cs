using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie1Konferencje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> ITList = new List<string> { "C#", "Bazy danych", "Java" };
        List<string> MotoList = new List<string> { "Samochody osobowe", "Samochody ciezarowe", "Motocykle" };
        List<string> RelaxList = new List<string> { "Zdrowa zywnosc", "Plany treningowe", "Catering" };
        public void DodajDane()
        {
            if(comboBox3.Text == "IT")
            {
                foreach (var item in ITList)
                {
                    if (comboBox4.Text != item)
                    {
                        if(comboBox7.Text != item)
                        {
                            comboBox10.Items.Add(item);
                        }
                        comboBox7.Items.Add(item);
                    }
                    comboBox4.Items.Add(item);
                }
            }
            else if(comboBox3.Text == "Motoryzacja")
            {
                foreach (var item in MotoList)
                {
                    if (comboBox4.Text != item)
                    {
                        if (comboBox7.Text != item)
                        {
                            comboBox10.Items.Add(item);
                        }
                        comboBox7.Items.Add(item);
                    }
                    comboBox4.Items.Add(item);
                }
            }
            else
            {
                foreach (var item in RelaxList)
                {
                    if (comboBox4.Text != item)
                    {
                        if (comboBox7.Text != item)
                        {
                            comboBox10.Items.Add(item);
                        }
                        comboBox7.Items.Add(item);
                    }
                    comboBox4.Items.Add(item);
                }
            }
        }
        public void DodajDane2()
        {
            if (comboBox3.Text == "IT")
            {
                foreach (var item in ITList)
                {
                    if (comboBox5.Text != item)
                    {
                        if (comboBox8.Text != item)
                        {
                            comboBox11.Items.Add(item);
                        }
                        comboBox8.Items.Add(item);
                    }
                    comboBox5.Items.Add(item);
                }
            }
            else if (comboBox3.Text == "Motoryzacja")
            {
                foreach (var item in MotoList)
                {
                    if (comboBox5.Text != item)
                    {
                        if (comboBox8.Text != item)
                        {
                            comboBox11.Items.Add(item);
                        }
                        comboBox8.Items.Add(item);
                    }
                    comboBox5.Items.Add(item);
                }
            }
            else
            {
                foreach (var item in RelaxList)
                {
                    if (comboBox5.Text != item)
                    {
                        if (comboBox8.Text != item)
                        {
                            comboBox11.Items.Add(item);
                        }
                        comboBox8.Items.Add(item);
                    }
                    comboBox5.Items.Add(item);
                }
            }
        }
        public void DodajDane3()
        {
            if (comboBox3.Text == "IT")
            {
                foreach (var item in ITList)
                {
                    if (comboBox6.Text != item)
                    {
                        if (comboBox9.Text != item)
                        {
                            comboBox12.Items.Add(item);
                        }
                        comboBox9.Items.Add(item);
                    }
                    comboBox6.Items.Add(item);
                }
            }
            else if (comboBox3.Text == "Motoryzacja")
            {
                foreach (var item in MotoList)
                {
                    if (comboBox6.Text != item)
                    {
                        if (comboBox9.Text != item)
                        {
                            comboBox12.Items.Add(item);
                        }
                        comboBox9.Items.Add(item);
                    }
                    comboBox6.Items.Add(item);
                }
            }
            else
            {
                foreach (var item in RelaxList)
                {
                    if (comboBox6.Text != item)
                    {
                        if (comboBox9.Text != item)
                        {
                            comboBox12.Items.Add(item);
                        }
                        comboBox9.Items.Add(item);
                    }
                    comboBox6.Items.Add(item);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //groupBox2.Visible = true;


            //Console.Clear();
            groupBox3.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // usuniety button
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //usuniety button
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            if (comboBox3.Text == "IT")
            {
                //comboBox4.Items.Clear();
                comboBox4.Text = "";
                DodajDane();
            }
            else if (comboBox3.Text == "Motoryzacja")
            {
                //comboBox4.Items.Clear();
                comboBox4.Text = "";
                DodajDane();
            }
            else
            {
                //comboBox4.Items.Clear();
                comboBox4.Text = "";
                DodajDane();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox7.Visible = true;
            if (comboBox3.Text == "IT")
            {
                //comboBox5.Items.Clear();
                comboBox5.Text = "";
                DodajDane2();
            }
            else if (comboBox3.Text == "Motoryzacja")
            {
                //comboBox5.Items.Clear();
                comboBox5.Text = "";
                DodajDane2();
            }
            else
            {
                //comboBox5.Items.Clear();
                comboBox5.Text = "";
                DodajDane2();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            groupBox8.Visible = true;
            if (comboBox3.Text == "IT")
            {
                //comboBox6.Items.Clear();
                comboBox6.Text = "";
                DodajDane3();
            }
            else if (comboBox3.Text == "Motoryzacja")
            {
                //comboBox6.Items.Clear();
                comboBox6.Text = "";
                DodajDane3();
            }
            else
            {
                //comboBox6.Items.Clear();
                comboBox6.Text = "";
                DodajDane3();
            }

        }

        private bool button4WasClicked = false;
        private void button4_Click_1(object sender, EventArgs e)
        {
            button4WasClicked = true;
            groupBox6.Visible = true;
            tabControl1.SelectTab(tabPage2);
            label19.Text = textBox1.Text + " " + textBox2.Text + " " + ", Firma: " + textBox3.Text + ", Konferencja: " + comboBox3.Text + ", Tematy: " + comboBox4.Text + ", " + comboBox7.Text + ", " + comboBox10.Text;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            groupBox5.Visible = true;
        }

        private bool button8WasClicked = false;
        private void button8_Click_1(object sender, EventArgs e)
        {
            button8WasClicked = true;
            groupBox6.Visible = true;
            tabControl1.SelectTab(tabPage2);
            label19.Text = textBox1.Text + " " + textBox2.Text + " " + ", Firma: " + textBox3.Text + ", Konferencja: " + comboBox3.Text + ", Temat: " + comboBox4.Text + ", " + comboBox7.Text + ", " + comboBox10.Text + "\r\n" +
                textBox6.Text + " " + textBox5.Text + " " + ", Firma: " + textBox4.Text  + ", Konferencja: " + comboBox3.Text + ", Temat: " + comboBox5.Text + ", " + comboBox8.Text + ", " + comboBox11.Text;
        }

        private bool button11WasClicked = false;
        private void button11_Click(object sender, EventArgs e)
        {
            button11WasClicked = true;
            groupBox6.Visible = true;
            tabControl1.SelectTab(tabPage2);
            label19.Text = textBox1.Text + " " + textBox2.Text + " " + ", Firma: " + textBox3.Text + ", Konferencja: " + comboBox3.Text + ", Temat: " + comboBox4.Text + ", " + comboBox7.Text + ", " + comboBox10.Text + "\r\n" +
                textBox6.Text + " " + textBox5.Text + " " + ", Firma: " + textBox4.Text + ", Konferencja: " + comboBox3.Text + ", Temat: " + comboBox5.Text + ", " + comboBox8.Text + ", " + comboBox11.Text + "\r\n" +
                textBox9.Text + " " + textBox8.Text + " " + ", Firma: " + textBox7.Text + ", Konferencja: " + comboBox3.Text + ", Temat: " + comboBox6.Text + ", " + comboBox9.Text + ", " + comboBox12.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                groupBox10.Visible = true;
            }
            else
            {
                MessageBox.Show("Wybrales opjce nie podawaj adresu e-mail");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            groupBox9.Visible = true;
            groupBox11.Visible = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label22.Visible = true;
            label22.Text = "Informacje zostana wyslane na podany e-mail: " + textBox10.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //usuniety 
        }

        private void button16_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(@"E:\temp\nowyplik.txt", false))
            {
                sw.WriteLine("UCZESTNICY");
                sw.WriteLine(label19.Text);
                sw.Dispose();
            }
            MessageBox.Show("Dane zostaly zapisane do pliku.");
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                MessageBox.Show("Posilki beda gotowe dla Ciebie :)");
            }
            else
            {
                MessageBox.Show("Bedziesz musial przyniesc szamke ze soba");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            groupBox12.Visible = true;
            if (comboBox3.Text == "IT")
            {
                comboBox7.Items.Clear();
                comboBox7.Text = "";
                DodajDane();
            }
            else if (comboBox3.Text == "Motoryzacja")
            {
                comboBox7.Items.Clear();
                comboBox7.Text = "";
                DodajDane();
            }
            else
            {
                comboBox7.Items.Clear();
                comboBox7.Text = "";
                DodajDane();
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            groupBox13.Visible = true;
            if (comboBox3.Text == "IT")
            {
                comboBox10.Items.Clear();
                comboBox10.Text = "";
                DodajDane();
            }
            else if (comboBox3.Text == "Motoryzacja")
            {
                comboBox10.Items.Clear();
                comboBox10.Text = "";
                DodajDane();
            }
            else
            {
                comboBox10.Items.Clear();
                comboBox10.Text = "";
                DodajDane();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            groupBox14.Visible = true;
            if (comboBox3.Text == "IT")
            {
                comboBox11.Items.Clear();
                comboBox11.Text = "";
                DodajDane2();
            }
            else if (comboBox3.Text == "Motoryzacja")
            {
                comboBox11.Items.Clear();
                comboBox11.Text = "";
                DodajDane2();
            }
            else
            {
                comboBox11.Items.Clear();
                comboBox11.Text = "";
                DodajDane2();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            groupBox15.Visible = true;
            if (comboBox3.Text == "IT")
            {
                comboBox8.Items.Clear();
                comboBox8.Text = "";
                DodajDane2();
            }
            else if (comboBox3.Text == "Motoryzacja")
            {
                comboBox8.Items.Clear();
                comboBox8.Text = "";
                DodajDane2();
            }
            else
            {
                comboBox8.Items.Clear();
                comboBox8.Text = "";
                DodajDane2();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            groupBox16.Visible = true;
            if (comboBox3.Text == "IT")
            {
                comboBox9.Items.Clear();
                comboBox9.Text = "";
                DodajDane3();
            }
            else if (comboBox3.Text == "Motoryzacja")
            {
                comboBox9.Items.Clear();
                comboBox9.Text = "";
                DodajDane3();
            }
            else
            {
                comboBox9.Items.Clear();
                comboBox9.Text = "";
                DodajDane3();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            groupBox17.Visible = true;
            if (comboBox3.Text == "IT")
            {
                comboBox12.Items.Clear();
                comboBox12.Text = "";
                DodajDane3();
            }
            else if (comboBox3.Text == "Motoryzacja")
            {
                comboBox12.Items.Clear();
                comboBox12.Text = "";
                DodajDane3();
            }
            else
            {
                comboBox12.Items.Clear();
                comboBox12.Text = "";
                DodajDane3();
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            label22.Visible = true;
            label22.Text = "Informacje zostana wyslane na podany e-mail: " + textBox11.Text;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            label22.Visible = true;
            label22.Text = "Informacje zostana wyslane na podany e-mail: " + textBox12.Text;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(@"E:\temp\nowyplik.txt", true))
            {
                sw.WriteLine();
                sw.WriteLine("Adresy e-mail: ");
                sw.WriteLine(textBox1.Text + " " + textBox2.Text + ": " + textBox10.Text);
                sw.WriteLine(textBox6.Text + " " + textBox5.Text + ": " + textBox11.Text);
                sw.WriteLine(textBox9.Text + " " + textBox8.Text + ": " + textBox12.Text);
                sw.Dispose();
            }
            MessageBox.Show("Dane zostaly dodane do pliku.");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zamykam aplikacje...");
            Application.Exit();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Restartowanie aplikacji...");
            Application.Restart();
            //Environment.Exit(0);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (button4WasClicked == true)
            {
                label36.Text = "Zapisany jest jeden uczestnik.";
            }
            else if (button8WasClicked == true)
            {
                label36.Text = "Dwoch uczestnikow jest zapisanych.";
            }
            else if (button11WasClicked == true)
            {
                label36.Text = "Trzech uczesntikow jest zapisanych.";
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage3);
        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {
            string path = @"E:\temp\nowyplik.txt";
            var str = File.ReadAllText(path);
            textBox13.Text = str;
        }
        

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {
            //usuniety
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //}
        }

        private void button35_Click(object sender, EventArgs e)
        {
            //comboBox3.Items.Remove(textBox14.Text);
            //to nie do tego buttona ale dobrze ze tu jest 
            //DODAWANIA KONFERENCJI PRZEZ UZYTKWNIKA DO LISTY KONFERENCJI
            //comboBox3.Items.Add(textBox1.Text);
        }

        private void button30_Click_1(object sender, EventArgs e)
        {
            //Form1 NewForm = new Form1();
            //NewForm.Show();
            //this.Dispose(false);
            textBox13.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            comboBox4.ResetText();
            comboBox7.ResetText();
            comboBox10.ResetText();
            comboBox5.ResetText();
            comboBox8.ResetText();
            comboBox11.ResetText();
            comboBox6.ResetText();
            comboBox9.ResetText();
            comboBox12.ResetText();
        }
    }
}
