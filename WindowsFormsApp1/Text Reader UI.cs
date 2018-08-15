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
            Publish(list);
        }

        private void Publish(List<string> list)
        {
            foreach(string item in list)
            {
                TextList.Items.Add(item);
            }
        }

        private void Sort_Click(object sender, EventArgs e)
        {

        }

        private void Alphabetize(List<string> TextList)
        {
            List<string> alphabet = new List<string>();
            foreach(string item in TextList)
            {
                alphabet.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
