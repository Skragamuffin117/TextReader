using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public class Data
    {
        public string Browse()
        {
            string document = string.Empty;
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Open Text Document";
            dialog.Filter = "Text files|*.txt";
            if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                document = dialog.FileName;
            }
            return document;
        }

        public void CollectData(string document)
        {
            StreamReader reader = new StreamReader(document);
            string collectdata = reader.ReadLine(document);
            List<string> List = new List<string>();
            while (reader.Peek() >= 0)
            {
                List.Add(reader.ReadLine);
            }
        }
    }
}
