using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TESTUI.Question;

namespace WinFormsApp1
{
    public partial class EasyForm : UserControl
    {
        List<TestItem> items = new List<TestItem>();
        int num = 1;
        public EasyForm()
        {
            InitializeComponent();
            createQuestion();
            askQuestion(num);
        }

        private void questionDisp(object sender, EventArgs e)
        {

        }

        public void askQuestion(int num)
        {
            switch (num)
            {
                case 1:
                    label1.Text = items[0].Question;
                    break;
                case 2:
                    label1.Text = items[1].Question;
                    break;
            }
        }

        private void createQuestion()
        {
            string[] q = new string[2];
            string[] a = new string[2];
            TestItem[] item = new TestItem[2];

            q[0] = "1 + 1 = ?";
            q[1] = "1 + 2 = ?";

            a[0] = "2";
            a[1] = "3";

            items.Add(item[0] = new TestItem(q[0], a[0]));
            items.Add(item[1] = new TestItem(q[1], a[1]));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void submit(object sender, EventArgs e)
        {
            string ans = userAnswer.Text.ToString();
            if (items[num - 1].CorrectAnswer == ans)
            {
                num++;
                //MessageBox.Show("Correct!!");
                askQuestion(num);
            }
            else
                MessageBox.Show("Wrong!!");
        }

        private void nextButton(object sender, EventArgs e)
        {

        }

        private void prevButton(object sender, EventArgs e)
        {

        }
    }
}
