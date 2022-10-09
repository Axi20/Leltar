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
        Jelmez dragonGirl = new Jelmez(1, "Dragon girl", "XS", 5000, false);
        Jelmez horrorCostume = new Jelmez(2, "Horror costume", "S", 7000, false);
        Jelmez monsterBride = new Jelmez(3, "Monster bride", "XS", 4000, false);
        Jelmez owl = new Jelmez(4, "Owl", "M", 6000, false);
        Jelmez darkQuenn = new Jelmez(5, "Dark Queen", "M", 4000, false);
        Jelmez skeletonBride = new Jelmez(6, "Skeleton bride", "M", 2000, false);
        Jelmez victorianDoll = new Jelmez(7, "Victorian doll", "L", 4000, false);
        Jelmez witch = new Jelmez(8, "Witch", "L", 3000, false);
        
        public Form1()
        {
            InitializeComponent();
            GetJelmez();
            


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SetTextBoxColor();
            SetTextBoxText();//Placeholder text for textboxs on Kölcsönzés tab on Form1.cs design
            TestBoxDisable();
            GroupBoxDisable();
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            //If the user click on the textbox, the placeholder will vanish
            if (textBox1.Text == "Vezetéknév") { textBox1.Text = ""; }
            textBox1.ForeColor = Color.Black;
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
            textBox2.ForeColor = Color.Black;
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
            textBox3.ForeColor = Color.Black;
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
            textBox4.ForeColor = Color.Black;
        }
        private void textBox4_Leave(object sender, EventArgs e)
        {
            //If the user click somewhere else than the placeholder will be visible again
            if (textBox4.Text == "") { textBox4.Text = "Város"; textBox4.ForeColor = Color.Gray; }
        }
        private void textBox5_Enter(object sender, EventArgs e)
        {
            //If the user click on the textbox, the placeholder will vanish
            if (textBox5.Text == "Utca") { textBox5.Text = ""; }
            textBox5.ForeColor = Color.Black;
        }
        private void textBox5_Leave(object sender, EventArgs e)
        {
            //If the user click somewhere else than the placeholder will be visible again
            if (textBox5.Text == "") { textBox5.Text = "Utca"; textBox5.ForeColor = Color.Gray; }

        }
        private void textBox6_Enter(object sender, EventArgs e)
        {
            //If the user click on the textbox, the placeholder will vanish
            if (textBox6.Text == "Ház szám") { textBox6.Text = ""; }
            textBox6.ForeColor = Color.Black;
        }
        private void textBox6_Leave(object sender, EventArgs e)
        {
            //If the user click somewhere else than the placeholder will be visible again
            if (textBox6.Text == "") { textBox6.Text = "Ház szám"; textBox6.ForeColor = Color.Gray; }

        }
        private void textBox7_Enter(object sender, EventArgs e)
        {
            //If the user click on the textbox, the placeholder will vanish
            if (textBox7.Text == "00000000") { textBox7.Text = ""; }
            textBox7.ForeColor = Color.Black;
        }
        private void textBox7_Leave(object sender, EventArgs e)
        {
            //If the user click somewhere else than the placeholder will be visible again
            if (textBox7.Text == "") { textBox7.Text = "00000000"; textBox7.ForeColor = Color.Gray; }
        }
        private void textBox8_Enter(object sender, EventArgs e)
        {
            //If the user click on the textbox, the placeholder will vanish
            if (textBox8.Text == "0") { textBox8.Text = ""; }
            textBox8.ForeColor = Color.Black;
        }
        private void textBox8_Leave(object sender, EventArgs e)
        {
            //If the user click somewhere else than the placeholder will be visible again
            if (textBox8.Text == "") { textBox8.Text = "0"; textBox8.ForeColor = Color.Gray; }
        }
        private void textBox9_Enter(object sender, EventArgs e)
        {
            //If the user click on the textbox, the placeholder will vanish
            if (textBox9.Text == "00") { textBox9.Text = ""; }
            textBox9.ForeColor = Color.Black;
        }
        private void textBox9_Leave(object sender, EventArgs e)
        {
            //If the user click somewhere else than the placeholder will be visible again
            if (textBox9.Text == "") { textBox9.Text = "00"; textBox9.ForeColor = Color.Gray; }
        }
        private void textBox10_Enter(object sender, EventArgs e)
        {
            //If the user click on the textbox, the placeholder will vanish
            if (textBox10.Text == "pelda@gmail.com") { textBox10.Text = ""; }
            textBox10.ForeColor = Color.Black;
        }
        private void textBox10_Leave(object sender, EventArgs e)
        {
            //If the user click somewhere else than the placeholder will be visible again
            if (textBox10.Text == "") { textBox10.Text = "pelda@gmail.com"; textBox10.ForeColor = Color.Gray; }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            Fizetendo();
        } //Kosár megtekintése
        private void TestBoxDisable()
        {
            textBox16.Enabled = false;
            textBox17.Enabled = false;
            textBox18.Enabled = false;
            textBox19.Enabled = false;
            textBox20.Enabled = false;
            textBox21.Enabled = false;
            textBox22.Enabled = false;
            textBox23.Enabled = false;
            textBox24.Enabled = false;
            textBox25.Enabled = false;
            textBox26.Enabled = false;
            textBox27.Enabled = false;
            textBox28.Enabled = false;
            textBox29.Enabled = false;
            textBox30.Enabled = false;
            textBox31.Enabled = false;
            textBox32.Enabled = false;
            textBox33.Enabled = false;
            textBox34.Enabled = false;
            textBox35.Enabled = false;
            textBox36.Enabled = false;
            textBox37.Enabled = false;
            textBox38.Enabled = false;
            textBox39.Enabled = false;
            textBox40.Enabled = false;
            textBox41.Enabled = false;
            textBox42.Enabled = false;
            textBox43.Enabled = false;
            textBox44.Enabled = false;
            textBox45.Enabled = false;
            textBox46.Enabled = false;
        }
        private void GroupBoxDisable()
        {
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            groupBox5.Enabled = false;
            groupBox6.Enabled = false;
            groupBox7.Enabled = false;
            groupBox8.Enabled = false;
            groupBox9.Enabled = false;
        }
        private void SetTextBoxColor()
        {
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
        }
        private void SetTextBoxText()
        {
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
        private void button5_Click(object sender, EventArgs e)
        {
            //If the user clicks on the button, the informations about this costume will be send to the another page
            string meret = dragonGirl.meret;
            string nev = dragonGirl.elnevezes;
            int id = dragonGirl.sorszam;
            int napi_ar = dragonGirl.napi_ar;
            int napok_szama = (int)numericUpDown2.Value;
            listBox1.Items.Add(napok_szama);
            listBox3.Items.Add(id);
            listBox4.Items.Add(nev);
            listBox5.Items.Add(meret);
            int osszes_ar = napok_szama * napi_ar;
            //listBox2.Items.Add(nev + " - " + osszes_ar + " FT");//price
            listBox2.Items.Add(osszes_ar);//price
            radioButton4.Checked = true; //Set available to false
            dragonGirl.kolcsonozve = true;
        }//kosárba 1
        private void button6_Click(object sender, EventArgs e)
        {
            //If the user clicks on the button, the informations about this costume will be send to the another page
            string meret = horrorCostume.meret;
            string nev = horrorCostume.elnevezes;
            int id = horrorCostume.sorszam;
            int napi_ar = horrorCostume.napi_ar;
            int napok_szama = (int)numericUpDown3.Value;
            listBox1.Items.Add(napok_szama);
            int osszes_ar = napok_szama * napi_ar;
            listBox3.Items.Add(id);
            listBox4.Items.Add(nev);
            listBox5.Items.Add(meret);
            //listBox2.Items.Add(nev + " - " + osszes_ar + " FT");
            listBox2.Items.Add(osszes_ar);
            radioButton5.Checked = true; //Set available to false
            horrorCostume.kolcsonozve = true;
        }//kosárba 2
        private void button7_Click(object sender, EventArgs e)
        {
            //If the user clicks on the button, the informations about this costume will be send to the another page
            string meret = monsterBride.meret;
            string nev = monsterBride.elnevezes;
            int id = monsterBride.sorszam;
            int napi_ar = monsterBride.napi_ar;
            int napok_szama = (int)numericUpDown4.Value;
            listBox1.Items.Add(napok_szama);
            int osszes_ar = napok_szama * napi_ar;
            listBox3.Items.Add(id);
            listBox4.Items.Add(nev);
            listBox5.Items.Add(meret);
            //listBox2.Items.Add(nev + " - " + osszes_ar + " FT");
            listBox2.Items.Add(osszes_ar);
            radioButton7.Checked = true; //Set available to false
            monsterBride.kolcsonozve = true;
        }//kosárba 3
        private void button8_Click(object sender, EventArgs e)
        {
            //If the user clicks on the button, the informations about this costume will be send to the another page
            string meret = owl.meret;
            string nev = owl.elnevezes;
            int id = owl.sorszam;
            int napi_ar = owl.napi_ar;
            int napok_szama = (int)numericUpDown5.Value;
            listBox1.Items.Add(napok_szama);
            int osszes_ar = napok_szama * napi_ar;
            listBox3.Items.Add(id);
            listBox4.Items.Add(nev);
            listBox5.Items.Add(meret);
            //listBox2.Items.Add(nev + " - " + osszes_ar + " FT");
            listBox2.Items.Add(osszes_ar);
            radioButton9.Checked = true; //Set available to false
            owl.kolcsonozve = true;
        }//kosárba 4
        private void button12_Click(object sender, EventArgs e)
        {
            //If the user clicks on the button, the informations about this costume will be send to the another page
            string meret = darkQuenn.meret;
            string nev = darkQuenn.elnevezes;
            int id = darkQuenn.sorszam;
            int napi_ar = darkQuenn.napi_ar;
            int napok_szama = (int)numericUpDown6.Value;
            listBox1.Items.Add(napok_szama);
            int osszes_ar = napok_szama * napi_ar;
            listBox3.Items.Add(id);
            listBox4.Items.Add(nev);
            listBox5.Items.Add(meret);
            //listBox2.Items.Add(nev + " - " + osszes_ar + " FT");
            listBox2.Items.Add(osszes_ar);
            radioButton11.Checked = true; //Set available to false
            darkQuenn.kolcsonozve = true;
        }//kosárba5
        private void button11_Click(object sender, EventArgs e)
        {
            //If the user clicks on the button, the informations about this costume will be send to the another page
            string meret = skeletonBride.meret;
            string nev = skeletonBride.elnevezes;
            int id = skeletonBride.sorszam;
            int napi_ar = skeletonBride.napi_ar;
            int napok_szama = (int)numericUpDown7.Value;
            listBox1.Items.Add(napok_szama);
            int osszes_ar = napok_szama * napi_ar;
            listBox3.Items.Add(id);
            listBox4.Items.Add(nev);
            listBox5.Items.Add(meret);
            //listBox2.Items.Add(nev + " - " + osszes_ar + " FT");
            listBox2.Items.Add(osszes_ar);
            radioButton13.Checked = true; //Set available to false
            skeletonBride.kolcsonozve = true;
        }//kosárba 6
        private void button10_Click(object sender, EventArgs e)
        {
            //If the user clicks on the button, the informations about this costume will be send to the another page
            string meret = victorianDoll.meret;
            string nev = victorianDoll.elnevezes;
            int id = victorianDoll.sorszam;
            int napi_ar = victorianDoll.napi_ar;
            int napok_szama = (int)numericUpDown8.Value;
            listBox1.Items.Add(napok_szama);
            int osszes_ar = napok_szama * napi_ar;
            listBox3.Items.Add(id);
            listBox4.Items.Add(nev);
            listBox5.Items.Add(meret);
            //listBox2.Items.Add(nev + " - " + osszes_ar + " FT");
            listBox2.Items.Add(osszes_ar);
            radioButton15.Checked = true; //Set available to false
            victorianDoll.kolcsonozve = true;
        }//kosárba 7
        private void button9_Click(object sender, EventArgs e)
        {
            //If the user clicks on the button, the informations about this costume will be send to the another page
            string meret = witch.meret;
            string nev = witch.elnevezes;
            int id = witch.sorszam;
            int napi_ar = witch.napi_ar;
            int napok_szama = (int)numericUpDown9.Value;
            listBox1.Items.Add(napok_szama);
            int osszes_ar = napok_szama * napi_ar;
            listBox3.Items.Add(id);
            listBox4.Items.Add(nev);
            listBox5.Items.Add(meret);
            //listBox2.Items.Add(nev + " - " + osszes_ar + " FT");
            listBox2.Items.Add(osszes_ar);
            radioButton17.Checked = true; //Set available to false
            witch.kolcsonozve = true;
        }//kosárba 8
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) { e.Handled = true; }
        }//Irányítószám
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) { e.Handled = true; }
        }//házszám
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) { e.Handled = true; }
        }//Adószám első része
        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) { e.Handled = true; }
        }//adószám 2. része
        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) { e.Handled = true; }
        }//Adószám 3. része

        private void button1_Click(object sender, EventArgs e)
        {
            
            int id = 0;
            id++;
            int napi_ar = 0;
            if (listBox4.Items.Contains(dragonGirl.elnevezes) == true) { napi_ar = dragonGirl.napi_ar; }
            if (listBox4.Items.Contains(monsterBride.elnevezes) == true ) { napi_ar = monsterBride.napi_ar; }
            if (listBox4.Items.Contains(horrorCostume.elnevezes) == true) { napi_ar = horrorCostume.napi_ar; }
            if (listBox4.Items.Contains(owl.elnevezes) == true) { napi_ar = owl.napi_ar; }
            if (listBox4.Items.Contains(darkQuenn.elnevezes) == true) { napi_ar = darkQuenn.napi_ar; }
            if (listBox4.Items.Contains(skeletonBride.elnevezes) == true) { napi_ar = skeletonBride.napi_ar; }
            if (listBox4.Items.Contains(victorianDoll.elnevezes) == true) { napi_ar = victorianDoll.napi_ar; }
            if (listBox4.Items.Contains(witch.elnevezes) == true) { napi_ar = witch.napi_ar; }

            dataGridView1.Rows.Add(id, listBox4.Items.ToString(), listBox5.Items.ToString(), listBox1.Items.ToString(), napi_ar);

        }//Rögzítés

        public void Fizetendo()
        {
            int fizetendo = 0;
            foreach (var item in listBox2.Items)
            {
                fizetendo += (int)item;
            }
            textBox12.Text = fizetendo.ToString();
        }
        public void GetJelmez()
        {
            textBox16.Text = dragonGirl.sorszam.ToString();
            textBox17.Text = dragonGirl.elnevezes;
            textBox18.Text = dragonGirl.napi_ar.ToString();
            textBox11.Text = dragonGirl.meret;

            textBox20.Text = horrorCostume.sorszam.ToString();
            textBox20.Text = horrorCostume.elnevezes;
            textBox19.Text = horrorCostume.napi_ar.ToString();
            textBox40.Text = horrorCostume.meret;

            textBox24.Text = monsterBride.sorszam.ToString();
            textBox23.Text = monsterBride.elnevezes;
            textBox22.Text = monsterBride.napi_ar.ToString();
            textBox41.Text = monsterBride.meret;

            textBox27.Text = owl.sorszam.ToString();
            textBox26.Text = owl.elnevezes;
            textBox25.Text = owl.napi_ar.ToString();
            textBox42.Text = owl.meret;

            textBox30.Text = darkQuenn.sorszam.ToString();
            textBox29.Text = darkQuenn.elnevezes;
            textBox28.Text = darkQuenn.napi_ar.ToString();
            textBox43.Text = darkQuenn.meret;

            textBox33.Text = skeletonBride.sorszam.ToString();
            textBox32.Text = skeletonBride.elnevezes;
            textBox31.Text = skeletonBride.napi_ar.ToString();
            textBox44.Text = skeletonBride.meret;

            textBox36.Text = victorianDoll.sorszam.ToString();
            textBox35.Text = victorianDoll.elnevezes;
            textBox34.Text = victorianDoll.napi_ar.ToString();
            textBox45.Text = victorianDoll.meret;

            textBox39.Text = witch.sorszam.ToString();
            textBox38.Text = witch.elnevezes;
            textBox37.Text = witch.napi_ar.ToString();
            textBox46.Text = witch.meret;
        }
    }
}
