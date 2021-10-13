using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace CalculatorWinforms
{
    public partial class Form1 : Form
    {
        int calculateCount = 0;
        bool _isNewEntry, _isInfinityException, _isRepeatLastOperation;
        decimal _dblResult, _dblOperand;
        char _chPreviousOperator;
        public List<string> history { get; set; } = new List<string>();
        public Timer Timer { get; set; }

        public Form1()
        {
            InitializeComponent();
            if (File.Exists("CalculateHistory.json"))
            {
                var text = File.ReadAllText("CalculateHistory.json");
                history = JsonSerializer.Deserialize<List<string>>(text);
            }
            Timer = new Timer();
            Timer.Interval = 1000;
            Timer.Tick += Timer_Tick;
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Text = "Calculator                                        " + DateTime.Now.ToString();
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
            if (sender is Button btn)
            {
                switch (_isInfinityException)
                {
                    case false:
                        {
                            switch (_isNewEntry)
                            {
                                case true:
                                    lbl_Result.Text = "0";
                                    _isNewEntry = false;
                                    break;
                            }
                            switch (_isRepeatLastOperation)
                            {
                                case true:
                                    _chPreviousOperator = '\0';
                                    _dblResult = 0;
                                    break;
                            }
                            switch (lbl_Result.Text == "0" && btn == btn_Num0)
                            {
                                case false when !(btn == btn_Dot && lbl_Result.Text.Contains(",")):
                                    lbl_Result.Text = lbl_Result.Text == "0" && btn == btn_Dot ? "0," : lbl_Result.Text == "0" ? (btn).Text : lbl_Result.Text + (btn).Text;
                                    break;
                            }
                            break;
                        }
                }
            }
        }
        private void Btn_All_Clear_MouseClick(object sender, MouseEventArgs e)
        {
            _isInfinityException = _isRepeatLastOperation = false;
            _dblOperand = _dblResult = 0;
            lbl_Result.Text = "0";
            _isNewEntry = true;
            _chPreviousOperator = '\0';
        }
        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            _isInfinityException = false;
            lbl_Result.Text = "0";
        }
        private void Btn_Pos_Neg_MouseClick(object sender, MouseEventArgs e)
        {
            if (!_isInfinityException)
                lbl_Result.Text = (decimal.Parse(lbl_Result.Text) * -1).ToString();
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            CalculateHistoryForm historyForm = new CalculateHistoryForm();
            historyForm.listBoxHistory.DataSource = history;
            historyForm.ShowDialog();
        }


        private void Btn_Operation_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender is Button btn)
            {
                if (!_isInfinityException)
                {
                    if (_chPreviousOperator == '\0')
                    {
                        _chPreviousOperator = (btn).Text[0];
                        _dblResult = decimal.Parse(lbl_Result.Text);
                    }
                    else if (_isNewEntry)
                        _chPreviousOperator = (btn).Text[0];
                    else
                    {
                        Operate(_dblResult, _chPreviousOperator, decimal.Parse(lbl_Result.Text));
                        _chPreviousOperator = (btn).Text[0];
                    }
                    _isNewEntry = true;
                    _isRepeatLastOperation = false;
                }
            }
        }
        private void Operate(decimal dblPreviousResult, char chPreviousOperator, decimal dblOperand)
        {
            string historyItem;
            switch (chPreviousOperator)
            {
                case '+':
                    lbl_Result.Text = (_dblResult = (dblPreviousResult + dblOperand)).ToString();
                    historyItem = dblPreviousResult.ToString() + " " + _chPreviousOperator + " " + dblOperand + " = " + _dblResult.ToString();
                    history.Add(historyItem);
                    calculateCount++;
                    progressBar1.Value += 20;
                    break;
                case '-':
                    lbl_Result.Text = (_dblResult = (dblPreviousResult - dblOperand)).ToString();
                    historyItem = dblPreviousResult.ToString() + " " + _chPreviousOperator + " " + dblOperand + " = " + _dblResult.ToString();
                    history.Add(historyItem);
                    calculateCount++;
                    progressBar1.Value += 20;
                    break;
                case 'x':
                    lbl_Result.Text = (_dblResult = (dblPreviousResult * dblOperand)).ToString();
                    historyItem = dblPreviousResult.ToString() + " " + _chPreviousOperator + " " + dblOperand + " = " + _dblResult.ToString();
                    history.Add(historyItem);
                    calculateCount++;
                    progressBar1.Value += 20;
                    break;
                case '/':
                    if (dblOperand == 0)
                    {
                        MessageBox.Show("Cannot divide by zero", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _isInfinityException = true;
                    }
                    else
                    {
                        lbl_Result.Text = (_dblResult = (dblPreviousResult / dblOperand)).ToString();
                        historyItem = dblPreviousResult.ToString() + " " + _chPreviousOperator + " " + dblOperand + " = " + _dblResult.ToString();
                        history.Add(historyItem);
                        calculateCount++;
                        progressBar1.Value += 20;
                    }
                    break;
            }
            if (calculateCount >= 5)
            {
                this.Controls.OfType<Button>().ToList().ForEach(btn => btn.Enabled = false);
                btnHistory.Enabled = true;
                lblInfo.Visible = true;
            }

            FileProcessJson.JsonFileWriteAllText("CalculateHistory.json", history);
        }
        private void Btn_Equal_MouseClick(object sender, MouseEventArgs e)
        {
            if (!_isInfinityException)
            {
                if (!_isRepeatLastOperation)
                {
                    _dblOperand = decimal.Parse(lbl_Result.Text);
                    _isRepeatLastOperation = true;
                }

                Operate(_dblResult, _chPreviousOperator, _dblOperand);
                _isNewEntry = true;
            }
        }

    }
}
