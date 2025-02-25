namespace GS1Autoprinter
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.remoteDesktop1 = new VncSharp.RemoteDesktop();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Disconnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Statu:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 100);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Modbus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "IP:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(56, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(12, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 100);
            this.panel2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "IP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "VNC";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(162, 49);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Disconnect";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(162, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Connect";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(12, 235);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 170);
            this.panel3.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(62, 118);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 16);
            this.label15.TabIndex = 9;
            this.label15.Text = "Job State:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(53, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 16);
            this.label14.TabIndex = 8;
            this.label14.Text = "Seq Result:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(60, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 16);
            this.label12.TabIndex = 6;
            this.label12.Text = "Seq State:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(88, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "State:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(144, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(144, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "-";
            // 
            // remoteDesktop1
            // 
            this.remoteDesktop1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.remoteDesktop1.AutoScroll = true;
            this.remoteDesktop1.AutoScrollMinSize = new System.Drawing.Size(608, 427);
            this.remoteDesktop1.Location = new System.Drawing.Point(293, 2);
            this.remoteDesktop1.Name = "remoteDesktop1";
            this.remoteDesktop1.Size = new System.Drawing.Size(1173, 744);
            this.remoteDesktop1.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label27);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.label26);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.label25);
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.label24);
            this.panel4.Controls.Add(this.label23);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Location = new System.Drawing.Point(12, 411);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(275, 215);
            this.panel4.TabIndex = 10;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(258, 189);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(11, 16);
            this.label27.TabIndex = 15;
            this.label27.Text = "-";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(79, 55);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(109, 16);
            this.label22.TabIndex = 9;
            this.label22.Text = "labels printed out";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(188, 189);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(64, 16);
            this.label26.TabIndex = 14;
            this.label26.Text = "Oto Statu:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(16, 55);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(11, 16);
            this.label21.TabIndex = 8;
            this.label21.Text = "-";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(258, 163);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(11, 16);
            this.label25.TabIndex = 13;
            this.label25.Text = "-";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(139, 102);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Reset";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(164, 163);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(88, 16);
            this.label24.TabIndex = 12;
            this.label24.Text = "Pr Command:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(258, 138);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(11, 16);
            this.label23.TabIndex = 11;
            this.label23.Text = "-";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(28, 131);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Stop";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(225, 138);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 16);
            this.label16.TabIndex = 10;
            this.label16.Text = "Ok:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(29, 102);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Start";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(202, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(11, 16);
            this.label20.TabIndex = 4;
            this.label20.Text = "-";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(160, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 16);
            this.label19.TabIndex = 3;
            this.label19.Text = "Last:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(4, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 16);
            this.label18.TabIndex = 2;
            this.label18.Text = "Adet:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(49, 24);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 16);
            this.label17.TabIndex = 0;
            this.label17.Text = "Oto";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(35, 46);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 27);
            this.button8.TabIndex = 16;
            this.button8.Text = "LP4777";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(163, 46);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 27);
            this.button9.TabIndex = 17;
            this.button9.Text = "LP4778";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Portrait";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(163, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 16);
            this.label13.TabIndex = 18;
            this.label13.Text = "Landspace";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(162, 116);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 27);
            this.button10.TabIndex = 19;
            this.button10.Text = "LP4781";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(163, 97);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(75, 16);
            this.label28.TabIndex = 20;
            this.label28.Text = "Landspace";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(35, 116);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 27);
            this.button11.TabIndex = 21;
            this.button11.Text = "LP4780";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(48, 97);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(49, 16);
            this.label29.TabIndex = 22;
            this.label29.Text = "Portrait";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button9);
            this.panel5.Controls.Add(this.label29);
            this.panel5.Controls.Add(this.button8);
            this.panel5.Controls.Add(this.button11);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label28);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.button10);
            this.panel5.Location = new System.Drawing.Point(12, 647);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(275, 170);
            this.panel5.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 829);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.remoteDesktop1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private VncSharp.RemoteDesktop remoteDesktop1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Panel panel5;
    }
}

