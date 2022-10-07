using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leltar
{
    public partial class Form1 : Form
    {
    /*Adószám:    Az adózót azonosító 7 jegyű szám + 1 ellenőrző szám
                  XXXXXXXX-Y-ZZ
                  Y: ÁFA kód
                  ZZ: két számjegyű területi kód
    */
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Placeholder text for textboxs on Kölcsönzés tab on Form1.cs design
            textBox1.ForeColor = Color.Gray;
            textBox2.ForeColor = Color.Gray;
            textBox3.ForeColor = Color.Gray;
            textBox4.ForeColor = Color.Gray;
            textBox5.ForeColor = Color.Gray;
            textBox6.ForeColor = Color.Gray;
            textBox7.ForeColor = Color.Gray;
            textBox8.ForeColor = Color.Gray;
            textBox9.ForeColor = Color.Gray;
            textBox10.ForeColor = Color.Gray;
            textBox1.Text = "Vezetéknév";     
            textBox2.Text = "Keresztnév";      
            textBox3.Text = "Irányítószám";
            textBox4.Text = "Város";
            textBox5.Text = "Utca";
            textBox6.Text = "Ház szám";
            textBox7.Text = "00000000";
            textBox8.Text = "0";
            textBox9.Text = "00";
            textBox10.Text = "pelda@gmail.com";
        }     
        private void textBox1_Enter(object sender, EventArgs e)
        {
            //If the user click on the textbox, the placeholder will vanish
            if (textBox1.Text == "Vezetéknév") { textBox1.Text = ""; }
        } 
        private void textBox1_Leave(object sender, EventArgs e)
        {
            //If the user click somewhere else than the placeholder will be visible again
            if (textBox1.Text == "") { textBox1.Text = "Vezetéknév"; textBox1.ForeColor = Color.Gray; }
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            //If the user click on the textbox, the placeholder will vanish
            if (textBox2.Text == "Keresztnév") { textBox2.Text = ""; }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            //If the user click somewhere else than the placeholder will be visible again
            if (textBox2.Text == "") { textBox2.Text = "Keresztnév"; textBox2.ForeColor = Color.Gray; }
        }
        private void textBox3_Enter(object sender, EventArgs e)
        {
            //If the user click on the textbox, the placeholder will vanish
            if (textBox3.Text == "Irányítószám") { textBox3.Text = ""; }
        }
        private void textBox3_Leave(object sender, EventArgs e)
        {
            //If the user click somewhere else than the placeholder will be visible again
            if (textBox3.Text == "") { textBox3.Text = "Irányítószám"; textBox3.ForeColor = Color.Gray; }
        }
        private void textBox4_Enter(object sender, EventArgs e)
        {
            //If the user click on the textbox, the placeholder will vanish
            if (textBox4.Text == "Város") { textBox4.Text = ""; }
        }
        private void textBox4_Leave(object sender, EventArgs e)
        {
          //If the user click somewhere else than the placeholder will be visible again
            if (textBox4.Text == "") { textBox4.Text = "Város"; textBox4.ForeColor = Color.Gray; }
        }
        private void textBox5_Enter(object sender, EventArgs e)
        {
            //If the user click on the textbox, the placeholder will vanish
            if (textBox5.Text == "Utca") { textBox5.Text = ""; textBox5.ForeColor = Color.Gray; }
        }
        private void textBox5_Leave(object sender, EventArgs e)
        {
            //If the user click somewhere else than the placeholder will be visible again
            if (textBox5.Text == "") { textBox5.Text = "Utca"; textBox5.ForeColor = Color.Gray; }

        }
        private void textBox6_Enter(object sender, EventArgs e)
        {
            //If the user click on the textbox, the placeholder will vanish
            if (textBox6.Text == "Ház szám") { textBox6.Text = ""; textBox6.ForeColor = Color.Gray; }
        }
        private void textBox6_Leave(object sender, EventArgs e)
        {
            //If the user click somewhere else than the placeholder will be visible again
            if (textBox6.Text == "") { textBox6.Text = "Ház szám"; textBox6.ForeColor = Color.Gray; }

        }
        private void textBox7_Enter(object sender, EventArgs e)
        {
            //If the user click on the textbox, the placeholder will vanish
            if (textBox7.Text == "00000000") { textBox7.Text = ""; textBox7.ForeColor = Color.Gray; }
        }
        private void textBox7_Leave(object sender, EventArgs e)
        {
            //If the user click somewhere else than the placeholder will be visible again
            if (textBox7.Text == "") { textBox7.Text = "00000000"; textBox7.ForeColor = Color.Gray; }
        }
        private void textBox8_Enter(object sender, EventArgs e)
        {
            //If the user click on the textbox, the placeholder will vanish
            if (textBox8.Text == "0") { textBox8.Text = ""; textBox8.ForeColor = Color.Gray; }
        }
        private void textBox8_Leave(object sender, EventArgs e)
        {
            //If the user click somewhere else than the placeholder will be visible again
            if (textBox8.Text == "") { textBox8.Text = "0"; textBox8.ForeColor = Color.Gray; }
        }
        private void textBox9_Enter(object sender, EventArgs e)
        {
            //If the user click on the textbox, the placeholder will vanish
            if (textBox9.Text == "00") { textBox9.Text = ""; textBox9.ForeColor = Color.Gray; }
        }
        private void textBox9_Leave(object sender, EventArgs e)
        {
            //If the user click somewhere else than the placeholder will be visible again
            if (textBox9.Text == "") { textBox9.Text = "00"; textBox9.ForeColor = Color.Gray; }
        }
        private void textBox10_Enter(object sender, EventArgs e)
        {
            //If the user click on the textbox, the placeholder will vanish
            if (textBox10.Text == "pelda@gmail.com") { textBox10.Text = ""; textBox10.ForeColor = Color.Gray; }
        }
        private void textBox10_Leave(object sender, EventArgs e)
        {
            //If the user click somewhere else than the placeholder will be visible again
            if (textBox10.Text == "") { textBox10.Text = "pelda@gmail.com"; textBox10.ForeColor = Color.Gray; }
        }


        //TXT fájlbaírás --> számla
    }
}
