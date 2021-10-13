
namespace CalculatorWinforms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Num7 = new System.Windows.Forms.Button();
            this.btn_Num8 = new System.Windows.Forms.Button();
            this.btn_Num9 = new System.Windows.Forms.Button();
            this.btn_All_Clear = new System.Windows.Forms.Button();
            this.btn_Multiply = new System.Windows.Forms.Button();
            this.btn_Divide = new System.Windows.Forms.Button();
            this.btn_Num6 = new System.Windows.Forms.Button();
            this.btn_Num5 = new System.Windows.Forms.Button();
            this.btn_Num4 = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Subtract = new System.Windows.Forms.Button();
            this.btn_Num3 = new System.Windows.Forms.Button();
            this.btn_Num2 = new System.Windows.Forms.Button();
            this.btn_Num1 = new System.Windows.Forms.Button();
            this.btn_Num0 = new System.Windows.Forms.Button();
            this.btn_Pos_Neg = new System.Windows.Forms.Button();
            this.btn_Dot = new System.Windows.Forms.Button();
            this.btn_Equal = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.gradientPanel1 = new CalculatorWinforms.GradientPanel();
            this.btnHistory = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Num7
            // 
            this.btn_Num7.BackColor = System.Drawing.Color.White;
            this.btn_Num7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Num7.Font = new System.Drawing.Font("Arial Unicode MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Num7.ForeColor = System.Drawing.Color.Black;
            this.btn_Num7.Location = new System.Drawing.Point(0, 167);
            this.btn_Num7.Name = "btn_Num7";
            this.btn_Num7.Size = new System.Drawing.Size(86, 87);
            this.btn_Num7.TabIndex = 2;
            this.btn_Num7.Text = "7";
            this.btn_Num7.UseVisualStyleBackColor = false;
            this.btn_Num7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_Num_MouseClick);
            this.btn_Num7.MouseLeave += new System.EventHandler(this.Btn_Num_MouseLeave);
            this.btn_Num7.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // btn_Num8
            // 
            this.btn_Num8.BackColor = System.Drawing.Color.White;
            this.btn_Num8.Font = new System.Drawing.Font("Arial Unicode MS", 19.8F);
            this.btn_Num8.ForeColor = System.Drawing.Color.Black;
            this.btn_Num8.Location = new System.Drawing.Point(83, 167);
            this.btn_Num8.Name = "btn_Num8";
            this.btn_Num8.Size = new System.Drawing.Size(86, 87);
            this.btn_Num8.TabIndex = 3;
            this.btn_Num8.Text = "8";
            this.btn_Num8.UseVisualStyleBackColor = false;
            this.btn_Num8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_Num_MouseClick);
            this.btn_Num8.MouseLeave += new System.EventHandler(this.Btn_Num_MouseLeave);
            this.btn_Num8.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // btn_Num9
            // 
            this.btn_Num9.BackColor = System.Drawing.Color.White;
            this.btn_Num9.Font = new System.Drawing.Font("Arial Unicode MS", 19.8F);
            this.btn_Num9.ForeColor = System.Drawing.Color.Black;
            this.btn_Num9.Location = new System.Drawing.Point(167, 167);
            this.btn_Num9.Name = "btn_Num9";
            this.btn_Num9.Size = new System.Drawing.Size(86, 87);
            this.btn_Num9.TabIndex = 4;
            this.btn_Num9.Text = "9";
            this.btn_Num9.UseVisualStyleBackColor = false;
            this.btn_Num9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_Num_MouseClick);
            this.btn_Num9.MouseLeave += new System.EventHandler(this.Btn_Num_MouseLeave);
            this.btn_Num9.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // btn_All_Clear
            // 
            this.btn_All_Clear.BackColor = System.Drawing.Color.Silver;
            this.btn_All_Clear.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_All_Clear.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_All_Clear.Location = new System.Drawing.Point(251, 167);
            this.btn_All_Clear.Name = "btn_All_Clear";
            this.btn_All_Clear.Size = new System.Drawing.Size(86, 87);
            this.btn_All_Clear.TabIndex = 5;
            this.btn_All_Clear.Text = "AC";
            this.btn_All_Clear.UseVisualStyleBackColor = true;
            this.btn_All_Clear.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_All_Clear_MouseClick);
            this.btn_All_Clear.MouseLeave += new System.EventHandler(this.Btn_Operation_MouseLeave);
            this.btn_All_Clear.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // btn_Multiply
            // 
            this.btn_Multiply.BackColor = System.Drawing.Color.Silver;
            this.btn_Multiply.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold);
            this.btn_Multiply.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Multiply.Location = new System.Drawing.Point(335, 249);
            this.btn_Multiply.Name = "btn_Multiply";
            this.btn_Multiply.Size = new System.Drawing.Size(86, 87);
            this.btn_Multiply.TabIndex = 11;
            this.btn_Multiply.Text = "x";
            this.btn_Multiply.UseVisualStyleBackColor = true;
            this.btn_Multiply.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_Operation_MouseClick);
            this.btn_Multiply.MouseLeave += new System.EventHandler(this.Btn_Operation_MouseLeave);
            this.btn_Multiply.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // btn_Divide
            // 
            this.btn_Divide.BackColor = System.Drawing.Color.Silver;
            this.btn_Divide.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold);
            this.btn_Divide.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Divide.Location = new System.Drawing.Point(251, 249);
            this.btn_Divide.Name = "btn_Divide";
            this.btn_Divide.Size = new System.Drawing.Size(86, 88);
            this.btn_Divide.TabIndex = 10;
            this.btn_Divide.Text = "/";
            this.btn_Divide.UseVisualStyleBackColor = true;
            this.btn_Divide.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_Operation_MouseClick);
            this.btn_Divide.MouseLeave += new System.EventHandler(this.Btn_Operation_MouseLeave);
            this.btn_Divide.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // btn_Num6
            // 
            this.btn_Num6.BackColor = System.Drawing.Color.White;
            this.btn_Num6.Font = new System.Drawing.Font("Arial Unicode MS", 19.8F);
            this.btn_Num6.ForeColor = System.Drawing.Color.Black;
            this.btn_Num6.Location = new System.Drawing.Point(167, 249);
            this.btn_Num6.Name = "btn_Num6";
            this.btn_Num6.Size = new System.Drawing.Size(86, 88);
            this.btn_Num6.TabIndex = 9;
            this.btn_Num6.Text = "6";
            this.btn_Num6.UseVisualStyleBackColor = false;
            this.btn_Num6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_Num_MouseClick);
            this.btn_Num6.MouseLeave += new System.EventHandler(this.Btn_Num_MouseLeave);
            this.btn_Num6.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // btn_Num5
            // 
            this.btn_Num5.BackColor = System.Drawing.Color.White;
            this.btn_Num5.Font = new System.Drawing.Font("Arial Unicode MS", 19.8F);
            this.btn_Num5.ForeColor = System.Drawing.Color.Black;
            this.btn_Num5.Location = new System.Drawing.Point(83, 249);
            this.btn_Num5.Name = "btn_Num5";
            this.btn_Num5.Size = new System.Drawing.Size(86, 88);
            this.btn_Num5.TabIndex = 8;
            this.btn_Num5.Text = "5";
            this.btn_Num5.UseVisualStyleBackColor = false;
            this.btn_Num5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_Num_MouseClick);
            this.btn_Num5.MouseLeave += new System.EventHandler(this.Btn_Num_MouseLeave);
            this.btn_Num5.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // btn_Num4
            // 
            this.btn_Num4.BackColor = System.Drawing.Color.White;
            this.btn_Num4.Font = new System.Drawing.Font("Arial Unicode MS", 19.8F);
            this.btn_Num4.ForeColor = System.Drawing.Color.Black;
            this.btn_Num4.Location = new System.Drawing.Point(0, 249);
            this.btn_Num4.Name = "btn_Num4";
            this.btn_Num4.Size = new System.Drawing.Size(86, 88);
            this.btn_Num4.TabIndex = 7;
            this.btn_Num4.Text = "4";
            this.btn_Num4.UseVisualStyleBackColor = false;
            this.btn_Num4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_Num_MouseClick);
            this.btn_Num4.MouseLeave += new System.EventHandler(this.Btn_Num_MouseLeave);
            this.btn_Num4.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold);
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Add.Location = new System.Drawing.Point(335, 333);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(87, 88);
            this.btn_Add.TabIndex = 16;
            this.btn_Add.Text = "+";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_Operation_MouseClick);
            this.btn_Add.MouseLeave += new System.EventHandler(this.Btn_Operation_MouseLeave);
            this.btn_Add.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // btn_Subtract
            // 
            this.btn_Subtract.BackColor = System.Drawing.Color.Silver;
            this.btn_Subtract.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold);
            this.btn_Subtract.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Subtract.Location = new System.Drawing.Point(251, 333);
            this.btn_Subtract.Name = "btn_Subtract";
            this.btn_Subtract.Size = new System.Drawing.Size(86, 88);
            this.btn_Subtract.TabIndex = 15;
            this.btn_Subtract.Text = "-";
            this.btn_Subtract.UseVisualStyleBackColor = true;
            this.btn_Subtract.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_Operation_MouseClick);
            this.btn_Subtract.MouseLeave += new System.EventHandler(this.Btn_Operation_MouseLeave);
            this.btn_Subtract.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // btn_Num3
            // 
            this.btn_Num3.BackColor = System.Drawing.Color.White;
            this.btn_Num3.Font = new System.Drawing.Font("Arial Unicode MS", 19.8F);
            this.btn_Num3.ForeColor = System.Drawing.Color.Black;
            this.btn_Num3.Location = new System.Drawing.Point(167, 333);
            this.btn_Num3.Name = "btn_Num3";
            this.btn_Num3.Size = new System.Drawing.Size(86, 88);
            this.btn_Num3.TabIndex = 14;
            this.btn_Num3.Text = "3";
            this.btn_Num3.UseVisualStyleBackColor = false;
            this.btn_Num3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_Num_MouseClick);
            this.btn_Num3.MouseLeave += new System.EventHandler(this.Btn_Num_MouseLeave);
            this.btn_Num3.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // btn_Num2
            // 
            this.btn_Num2.BackColor = System.Drawing.Color.White;
            this.btn_Num2.Font = new System.Drawing.Font("Arial Unicode MS", 19.8F);
            this.btn_Num2.ForeColor = System.Drawing.Color.Black;
            this.btn_Num2.Location = new System.Drawing.Point(83, 333);
            this.btn_Num2.Name = "btn_Num2";
            this.btn_Num2.Size = new System.Drawing.Size(86, 88);
            this.btn_Num2.TabIndex = 13;
            this.btn_Num2.Text = "2";
            this.btn_Num2.UseVisualStyleBackColor = false;
            this.btn_Num2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_Num_MouseClick);
            this.btn_Num2.MouseLeave += new System.EventHandler(this.Btn_Num_MouseLeave);
            this.btn_Num2.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // btn_Num1
            // 
            this.btn_Num1.BackColor = System.Drawing.Color.White;
            this.btn_Num1.Font = new System.Drawing.Font("Arial Unicode MS", 19.8F);
            this.btn_Num1.ForeColor = System.Drawing.Color.Black;
            this.btn_Num1.Location = new System.Drawing.Point(1, 333);
            this.btn_Num1.Name = "btn_Num1";
            this.btn_Num1.Size = new System.Drawing.Size(86, 88);
            this.btn_Num1.TabIndex = 12;
            this.btn_Num1.Text = "1";
            this.btn_Num1.UseVisualStyleBackColor = false;
            this.btn_Num1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_Num_MouseClick);
            this.btn_Num1.MouseLeave += new System.EventHandler(this.Btn_Num_MouseLeave);
            this.btn_Num1.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // btn_Num0
            // 
            this.btn_Num0.BackColor = System.Drawing.Color.White;
            this.btn_Num0.Font = new System.Drawing.Font("Arial Unicode MS", 19.8F);
            this.btn_Num0.ForeColor = System.Drawing.Color.Black;
            this.btn_Num0.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Num0.Location = new System.Drawing.Point(1, 417);
            this.btn_Num0.Name = "btn_Num0";
            this.btn_Num0.Size = new System.Drawing.Size(86, 88);
            this.btn_Num0.TabIndex = 17;
            this.btn_Num0.Text = "0";
            this.btn_Num0.UseVisualStyleBackColor = false;
            this.btn_Num0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_Num_MouseClick);
            this.btn_Num0.MouseLeave += new System.EventHandler(this.Btn_Num_MouseLeave);
            this.btn_Num0.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // btn_Pos_Neg
            // 
            this.btn_Pos_Neg.BackColor = System.Drawing.Color.Silver;
            this.btn_Pos_Neg.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold);
            this.btn_Pos_Neg.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Pos_Neg.Location = new System.Drawing.Point(83, 417);
            this.btn_Pos_Neg.Name = "btn_Pos_Neg";
            this.btn_Pos_Neg.Size = new System.Drawing.Size(86, 88);
            this.btn_Pos_Neg.TabIndex = 18;
            this.btn_Pos_Neg.Text = "+/-";
            this.btn_Pos_Neg.UseVisualStyleBackColor = true;
            this.btn_Pos_Neg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_Pos_Neg_MouseClick);
            this.btn_Pos_Neg.MouseLeave += new System.EventHandler(this.Btn_Operation_MouseLeave);
            this.btn_Pos_Neg.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // btn_Dot
            // 
            this.btn_Dot.Font = new System.Drawing.Font("Arial Unicode MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dot.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Dot.Location = new System.Drawing.Point(167, 417);
            this.btn_Dot.Name = "btn_Dot";
            this.btn_Dot.Size = new System.Drawing.Size(86, 88);
            this.btn_Dot.TabIndex = 19;
            this.btn_Dot.Text = ",";
            this.btn_Dot.UseVisualStyleBackColor = true;
            this.btn_Dot.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_Num_MouseClick);
            this.btn_Dot.MouseLeave += new System.EventHandler(this.Btn_Operation_MouseLeave);
            this.btn_Dot.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // btn_Equal
            // 
            this.btn_Equal.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Equal.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold);
            this.btn_Equal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Equal.Location = new System.Drawing.Point(251, 417);
            this.btn_Equal.Name = "btn_Equal";
            this.btn_Equal.Size = new System.Drawing.Size(171, 88);
            this.btn_Equal.TabIndex = 20;
            this.btn_Equal.Text = "=";
            this.btn_Equal.UseVisualStyleBackColor = false;
            this.btn_Equal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_Equal_MouseClick);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Silver;
            this.btn_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Clear.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold);
            this.btn_Clear.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Clear.Location = new System.Drawing.Point(335, 167);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(87, 87);
            this.btn_Clear.TabIndex = 6;
            this.btn_Clear.Text = "C";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            this.btn_Clear.MouseLeave += new System.EventHandler(this.Btn_Operation_MouseLeave);
            this.btn_Clear.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.BottomColor = System.Drawing.Color.Gray;
            this.gradientPanel1.Controls.Add(this.btnHistory);
            this.gradientPanel1.Controls.Add(this.lblInfo);
            this.gradientPanel1.Controls.Add(this.progressBar1);
            this.gradientPanel1.Controls.Add(this.lbl_Result);
            this.gradientPanel1.Location = new System.Drawing.Point(1, 1);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gradientPanel1.Size = new System.Drawing.Size(420, 171);
            this.gradientPanel1.TabIndex = 1;
            this.gradientPanel1.TopColor = System.Drawing.Color.LightSteelBlue;
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.Gray;
            this.btnHistory.BackgroundImage = global::CalculatorWinforms.Properties.Resources.history1;
            this.btnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHistory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.ForeColor = System.Drawing.Color.Transparent;
            this.btnHistory.Location = new System.Drawing.Point(378, 29);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(39, 35);
            this.btnHistory.TabIndex = 3;
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblInfo.Location = new System.Drawing.Point(0, 33);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(299, 37);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "The calculate is over";
            this.lblInfo.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.MarqueeAnimationSpeed = 50;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBar1.Size = new System.Drawing.Size(421, 23);
            this.progressBar1.Step = 20;
            this.progressBar1.TabIndex = 1;
            // 
            // lbl_Result
            // 
            this.lbl_Result.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Result.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl_Result.Font = new System.Drawing.Font("Copperplate Gothic Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Result.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Result.Location = new System.Drawing.Point(24, 98);
            this.lbl_Result.MaximumSize = new System.Drawing.Size(397, 53);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Result.Size = new System.Drawing.Size(397, 53);
            this.lbl_Result.TabIndex = 0;
            this.lbl_Result.Text = "0";
            this.lbl_Result.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_Result.UseMnemonic = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(424, 507);
            this.Controls.Add(this.btn_Equal);
            this.Controls.Add(this.btn_Dot);
            this.Controls.Add(this.btn_Pos_Neg);
            this.Controls.Add(this.btn_Num0);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Subtract);
            this.Controls.Add(this.btn_Num3);
            this.Controls.Add(this.btn_Num2);
            this.Controls.Add(this.btn_Num1);
            this.Controls.Add(this.btn_Multiply);
            this.Controls.Add(this.btn_Divide);
            this.Controls.Add(this.btn_Num6);
            this.Controls.Add(this.btn_Num5);
            this.Controls.Add(this.btn_Num4);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_All_Clear);
            this.Controls.Add(this.btn_Num9);
            this.Controls.Add(this.btn_Num8);
            this.Controls.Add(this.btn_Num7);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calculator";
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Button btn_Num7;
        private System.Windows.Forms.Button btn_Num8;
        private System.Windows.Forms.Button btn_Num9;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_All_Clear;
        private System.Windows.Forms.Button btn_Multiply;
        private System.Windows.Forms.Button btn_Divide;
        private System.Windows.Forms.Button btn_Num6;
        private System.Windows.Forms.Button btn_Num5;
        private System.Windows.Forms.Button btn_Num4;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Subtract;
        private System.Windows.Forms.Button btn_Num3;
        private System.Windows.Forms.Button btn_Num2;
        private System.Windows.Forms.Button btn_Num1;
        private System.Windows.Forms.Button btn_Num0;
        private System.Windows.Forms.Button btn_Pos_Neg;
        private System.Windows.Forms.Button btn_Dot;
        private System.Windows.Forms.Button btn_Equal;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnHistory;
    }
}

