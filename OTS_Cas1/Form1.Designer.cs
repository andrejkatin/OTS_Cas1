namespace OTS_Cas1
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
            this.gbxType = new System.Windows.Forms.GroupBox();
            this.rbtnCustomMoney = new System.Windows.Forms.RadioButton();
            this.rbtnTime = new System.Windows.Forms.RadioButton();
            this.rbtnMoney = new System.Windows.Forms.RadioButton();
            this.rbtnLength = new System.Windows.Forms.RadioButton();
            this.rbtnMass = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbxTime = new System.Windows.Forms.GroupBox();
            this.rbtnSeconds = new System.Windows.Forms.RadioButton();
            this.rbtnMinutes = new System.Windows.Forms.RadioButton();
            this.rbtnHours = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnSingle = new System.Windows.Forms.RadioButton();
            this.rbtnArray = new System.Windows.Forms.RadioButton();
            this.gbxType.SuspendLayout();
            this.gbxTime.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxType
            // 
            this.gbxType.Controls.Add(this.rbtnCustomMoney);
            this.gbxType.Controls.Add(this.rbtnTime);
            this.gbxType.Controls.Add(this.rbtnMoney);
            this.gbxType.Controls.Add(this.rbtnLength);
            this.gbxType.Controls.Add(this.rbtnMass);
            this.gbxType.Location = new System.Drawing.Point(48, 45);
            this.gbxType.Name = "gbxType";
            this.gbxType.Size = new System.Drawing.Size(222, 110);
            this.gbxType.TabIndex = 0;
            this.gbxType.TabStop = false;
            this.gbxType.Text = "Conventer Type";
            // 
            // rbtnCustomMoney
            // 
            this.rbtnCustomMoney.AutoSize = true;
            this.rbtnCustomMoney.Location = new System.Drawing.Point(50, 80);
            this.rbtnCustomMoney.Name = "rbtnCustomMoney";
            this.rbtnCustomMoney.Size = new System.Drawing.Size(122, 21);
            this.rbtnCustomMoney.TabIndex = 4;
            this.rbtnCustomMoney.Text = "Custom money";
            this.rbtnCustomMoney.UseVisualStyleBackColor = true;
            this.rbtnCustomMoney.CheckedChanged += new System.EventHandler(this.RbtnCustomMoney_CheckedChanged);
            // 
            // rbtnTime
            // 
            this.rbtnTime.AutoSize = true;
            this.rbtnTime.Location = new System.Drawing.Point(123, 50);
            this.rbtnTime.Name = "rbtnTime";
            this.rbtnTime.Size = new System.Drawing.Size(60, 21);
            this.rbtnTime.TabIndex = 3;
            this.rbtnTime.Text = "Time";
            this.rbtnTime.UseVisualStyleBackColor = true;
            this.rbtnTime.CheckedChanged += new System.EventHandler(this.RbtnTime_CheckedChanged);
            // 
            // rbtnMoney
            // 
            this.rbtnMoney.AutoSize = true;
            this.rbtnMoney.Location = new System.Drawing.Point(123, 22);
            this.rbtnMoney.Name = "rbtnMoney";
            this.rbtnMoney.Size = new System.Drawing.Size(71, 21);
            this.rbtnMoney.TabIndex = 2;
            this.rbtnMoney.Text = "Money";
            this.rbtnMoney.UseVisualStyleBackColor = true;
            this.rbtnMoney.CheckedChanged += new System.EventHandler(this.RbtnMoney_CheckedChanged);
            // 
            // rbtnLength
            // 
            this.rbtnLength.AutoSize = true;
            this.rbtnLength.Location = new System.Drawing.Point(7, 50);
            this.rbtnLength.Name = "rbtnLength";
            this.rbtnLength.Size = new System.Drawing.Size(73, 21);
            this.rbtnLength.TabIndex = 1;
            this.rbtnLength.Text = "Length";
            this.rbtnLength.UseVisualStyleBackColor = true;
            this.rbtnLength.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // rbtnMass
            // 
            this.rbtnMass.AutoSize = true;
            this.rbtnMass.Checked = true;
            this.rbtnMass.Location = new System.Drawing.Point(7, 22);
            this.rbtnMass.Name = "rbtnMass";
            this.rbtnMass.Size = new System.Drawing.Size(62, 21);
            this.rbtnMass.TabIndex = 0;
            this.rbtnMass.TabStop = true;
            this.rbtnMass.Text = "Mass";
            this.rbtnMass.UseVisualStyleBackColor = true;
            this.rbtnMass.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(222, 233);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 22);
            this.textBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // gbxTime
            // 
            this.gbxTime.Controls.Add(this.rbtnSeconds);
            this.gbxTime.Controls.Add(this.rbtnMinutes);
            this.gbxTime.Controls.Add(this.rbtnHours);
            this.gbxTime.Location = new System.Drawing.Point(276, 46);
            this.gbxTime.Name = "gbxTime";
            this.gbxTime.Size = new System.Drawing.Size(200, 109);
            this.gbxTime.TabIndex = 6;
            this.gbxTime.TabStop = false;
            this.gbxTime.Text = "Time output";
            this.gbxTime.Visible = false;
            // 
            // rbtnSeconds
            // 
            this.rbtnSeconds.AutoSize = true;
            this.rbtnSeconds.Location = new System.Drawing.Point(7, 79);
            this.rbtnSeconds.Name = "rbtnSeconds";
            this.rbtnSeconds.Size = new System.Drawing.Size(84, 21);
            this.rbtnSeconds.TabIndex = 2;
            this.rbtnSeconds.TabStop = true;
            this.rbtnSeconds.Text = "Seconds";
            this.rbtnSeconds.UseVisualStyleBackColor = true;
            // 
            // rbtnMinutes
            // 
            this.rbtnMinutes.AutoSize = true;
            this.rbtnMinutes.Location = new System.Drawing.Point(7, 49);
            this.rbtnMinutes.Name = "rbtnMinutes";
            this.rbtnMinutes.Size = new System.Drawing.Size(78, 21);
            this.rbtnMinutes.TabIndex = 1;
            this.rbtnMinutes.TabStop = true;
            this.rbtnMinutes.Text = "Minutes";
            this.rbtnMinutes.UseVisualStyleBackColor = true;
            // 
            // rbtnHours
            // 
            this.rbtnHours.AutoSize = true;
            this.rbtnHours.Location = new System.Drawing.Point(7, 21);
            this.rbtnHours.Name = "rbtnHours";
            this.rbtnHours.Size = new System.Drawing.Size(67, 21);
            this.rbtnHours.TabIndex = 0;
            this.rbtnHours.TabStop = true;
            this.rbtnHours.Text = "Hours";
            this.rbtnHours.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnArray);
            this.groupBox1.Controls.Add(this.rbtnSingle);
            this.groupBox1.Location = new System.Drawing.Point(445, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 110);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Segment Type";
            // 
            // rbtnSingle
            // 
            this.rbtnSingle.AutoSize = true;
            this.rbtnSingle.Checked = true;
            this.rbtnSingle.Location = new System.Drawing.Point(7, 22);
            this.rbtnSingle.Name = "rbtnSingle";
            this.rbtnSingle.Size = new System.Drawing.Size(106, 21);
            this.rbtnSingle.TabIndex = 0;
            this.rbtnSingle.TabStop = true;
            this.rbtnSingle.Text = "Single value";
            this.rbtnSingle.UseVisualStyleBackColor = true;
            // 
            // rbtnArray
            // 
            this.rbtnArray.AutoSize = true;
            this.rbtnArray.Location = new System.Drawing.Point(7, 50);
            this.rbtnArray.Name = "rbtnArray";
            this.rbtnArray.Size = new System.Drawing.Size(124, 21);
            this.rbtnArray.TabIndex = 1;
            this.rbtnArray.Text = "Array of values";
            this.rbtnArray.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(657, 431);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxType.ResumeLayout(false);
            this.gbxType.PerformLayout();
            this.gbxTime.ResumeLayout(false);
            this.gbxTime.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxType;
        private System.Windows.Forms.RadioButton rbtnLength;
        private System.Windows.Forms.RadioButton rbtnMass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbtnCustomMoney;
        private System.Windows.Forms.RadioButton rbtnTime;
        private System.Windows.Forms.RadioButton rbtnMoney;
        private System.Windows.Forms.GroupBox gbxTime;
        private System.Windows.Forms.RadioButton rbtnSeconds;
        private System.Windows.Forms.RadioButton rbtnMinutes;
        private System.Windows.Forms.RadioButton rbtnHours;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnArray;
        private System.Windows.Forms.RadioButton rbtnSingle;
    }
}

