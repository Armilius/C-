using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Stack<double> s1 = new Stack<double>();
        Stack<char> s2 = new Stack<char>();
        Stack<int> sign = new Stack<int>();
        int f = 1;
        bool flag = false;
        double num1, num2, num3, tempresult, result;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Instack(char ch)
        {
            int tag = -1, tag0;
            switch (ch)
            {
                case '@':
                case 's':
                case 'c': tag = 9; break;
                case '^': tag = 6; break;
                case '*':
                case '/':
                case '%': tag = 4; break;
                case '+':
                case '-': tag = 2; break;
                case '(': tag = 10; break;
                case ')': tag = 1; break;
                case '#': tag = 0; break;
            }
            while (true)
            {
                tag0 = sign.Peek();
                if (tag0 < tag)
                {
                    s2.Push(ch);
                    if (tag < 9 && tag > 1) sign.Push(tag + 1);
                    else if (tag == 9) sign.Push(tag - 1);
                    else if (tag == 0) sign.Push(tag);
                    else if (tag == 1) sign.Push(10);
                    else if (tag == 10) sign.Push(1);
                    break;
                }
                else if (tag0 > tag)
                {
                    char t = s2.Peek();
                    s2.Pop();
                    sign.Pop();
                    switch (t)
                    {
                        case '@': { num3 = s1.Peek(); s1.Pop(); tempresult = -num3; s1.Push(tempresult); break; }
                        case 's': { num3 = s1.Peek(); s1.Pop(); tempresult = Math.Sqrt(num3); s1.Push(tempresult); break; }
                        case 'c': { num3 = s1.Peek(); s1.Pop(); tempresult = Math.Cos(num3); s1.Push(tempresult); break; }
                        case '^': { num3 = s1.Peek(); s1.Pop(); num2 = s1.Peek(); s1.Pop(); tempresult = Math.Pow(num2, num3); s1.Push(tempresult); break; }
                        case '*': { num3 = s1.Peek(); s1.Pop(); num2 = s1.Peek(); s1.Pop(); tempresult = num2 * num3; s1.Push(tempresult); break; }
                        case '/': { num3 = s1.Peek(); s1.Pop(); num2 = s1.Peek(); s1.Pop(); tempresult = num2 / num3; s1.Push(tempresult); break; }
                        case '%': { num3 = s1.Peek(); s1.Pop(); num2 = s1.Peek(); s1.Pop(); tempresult = num2 % num3; s1.Push(tempresult); break; }
                        case '+': { num3 = s1.Peek(); s1.Pop(); num2 = s1.Peek(); s1.Pop(); tempresult = num2 + num3; s1.Push(tempresult); break; }
                        case '-': { num3 = s1.Peek(); s1.Pop(); num2 = s1.Peek(); s1.Pop(); tempresult = num2 - num3; s1.Push(tempresult); break; }
                        case '(': break;
                        case ')': break;
                        case '#': break;
                    }
                }
                else
                {
                    s2.Pop();
                    sign.Pop();
                    break;
                }
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            f = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            f = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            f = 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            f = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            f = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            f = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            f = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            f = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
                textBox1.Text += "-";
                f = 1;
                flag = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (f == 0) MessageBox.Show("WRONG INPUT!", "ERROR!", MessageBoxButtons.OK);
            else
            {
                textBox1.Text += "(";
                f = 1;
                flag = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (f == 1) MessageBox.Show("WRONG INPUT!", "ERROR!", MessageBoxButtons.OK);
            else
            {
                textBox1.Text += ")";
                f = 0;
                flag = false;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (f == 1)
                MessageBox.Show("WRONG INPUT!", "ERROR!", MessageBoxButtons.OK);
            else
            {
                textBox1.Text += "+";
                f = 1;
                flag = false;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (f == 1)
                MessageBox.Show("WRONG INPUT!", "ERROR!", MessageBoxButtons.OK);
            else
            {
                textBox1.Text += "*";
                f = 1;
                flag = false;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (f == 1)
                MessageBox.Show("WRONG INPUT!", "ERROR!", MessageBoxButtons.OK);
            else
            { textBox1.Text += "/";
                f = 1;
                flag = false;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if(f==0) { MessageBox.Show("WRONG INPUT!","ERROR!", MessageBoxButtons.OK); }
            else
            {
                textBox1.Text += "sqrt";
                f = 1;
                flag = false;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (f == 1)
                MessageBox.Show("WRONG INPUT!", "ERROR!", MessageBoxButtons.OK);
            else
            {
                textBox1.Text += "%";
                f = 1;
                flag = false;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (f == 1) MessageBox.Show("WRONG INPUT!", "ERROR!", MessageBoxButtons.OK);
            else
            {
                textBox1.Text += "^";
                f = 1;
                flag = false;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (f == 1)
                MessageBox.Show("WRONG INPUT!", "ERROR!", MessageBoxButtons.OK);
            else
            {
                s2.Push('#');
                sign.Push(0);
                string s = "";
                char[] ch = textBox1.Text.ToCharArray();
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    if ((ch[i] >= '0' && ch[i] <= '9') || ch[i] == '.')
                        s = s + ch[i];
                    else if (ch[i] < '0' || ch[i] > '9') 
                    {
                        if (ch[i] == 's')
                        {
                            Instack('s');
                            i += 3;
                        }
                        else if (ch[i] == 'c')
                        {
                            Instack('c');
                            i += 2;
                        }
                        else if (ch[i] == '(') Instack('(');
                        else if (ch[i] == '-' && (i == 0 || ((ch[i - 1] < '0' || ch[i - 1] > '9') && ch[i - 1] != ')')))
                            Instack('@');
                        else if (ch[i - 1] == ')') Instack(ch[i]);
                        else
                        {
                            num1 = Convert.ToDouble(s);
                            s = "";
                            s1.Push(num1);
                            Instack(ch[i]);
                        }
                    }
                }
                if (s != "")
                {
                    num1 = Convert.ToDouble(s);
                    s1.Push(num1);
                }
                Instack('#');
                if (s2.Count == 0)
                {
                    result = s1.Peek();
                    s1.Clear();
                    s2.Clear();
                    sign.Clear();
                    textBox2.Text = result.ToString();
                }
                else MessageBox.Show("WRONG INPUT!", "ERROR!", MessageBoxButtons.OK);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (f == 0) { MessageBox.Show("WRONG INPUT!", "ERROR!", MessageBoxButtons.OK); }
            else
            {
                textBox1.Text += "cos";
                f = 1;
                flag = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                char tt = textBox1.Text.ElementAt(textBox1.Text.Length - 1);
                if (tt != 't' && tt != 's')
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                    if (tt == '.') flag = false;
                }
                else if (tt == 't')
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 4);
                else if (tt == 's')
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 3);
                if (textBox1.Text.Length > 0)
                {
                    tt = textBox1.Text.ElementAt(textBox1.Text.Length - 1);
                    if ((tt < '0' || tt > '9') && tt != ')') f = 1;
                    else f = 0;
                }
                else f = 1;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if(f==1)
                MessageBox.Show("WRONG INPUT!", "ERROR!", MessageBoxButtons.OK);
            else
            {
                Stack<char> st = new Stack<char>();
                char tt = textBox1.Text.ElementAt(textBox1.Text.Length - 1);
                if (tt != ')')
                {
                    while (((tt >= '0' && tt <= '9') || tt == '.') && textBox1.Text.Length != 0)
                    {
                        textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                        st.Push(tt);
                        if (textBox1.Text.Length > 0) tt = textBox1.Text.ElementAt(textBox1.Text.Length - 1);
                    }
                }
                else
                {
                    while(tt!='('&&textBox1.Text.Length!=0)
                    {
                        textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                        st.Push(tt);
                        if (textBox1.Text.Length > 0) tt = textBox1.Text.ElementAt(textBox1.Text.Length - 1);
                    }
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                    st.Push(tt);
                }
                textBox1.Text += "(1/";
                while(st.Count!=0)
                {
                    tt = st.Peek();
                    st.Pop();
                    textBox1.Text += tt;
                }
                textBox1.Text += ")";
                f = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            s1.Clear();
            s2.Clear();
            sign.Clear();
            flag = false;
            f = 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            f = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            f = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text += "0.";
                f = 1;
                flag = true;
            }
            else if (flag==false)
            {
                textBox1.Text += ".";
                f = 1;
                flag = true;
            }
            else if(flag)
                MessageBox.Show("WRONG INPUT!", "ERROR!", MessageBoxButtons.OK);
        }
    }
}
