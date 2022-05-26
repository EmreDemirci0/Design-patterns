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
using Newtonsoft.Json;

namespace YazilimMimarisiVeTasarımı
{
    public partial class frm_jsongöster : Form
    {
        public frm_jsongöster()
        {
            InitializeComponent();
        }

        private void frm_jsongöster_Load(object sender, EventArgs e)
        {
            using (StreamReader read = new StreamReader("JSONRAPOR.json"))
            {
                while (true)
                {
                    string line = read.ReadLine();
                    if (line == null)
                        break;
                    richTextBox1.Text = line;
                }

            }
            //
        }
    }
}
