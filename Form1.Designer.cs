namespace Ccs_Lab3_01
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxHue = new TextBox();
            textBoxSaturation = new TextBox();
            textBoxValue = new TextBox();
            textBoxAmount = new TextBox();
            addRedButton = new Button();
            addGreenButton = new Button();
            addBlueButton = new Button();
            subtractRedButton = new Button();
            subtractGreenButton = new Button();
            subtrackBlueButton = new Button();
            addSaturationButton = new Button();
            subtrackSaturationButton = new Button();
            addBrightnessButton = new Button();
            subtrackBrightnessButton = new Button();
            finalColorPanel = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Cursor = Cursors.AppStarting;
            label1.Font = new Font("Viner Hand ITC", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(29, 12);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(309, 601);
            label1.TabIndex = 0;
            label1.Text = "Калор калькулэйшн";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 14F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(38, 87);
            label2.Name = "label2";
            label2.Size = new Size(177, 25);
            label2.TabIndex = 1;
            label2.Text = "Оттенок:";
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 14F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(38, 131);
            label3.Name = "label3";
            label3.Size = new Size(177, 25);
            label3.TabIndex = 2;
            label3.Text = "Насыщенность:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Times New Roman", 14F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(38, 180);
            label4.Name = "label4";
            label4.Size = new Size(177, 25);
            label4.TabIndex = 3;
            label4.Text = "Яркость:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Times New Roman", 14F);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(38, 230);
            label5.Name = "label5";
            label5.Size = new Size(177, 25);
            label5.TabIndex = 4;
            label5.Text = "Величина:";
            // 
            // textBoxHue
            // 
            textBoxHue.Location = new Point(212, 88);
            textBoxHue.Name = "textBoxHue";
            textBoxHue.Size = new Size(110, 27);
            textBoxHue.TabIndex = 5;
            textBoxHue.TextChanged += textBoxHue_TextChanged;
            // 
            // textBoxSaturation
            // 
            textBoxSaturation.Location = new Point(212, 131);
            textBoxSaturation.Name = "textBoxSaturation";
            textBoxSaturation.Size = new Size(110, 27);
            textBoxSaturation.TabIndex = 6;
            textBoxSaturation.TextChanged += textBoxSaturation_TextChanged;
            // 
            // textBoxValue
            // 
            textBoxValue.Location = new Point(212, 180);
            textBoxValue.Name = "textBoxValue";
            textBoxValue.Size = new Size(110, 27);
            textBoxValue.TabIndex = 7;
            textBoxValue.TextChanged += textBoxValue_TextChanged;
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(212, 230);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(110, 27);
            textBoxAmount.TabIndex = 8;
            textBoxAmount.TextChanged += textBoxAmount_TextChanged;
            // 
            // addRedButton
            // 
            addRedButton.BackColor = Color.Red;
            addRedButton.Location = new Point(38, 292);
            addRedButton.Name = "addRedButton";
            addRedButton.Size = new Size(135, 29);
            addRedButton.TabIndex = 9;
            addRedButton.Text = "Add Red";
            addRedButton.UseVisualStyleBackColor = false;
            addRedButton.Click += addRedButton_Click;
            // 
            // addGreenButton
            // 
            addGreenButton.BackColor = Color.Green;
            addGreenButton.Location = new Point(38, 327);
            addGreenButton.Name = "addGreenButton";
            addGreenButton.Size = new Size(135, 29);
            addGreenButton.TabIndex = 10;
            addGreenButton.Text = "Add Green";
            addGreenButton.UseVisualStyleBackColor = false;
            // 
            // addBlueButton
            // 
            addBlueButton.BackColor = Color.Blue;
            addBlueButton.ForeColor = Color.White;
            addBlueButton.Location = new Point(38, 362);
            addBlueButton.Name = "addBlueButton";
            addBlueButton.Size = new Size(135, 29);
            addBlueButton.TabIndex = 11;
            addBlueButton.Text = "Add Blue";
            addBlueButton.UseVisualStyleBackColor = false;
            // 
            // subtractRedButton
            // 
            subtractRedButton.BackColor = Color.FromArgb(255, 128, 128);
            subtractRedButton.Location = new Point(187, 292);
            subtractRedButton.Name = "subtractRedButton";
            subtractRedButton.Size = new Size(135, 29);
            subtractRedButton.TabIndex = 12;
            subtractRedButton.Text = "Subtrack Red";
            subtractRedButton.UseVisualStyleBackColor = false;
            subtractRedButton.Click += subtractRedButton_Click;
            // 
            // subtractGreenButton
            // 
            subtractGreenButton.BackColor = Color.FromArgb(0, 192, 0);
            subtractGreenButton.Location = new Point(187, 327);
            subtractGreenButton.Name = "subtractGreenButton";
            subtractGreenButton.Size = new Size(135, 29);
            subtractGreenButton.TabIndex = 13;
            subtractGreenButton.Text = "Subtrack Green";
            subtractGreenButton.UseVisualStyleBackColor = false;
            // 
            // subtrackBlueButton
            // 
            subtrackBlueButton.BackColor = Color.FromArgb(128, 128, 255);
            subtrackBlueButton.Location = new Point(187, 362);
            subtrackBlueButton.Name = "subtrackBlueButton";
            subtrackBlueButton.Size = new Size(135, 29);
            subtrackBlueButton.TabIndex = 14;
            subtrackBlueButton.Text = "Subtrack Blue";
            subtrackBlueButton.UseVisualStyleBackColor = false;
            // 
            // addSaturationButton
            // 
            addSaturationButton.Location = new Point(38, 397);
            addSaturationButton.Name = "addSaturationButton";
            addSaturationButton.Size = new Size(284, 29);
            addSaturationButton.TabIndex = 15;
            addSaturationButton.Text = "Добавить насыщенность";
            addSaturationButton.UseVisualStyleBackColor = true;
            // 
            // subtrackSaturationButton
            // 
            subtrackSaturationButton.Location = new Point(38, 432);
            subtrackSaturationButton.Name = "subtrackSaturationButton";
            subtrackSaturationButton.Size = new Size(284, 29);
            subtrackSaturationButton.TabIndex = 16;
            subtrackSaturationButton.Text = "Убрать насыщенность";
            subtrackSaturationButton.UseVisualStyleBackColor = true;
            // 
            // addBrightnessButton
            // 
            addBrightnessButton.Location = new Point(38, 467);
            addBrightnessButton.Name = "addBrightnessButton";
            addBrightnessButton.Size = new Size(284, 29);
            addBrightnessButton.TabIndex = 17;
            addBrightnessButton.Text = "Добавить яркости (не в жизни)";
            addBrightnessButton.UseVisualStyleBackColor = true;
            // 
            // subtrackBrightnessButton
            // 
            subtrackBrightnessButton.Location = new Point(38, 502);
            subtrackBrightnessButton.Name = "subtrackBrightnessButton";
            subtrackBrightnessButton.Size = new Size(284, 29);
            subtrackBrightnessButton.TabIndex = 18;
            subtrackBrightnessButton.Text = "Убрать яркости";
            subtrackBrightnessButton.UseVisualStyleBackColor = true;
            // 
            // finalColorPanel
            // 
            finalColorPanel.BorderStyle = BorderStyle.FixedSingle;
            finalColorPanel.Location = new Point(38, 537);
            finalColorPanel.Name = "finalColorPanel";
            finalColorPanel.Size = new Size(284, 63);
            finalColorPanel.TabIndex = 19;
            finalColorPanel.Paint += this.finalColorPanel;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InfoText;
            ClientSize = new Size(376, 625);
            Controls.Add(finalColorPanel);
            Controls.Add(subtrackBrightnessButton);
            Controls.Add(addBrightnessButton);
            Controls.Add(subtrackSaturationButton);
            Controls.Add(addSaturationButton);
            Controls.Add(subtrackBlueButton);
            Controls.Add(subtractGreenButton);
            Controls.Add(subtractRedButton);
            Controls.Add(addBlueButton);
            Controls.Add(addGreenButton);
            Controls.Add(addRedButton);
            Controls.Add(textBoxAmount);
            Controls.Add(textBoxValue);
            Controls.Add(textBoxSaturation);
            Controls.Add(textBoxHue);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxHue;
        private TextBox textBoxSaturation;
        private TextBox textBoxValue;
        private TextBox textBoxAmount;
        private Button addRedButton;
        private Button addGreenButton;
        private Button addBlueButton;
        private Button subtractRedButton;
        private Button subtractGreenButton;
        private Button subtrackBlueButton;
        private Button addSaturationButton;
        private Button subtrackSaturationButton;
        private Button addBrightnessButton;
        private Button subtrackBrightnessButton;
        private Panel finalColorPanel;
    }
}
