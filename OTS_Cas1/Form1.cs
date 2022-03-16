using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS_Cas1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gbxTime.Visible = false;
            groupBox1.Visible = true;
            label1.Text = "pounds";
            label2.Text = "kg";
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gbxTime.Visible = false;
            groupBox1.Visible = true;
            label1.Text = "feet";
            label2.Text = "m";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (rbtnMass.Checked)
            {
                MassConverter converter = new MassConverter();
                if (rbtnArray.Checked)
                {
                    try
                    {
                        textBox2.Text = converter.ConvertArray(textBox1.Text).ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Invalid input! Try again with numbered value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        textBox2.Text = converter.Convert(Double.Parse(textBox1.Text)).ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Invalid input! Try again with numbered value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (rbtnLength.Checked)
            {
                LengthConverter converter = new LengthConverter();
                if (rbtnArray.Checked)
                {
                    try
                    {
                        textBox2.Text = converter.ConvertArray(textBox1.Text).ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Invalid input! Try again with numbered value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        textBox2.Text = converter.Convert(Double.Parse(textBox1.Text)).ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Invalid input! Try again with numbered value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (rbtnMoney.Checked)
            {
                MoneyConventer converter = new MoneyConventer();
                if (rbtnArray.Checked)
                {
                    try
                    {
                        textBox2.Text = converter.ConvertArray(textBox1.Text).ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Invalid input! Try again with numbered value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        textBox2.Text = converter.Convert(Double.Parse(textBox1.Text)).ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Invalid input! Try again with numbered value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (rbtnTime.Checked)
            {
                TimeConventer converter = new TimeConventer();
                try
                {
                    if (rbtnHours.Checked)
                    {
                        textBox2.Text = converter.ConvertHours(Double.Parse(textBox1.Text)).ToString();
                    }
                    else if (rbtnMinutes.Checked)
                    {
                        textBox2.Text = converter.ConvertMinutes(Double.Parse(textBox1.Text)).ToString();
                    }
                    else if (rbtnSeconds.Checked)
                    {
                        textBox2.Text = converter.ConvertSeconds(Double.Parse(textBox1.Text)).ToString();
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid input! Try again with numbered value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rbtnCustomMoney.Checked)
            {
                CustomMoneyConventer converter = new CustomMoneyConventer();
                try
                {
                    textBox2.Text = converter.ConvertCustomMoney(textBox1.Text).ToString();
                }
                catch
                {
                    MessageBox.Show("Invalid input! Try again with numbered value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RbtnMoney_CheckedChanged(object sender, EventArgs e)
        {
            gbxTime.Visible = false;
            groupBox1.Visible = true;
            label1.Text = "eur";
            label2.Text = "rsd";
        }

        private void RbtnTime_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "days";
            gbxTime.Visible = true;
            groupBox1.Visible = false;
            if (rbtnHours.Checked)
            {
                label2.Text = "hours";
            }
            else if (rbtnMinutes.Checked)
            {
                label2.Text = "minutes";
            }
            else
            {
                label2.Text = "seconds";
            }
        }

        private void RbtnCustomMoney_CheckedChanged(object sender, EventArgs e)
        {
            gbxTime.Visible = false;
            groupBox1.Visible = false;
            label1.Text = "custom expression";
            label2.Text = "result";
        }
    }
}
