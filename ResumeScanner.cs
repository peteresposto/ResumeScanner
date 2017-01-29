using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResumeScanner
{
    public partial class Main : Form
    {
        string fileName;

        public Main()
        {
            InitializeComponent();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            fileName = openFileDialog1.FileName;
            MessageBox.Show(fileName);
        }
    }
}
