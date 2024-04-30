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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            startBtn = new Button();
            maxValue = new TextBox();
            repeatBtn = new Button();
            numberMeasure = new TextBox();
            label7 = new Label();
            label6 = new Label();
            Nastavenie = new GroupBox();
            changeSettings = new Button();
            silaFmin = new TextBox();
            label12 = new Label();
            silaFs = new TextBox();
            casTt = new TextBox();
            label9 = new Label();
            label11 = new Label();
            casTd = new TextBox();
            label8 = new Label();
            silaFd = new TextBox();
            label10 = new Label();
            showLimitsCheckbox = new CheckBox();
            conditionFdmax = new TextBox();
            conditionFmin = new TextBox();
            conditionFs = new TextBox();
            zeroBtn = new Button();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            graphPicture = new PictureBox();
            loadingBox = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Nastavenie.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)graphPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loadingBox).BeginInit();
            SuspendLayout();
            // 
            // logger
            // 
            logger.BackColor = SystemColors.Info;
            logger.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logger.Location = new Point(6, 30);
            logger.Name = "logger";
            logger.ReadOnly = true;
            logger.Size = new Size(894, 47);
            logger.TabIndex = 0;
            logger.TextAlign = HorizontalAlignment.Center;
            // 
            // actualData
            // 
            actualData.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold);
            actualData.Location = new Point(505, 137);
            actualData.Name = "actualData";
            actualData.ReadOnly = true;
            actualData.Size = new Size(260, 61);
            actualData.TabIndex = 4;
            actualData.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label3.Location = new Point(535, 104);
            label3.Name = "label3";
            label3.Size = new Size(184, 30);
            label3.TabIndex = 5;
            label3.Text = "Aktuálna sila (N)";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(0, 102);
            label4.Name = "label4";
            label4.Size = new Size(1264, 2);
            label4.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBoxPort);
            groupBox1.Controls.Add(connectBtn);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(12, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(328, 88);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pripojenie k zariadeniu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 19);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 1;
            label1.Text = "COM port";
            // 
            // comboBoxPort
            // 
            comboBoxPort.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxPort.FormattingEnabled = true;
            comboBoxPort.Location = new Point(14, 43);
            comboBoxPort.Name = "comboBoxPort";
            comboBoxPort.Size = new Size(107, 33);
            comboBoxPort.TabIndex = 0;
            // 
            // connectBtn
            // 
            connectBtn.BackColor = SystemColors.ButtonFace;
            connectBtn.FlatAppearance.MouseOverBackColor = SystemColors.ScrollBar;
            connectBtn.FlatStyle = FlatStyle.Flat;
            connectBtn.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            connectBtn.ForeColor = SystemColors.ControlText;
            connectBtn.Location = new Point(144, 29);
            connectBtn.Name = "connectBtn";
            connectBtn.Size = new Size(172, 48);
            connectBtn.TabIndex = 2;
            connectBtn.Text = "PRIPOJIŤ SA";
            connectBtn.UseVisualStyleBackColor = false;
            connectBtn.Click += connect_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(logger);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(346, 9);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(906, 88);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Stav";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { counter, time, value });
            listView1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView1.GridLines = true;
            listView1.Location = new Point(826, 137);
            listView1.Name = "listView1";
            listView1.Size = new Size(420, 344);
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
            time.Width = 170;
            // 
            // value
            // 
            value.Text = "Sila (N)";
            value.Width = 170;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label2.Location = new Point(940, 104);
            label2.Name = "label2";
            label2.Size = new Size(173, 30);
            label2.TabIndex = 13;
            label2.Text = "Namerané dáta";
            // 
            // timer1
            // 
            timer1.Interval = 6000;
            timer1.Tick += timer1_Tick;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(291, 686);
            label5.Name = "label5";
            label5.Size = new Size(125, 21);
            label5.TabIndex = 14;
            label5.Text = "Saturel, s.r.o. (C) ";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(0, 545);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 170);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // startBtn
            // 
            startBtn.BackColor = SystemColors.ButtonFace;
            startBtn.Enabled = false;
            startBtn.FlatAppearance.MouseOverBackColor = SystemColors.ScrollBar;
            startBtn.FlatStyle = FlatStyle.Flat;
            startBtn.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            startBtn.ForeColor = SystemColors.ControlText;
            startBtn.Location = new Point(8, 33);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(198, 52);
            startBtn.TabIndex = 22;
            startBtn.Text = "SPUSTIŤ";
            startBtn.UseVisualStyleBackColor = false;
            startBtn.Click += startMeasuring_Click;
            // 
            // maxValue
            // 
            maxValue.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            maxValue.Location = new Point(535, 398);
            maxValue.Name = "maxValue";
            maxValue.ReadOnly = true;
            maxValue.Size = new Size(199, 43);
            maxValue.TabIndex = 26;
            maxValue.TextAlign = HorizontalAlignment.Center;
            // 
            // repeatBtn
            // 
            repeatBtn.BackColor = SystemColors.ButtonFace;
            repeatBtn.Enabled = false;
            repeatBtn.FlatAppearance.MouseOverBackColor = SystemColors.ScrollBar;
            repeatBtn.FlatStyle = FlatStyle.Flat;
            repeatBtn.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            repeatBtn.ForeColor = SystemColors.ControlText;
            repeatBtn.Location = new Point(220, 33);
            repeatBtn.Name = "repeatBtn";
            repeatBtn.Size = new Size(199, 52);
            repeatBtn.TabIndex = 25;
            repeatBtn.Text = "OPAKOVAŤ";
            repeatBtn.UseVisualStyleBackColor = false;
            repeatBtn.Click += repeatMeasuring_Click;
            // 
            // numberMeasure
            // 
            numberMeasure.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            numberMeasure.Location = new Point(535, 313);
            numberMeasure.Name = "numberMeasure";
            numberMeasure.ReadOnly = true;
            numberMeasure.Size = new Size(199, 43);
            numberMeasure.TabIndex = 23;
            numberMeasure.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label7.Location = new Point(561, 365);
            label7.Name = "label7";
            label7.Size = new Size(137, 30);
            label7.TabIndex = 27;
            label7.Text = "Max sila (N)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label6.Location = new Point(553, 281);
            label6.Name = "label6";
            label6.Size = new Size(150, 30);
            label6.TabIndex = 24;
            label6.Text = "Meranie číslo";
            // 
            // Nastavenie
            // 
            Nastavenie.Controls.Add(changeSettings);
            Nastavenie.Controls.Add(silaFmin);
            Nastavenie.Controls.Add(label12);
            Nastavenie.Controls.Add(silaFs);
            Nastavenie.Controls.Add(casTt);
            Nastavenie.Controls.Add(label9);
            Nastavenie.Controls.Add(label11);
            Nastavenie.Controls.Add(casTd);
            Nastavenie.Controls.Add(label8);
            Nastavenie.Controls.Add(silaFd);
            Nastavenie.Controls.Add(label10);
            Nastavenie.Font = new Font("Segoe UI", 12F);
            Nastavenie.Location = new Point(12, 246);
            Nastavenie.Name = "Nastavenie";
            Nastavenie.Size = new Size(431, 299);
            Nastavenie.TabIndex = 28;
            Nastavenie.TabStop = false;
            Nastavenie.Text = "Nastavenia";
            // 
            // changeSettings
            // 
            changeSettings.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            changeSettings.Location = new Point(168, 9);
            changeSettings.Name = "changeSettings";
            changeSettings.Size = new Size(87, 29);
            changeSettings.TabIndex = 32;
            changeSettings.Text = "Upraviť";
            changeSettings.UseVisualStyleBackColor = true;
            changeSettings.Click += changeSettings_Click;
            // 
            // silaFmin
            // 
            silaFmin.Enabled = false;
            silaFmin.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            silaFmin.Location = new Point(6, 240);
            silaFmin.Name = "silaFmin";
            silaFmin.Size = new Size(200, 43);
            silaFmin.TabIndex = 33;
            silaFmin.Text = "25";
            silaFmin.TextAlign = HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label12.Location = new Point(30, 207);
            label12.Name = "label12";
            label12.Size = new Size(144, 30);
            label12.TabIndex = 34;
            label12.Text = "Sila Fmin (N)";
            // 
            // silaFs
            // 
            silaFs.Enabled = false;
            silaFs.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            silaFs.Location = new Point(6, 68);
            silaFs.Name = "silaFs";
            silaFs.Size = new Size(200, 43);
            silaFs.TabIndex = 31;
            silaFs.Text = "150";
            silaFs.TextAlign = HorizontalAlignment.Center;
            // 
            // casTt
            // 
            casTt.Enabled = false;
            casTt.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            casTt.Location = new Point(220, 155);
            casTt.Name = "casTt";
            casTt.Size = new Size(200, 43);
            casTt.TabIndex = 29;
            casTt.Text = "5,0";
            casTt.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label9.Location = new Point(261, 122);
            label9.Name = "label9";
            label9.Size = new Size(109, 30);
            label9.TabIndex = 30;
            label9.Text = "Čas Tt (s)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label11.Location = new Point(45, 35);
            label11.Name = "label11";
            label11.Size = new Size(115, 30);
            label11.TabIndex = 32;
            label11.Text = "Sila Fs (N)";
            // 
            // casTd
            // 
            casTd.Enabled = false;
            casTd.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            casTd.Location = new Point(220, 68);
            casTd.Name = "casTd";
            casTd.Size = new Size(200, 43);
            casTd.TabIndex = 29;
            casTd.Text = "0,75";
            casTd.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label8.Location = new Point(261, 35);
            label8.Name = "label8";
            label8.Size = new Size(112, 30);
            label8.TabIndex = 30;
            label8.Text = "Čas Td (s)";
            // 
            // silaFd
            // 
            silaFd.Enabled = false;
            silaFd.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            silaFd.Location = new Point(6, 155);
            silaFd.Name = "silaFd";
            silaFd.Size = new Size(200, 43);
            silaFd.TabIndex = 29;
            silaFd.Text = "1400";
            silaFd.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label10.Location = new Point(43, 122);
            label10.Name = "label10";
            label10.Size = new Size(119, 30);
            label10.TabIndex = 30;
            label10.Text = "Sila Fd (N)";
            // 
            // showLimitsCheckbox
            // 
            showLimitsCheckbox.AutoSize = true;
            showLimitsCheckbox.Checked = true;
            showLimitsCheckbox.CheckState = CheckState.Checked;
            showLimitsCheckbox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showLimitsCheckbox.Location = new Point(501, 651);
            showLimitsCheckbox.Name = "showLimitsCheckbox";
            showLimitsCheckbox.Size = new Size(261, 34);
            showLimitsCheckbox.TabIndex = 35;
            showLimitsCheckbox.Text = "Vykresliť limity na grafe";
            showLimitsCheckbox.UseVisualStyleBackColor = true;
            showLimitsCheckbox.CheckedChanged += showLimitsCheckbox_CheckedChanged;
            // 
            // conditionFdmax
            // 
            conditionFdmax.BackColor = Color.White;
            conditionFdmax.BorderStyle = BorderStyle.None;
            conditionFdmax.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            conditionFdmax.Location = new Point(11, 28);
            conditionFdmax.Name = "conditionFdmax";
            conditionFdmax.ReadOnly = true;
            conditionFdmax.Size = new Size(260, 36);
            conditionFdmax.TabIndex = 29;
            conditionFdmax.Text = "F < Fd Max limit";
            conditionFdmax.TextAlign = HorizontalAlignment.Center;
            // 
            // conditionFmin
            // 
            conditionFmin.BackColor = Color.White;
            conditionFmin.BorderStyle = BorderStyle.None;
            conditionFmin.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            conditionFmin.Location = new Point(11, 139);
            conditionFmin.Name = "conditionFmin";
            conditionFmin.ReadOnly = true;
            conditionFmin.Size = new Size(260, 36);
            conditionFmin.TabIndex = 30;
            conditionFmin.Text = "F < Fmin po Tt";
            conditionFmin.TextAlign = HorizontalAlignment.Center;
            // 
            // conditionFs
            // 
            conditionFs.BackColor = Color.White;
            conditionFs.BorderStyle = BorderStyle.None;
            conditionFs.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            conditionFs.Location = new Point(11, 85);
            conditionFs.Name = "conditionFs";
            conditionFs.ReadOnly = true;
            conditionFs.Size = new Size(260, 36);
            conditionFs.TabIndex = 31;
            conditionFs.Text = "F < Fs po Td";
            conditionFs.TextAlign = HorizontalAlignment.Center;
            // 
            // zeroBtn
            // 
            zeroBtn.BackColor = SystemColors.ButtonFace;
            zeroBtn.Enabled = false;
            zeroBtn.FlatAppearance.MouseOverBackColor = SystemColors.ScrollBar;
            zeroBtn.FlatStyle = FlatStyle.Flat;
            zeroBtn.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            zeroBtn.ForeColor = SystemColors.ControlText;
            zeroBtn.Location = new Point(535, 213);
            zeroBtn.Name = "zeroBtn";
            zeroBtn.Size = new Size(199, 52);
            zeroBtn.TabIndex = 32;
            zeroBtn.Text = "VYNULOVAŤ";
            zeroBtn.UseVisualStyleBackColor = false;
            zeroBtn.Click += zeroBtn_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(startBtn);
            groupBox3.Controls.Add(repeatBtn);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(12, 107);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(431, 101);
            groupBox3.TabIndex = 33;
            groupBox3.TabStop = false;
            groupBox3.Text = "Meranie";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(conditionFdmax);
            groupBox4.Controls.Add(conditionFs);
            groupBox4.Controls.Add(conditionFmin);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(490, 451);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(285, 184);
            groupBox4.TabIndex = 34;
            groupBox4.TabStop = false;
            groupBox4.Text = "Podmienky";
            // 
            // graphPicture
            // 
            graphPicture.BackColor = SystemColors.Window;
            graphPicture.BorderStyle = BorderStyle.FixedSingle;
            graphPicture.Cursor = Cursors.Hand;
            graphPicture.Enabled = false;
            graphPicture.ImageLocation = "";
            graphPicture.Location = new Point(826, 489);
            graphPicture.Name = "graphPicture";
            graphPicture.Size = new Size(420, 210);
            graphPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            graphPicture.TabIndex = 35;
            graphPicture.TabStop = false;
            graphPicture.Click += graphPicture_Click;
            // 
            // loadingBox
            // 
            loadingBox.BackColor = SystemColors.Window;
            loadingBox.BackgroundImageLayout = ImageLayout.Stretch;
            loadingBox.Image = (Image)resources.GetObject("loadingBox.Image");
            loadingBox.Location = new Point(1013, 570);
            loadingBox.Name = "loadingBox";
            loadingBox.Size = new Size(50, 50);
            loadingBox.SizeMode = PictureBoxSizeMode.StretchImage;
            loadingBox.TabIndex = 36;
            loadingBox.TabStop = false;
            loadingBox.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(1264, 711);
            Controls.Add(loadingBox);
            Controls.Add(showLimitsCheckbox);
            Controls.Add(graphPicture);
            Controls.Add(label5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(zeroBtn);
            Controls.Add(Nastavenie);
            Controls.Add(maxValue);
            Controls.Add(numberMeasure);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(actualData);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
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
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)graphPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)loadingBox).EndInit();
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
        private TextBox conditionFdmax;
        private TextBox conditionFmin;
        private TextBox conditionFs;
        private Button changeSettings;
        private TextBox silaFmin;
        private Label label12;
        private Button zeroBtn;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private CheckBox showLimitsCheckbox;
        private PictureBox graphPicture;
        private PictureBox loadingBox;
    }
}
