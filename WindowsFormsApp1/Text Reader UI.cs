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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Read_Click(object sender, EventArgs e)
        {
            Data read = new Data();
            string Text = read.Browse();
            List<string> list = read.CollectData(Text);
        }

        private void Publish()
        {

        }

        private void Sort_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
