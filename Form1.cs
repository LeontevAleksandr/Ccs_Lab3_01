using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ccs_Lab3_01
{
    public partial class Form1 : Form
    {
        private HSVColor hsvColor;
        private Color panel;
        public Form1()
        {
            InitializeComponent();
            hsvColor = new HSVColor(0, 1, 1); // ��������� ����: ������� (0),
                                              // ������������ ������������ � �������
            UpdateColorValues();
        }

        private void UpdateColorValues()
        {
            // ���������� �������� � ��������� �����
            textBoxHue.Text = hsvColor.Hue.ToString();
            textBoxSaturation.Text = hsvColor.Saturation.ToString();
            textBoxValue.Text = hsvColor.Value.ToString();

            // ���������� ����� �� �����
            Color rgbColor = hsvColor.ToRGB().ToColor();
            finalColorPanel(rgbColor);  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void finalColorPanel(object sender, PaintEventArgs e)
        {
            panel.BackColor = color;
        }

        private void addRedButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(textBoxAmount.Text);
            hsvColor.AddRed(amount);
            UpdateColorValues();
        }

        private void subtractRedButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(textBoxAmount.Text);
            hsvColor.SubtractRed(amount);
            UpdateColorValues();
        }

        private void textBoxHue_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSaturation_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
