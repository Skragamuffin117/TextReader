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
        public void Browse()
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Open Text Document";
            dialog.Filter = "Text files|*.txt";
            dialog.ShowDialog();
        }

        public void Publish()
        {

        }
    }
}
