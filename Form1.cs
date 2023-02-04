using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FileReader
{
    public partial class Form1 : Form
    {

        List<string> list = new List<string>();

        public Form1()
        {

            InitializeComponent();

            string path = @"C:\Users\Администратор\Desktop\file.txt";

            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";

                while ((s = sr.ReadLine()) != null)
                {
                    listBox1.Items.Add(s); // добавляем полученные данные в ListBox  

                    list.Add(s); // добавляем полученные данные в List 

                }

            }

        }

    }
}
