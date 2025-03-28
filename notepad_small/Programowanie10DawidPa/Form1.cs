using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programowanie10DawidPa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        //otworz
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                richTextBox1.Text = File.ReadAllText(ofd.FileName);
                this.Text = Path.GetFileName(ofd.FileName);
            }
        }

        //zamknij
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Any(c => !char.IsDigit(c)))
            {
                DialogResult dr = MessageBox.Show("Czy napewno chcesz zamknąć program?", "", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    this.Close();
                 
                }
            }
            else
            {
                this.Close();
            }
            
        }

        //Nowy
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            if(richTextBox1.Text.Any(c => !char.IsDigit(c)))
             {
                DialogResult dr = MessageBox.Show("Czy napewno chcesz rozpocząć nowy tekst?", "", MessageBoxButtons.YesNo);
                if(dr == DialogResult.Yes)
                { 
                richTextBox1.Clear();
                this.Text = "Notatniczek";
                }
            }
            
        }

        //Zapisz jako
        private void saveasJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            SaveFileDialog sfd = new SaveFileDialog();
            Form1 f1 = new Form1();
           
            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; //odpowiedzialne filtrowanie odpowiednich typów pliku
          
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter file = new StreamWriter(sfd.FileName.ToString());
                    file.WriteLine(richTextBox1.Text);
                    this.Text = Path.GetFileName(sfd.FileName);
                    file.Close();



                }
            
        }
        
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           richTextBox1.Paste();

        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            richTextBox1.BackColor = Color.Black;
            richTextBox1.ForeColor = Color.White;
        }
        
        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            richTextBox1.BackColor = Color.White;
            richTextBox1.ForeColor = Color.Black;
        }
    }
}