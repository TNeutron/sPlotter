namespace sPlotter
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
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel4 = new Panel();
            numericUpDown2 = new NumericUpDown();
            label9 = new Label();
            checkBox_MedF = new CheckBox();
            label3 = new Label();
            panel1 = new Panel();
            checkBox_MAV = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            panel2 = new Panel();
            RC_txtBox = new TextBox();
            checkBox_LPF = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            dT_txtBox = new TextBox();
            panel3 = new Panel();
            checkBox_HPF = new CheckBox();
            hpf_RC_txtbx = new TextBox();
            hpf_dT_txtbx = new TextBox();
            label7 = new Label();
            label6 = new Label();
            tabPage2 = new TabPage();
            label8 = new Label();
            FFT_window_size_NumUpDn = new NumericUpDown();
            checkedListBox4 = new CheckedListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FFT_window_size_NumUpDn).BeginInit();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(597, 12);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(1022, 362);
            formsPlot1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(1482, 415);
            button1.Name = "button1";
            button1.Size = new Size(104, 23);
            button1.TabIndex = 1;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            richTextBox1.Location = new Point(298, 25);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(270, 320);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(365, 411);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            comboBox1.MouseClick += comboBox1_MouseClick;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "4800", "9600", "19200", "38400", "57600", "115200", "230400", "460800", "921600" });
            comboBox2.Location = new Point(1070, 415);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 4;
            comboBox2.Text = "9600";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(299, 414);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 5;
            label1.Text = "COM Port";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(1000, 419);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 6;
            label2.Text = "BAUD Rate";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Location = new Point(298, 351);
            button2.Name = "button2";
            button2.Size = new Size(78, 23);
            button2.TabIndex = 7;
            button2.Text = "Save as CSV";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(280, 426);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(272, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Time Domain";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(numericUpDown2);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(checkBox_MedF);
            panel4.Location = new Point(6, 212);
            panel4.Name = "panel4";
            panel4.Size = new Size(260, 55);
            panel4.TabIndex = 20;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(92, 23);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(121, 23);
            numericUpDown2.TabIndex = 2;
            numericUpDown2.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 25);
            label9.Name = "label9";
            label9.Size = new Size(74, 15);
            label9.TabIndex = 1;
            label9.Text = "Window Size";
            // 
            // checkBox_MedF
            // 
            checkBox_MedF.AutoSize = true;
            checkBox_MedF.Location = new Point(12, 3);
            checkBox_MedF.Name = "checkBox_MedF";
            checkBox_MedF.Size = new Size(95, 19);
            checkBox_MedF.TabIndex = 0;
            checkBox_MedF.Text = "Median Filter";
            checkBox_MedF.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 38);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 3;
            label3.Text = "Window Size";
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBox_MAV);
            panel1.Controls.Add(numericUpDown1);
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 63);
            panel1.TabIndex = 17;
            // 
            // checkBox_MAV
            // 
            checkBox_MAV.AutoSize = true;
            checkBox_MAV.Location = new Point(11, 10);
            checkBox_MAV.Name = "checkBox_MAV";
            checkBox_MAV.Size = new Size(113, 19);
            checkBox_MAV.TabIndex = 16;
            checkBox_MAV.Text = "Moving Average";
            checkBox_MAV.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(92, 30);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(121, 23);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // panel2
            // 
            panel2.Controls.Add(RC_txtBox);
            panel2.Controls.Add(checkBox_LPF);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dT_txtBox);
            panel2.Location = new Point(6, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 64);
            panel2.TabIndex = 18;
            // 
            // RC_txtBox
            // 
            RC_txtBox.Location = new Point(45, 28);
            RC_txtBox.Name = "RC_txtBox";
            RC_txtBox.Size = new Size(73, 23);
            RC_txtBox.TabIndex = 5;
            // 
            // checkBox_LPF
            // 
            checkBox_LPF.AutoSize = true;
            checkBox_LPF.Location = new Point(11, 9);
            checkBox_LPF.Name = "checkBox_LPF";
            checkBox_LPF.Size = new Size(103, 19);
            checkBox_LPF.TabIndex = 14;
            checkBox_LPF.Text = "Low Pass Filter";
            checkBox_LPF.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 31);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 6;
            label4.Text = "RC";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(126, 31);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 7;
            label5.Text = "dT";
            // 
            // dT_txtBox
            // 
            dT_txtBox.Location = new Point(152, 28);
            dT_txtBox.Name = "dT_txtBox";
            dT_txtBox.Size = new Size(91, 23);
            dT_txtBox.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Controls.Add(checkBox_HPF);
            panel3.Controls.Add(hpf_RC_txtbx);
            panel3.Controls.Add(hpf_dT_txtbx);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(6, 145);
            panel3.Name = "panel3";
            panel3.Size = new Size(260, 61);
            panel3.TabIndex = 19;
            // 
            // checkBox_HPF
            // 
            checkBox_HPF.AutoSize = true;
            checkBox_HPF.Location = new Point(11, 6);
            checkBox_HPF.Name = "checkBox_HPF";
            checkBox_HPF.Size = new Size(107, 19);
            checkBox_HPF.TabIndex = 15;
            checkBox_HPF.Text = "High Pass Filter";
            checkBox_HPF.UseVisualStyleBackColor = true;
            // 
            // hpf_RC_txtbx
            // 
            hpf_RC_txtbx.Location = new Point(45, 25);
            hpf_RC_txtbx.Name = "hpf_RC_txtbx";
            hpf_RC_txtbx.Size = new Size(73, 23);
            hpf_RC_txtbx.TabIndex = 10;
            // 
            // hpf_dT_txtbx
            // 
            hpf_dT_txtbx.Location = new Point(152, 25);
            hpf_dT_txtbx.Name = "hpf_dT_txtbx";
            hpf_dT_txtbx.Size = new Size(91, 23);
            hpf_dT_txtbx.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 28);
            label7.Name = "label7";
            label7.Size = new Size(22, 15);
            label7.TabIndex = 11;
            label7.Text = "RC";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(126, 28);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 12;
            label6.Text = "dT";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(FFT_window_size_NumUpDn);
            tabPage2.Controls.Add(checkedListBox4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(272, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Frequency Domain";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 29);
            label8.Name = "label8";
            label8.Size = new Size(74, 15);
            label8.TabIndex = 5;
            label8.Text = "Window Size";
            // 
            // FFT_window_size_NumUpDn
            // 
            FFT_window_size_NumUpDn.Location = new Point(100, 27);
            FFT_window_size_NumUpDn.Name = "FFT_window_size_NumUpDn";
            FFT_window_size_NumUpDn.Size = new Size(121, 23);
            FFT_window_size_NumUpDn.TabIndex = 4;
            FFT_window_size_NumUpDn.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // checkedListBox4
            // 
            checkedListBox4.FormattingEnabled = true;
            checkedListBox4.Items.AddRange(new object[] { "FFT" });
            checkedListBox4.Location = new Point(6, 6);
            checkedListBox4.Name = "checkedListBox4";
            checkedListBox4.Size = new Size(248, 58);
            checkedListBox4.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1631, 450);
            Controls.Add(tabControl1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(formsPlot1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FFT_window_size_NumUpDn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private Button button1;
        private RichTextBox richTextBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private Button button2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private TextBox dT_txtBox;
        private Label label5;
        private Label label4;
        private TextBox RC_txtBox;
        private TextBox hpf_dT_txtbx;
        private Label label6;
        private Label label7;
        private TextBox hpf_RC_txtbx;
        private Label label8;
        private NumericUpDown FFT_window_size_NumUpDn;
        private CheckedListBox checkedListBox4;
        private CheckBox checkBox_HPF;
        private CheckBox checkBox_LPF;
        private Panel panel1;
        private CheckBox checkBox_MAV;
        private Panel panel4;
        private Panel panel2;
        private Panel panel3;
        private NumericUpDown numericUpDown2;
        private Label label9;
        private CheckBox checkBox_MedF;
    }
}
