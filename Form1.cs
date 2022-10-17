using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimjenaWindowsKontrola
{
    public partial class FormaProgram : Form
    {
        public FormaProgram()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (comboBoxProgram.Text == "Notepad")
            { System.Diagnostics.Process.Start(@"notepad.exe"); }
            else if (comboBoxProgram.Text =="Paint")
            { System.Diagnostics.Process.Start(@"mspaint.exe"); }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked == true)
            { groupBoxRun.Visible = false; }
            else if (checkBoxShow.Checked == false)
            { groupBoxRun.Visible = true; }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxDescription.Clear();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            MessageBox.Show("Odaberite neko dugme","Obavestenje",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
                
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formaText = new Form();
            formaText.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
          DialogResult rezultat2= MessageBox.Show("Da li ste sigurni da zelite zatvoriti aplikaciju?", "Obavestenje", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        if(rezultat2 = DialogResult.Yes)
            { Form.Close(FormaProgram); }
        }

        private void textToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
