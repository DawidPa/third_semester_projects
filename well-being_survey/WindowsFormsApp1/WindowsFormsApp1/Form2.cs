using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        int wynikTak = 0;
        int wynikNie = 0;

        public static Form2 instance;
        public Form2()
        {
            InitializeComponent();
            instance = this;
            button1.Enabled = false;

        }

        private void checkBoxTak1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTak1.Checked)
            {
                checkBoxNie1.Enabled = false;
                progressBar1.Increment(20);
                
                wynikTak++;
                

                if (progressBar1.Value == 100)
                {
                    button1.Enabled = true;
                }
            }
            else
            {

                checkBoxNie1.Enabled = true;
                progressBar1.Increment(-20);
                
                wynikTak--;
                
                button1.Enabled = false;
            }
        }

        private void checkBoxNie1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNie1.Checked)
            {
                checkBoxTak1.Enabled = false;
                progressBar1.Increment(20);
                wynikNie++;
                

                if (progressBar1.Value == 100)
                {
                    button1.Enabled = true;
                }
            }
            else
            {

                checkBoxTak1.Enabled = true;
                progressBar1.Increment(-20);
                wynikNie--;
                
                button1.Enabled = false;
            }
        }

        private void checkBoxTak2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTak2.Checked)
            {
                checkBoxNie2.Enabled = false;
                progressBar1.Increment(20);
                wynikTak++;
               

                if (progressBar1.Value == 100)
                {
                    button1.Enabled = true;
                }
            }
            else
            {

                checkBoxNie2.Enabled = true;
                progressBar1.Increment(-20);
                wynikTak--;
               
                button1.Enabled = false;
            }
        }

        private void checkBoxNie2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNie2.Checked)
            {
                checkBoxTak2.Enabled = false;
                progressBar1.Increment(20);
                wynikNie++;
                

                if (progressBar1.Value == 100)
                {
                    button1.Enabled = true;
                }
            }
            else
            {

                checkBoxTak2.Enabled = true;
                progressBar1.Increment(-20);
                wynikNie--;
                
                button1.Enabled = false;
            }
        }

        private void checkBoxTak3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTak3.Checked)
            {
                checkBoxNie3.Enabled = false;
                progressBar1.Increment(20);
                wynikTak++;
                

                if (progressBar1.Value == 100)
                {
                    button1.Enabled = true;
                }
            }
            else
            {

                checkBoxNie3.Enabled = true;
                progressBar1.Increment(-20);
                wynikTak--;
               
                button1.Enabled = false;
            }
        }

        private void checkBoxNie3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNie3.Checked)
            {
                checkBoxTak3.Enabled = false;
                progressBar1.Increment(20);
                wynikNie++;
                

                if (progressBar1.Value == 100)
                {
                    button1.Enabled = true;
                }
            }
            else
            {

                checkBoxTak3.Enabled = true;
                progressBar1.Increment(-20);
                wynikNie--;
                
                button1.Enabled = false;
            }
        }

        private void checkBoxTak4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTak4.Checked)
            {
                checkBoxNie4.Enabled = false;
                progressBar1.Increment(20);
                wynikTak++;
               

                if (progressBar1.Value == 100)
                {
                    button1.Enabled = true;
                }
            }
            else
            {

                checkBoxNie4.Enabled = true;
                progressBar1.Increment(-20);
                wynikTak--;
                
                button1.Enabled = false;
            }
        }

        private void checkBoxNie4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNie4.Checked)
            {
                checkBoxTak4.Enabled = false;
                progressBar1.Increment(20);
                wynikNie++;
                

                if (progressBar1.Value == 100)
                {
                    button1.Enabled = true;
                }
            }
            else
            {

                checkBoxTak4.Enabled = true;
                progressBar1.Increment(-20);
                wynikNie--;
                
                button1.Enabled = false;
            }
        }

        private void checkBoxTak5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTak5.Checked)
            {
                checkBoxNie5.Enabled = false;
                progressBar1.Increment(20);
                wynikTak++;
               

                if (progressBar1.Value == 100)
                {
                    button1.Enabled = true;
                }
            }
            else
            {

                checkBoxNie5.Enabled = true;
                progressBar1.Increment(-20);
                wynikTak--;
                
                button1.Enabled = false;
            }
        }

        private void checkBoxNie5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNie5.Checked)
            {
                checkBoxTak5.Enabled = false;
                progressBar1.Increment(20);
                wynikNie++;
               

                if (progressBar1.Value == 100)
                {
                    button1.Enabled = true;
                }
            }
            else
            {

                checkBoxTak5.Enabled = true;
                progressBar1.Increment(-20);
                wynikNie--;
               
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 myForm = new Form3(wynikTak , wynikNie);
            myForm.ShowDialog();
            button1.Enabled = false;
            checkBoxNie1.Enabled = false;
            checkBoxNie2.Enabled = false;
            checkBoxNie3.Enabled = false;
            checkBoxNie4.Enabled = false;
            checkBoxNie5.Enabled = false;
            checkBoxTak1.Enabled = false;
            checkBoxTak2.Enabled = false;
            checkBoxTak3.Enabled = false;
            checkBoxTak4.Enabled = false;
            checkBoxTak5.Enabled = false;
           

        }
    }
}
