using System;
using System.Windows.Forms;
using System.Windows.Input;

namespace labGUI1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Ввод слов и вывод ответа,а также вывод сообщения об ошибке
        private void button_solution_Click(object sender, EventArgs e)
        {
            if (Word1.Text.Length == 0)
                MessageBox.Show("Введите первое слово", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Word2.Text.Length == 0)
                MessageBox.Show("Введите второе слово", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                label_answer.Text = "Ответ: ";
                string unicchar = Logic.UnicSymbol(Word1.Text);
                label_answer.Text += Logic.Solution(Word2.Text, unicchar);
                label_answer.Visible = true;
            }
        }

        //Сохранение при закрытии программы
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Word1 = Word1.Text;
            Properties.Settings.Default.Word2 = Word2.Text;
            Properties.Settings.Default.Save();
        }

        //Загрузка сохраненных данных
        private void Form1_Load(object sender, EventArgs e)
        {
            Word1.Text = Properties.Settings.Default.Word1;
            Word2.Text = Properties.Settings.Default.Word2;
        }


        //Очистка полей при нажатии на кнопку
        private void button_clear_Click(object sender, EventArgs e)
        {
            Word1.Text = Word1.Text.Remove(0);
            Word2.Text = Word2.Text.Remove(0);
            label_answer.Visible =false;
        }
    }
}