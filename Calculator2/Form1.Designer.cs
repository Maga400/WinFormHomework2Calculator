namespace Calculator2
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
            panel1 = new Panel();
            panel2 = new Panel();
            resultTextBox = new TextBox();
            panel3 = new Panel();
            ceButton = new Button();
            pointButton = new Button();
            button0 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            equalButton = new Button();
            additionButtonadditionButton = new Button();
            emissionButton = new Button();
            multiplicationButton = new Button();
            divisonButton = new Button();
            cButton = new Button();
            resultLabel = new Label();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(415, 5);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.OrangeRed;
            panel2.Location = new Point(24, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(376, 28);
            panel2.TabIndex = 1;
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(24, 108);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.RightToLeft = RightToLeft.No;
            resultTextBox.Size = new Size(376, 119);
            resultTextBox.TabIndex = 2;
            resultTextBox.Text = "0";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.Controls.Add(ceButton);
            panel3.Controls.Add(pointButton);
            panel3.Controls.Add(button0);
            panel3.Controls.Add(button9);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(equalButton);
            panel3.Controls.Add(additionButtonadditionButton);
            panel3.Controls.Add(emissionButton);
            panel3.Controls.Add(multiplicationButton);
            panel3.Controls.Add(divisonButton);
            panel3.Controls.Add(cButton);
            panel3.Location = new Point(24, 247);
            panel3.Name = "panel3";
            panel3.Size = new Size(376, 317);
            panel3.TabIndex = 3;
            // 
            // ceButton
            // 
            ceButton.BackColor = SystemColors.ButtonHighlight;
            ceButton.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            ceButton.ForeColor = Color.OrangeRed;
            ceButton.Location = new Point(191, 3);
            ceButton.Name = "ceButton";
            ceButton.Size = new Size(82, 55);
            ceButton.TabIndex = 30;
            ceButton.Text = "CE";
            ceButton.UseVisualStyleBackColor = false;
            ceButton.Click += ceButton_Click;
            // 
            // pointButton
            // 
            pointButton.BackColor = SystemColors.ButtonHighlight;
            pointButton.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            pointButton.ForeColor = SystemColors.ActiveCaptionText;
            pointButton.Location = new Point(191, 244);
            pointButton.Name = "pointButton";
            pointButton.Size = new Size(82, 55);
            pointButton.TabIndex = 29;
            pointButton.Text = ".";
            pointButton.UseVisualStyleBackColor = false;
            pointButton.Click += pointButton_Click;
            // 
            // button0
            // 
            button0.BackColor = SystemColors.ButtonHighlight;
            button0.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button0.ForeColor = SystemColors.ActiveCaptionText;
            button0.Location = new Point(15, 244);
            button0.Name = "button0";
            button0.Size = new Size(170, 55);
            button0.TabIndex = 28;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += numsEvent;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ButtonHighlight;
            button9.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = SystemColors.ActiveCaptionText;
            button9.Location = new Point(191, 64);
            button9.Name = "button9";
            button9.Size = new Size(82, 55);
            button9.TabIndex = 27;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += numsEvent;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ButtonHighlight;
            button8.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.ActiveCaptionText;
            button8.Location = new Point(103, 64);
            button8.Name = "button8";
            button8.Size = new Size(82, 55);
            button8.TabIndex = 26;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += numsEvent;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ButtonHighlight;
            button7.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ActiveCaptionText;
            button7.Location = new Point(15, 64);
            button7.Name = "button7";
            button7.Size = new Size(82, 55);
            button7.TabIndex = 25;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += numsEvent;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonHighlight;
            button6.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ActiveCaptionText;
            button6.Location = new Point(191, 125);
            button6.Name = "button6";
            button6.Size = new Size(82, 55);
            button6.TabIndex = 24;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += numsEvent;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonHighlight;
            button5.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(103, 125);
            button5.Name = "button5";
            button5.Size = new Size(82, 55);
            button5.TabIndex = 23;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += numsEvent;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(15, 125);
            button4.Name = "button4";
            button4.Size = new Size(82, 55);
            button4.TabIndex = 22;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += numsEvent;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(191, 186);
            button3.Name = "button3";
            button3.Size = new Size(82, 55);
            button3.TabIndex = 21;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += numsEvent;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(103, 186);
            button2.Name = "button2";
            button2.Size = new Size(82, 55);
            button2.TabIndex = 20;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += numsEvent;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(15, 183);
            button1.Name = "button1";
            button1.Size = new Size(82, 55);
            button1.TabIndex = 19;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += numsEvent;
            // 
            // equalButton
            // 
            equalButton.BackColor = SystemColors.ButtonHighlight;
            equalButton.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            equalButton.ForeColor = Color.OrangeRed;
            equalButton.Location = new Point(279, 244);
            equalButton.Name = "equalButton";
            equalButton.Size = new Size(82, 55);
            equalButton.TabIndex = 18;
            equalButton.Text = "=";
            equalButton.UseVisualStyleBackColor = false;
            equalButton.Click += equalButton_Click;
            // 
            // additionButtonadditionButton
            // 
            additionButtonadditionButton.BackColor = SystemColors.ButtonHighlight;
            additionButtonadditionButton.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            additionButtonadditionButton.ForeColor = Color.OrangeRed;
            additionButtonadditionButton.Location = new Point(279, 183);
            additionButtonadditionButton.Name = "additionButtonadditionButton";
            additionButtonadditionButton.Size = new Size(82, 55);
            additionButtonadditionButton.TabIndex = 17;
            additionButtonadditionButton.Text = "+";
            additionButtonadditionButton.UseVisualStyleBackColor = false;
            additionButtonadditionButton.Click += opertionsEvent;
            // 
            // emissionButton
            // 
            emissionButton.BackColor = SystemColors.ButtonHighlight;
            emissionButton.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            emissionButton.ForeColor = Color.OrangeRed;
            emissionButton.Location = new Point(279, 125);
            emissionButton.Name = "emissionButton";
            emissionButton.Size = new Size(82, 55);
            emissionButton.TabIndex = 16;
            emissionButton.Text = "-";
            emissionButton.UseVisualStyleBackColor = false;
            emissionButton.Click += opertionsEvent;
            // 
            // multiplicationButton
            // 
            multiplicationButton.BackColor = SystemColors.ButtonHighlight;
            multiplicationButton.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            multiplicationButton.ForeColor = Color.OrangeRed;
            multiplicationButton.Location = new Point(279, 64);
            multiplicationButton.Name = "multiplicationButton";
            multiplicationButton.Size = new Size(82, 55);
            multiplicationButton.TabIndex = 15;
            multiplicationButton.Text = "X";
            multiplicationButton.UseVisualStyleBackColor = false;
            multiplicationButton.Click += opertionsEvent;
            // 
            // divisonButton
            // 
            divisonButton.BackColor = SystemColors.ButtonHighlight;
            divisonButton.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            divisonButton.ForeColor = Color.OrangeRed;
            divisonButton.Location = new Point(279, 3);
            divisonButton.Name = "divisonButton";
            divisonButton.Size = new Size(82, 55);
            divisonButton.TabIndex = 14;
            divisonButton.Text = "/";
            divisonButton.UseVisualStyleBackColor = false;
            divisonButton.Click += opertionsEvent;
            // 
            // cButton
            // 
            cButton.BackColor = SystemColors.ButtonHighlight;
            cButton.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            cButton.ForeColor = Color.OrangeRed;
            cButton.Location = new Point(15, 0);
            cButton.Name = "cButton";
            cButton.Size = new Size(170, 55);
            cButton.TabIndex = 0;
            cButton.Text = "C";
            cButton.UseVisualStyleBackColor = false;
            cButton.Click += cButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(25, 47);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 20);
            resultLabel.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 576);
            Controls.Add(resultLabel);
            Controls.Add(panel3);
            Controls.Add(resultTextBox);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox resultTextBox;
        private Panel panel3;
        private Button cButton;
        private Button button8;
        private Button emissionButton;
        private Button multiplicationButton;
        private Button divisonButton;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button equalButton;
        private Button additionButtonadditionButton;
        private Button button10;
        private Button button9;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button pointButton;
        private Button button0;
        private Label resultLabel;
        private Button ceButton;
    }
}