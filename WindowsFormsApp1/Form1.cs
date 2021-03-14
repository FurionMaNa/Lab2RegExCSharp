using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = saveFileDialog1.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<String, int> dictionary = FileClass.ReadFile(textBox1.Text);
            List<KeyValuePair<String, int>> list = dictionary.ToList();
            ComparatorClass comporator = new ComparatorClass();
            list.Sort(comporator.Compare);
            FileClass.WriteFile(list, textBox2.Text);
        }
    }
}
