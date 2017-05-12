using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTest
{
    public partial class Form2 : Form
    {
        int flag1 = 0;
        int flag2 = 0;
        int flag3 = 0;
        int flag4 = 0;

        Form1 ff;

        public Form2(Form1 f1)
        {
            this.ff = f1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string s_reg = @"^[\u4e00-\u9fa5]{0,}$";
            Regex reg = new Regex(s_reg);
            if (reg.IsMatch(s))
            {
                MessageBox.Show("~OK~");
                flag1 = 1;
            }
            else
            {
                MessageBox.Show("请输入中文");
                flag1 = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = textBox2.Text;
            string s_reg = @"^\d{6,8}$";
            Regex reg = new Regex(s_reg);
            if (reg.IsMatch(s))
            {
                MessageBox.Show("~OK~");
                flag2 = 1;
            }
            else
            {
                MessageBox.Show("请正确输入");
                flag2 = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = textBox3.Text;
            string s_reg = @"^[\u4E00-\u9FA5]{0,}$";
            Regex reg = new Regex(s_reg);
            if (reg.IsMatch(s))
            {
                MessageBox.Show("~OK~");
                flag3 = 1;
            }
            else
            {
                MessageBox.Show("请输入中文");
                flag3 = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s = textBox4.Text;
            string s_reg = @"^[\u4E00-\u9FA5]{0,}$";
            Regex reg = new Regex(s_reg);
            if (reg.IsMatch(s))
            {
                MessageBox.Show("~OK~");
                flag4 = 1;
            }
            else
            {
                MessageBox.Show("请输入中文");
                flag4 = 0;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(flag1 == 1 && flag2 == 1 && flag3 == 1 && flag4 == 1)
            {
                string[] s = new string[20];
                s[0] = "蛤";
                s[1] = "凹凸曼";
                s[2] = "高富帅";
                s[3] = "矮穷挫";
                s[4] = "金正恩";
                s[5] = "杨永信";
                s[6] = "尹志平";
                s[7] = "黄旭东";
                s[8] = "伊藤诚";
                s[9] = "脏杰";
                s[10] = "掏粪男孩";
                s[11] = "甘道夫";
                s[12] = "小野妹子";
                Random rd = new Random();
                richTextBox1.Text = s[rd.Next(0, 12)];
                richTextBox2.Text = rd.Next(0, 100).ToString();
            }
            flag1 = flag2 = flag3 = flag4 = 0;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("~Wish you happy forever!~");
            ff.Show();
        }
    }
}
