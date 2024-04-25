namespace FiresWinForms
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
            components = new System.ComponentModel.Container();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            button3 = new Button();
            label4 = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            listView1 = new ListView();
            counter = new ColumnHeader();
            time = new ColumnHeader();
            value = new ColumnHeader();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Info;
            textBox2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(6, 24);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(485, 39);
            textBox2.TabIndex = 0;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 32);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(65, 101);
            label3.Name = "label3";
            label3.Size = new Size(117, 21);
            label3.TabIndex = 5;
            label3.Text = "Aktuálne dáta";
            label3.Click += label3_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(43, 174);
            button3.Name = "button3";
            button3.Size = new Size(160, 41);
            button3.TabIndex = 7;
            button3.Text = "ZAČAŤ MERANIE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(0, 96);
            label4.Name = "label4";
            label4.Size = new Size(784, 2);
            label4.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 81);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pripojenie k zariadeniu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 18);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 1;
            label1.Text = "COM port";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(20, 40);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(79, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(114, 24);
            button1.Name = "button1";
            button1.Size = new Size(126, 41);
            button1.TabIndex = 2;
            button1.Text = "PRIPOJIŤ SA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(275, 9);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(497, 81);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Stav";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { counter, time, value });
            listView1.GridLines = true;
            listView1.Location = new Point(322, 125);
            listView1.Name = "listView1";
            listView1.Size = new Size(366, 329);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // counter
            // 
            counter.Text = "Č.";
            counter.Width = 50;
            // 
            // time
            // 
            time.Text = "Čas (s)";
            time.Width = 150;
            // 
            // value
            // 
            value.Text = "Sila (N)";
            value.Width = 150;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(432, 101);
            label2.Name = "label2";
            label2.Size = new Size(128, 21);
            label2.TabIndex = 13;
            label2.Text = "Namerané dáta";
            label2.Click += label2_Click;
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(313, 484);
            label5.Name = "label5";
            label5.Size = new Size(125, 21);
            label5.TabIndex = 14;
            label5.Text = "Saturel, s.r.o. (C) ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(784, 511);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(button3);
            Name = "Form1";
            Text = "Fires meranie";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Label label3;
        private Button button3;
        private Label label4;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox comboBox1;
        private Button button1;
        private GroupBox groupBox2;
        private ListView listView1;
        private ColumnHeader time;
        private Label label2;
        private ColumnHeader value;
        private System.Windows.Forms.Timer timer1;
        private ColumnHeader counter;
        private Label label5;
    }
}
