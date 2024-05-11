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
            dT_txtBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            RC_txtBox = new TextBox();
            checkedListBox2 = new CheckedListBox();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            checkedListBox1 = new CheckedListBox();
            tabPage2 = new TabPage();
            hpf_dT_txtbx = new TextBox();
            label6 = new Label();
            label7 = new Label();
            hpf_RC_txtbx = new TextBox();
            checkedListBox3 = new CheckedListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            tabPage1.Controls.Add(hpf_dT_txtbx);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(hpf_RC_txtbx);
            tabPage1.Controls.Add(checkedListBox3);
            tabPage1.Controls.Add(dT_txtBox);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(RC_txtBox);
            tabPage1.Controls.Add(checkedListBox2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(numericUpDown1);
            tabPage1.Controls.Add(checkedListBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(272, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Time Domain";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dT_txtBox
            // 
            dT_txtBox.Location = new Point(157, 94);
            dT_txtBox.Name = "dT_txtBox";
            dT_txtBox.Size = new Size(91, 23);
            dT_txtBox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(131, 97);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 7;
            label5.Text = "dT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 97);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 6;
            label4.Text = "RC";
            // 
            // RC_txtBox
            // 
            RC_txtBox.Location = new Point(42, 94);
            RC_txtBox.Name = "RC_txtBox";
            RC_txtBox.Size = new Size(73, 23);
            RC_txtBox.TabIndex = 5;
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "Low Pass Filter" });
            checkedListBox2.Location = new Point(6, 70);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(260, 58);
            checkedListBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 33);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 3;
            label3.Text = "Window Size";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(106, 31);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(121, 23);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Moving Average" });
            checkedListBox1.Location = new Point(6, 6);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(260, 58);
            checkedListBox1.TabIndex = 2;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(272, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Frequency Domain";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // hpf_dT_txtbx
            // 
            hpf_dT_txtbx.Location = new Point(157, 158);
            hpf_dT_txtbx.Name = "hpf_dT_txtbx";
            hpf_dT_txtbx.Size = new Size(91, 23);
            hpf_dT_txtbx.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(131, 161);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 12;
            label6.Text = "dT";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 161);
            label7.Name = "label7";
            label7.Size = new Size(22, 15);
            label7.TabIndex = 11;
            label7.Text = "RC";
            // 
            // hpf_RC_txtbx
            // 
            hpf_RC_txtbx.Location = new Point(42, 158);
            hpf_RC_txtbx.Name = "hpf_RC_txtbx";
            hpf_RC_txtbx.Size = new Size(73, 23);
            hpf_RC_txtbx.TabIndex = 10;
            // 
            // checkedListBox3
            // 
            checkedListBox3.FormattingEnabled = true;
            checkedListBox3.Items.AddRange(new object[] { "High Pass Filter" });
            checkedListBox3.Location = new Point(6, 134);
            checkedListBox3.Name = "checkedListBox3";
            checkedListBox3.Size = new Size(260, 58);
            checkedListBox3.TabIndex = 9;
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
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
        private CheckedListBox checkedListBox1;
        private CheckedListBox checkedListBox2;
        private TextBox dT_txtBox;
        private Label label5;
        private Label label4;
        private TextBox RC_txtBox;
        private TextBox hpf_dT_txtbx;
        private Label label6;
        private Label label7;
        private TextBox hpf_RC_txtbx;
        private CheckedListBox checkedListBox3;
    }
}
