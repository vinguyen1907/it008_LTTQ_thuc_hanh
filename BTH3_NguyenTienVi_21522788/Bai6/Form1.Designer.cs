namespace Bai6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.BtnBackspace = new System.Windows.Forms.Button();
            this.BtnCE = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnMC = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnEqual = new System.Windows.Forms.Button();
            this.BtnSqrt = new System.Windows.Forms.Button();
            this.Btn1x = new System.Windows.Forms.Button();
            this.BtnMod = new System.Windows.Forms.Button();
            this.BtnAddtraction = new System.Windows.Forms.Button();
            this.BtnDivision = new System.Windows.Forms.Button();
            this.BtnSubstraction = new System.Windows.Forms.Button();
            this.BtnMultiply = new System.Windows.Forms.Button();
            this.BtnPoint = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.BtnReverseSign = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnMPlus = new System.Windows.Forms.Button();
            this.BtnMS = new System.Windows.Forms.Button();
            this.BtnMR = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(447, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(12, 31);
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.Size = new System.Drawing.Size(424, 27);
            this.TxtDisplay.TabIndex = 1;
            this.TxtDisplay.Text = "0";
            this.TxtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnBackspace
            // 
            this.BtnBackspace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBackspace.Location = new System.Drawing.Point(132, 11);
            this.BtnBackspace.Name = "BtnBackspace";
            this.BtnBackspace.Size = new System.Drawing.Size(90, 40);
            this.BtnBackspace.TabIndex = 2;
            this.BtnBackspace.Text = "Backspace";
            this.BtnBackspace.UseVisualStyleBackColor = true;
            // 
            // BtnCE
            // 
            this.BtnCE.Location = new System.Drawing.Point(228, 11);
            this.BtnCE.Name = "BtnCE";
            this.BtnCE.Size = new System.Drawing.Size(90, 40);
            this.BtnCE.TabIndex = 3;
            this.BtnCE.Text = "CE";
            this.BtnCE.UseVisualStyleBackColor = true;
            this.BtnCE.Click += new System.EventHandler(this.BtnCE_Click);
            // 
            // BtnC
            // 
            this.BtnC.Location = new System.Drawing.Point(324, 11);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(90, 40);
            this.BtnC.TabIndex = 4;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = true;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnMC
            // 
            this.BtnMC.ForeColor = System.Drawing.Color.Red;
            this.BtnMC.Location = new System.Drawing.Point(7, 6);
            this.BtnMC.Margin = new System.Windows.Forms.Padding(3, 5, 10, 3);
            this.BtnMC.Name = "BtnMC";
            this.BtnMC.Size = new System.Drawing.Size(60, 40);
            this.BtnMC.TabIndex = 5;
            this.BtnMC.Text = "MC";
            this.BtnMC.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 273);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.BtnEqual);
            this.panel4.Controls.Add(this.BtnSqrt);
            this.panel4.Controls.Add(this.Btn1x);
            this.panel4.Controls.Add(this.BtnMod);
            this.panel4.Controls.Add(this.BtnAddtraction);
            this.panel4.Controls.Add(this.BtnDivision);
            this.panel4.Controls.Add(this.BtnSubstraction);
            this.panel4.Controls.Add(this.BtnMultiply);
            this.panel4.Controls.Add(this.BtnPoint);
            this.panel4.Controls.Add(this.Btn9);
            this.panel4.Controls.Add(this.Btn3);
            this.panel4.Controls.Add(this.Btn6);
            this.panel4.Controls.Add(this.BtnReverseSign);
            this.panel4.Controls.Add(this.Btn8);
            this.panel4.Controls.Add(this.Btn2);
            this.panel4.Controls.Add(this.Btn5);
            this.panel4.Controls.Add(this.Btn0);
            this.panel4.Controls.Add(this.Btn7);
            this.panel4.Controls.Add(this.Btn1);
            this.panel4.Controls.Add(this.Btn4);
            this.panel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel4.Location = new System.Drawing.Point(83, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(341, 207);
            this.panel4.TabIndex = 10;
            // 
            // BtnEqual
            // 
            this.BtnEqual.ForeColor = System.Drawing.Color.Red;
            this.BtnEqual.Location = new System.Drawing.Point(271, 150);
            this.BtnEqual.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.BtnEqual.Name = "BtnEqual";
            this.BtnEqual.Size = new System.Drawing.Size(60, 40);
            this.BtnEqual.TabIndex = 24;
            this.BtnEqual.Text = "=";
            this.BtnEqual.UseVisualStyleBackColor = true;
            this.BtnEqual.Click += new System.EventHandler(this.BtnEqual_Click);
            // 
            // BtnSqrt
            // 
            this.BtnSqrt.ForeColor = System.Drawing.Color.Blue;
            this.BtnSqrt.Location = new System.Drawing.Point(271, 6);
            this.BtnSqrt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.BtnSqrt.Name = "BtnSqrt";
            this.BtnSqrt.Size = new System.Drawing.Size(60, 40);
            this.BtnSqrt.TabIndex = 21;
            this.BtnSqrt.Text = "sqrt";
            this.BtnSqrt.UseVisualStyleBackColor = true;
            // 
            // Btn1x
            // 
            this.Btn1x.ForeColor = System.Drawing.Color.Blue;
            this.Btn1x.Location = new System.Drawing.Point(271, 102);
            this.Btn1x.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.Btn1x.Name = "Btn1x";
            this.Btn1x.Size = new System.Drawing.Size(60, 40);
            this.Btn1x.TabIndex = 23;
            this.Btn1x.Text = "1/x";
            this.Btn1x.UseVisualStyleBackColor = true;
            // 
            // BtnMod
            // 
            this.BtnMod.ForeColor = System.Drawing.Color.Blue;
            this.BtnMod.Location = new System.Drawing.Point(271, 54);
            this.BtnMod.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.BtnMod.Name = "BtnMod";
            this.BtnMod.Size = new System.Drawing.Size(60, 40);
            this.BtnMod.TabIndex = 22;
            this.BtnMod.Text = "%";
            this.BtnMod.UseVisualStyleBackColor = true;
            // 
            // BtnAddtraction
            // 
            this.BtnAddtraction.ForeColor = System.Drawing.Color.Red;
            this.BtnAddtraction.Location = new System.Drawing.Point(205, 150);
            this.BtnAddtraction.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.BtnAddtraction.Name = "BtnAddtraction";
            this.BtnAddtraction.Size = new System.Drawing.Size(60, 40);
            this.BtnAddtraction.TabIndex = 20;
            this.BtnAddtraction.Text = "+";
            this.BtnAddtraction.UseVisualStyleBackColor = true;
            this.BtnAddtraction.Click += new System.EventHandler(this.BtnOperator_Click);
            // 
            // BtnDivision
            // 
            this.BtnDivision.ForeColor = System.Drawing.Color.Red;
            this.BtnDivision.Location = new System.Drawing.Point(205, 6);
            this.BtnDivision.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.BtnDivision.Name = "BtnDivision";
            this.BtnDivision.Size = new System.Drawing.Size(60, 40);
            this.BtnDivision.TabIndex = 17;
            this.BtnDivision.Text = "/";
            this.BtnDivision.UseVisualStyleBackColor = true;
            this.BtnDivision.Click += new System.EventHandler(this.BtnOperator_Click);
            // 
            // BtnSubstraction
            // 
            this.BtnSubstraction.ForeColor = System.Drawing.Color.Red;
            this.BtnSubstraction.Location = new System.Drawing.Point(205, 102);
            this.BtnSubstraction.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.BtnSubstraction.Name = "BtnSubstraction";
            this.BtnSubstraction.Size = new System.Drawing.Size(60, 40);
            this.BtnSubstraction.TabIndex = 19;
            this.BtnSubstraction.Text = "-";
            this.BtnSubstraction.UseVisualStyleBackColor = true;
            this.BtnSubstraction.Click += new System.EventHandler(this.BtnOperator_Click);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.ForeColor = System.Drawing.Color.Red;
            this.BtnMultiply.Location = new System.Drawing.Point(205, 54);
            this.BtnMultiply.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(60, 40);
            this.BtnMultiply.TabIndex = 18;
            this.BtnMultiply.Text = "*";
            this.BtnMultiply.UseVisualStyleBackColor = true;
            this.BtnMultiply.Click += new System.EventHandler(this.BtnOperator_Click);
            // 
            // BtnPoint
            // 
            this.BtnPoint.ForeColor = System.Drawing.Color.Blue;
            this.BtnPoint.Location = new System.Drawing.Point(139, 150);
            this.BtnPoint.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.BtnPoint.Name = "BtnPoint";
            this.BtnPoint.Size = new System.Drawing.Size(60, 40);
            this.BtnPoint.TabIndex = 16;
            this.BtnPoint.Text = ".";
            this.BtnPoint.UseVisualStyleBackColor = true;
            this.BtnPoint.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn9
            // 
            this.Btn9.ForeColor = System.Drawing.Color.Blue;
            this.Btn9.Location = new System.Drawing.Point(139, 6);
            this.Btn9.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(60, 40);
            this.Btn9.TabIndex = 13;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn3
            // 
            this.Btn3.ForeColor = System.Drawing.Color.Blue;
            this.Btn3.Location = new System.Drawing.Point(139, 102);
            this.Btn3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(60, 40);
            this.Btn3.TabIndex = 15;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn6
            // 
            this.Btn6.ForeColor = System.Drawing.Color.Blue;
            this.Btn6.Location = new System.Drawing.Point(139, 54);
            this.Btn6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(60, 40);
            this.Btn6.TabIndex = 14;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnReverseSign
            // 
            this.BtnReverseSign.ForeColor = System.Drawing.Color.Blue;
            this.BtnReverseSign.Location = new System.Drawing.Point(73, 150);
            this.BtnReverseSign.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.BtnReverseSign.Name = "BtnReverseSign";
            this.BtnReverseSign.Size = new System.Drawing.Size(60, 40);
            this.BtnReverseSign.TabIndex = 12;
            this.BtnReverseSign.Text = "+/-";
            this.BtnReverseSign.UseVisualStyleBackColor = true;
            this.BtnReverseSign.Click += new System.EventHandler(this.BtnReverseSign_Click);
            // 
            // Btn8
            // 
            this.Btn8.ForeColor = System.Drawing.Color.Blue;
            this.Btn8.Location = new System.Drawing.Point(73, 6);
            this.Btn8.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(60, 40);
            this.Btn8.TabIndex = 9;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn2
            // 
            this.Btn2.ForeColor = System.Drawing.Color.Blue;
            this.Btn2.Location = new System.Drawing.Point(73, 102);
            this.Btn2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(60, 40);
            this.Btn2.TabIndex = 11;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn5
            // 
            this.Btn5.ForeColor = System.Drawing.Color.Blue;
            this.Btn5.Location = new System.Drawing.Point(73, 54);
            this.Btn5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(60, 40);
            this.Btn5.TabIndex = 10;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn0
            // 
            this.Btn0.ForeColor = System.Drawing.Color.Blue;
            this.Btn0.Location = new System.Drawing.Point(7, 150);
            this.Btn0.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(60, 40);
            this.Btn0.TabIndex = 8;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn7
            // 
            this.Btn7.ForeColor = System.Drawing.Color.Blue;
            this.Btn7.Location = new System.Drawing.Point(7, 6);
            this.Btn7.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(60, 40);
            this.Btn7.TabIndex = 5;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn1
            // 
            this.Btn1.ForeColor = System.Drawing.Color.Blue;
            this.Btn1.Location = new System.Drawing.Point(7, 102);
            this.Btn1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(60, 40);
            this.Btn1.TabIndex = 7;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn4
            // 
            this.Btn4.ForeColor = System.Drawing.Color.Blue;
            this.Btn4.Location = new System.Drawing.Point(7, 54);
            this.Btn4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(60, 40);
            this.Btn4.TabIndex = 6;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnC);
            this.panel3.Controls.Add(this.BtnBackspace);
            this.panel3.Controls.Add(this.BtnCE);
            this.panel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel3.ForeColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(424, 54);
            this.panel3.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.BtnMPlus);
            this.panel2.Controls.Add(this.BtnMC);
            this.panel2.Controls.Add(this.BtnMS);
            this.panel2.Controls.Add(this.BtnMR);
            this.panel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(3, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(98, 207);
            this.panel2.TabIndex = 9;
            // 
            // BtnMPlus
            // 
            this.BtnMPlus.ForeColor = System.Drawing.Color.Red;
            this.BtnMPlus.Location = new System.Drawing.Point(7, 150);
            this.BtnMPlus.Margin = new System.Windows.Forms.Padding(3, 5, 10, 3);
            this.BtnMPlus.Name = "BtnMPlus";
            this.BtnMPlus.Size = new System.Drawing.Size(60, 40);
            this.BtnMPlus.TabIndex = 8;
            this.BtnMPlus.Text = "M+";
            this.BtnMPlus.UseVisualStyleBackColor = true;
            // 
            // BtnMS
            // 
            this.BtnMS.ForeColor = System.Drawing.Color.Red;
            this.BtnMS.Location = new System.Drawing.Point(7, 102);
            this.BtnMS.Margin = new System.Windows.Forms.Padding(3, 5, 10, 3);
            this.BtnMS.Name = "BtnMS";
            this.BtnMS.Size = new System.Drawing.Size(60, 40);
            this.BtnMS.TabIndex = 7;
            this.BtnMS.Text = "MS";
            this.BtnMS.UseVisualStyleBackColor = true;
            // 
            // BtnMR
            // 
            this.BtnMR.ForeColor = System.Drawing.Color.Red;
            this.BtnMR.Location = new System.Drawing.Point(7, 54);
            this.BtnMR.Margin = new System.Windows.Forms.Padding(3, 5, 10, 3);
            this.BtnMR.Name = "BtnMR";
            this.BtnMR.Size = new System.Drawing.Size(60, 40);
            this.BtnMR.TabIndex = 6;
            this.BtnMR.Text = "MR";
            this.BtnMR.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 350);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private TextBox TxtDisplay;
        private Button BtnBackspace;
        private Button BtnCE;
        private Button BtnC;
        private Button BtnMC;
        private Panel panel1;
        private Panel panel4;
        private Button BtnEqual;
        private Button BtnSqrt;
        private Button Btn1x;
        private Button BtnMod;
        private Button BtnAddtraction;
        private Button BtnDivision;
        private Button BtnSubstraction;
        private Button BtnMultiply;
        private Button BtnPoint;
        private Button Btn9;
        private Button Btn3;
        private Button Btn6;
        private Button BtnReverseSign;
        private Button Btn8;
        private Button Btn2;
        private Button Btn5;
        private Button Btn0;
        private Button Btn7;
        private Button Btn1;
        private Button Btn4;
        private Panel panel3;
        private Panel panel2;
        private Button BtnMPlus;
        private Button BtnMS;
        private Button BtnMR;
    }
}