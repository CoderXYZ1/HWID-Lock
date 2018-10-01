using System;
using System.Net;
using System.Windows.Forms;

namespace HWID_AUTH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = HWID.GetMachineGuid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            int b = a.Length;

            try
            {
                if (b > 35)
                {
                    WebClient webc = new WebClient();
                    string rcv = webc.DownloadString(""); //use pastebin

                    if (rcv.Contains(textBox1.Text))
                    {
                        MessageBox.Show("Unlocked");
                    }
                }
                else
                {
                    MessageBox.Show("Locked");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
