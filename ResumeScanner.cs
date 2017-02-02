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
        private static int numMatches = 0;
        private static string[] keyWords = { "Western", "Academic", "academic", "C#" };

        public Main()
        {
            InitializeComponent();

        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files | *.txt"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                String path = dialog.FileName; // get name of file
                using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding())) // do anything you want, e.g. read it
                {

                    string myString = reader.ReadLine();
                    StringBuilder tempString = new StringBuilder();
                    int i = -1;

                    foreach (char c in myString)
                    {
                        i++;
                        if (i == myString.Length)
                            MessageBox.Show("i = length");
                      if (c == 32 || i == myString.Length)
                        {
                            String word = tempString.ToString();
                            comparatorFunction(tempString.Length, word);
                            tempString.Clear();
                        }
                        else if (c != 32)
                        {
                            tempString.Append(c);
                        }
                    }
                    MessageBox.Show("" + numMatches);
                }
            }
        }

        private void comparatorFunction(int length, string word)
        {
            switch (length)
            {
                case 2:
                    {
                        if (word.Equals(keyWords[3]))
                            numMatches++;
                        break;
                    }
                    
                case 7:
                    {
                        if (word.Equals(keyWords[0]))
                            numMatches++;
                        break;
                    }
                    
                case 8:
                    {
                        if (word.Equals(keyWords[1]) || word.Equals(keyWords[2]))
                            numMatches++;
                        break;
                    }          
            }
        }
    }
}
