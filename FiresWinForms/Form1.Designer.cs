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
            logger = new TextBox();
            actualData = new TextBox();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            comboBoxPort = new ComboBox();
            connectBtn = new Button();
            groupBox2 = new GroupBox();
            listView1 = new ListView();
            counter = new ColumnHeader();
            time = new ColumnHeader();
            value = new ColumnHeader();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label5 = new Label();
            pictureBox1 = new PictureBox();
            showGraphBtn = new Button();
            startBtn = new Button();
            maxValue = new TextBox();
            repeatBtn = new Button();
            numberMeasure = new TextBox();
            label7 = new Label();
            label6 = new Label();
            Nastavenie = new GroupBox();
            silaFmin = new TextBox();
            label12 = new Label();
            changeSettings = new Button();
            silaFs = new TextBox();
            casTt = new TextBox();
            label9 = new Label();
            label11 = new Label();
            casTd = new TextBox();
            label8 = new Label();
            silaFd = new TextBox();
            label10 = new Label();
            Condition25 = new TextBox();
            ConditionFdMax = new TextBox();
            ConditionFs = new TextBox();
            zeroBtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Nastavenie.SuspendLayout();
            SuspendLayout();
            // 
            // logger
            // 
            logger.BackColor = SystemColors.Info;
            logger.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logger.Location = new Point(6, 24);
            logger.Name = "logger";
            logger.ReadOnly = true;
            logger.Size = new Size(685, 39);
            logger.TabIndex = 0;
            logger.TextAlign = HorizontalAlignment.Center;
            // 
            // actualData
            // 
            actualData.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            actualData.Location = new Point(161, 125);
            actualData.Name = "actualData";
            actualData.ReadOnly = true;
            actualData.Size = new Size(136, 32);
            actualData.TabIndex = 4;
            actualData.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(161, 101);
            label3.Name = "label3";
            label3.Size = new Size(138, 21);
            label3.TabIndex = 5;
            label3.Text = "Aktuálna sila (N)";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(0, 96);
            label4.Name = "label4";
            label4.Size = new Size(984, 2);
            label4.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBoxPort);
            groupBox1.Controls.Add(connectBtn);
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
            // comboBoxPort
            // 
            comboBoxPort.FormattingEnabled = true;
            comboBoxPort.Location = new Point(20, 40);
            comboBoxPort.Name = "comboBoxPort";
            comboBoxPort.Size = new Size(79, 23);
            comboBoxPort.TabIndex = 0;
            // 
            // connectBtn
            // 
            connectBtn.BackColor = SystemColors.ButtonFace;
            connectBtn.FlatAppearance.MouseOverBackColor = SystemColors.ScrollBar;
            connectBtn.FlatStyle = FlatStyle.Flat;
            connectBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            connectBtn.ForeColor = SystemColors.ControlText;
            connectBtn.Location = new Point(114, 24);
            connectBtn.Name = "connectBtn";
            connectBtn.Size = new Size(126, 41);
            connectBtn.TabIndex = 2;
            connectBtn.Text = "PRIPOJIŤ SA";
            connectBtn.UseVisualStyleBackColor = false;
            connectBtn.Click += connect_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(logger);
            groupBox2.Location = new Point(275, 9);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(697, 81);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Stav";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { counter, time, value });
            listView1.GridLines = true;
            listView1.Location = new Point(597, 125);
            listView1.Name = "listView1";
            listView1.Size = new Size(375, 330);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // counter
            // 
            counter.Text = "";
            counter.Width = 100;
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
            label2.Location = new Point(717, 101);
            label2.Name = "label2";
            label2.Size = new Size(128, 21);
            label2.TabIndex = 13;
            label2.Text = "Namerané dáta";
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(435, 508);
            label5.Name = "label5";
            label5.Size = new Size(125, 21);
            label5.TabIndex = 14;
            label5.Text = "Saturel, s.r.o. (C) ";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.ImageLocation = "C:\\Users\\rober\\source\\repos\\FiresWinForms\\FiresWinForms\\images\\fires-logo-white.png";
            pictureBox1.Location = new Point(0, 403);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 170);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // showGraphBtn
            // 
            showGraphBtn.BackColor = SystemColors.ButtonFace;
            showGraphBtn.Enabled = false;
            showGraphBtn.FlatAppearance.MouseOverBackColor = SystemColors.ScrollBar;
            showGraphBtn.FlatStyle = FlatStyle.Flat;
            showGraphBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            showGraphBtn.ForeColor = SystemColors.ControlText;
            showGraphBtn.Location = new Point(699, 461);
            showGraphBtn.Name = "showGraphBtn";
            showGraphBtn.Size = new Size(160, 41);
            showGraphBtn.TabIndex = 16;
            showGraphBtn.Text = "ZOBRAZIŤ GRAF";
            showGraphBtn.UseVisualStyleBackColor = false;
            showGraphBtn.Click += showGraph_Click;
            // 
            // startBtn
            // 
            startBtn.BackColor = SystemColors.ButtonFace;
            startBtn.Enabled = false;
            startBtn.FlatAppearance.MouseOverBackColor = SystemColors.ScrollBar;
            startBtn.FlatStyle = FlatStyle.Flat;
            startBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            startBtn.ForeColor = SystemColors.ControlText;
            startBtn.Location = new Point(335, 177);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(200, 41);
            startBtn.TabIndex = 22;
            startBtn.Text = "SPUSTIŤ MERANIE";
            startBtn.UseVisualStyleBackColor = false;
            startBtn.Click += startMeasuring_Click;
            // 
            // maxValue
            // 
            maxValue.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            maxValue.Location = new Point(445, 314);
            maxValue.Name = "maxValue";
            maxValue.ReadOnly = true;
            maxValue.Size = new Size(120, 32);
            maxValue.TabIndex = 26;
            maxValue.TextAlign = HorizontalAlignment.Center;
            // 
            // repeatBtn
            // 
            repeatBtn.BackColor = SystemColors.ButtonFace;
            repeatBtn.Enabled = false;
            repeatBtn.FlatAppearance.MouseOverBackColor = SystemColors.ScrollBar;
            repeatBtn.FlatStyle = FlatStyle.Flat;
            repeatBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            repeatBtn.ForeColor = SystemColors.ControlText;
            repeatBtn.Location = new Point(335, 234);
            repeatBtn.Name = "repeatBtn";
            repeatBtn.Size = new Size(200, 41);
            repeatBtn.TabIndex = 25;
            repeatBtn.Text = "OPAKOVAŤ MERANIE";
            repeatBtn.UseVisualStyleBackColor = false;
            repeatBtn.Click += repeatMeasuring_Click;
            // 
            // numberMeasure
            // 
            numberMeasure.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            numberMeasure.Location = new Point(305, 314);
            numberMeasure.Name = "numberMeasure";
            numberMeasure.ReadOnly = true;
            numberMeasure.Size = new Size(120, 32);
            numberMeasure.TabIndex = 23;
            numberMeasure.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(443, 290);
            label7.Name = "label7";
            label7.Size = new Size(102, 21);
            label7.TabIndex = 27;
            label7.Text = "Max sila (N)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(304, 290);
            label6.Name = "label6";
            label6.Size = new Size(112, 21);
            label6.TabIndex = 24;
            label6.Text = "Meranie číslo";
            // 
            // Nastavenie
            // 
            Nastavenie.Controls.Add(silaFmin);
            Nastavenie.Controls.Add(label12);
            Nastavenie.Controls.Add(changeSettings);
            Nastavenie.Controls.Add(silaFs);
            Nastavenie.Controls.Add(casTt);
            Nastavenie.Controls.Add(label9);
            Nastavenie.Controls.Add(label11);
            Nastavenie.Controls.Add(casTd);
            Nastavenie.Controls.Add(label8);
            Nastavenie.Controls.Add(silaFd);
            Nastavenie.Controls.Add(label10);
            Nastavenie.Location = new Point(12, 163);
            Nastavenie.Name = "Nastavenie";
            Nastavenie.Size = new Size(285, 204);
            Nastavenie.TabIndex = 28;
            Nastavenie.TabStop = false;
            Nastavenie.Text = "Nastavenia";
            // 
            // silaFmin
            // 
            silaFmin.Enabled = false;
            silaFmin.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            silaFmin.Location = new Point(10, 38);
            silaFmin.Name = "silaFmin";
            silaFmin.Size = new Size(120, 32);
            silaFmin.TabIndex = 33;
            silaFmin.Text = "25";
            silaFmin.TextAlign = HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(30, 14);
            label12.Name = "label12";
            label12.Size = new Size(109, 21);
            label12.TabIndex = 34;
            label12.Text = "Sila Fmin (N)";
            // 
            // changeSettings
            // 
            changeSettings.Location = new Point(75, -4);
            changeSettings.Name = "changeSettings";
            changeSettings.Size = new Size(61, 21);
            changeSettings.TabIndex = 32;
            changeSettings.Text = "Zmeniť";
            changeSettings.UseVisualStyleBackColor = true;
            changeSettings.Click += changeSettings_Click;
            // 
            // silaFs
            // 
            silaFs.Enabled = false;
            silaFs.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            silaFs.Location = new Point(10, 151);
            silaFs.Name = "silaFs";
            silaFs.Size = new Size(120, 32);
            silaFs.TabIndex = 31;
            silaFs.Text = "150";
            silaFs.TextAlign = HorizontalAlignment.Center;
            // 
            // casTt
            // 
            casTt.Enabled = false;
            casTt.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            casTt.Location = new Point(151, 95);
            casTt.Name = "casTt";
            casTt.Size = new Size(120, 32);
            casTt.TabIndex = 29;
            casTt.Text = "5,0";
            casTt.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(182, 71);
            label9.Name = "label9";
            label9.Size = new Size(78, 21);
            label9.TabIndex = 30;
            label9.Text = "Čas Tt (s)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(41, 127);
            label11.Name = "label11";
            label11.Size = new Size(86, 21);
            label11.TabIndex = 32;
            label11.Text = "Sila Fs (N)";
            // 
            // casTd
            // 
            casTd.Enabled = false;
            casTd.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            casTd.Location = new Point(151, 38);
            casTd.Name = "casTd";
            casTd.Size = new Size(120, 32);
            casTd.TabIndex = 29;
            casTd.Text = "0,75";
            casTd.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(181, 14);
            label8.Name = "label8";
            label8.Size = new Size(81, 21);
            label8.TabIndex = 30;
            label8.Text = "Čas Td (s)";
            // 
            // silaFd
            // 
            silaFd.Enabled = false;
            silaFd.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            silaFd.Location = new Point(10, 94);
            silaFd.Name = "silaFd";
            silaFd.Size = new Size(120, 32);
            silaFd.TabIndex = 29;
            silaFd.Text = "1400";
            silaFd.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(39, 70);
            label10.Name = "label10";
            label10.Size = new Size(89, 21);
            label10.TabIndex = 30;
            label10.Text = "Sila Fd (N)";
            // 
            // Condition25
            // 
            Condition25.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            Condition25.Location = new Point(305, 363);
            Condition25.Name = "Condition25";
            Condition25.ReadOnly = true;
            Condition25.Size = new Size(260, 32);
            Condition25.TabIndex = 29;
            Condition25.Text = "F < 25 N po dobe Tt";
            Condition25.TextAlign = HorizontalAlignment.Center;
            // 
            // ConditionFdMax
            // 
            ConditionFdMax.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            ConditionFdMax.Location = new Point(305, 463);
            ConditionFdMax.Name = "ConditionFdMax";
            ConditionFdMax.ReadOnly = true;
            ConditionFdMax.Size = new Size(260, 32);
            ConditionFdMax.TabIndex = 30;
            ConditionFdMax.Text = "F < Fd Max limit";
            ConditionFdMax.TextAlign = HorizontalAlignment.Center;
            // 
            // ConditionFs
            // 
            ConditionFs.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            ConditionFs.Location = new Point(305, 413);
            ConditionFs.Name = "ConditionFs";
            ConditionFs.ReadOnly = true;
            ConditionFs.Size = new Size(260, 32);
            ConditionFs.TabIndex = 31;
            ConditionFs.Text = "F < Fs po dobe Td";
            ConditionFs.TextAlign = HorizontalAlignment.Center;
            // 
            // zeroBtn
            // 
            zeroBtn.BackColor = SystemColors.ButtonFace;
            zeroBtn.Enabled = false;
            zeroBtn.FlatAppearance.MouseOverBackColor = SystemColors.ScrollBar;
            zeroBtn.FlatStyle = FlatStyle.Flat;
            zeroBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            zeroBtn.ForeColor = SystemColors.ControlText;
            zeroBtn.Location = new Point(335, 121);
            zeroBtn.Name = "zeroBtn";
            zeroBtn.Size = new Size(200, 41);
            zeroBtn.TabIndex = 32;
            zeroBtn.Text = "NULOVAŤ SILU";
            zeroBtn.UseVisualStyleBackColor = false;
            zeroBtn.Click += zeroBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(984, 531);
            Controls.Add(zeroBtn);
            Controls.Add(ConditionFs);
            Controls.Add(ConditionFdMax);
            Controls.Add(Condition25);
            Controls.Add(Nastavenie);
            Controls.Add(startBtn);
            Controls.Add(maxValue);
            Controls.Add(repeatBtn);
            Controls.Add(numberMeasure);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(actualData);
            Controls.Add(label3);
            Controls.Add(showGraphBtn);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Name = "Form1";
            Text = "Fires meranie";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Nastavenie.ResumeLayout(false);
            Nastavenie.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox actualData;
        private Label label3;
        private Label label4;
        private TextBox logger;
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox comboBoxPort;
        private Button connectBtn;
        private GroupBox groupBox2;
        private ListView listView1;
        private ColumnHeader time;
        private Label label2;
        private ColumnHeader value;
        private System.Windows.Forms.Timer timer1;
        private ColumnHeader counter;
        private Label label5;
        private PictureBox pictureBox1;
        private Button showGraphBtn;
        private Button startBtn;
        private TextBox maxValue;
        private Button repeatBtn;
        private TextBox numberMeasure;
        private Label label7;
        private Label label6;
        private GroupBox Nastavenie;
        private TextBox silaFd;
        private Label label10;
        private TextBox casTt;
        private Label label9;
        private Label label8;
        private TextBox silaFs;
        private Label label11;
        private TextBox casTd;
        private TextBox Condition25;
        private TextBox ConditionFdMax;
        private TextBox ConditionFs;
        private Button changeSettings;
        private TextBox silaFmin;
        private Label label12;
        private Button zeroBtn;
    }
}
