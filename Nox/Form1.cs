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
using WeAreDevs_API;

namespace ExampleExploit
{
    public partial class WeAreDevs : Form
    {
        // Making all the functions work
        ExploitAPI api = new ExploitAPI();
        public WeAreDevs()
        {
            InitializeComponent();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            string readfile = File.ReadAllText(filename);
            fastColoredTextBox1.Text = readfile;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = fastColoredTextBox1.Text;
            this.api.SendLuaCScript(text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();
            api.SendCommand("print Exploit Attached");
            bool yes = api.isAPIAttached();
            if (yes == true)
            {
                label2.Text = "Status:Attached";
                label2.ForeColor = Color.LimeGreen;
            }
            else
            {
                label2.Text = "Status:Not Attached";
                label2.ForeColor = Color.Red;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            api.SendCommand("btools me");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            api.SendCommand("ff me");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            api.SendCommand("kill me");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            api.SendCommand("sparkles me");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            api.SendCommand("fire me");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            api.SendCommand("smoke me");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            api.SendCommand("float me");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            api.SendCommand("boxesp me");
        }
    }
}
