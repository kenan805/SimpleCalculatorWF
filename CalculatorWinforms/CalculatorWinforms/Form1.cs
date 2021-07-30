using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CalculatorWinforms
{
    public partial class Form1 : Form
    {
        double number = 0;
        string operation = "";
        bool isOperationCh = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_MouseHover(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.BackColor = Color.LightSkyBlue;
            }
        }
        private void Btn_Num_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.BackColor = Color.White;
            }
        }
        private void Btn_Operation_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.BackColor = Color.Silver;
            }
        }
        private void Btn_Num_MouseClick(object sender, MouseEventArgs e)
        {
            if (lbl_Result.Text == "0" || isOperationCh)
            {
                lbl_Result.Text = lbl_Result.Text.Remove(0);
            }
            if (sender is Button btn)
            {
                lbl_Result.Text += btn.Text;
                isOperationCh = false;

            }
        }
        private void Btn_Num0_MouseClick(object sender, MouseEventArgs e)
        {
            if (lbl_Result.Text == "0")
            {
                lbl_Result.Text = "0";
            }
            else
            {
                lbl_Result.Text += btn_Num0.Text;
            }
        }
        private void Btn_All_Clear_MouseClick(object sender, MouseEventArgs e)
        {
            lbl_Result.Text = "0";
            number = 0;
            operation = "";
        }
        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            if (lbl_Result.Text == "0")
            {
                lbl_Result.Text = "0";
            }
            else
            {
                if (lbl_Result.Text.Length == 1)
                {
                    lbl_Result.Text = "0";
                }
                else if (lbl_Result.Text.Length >= 10)
                {
                    lbl_Result.Text = lbl_Result.Text.Remove(9);
                }
                else
                {
                    lbl_Result.Text = lbl_Result.Text.Remove(lbl_Result.Text.Length - 1);
                }
            }
        }
        private void Btn_Pos_Neg_MouseClick(object sender, MouseEventArgs e)
        {
            if (lbl_Result.Text == "0")
            {
                lbl_Result.Text = "0";
            }
            else
            {
                if (lbl_Result.Text.Length < 10 && lbl_Result.Text[0] != '-')
                {
                    lbl_Result.Text = "-" + lbl_Result.Text;
                }
                else if (lbl_Result.Text.Length < 10 && lbl_Result.Text[0] == '-')
                {
                    lbl_Result.Text = lbl_Result.Text.Remove(0, 1);
                }
            }
        }
        private void Btn_Dot_MouseClick(object sender, MouseEventArgs e)
        {
            if (lbl_Result.Text.Count(c => c == '.') != 1)
            {
                lbl_Result.Text += ".";
            }
        }
        private void Btn_Operation_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender is Button btn)
            {
                operation = btn.Text;
                number = double.Parse(lbl_Result.Text);
                isOperationCh = true;
            }
        }
        private void Btn_Equal_MouseClick(object sender, MouseEventArgs e)
        {
            isOperationCh = true;
            switch (operation)
            {
                case "+":
                    {
                        lbl_Result.Text = (number + double.Parse(lbl_Result.Text)).ToString();
                        break;
                    }
                case "-":
                    {
                        lbl_Result.Text = (number - double.Parse(lbl_Result.Text)).ToString();
                        break;
                    }
                case "x":
                    {
                        lbl_Result.Text = (number * double.Parse(lbl_Result.Text)).ToString();
                        break;
                    }
                case "/":
                    {
                        lbl_Result.Text = (number / double.Parse(lbl_Result.Text)).ToString();
                        break;
                    }
                default:
                    break;
            }
            number = double.Parse(lbl_Result.Text);
        }

    }
}
