using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labGUI1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_solution_Click(object sender, EventArgs e)
        {
            if (Word1.Text.Length == 0)
                MessageBox.Show("Введите первое слово", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Word2.Text.Length == 0)
                MessageBox.Show("Введите второе слово", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string unicchar = Logic.UnicSymbol(Word1.Text);
                label_answer.Text += Logic.Solution(Word2.Text, unicchar);
                label_answer.Visible = true;
            }
        }
    }
}