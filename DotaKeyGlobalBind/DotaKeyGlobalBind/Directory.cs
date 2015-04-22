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

namespace DotaKeyGlobalBind
{

    public partial class Directory : Form
    {
        string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Dota 2 Universal Key Bind by Bermuda/dota2keybind_settings.txt");
        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Dota 2 Universal Key Bind by Bermuda");
       
        public Directory()
        {
            InitializeComponent();
        }

        private void Directory_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            this.TopMost = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //yay
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(textBox1.Text + "/dota/cfg/autoexec.cfg"))
            {
                System.IO.Directory.CreateDirectory(filePath);
                File.WriteAllText(fileName, "Directory >" + textBox1.Text);//TODO: add all commands
                System.Diagnostics.Process.Start(Application.ExecutablePath);
                Application.Exit();
                //Application.Restart();
            }
            else
            {
                MessageBox.Show("Wrong directory located. Please locate 'dota 2 beta' folder in your Steam library.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://imnotbermuda.com/2014/11/22/dota-2-universal-keybind/");
        }
    }
}
