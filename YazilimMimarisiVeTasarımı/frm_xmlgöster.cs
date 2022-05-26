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
using System.Xml;

namespace YazilimMimarisiVeTasarımı
{
    public partial class frm_xmlgöster : Form
    {
        public frm_xmlgöster()
        {
            InitializeComponent();
        }

        private void frm_xmlgöster_Load(object sender, EventArgs e)
        {
            string xmlTexti = File.ReadAllText("XMLRAPOR.xml", Encoding.UTF8);

            XmlDocument document = new XmlDocument();
            document.LoadXml(xmlTexti);
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add(new TreeNode(document.DocumentElement.Name));

            TreeNode tNode = new TreeNode();
            tNode = treeView1.Nodes[0];

            this.AddNode(document.DocumentElement, tNode);

            using (StreamReader read = new StreamReader("XMLRAPOR.xml"))
            {
                string line = read.ReadToEnd();
                richTextBox1.Text = line;

            }
        }
        private void AddNode(XmlNode xmlNode, TreeNode treeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList nodeList;
            if (xmlNode.HasChildNodes)
            {
                nodeList = xmlNode.ChildNodes;
                for (int i = 0; i <= nodeList.Count - 1; i++)
                {
                    xNode = xmlNode.ChildNodes[i];
                    treeNode.Nodes.Add(new TreeNode(xNode.Name));
                    tNode = treeNode.Nodes[i];
                    AddNode(xNode, tNode);
                }
            }
            else
                treeNode.Text = (xmlNode.OuterXml).Trim();
        }
    }
}
