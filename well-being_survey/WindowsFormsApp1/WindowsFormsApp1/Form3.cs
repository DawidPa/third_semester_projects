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
    public partial class Form3 : Form
    {     

        public Form3()
        {
            InitializeComponent();
       

        }
        public Form3(int wynikTak, int wynikNie)
        {
            
            InitializeComponent();
            if (wynikTak > wynikNie)
            {

                pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.happy;
                label1.Text = "Jest dobrze";
                Closed += (s, args) => this.Close();
              

            
                
            }
            else if (wynikNie > wynikTak)
            {
                pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.sad;
                label1.Text = "Jest źle";
                Closed += (s, args) => this.Close();
               


               
            }

        }
    }
}

