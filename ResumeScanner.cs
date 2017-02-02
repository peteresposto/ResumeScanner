using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ResumeScanner
{
    public partial class Main : Form
    {
        string fileName;

        public Main()
        {
            InitializeComponent();

            // Read the file as one string.
            System.IO.StreamReader myFile = new System.IO.StreamReader("c:\\Desktop\\K.txt");
            string myString = myFile.ReadToEnd();

            myFile.Close();

            // Display the file contents.
            Console.WriteLine(myString);
            // Suspend the screen.
            Console.ReadLine();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            fileName = openFileDialog1.FileName;
            MessageBox.Show(fileName);

            
        }

        



    }
}
