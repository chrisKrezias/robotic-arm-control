namespace rompotiki
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
            this.components = new System.ComponentModel.Container();
            this.OpenPort = new System.Windows.Forms.Button();
            this.ClosePort = new System.Windows.Forms.Button();
            this.Send1 = new System.Windows.Forms.Button();
            this.Send2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.Send2L = new System.Windows.Forms.Button();
            this.Send1L = new System.Windows.Forms.Button();
            this.Send4L = new System.Windows.Forms.Button();
            this.Send3L = new System.Windows.Forms.Button();
            this.Send4R = new System.Windows.Forms.Button();
            this.Send3R = new System.Windows.Forms.Button();
            this.Send5L = new System.Windows.Forms.Button();
            this.Send5R = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ledoff = new System.Windows.Forms.Button();
            this.ledon = new System.Windows.Forms.Button();
            this.Move = new System.Windows.Forms.Button();
            this.teach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenPort
            // 
            this.OpenPort.Location = new System.Drawing.Point(10, 145);
            this.OpenPort.Name = "OpenPort";
            this.OpenPort.Size = new System.Drawing.Size(75, 23);
            this.OpenPort.TabIndex = 0;
            this.OpenPort.Text = "Open Port";
            this.OpenPort.UseVisualStyleBackColor = true;
            this.OpenPort.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClosePort
            // 
            this.ClosePort.Enabled = false;
            this.ClosePort.Location = new System.Drawing.Point(10, 174);
            this.ClosePort.Name = "ClosePort";
            this.ClosePort.Size = new System.Drawing.Size(75, 23);
            this.ClosePort.TabIndex = 1;
            this.ClosePort.Text = "Close Port";
            this.ClosePort.UseVisualStyleBackColor = true;
            this.ClosePort.Click += new System.EventHandler(this.ClosePort_Click);
            // 
            // Send1
            // 
            this.Send1.Enabled = false;
            this.Send1.Location = new System.Drawing.Point(104, 174);
            this.Send1.Name = "Send1";
            this.Send1.Size = new System.Drawing.Size(75, 23);
            this.Send1.TabIndex = 2;
            this.Send1.Text = "M4 Right";
            this.Send1.UseVisualStyleBackColor = true;
            this.Send1.Click += new System.EventHandler(this.Send1_Click);
            // 
            // Send2
            // 
            this.Send2.Enabled = false;
            this.Send2.Location = new System.Drawing.Point(104, 203);
            this.Send2.Name = "Send2";
            this.Send2.Size = new System.Drawing.Size(75, 23);
            this.Send2.TabIndex = 3;
            this.Send2.Text = "M3 Up";
            this.Send2.UseVisualStyleBackColor = true;
            this.Send2.Click += new System.EventHandler(this.Send2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(139, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "PORT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "BAUDRATE";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.comboBox2.Location = new System.Drawing.Point(139, 118);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(212, 73);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 388);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(281, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Progress Bar";
            // 
            // Send2L
            // 
            this.Send2L.Enabled = false;
            this.Send2L.Location = new System.Drawing.Point(185, 203);
            this.Send2L.Name = "Send2L";
            this.Send2L.Size = new System.Drawing.Size(75, 23);
            this.Send2L.TabIndex = 12;
            this.Send2L.Text = "M3 Down";
            this.Send2L.UseVisualStyleBackColor = true;
            this.Send2L.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Send1L
            // 
            this.Send1L.Enabled = false;
            this.Send1L.Location = new System.Drawing.Point(185, 174);
            this.Send1L.Name = "Send1L";
            this.Send1L.Size = new System.Drawing.Size(75, 23);
            this.Send1L.TabIndex = 11;
            this.Send1L.Text = "M4 Left";
            this.Send1L.UseVisualStyleBackColor = true;
            this.Send1L.Click += new System.EventHandler(this.button2_Click);
            // 
            // Send4L
            // 
            this.Send4L.Enabled = false;
            this.Send4L.Location = new System.Drawing.Point(185, 261);
            this.Send4L.Name = "Send4L";
            this.Send4L.Size = new System.Drawing.Size(75, 23);
            this.Send4L.TabIndex = 16;
            this.Send4L.Text = "M1 Down";
            this.Send4L.UseVisualStyleBackColor = true;
            this.Send4L.Click += new System.EventHandler(this.button3_Click);
            // 
            // Send3L
            // 
            this.Send3L.Enabled = false;
            this.Send3L.Location = new System.Drawing.Point(185, 232);
            this.Send3L.Name = "Send3L";
            this.Send3L.Size = new System.Drawing.Size(75, 23);
            this.Send3L.TabIndex = 15;
            this.Send3L.Text = "M2 Down";
            this.Send3L.UseVisualStyleBackColor = true;
            this.Send3L.Click += new System.EventHandler(this.button4_Click);
            // 
            // Send4R
            // 
            this.Send4R.Enabled = false;
            this.Send4R.Location = new System.Drawing.Point(104, 261);
            this.Send4R.Name = "Send4R";
            this.Send4R.Size = new System.Drawing.Size(75, 23);
            this.Send4R.TabIndex = 14;
            this.Send4R.Text = "M1 Up";
            this.Send4R.UseVisualStyleBackColor = true;
            this.Send4R.Click += new System.EventHandler(this.button5_Click);
            // 
            // Send3R
            // 
            this.Send3R.Enabled = false;
            this.Send3R.Location = new System.Drawing.Point(104, 232);
            this.Send3R.Name = "Send3R";
            this.Send3R.Size = new System.Drawing.Size(75, 23);
            this.Send3R.TabIndex = 13;
            this.Send3R.Text = "M2 Up";
            this.Send3R.UseVisualStyleBackColor = true;
            this.Send3R.Click += new System.EventHandler(this.button6_Click);
            // 
            // Send5L
            // 
            this.Send5L.Enabled = false;
            this.Send5L.Location = new System.Drawing.Point(185, 290);
            this.Send5L.Name = "Send5L";
            this.Send5L.Size = new System.Drawing.Size(75, 23);
            this.Send5L.TabIndex = 19;
            this.Send5L.Text = "M0 Close";
            this.Send5L.UseVisualStyleBackColor = true;
            this.Send5L.Click += new System.EventHandler(this.button8_Click);
            // 
            // Send5R
            // 
            this.Send5R.Enabled = false;
            this.Send5R.Location = new System.Drawing.Point(104, 290);
            this.Send5R.Name = "Send5R";
            this.Send5R.Size = new System.Drawing.Size(75, 23);
            this.Send5R.TabIndex = 17;
            this.Send5R.Text = "M0 Open";
            this.Send5R.UseVisualStyleBackColor = true;
            this.Send5R.Click += new System.EventHandler(this.button10_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Robotic Arm Controls";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ledoff
            // 
            this.ledoff.Enabled = false;
            this.ledoff.Location = new System.Drawing.Point(185, 319);
            this.ledoff.Name = "ledoff";
            this.ledoff.Size = new System.Drawing.Size(75, 23);
            this.ledoff.TabIndex = 24;
            this.ledoff.Text = "LED OFF";
            this.ledoff.UseVisualStyleBackColor = true;
            this.ledoff.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // ledon
            // 
            this.ledon.Enabled = false;
            this.ledon.Location = new System.Drawing.Point(104, 319);
            this.ledon.Name = "ledon";
            this.ledon.Size = new System.Drawing.Size(75, 23);
            this.ledon.TabIndex = 23;
            this.ledon.Text = "LED ON";
            this.ledon.UseVisualStyleBackColor = true;
            this.ledon.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Move
            // 
            this.Move.Enabled = false;
            this.Move.Location = new System.Drawing.Point(185, 348);
            this.Move.Name = "Move";
            this.Move.Size = new System.Drawing.Size(75, 23);
            this.Move.TabIndex = 26;
            this.Move.Text = "Move";
            this.Move.UseVisualStyleBackColor = true;
            this.Move.Click += new System.EventHandler(this.Move_Click);
            // 
            // teach
            // 
            this.teach.Enabled = false;
            this.teach.Location = new System.Drawing.Point(104, 348);
            this.teach.Name = "teach";
            this.teach.Size = new System.Drawing.Size(75, 23);
            this.teach.TabIndex = 25;
            this.teach.Text = "Teach";
            this.teach.UseVisualStyleBackColor = true;
            this.teach.Click += new System.EventHandler(this.teach_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 423);
            this.Controls.Add(this.Move);
            this.Controls.Add(this.teach);
            this.Controls.Add(this.ledoff);
            this.Controls.Add(this.ledon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Send5L);
            this.Controls.Add(this.Send5R);
            this.Controls.Add(this.Send4L);
            this.Controls.Add(this.Send3L);
            this.Controls.Add(this.Send4R);
            this.Controls.Add(this.Send3R);
            this.Controls.Add(this.Send2L);
            this.Controls.Add(this.Send1L);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Send2);
            this.Controls.Add(this.Send1);
            this.Controls.Add(this.ClosePort);
            this.Controls.Add(this.OpenPort);
            this.Name = "Form1";
            this.Text = "Robotic Arm Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenPort;
        private System.Windows.Forms.Button ClosePort;
        private System.Windows.Forms.Button Send1;
        private System.Windows.Forms.Button Send2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Send2L;
        private System.Windows.Forms.Button Send1L;
        private System.Windows.Forms.Button Send4L;
        private System.Windows.Forms.Button Send3L;
        private System.Windows.Forms.Button Send4R;
        private System.Windows.Forms.Button Send3R;
        private System.Windows.Forms.Button Send5L;
        private System.Windows.Forms.Button Send5R;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ledoff;
        private System.Windows.Forms.Button ledon;
        private System.Windows.Forms.Button Move;
        private System.Windows.Forms.Button teach;
    }
}

