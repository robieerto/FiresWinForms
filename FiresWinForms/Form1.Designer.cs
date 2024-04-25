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
            connect = new Button();
            groupBox2 = new GroupBox();
            listView1 = new ListView();
            counter = new ColumnHeader();
            time = new ColumnHeader();
            value = new ColumnHeader();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label5 = new Label();
            pictureBox1 = new PictureBox();
            showGraph = new Button();
            startMeasuring = new Button();
            maxValue = new TextBox();
            repeatMeasuring = new Button();
            numberMeasure = new TextBox();
            label7 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // logger
            // 
            logger.BackColor = SystemColors.Info;
            logger.Enabled = false;
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
            actualData.Enabled = false;
            actualData.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            actualData.Location = new Point(12, 125);
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
            label3.Location = new Point(12, 101);
            label3.Name = "label3";
            label3.Size = new Size(117, 21);
            label3.TabIndex = 5;
            label3.Text = "Aktuálne dáta";
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
            groupBox1.Controls.Add(connect);
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
            // connect
            // 
            connect.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            connect.Location = new Point(114, 24);
            connect.Name = "connect";
            connect.Size = new Size(126, 41);
            connect.TabIndex = 2;
            connect.Text = "PRIPOJIŤ SA";
            connect.UseVisualStyleBackColor = true;
            connect.Click += connect_Click;
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
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(435, 488);
            label5.Name = "label5";
            label5.Size = new Size(125, 21);
            label5.TabIndex = 14;
            label5.Text = "Saturel, s.r.o. (C) ";
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "C:\\Users\\rober\\source\\repos\\FiresWinForms\\FiresWinForms\\fires-logo-white.png";
            pictureBox1.Location = new Point(0, 383);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 170);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // showGraph
            // 
            showGraph.Enabled = false;
            showGraph.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showGraph.Location = new Point(697, 461);
            showGraph.Name = "showGraph";
            showGraph.Size = new Size(160, 41);
            showGraph.TabIndex = 16;
            showGraph.Text = "ZOBRAZIŤ GRAF";
            showGraph.UseVisualStyleBackColor = true;
            showGraph.Click += showGraph_Click;
            // 
            // startMeasuring
            // 
            startMeasuring.Enabled = false;
            startMeasuring.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startMeasuring.Location = new Point(163, 116);
            startMeasuring.Name = "startMeasuring";
            startMeasuring.Size = new Size(200, 41);
            startMeasuring.TabIndex = 22;
            startMeasuring.Text = "SPUSTIŤ MERANIE";
            startMeasuring.UseVisualStyleBackColor = true;
            startMeasuring.Click += startMeasuring_Click;
            // 
            // maxValue
            // 
            maxValue.Enabled = false;
            maxValue.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maxValue.Location = new Point(411, 201);
            maxValue.Name = "maxValue";
            maxValue.ReadOnly = true;
            maxValue.Size = new Size(136, 32);
            maxValue.TabIndex = 26;
            maxValue.TextAlign = HorizontalAlignment.Center;
            // 
            // repeatMeasuring
            // 
            repeatMeasuring.Enabled = false;
            repeatMeasuring.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            repeatMeasuring.Location = new Point(374, 116);
            repeatMeasuring.Name = "repeatMeasuring";
            repeatMeasuring.Size = new Size(206, 41);
            repeatMeasuring.TabIndex = 25;
            repeatMeasuring.Text = "OPAKOVAŤ MERANIE";
            repeatMeasuring.UseVisualStyleBackColor = true;
            // 
            // numberMeasure
            // 
            numberMeasure.Enabled = false;
            numberMeasure.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numberMeasure.Location = new Point(202, 201);
            numberMeasure.Name = "numberMeasure";
            numberMeasure.ReadOnly = true;
            numberMeasure.Size = new Size(136, 32);
            numberMeasure.TabIndex = 23;
            numberMeasure.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(394, 177);
            label7.Name = "label7";
            label7.Size = new Size(165, 21);
            label7.TabIndex = 27;
            label7.Text = "Maximálna hodnota";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(210, 177);
            label6.Name = "label6";
            label6.Size = new Size(112, 21);
            label6.TabIndex = 24;
            label6.Text = "Meranie číslo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(984, 511);
            Controls.Add(startMeasuring);
            Controls.Add(maxValue);
            Controls.Add(repeatMeasuring);
            Controls.Add(numberMeasure);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(actualData);
            Controls.Add(label3);
            Controls.Add(showGraph);
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
        private Button connect;
        private GroupBox groupBox2;
        private ListView listView1;
        private ColumnHeader time;
        private Label label2;
        private ColumnHeader value;
        private System.Windows.Forms.Timer timer1;
        private ColumnHeader counter;
        private Label label5;
        private PictureBox pictureBox1;
        private Button showGraph;
        private Button startMeasuring;
        private TextBox maxValue;
        private Button repeatMeasuring;
        private TextBox numberMeasure;
        private Label label7;
        private Label label6;
    }
}
