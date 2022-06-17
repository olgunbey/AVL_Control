using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DengeliTree bilgi_tree = new DengeliTree();
        
        private void button1_Click(object sender, EventArgs e)
        {
           

            bilgi_tree.ara(Convert.ToInt32(textBox1.Text));
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bilgi_tree.insert(15);
            bilgi_tree.insert(20);
            bilgi_tree.insert(25);
            bilgi_tree.insert(17);
            bilgi_tree.insert(19);
            bilgi_tree.insert(24);




        }
    }
}
