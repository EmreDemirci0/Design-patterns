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

namespace YazilimMimarisiVeTasarımı
{
    public partial class frm_htmlGöster : Form
    {
        public frm_htmlGöster()
        {
            InitializeComponent();
        }

        private void frm_htmlGöster_Load(object sender, EventArgs e)
        {
            using (StreamReader read = new StreamReader("HTMLRAPOR.html"))
            {
                while (true)
                {
                    string line = read.ReadLine();
                    if (line == null)
                        break;
                    webBrowser1.DocumentText = line;
                    richTextBox2.Text = line;
                }

            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
