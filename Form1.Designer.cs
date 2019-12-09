namespace Auto_clicker
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
            this.Button_addPoint = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Internal_interval = new System.Windows.Forms.TextBox();
            this.Ypos = new System.Windows.Forms.TextBox();
            this.Xpos = new System.Windows.Forms.TextBox();
            this.Button_clear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NRepeatCheck = new System.Windows.Forms.CheckBox();
            this.RepeatCheck = new System.Windows.Forms.CheckBox();
            this.Button_start = new System.Windows.Forms.Button();
            this.Button_stop = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Interval_ms = new System.Windows.Forms.TextBox();
            this.Interval_m = new System.Windows.Forms.TextBox();
            this.Interval_s = new System.Windows.Forms.TextBox();
            this.Interval_h = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Delay_m = new System.Windows.Forms.TextBox();
            this.Delay_s = new System.Windows.Forms.TextBox();
            this.Delay_h = new System.Windows.Forms.TextBox();
            this.Button_ClearList = new System.Windows.Forms.Button();
            this.MessageWindow = new System.Windows.Forms.ListBox();
            this.Repeat_count = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Repeat_count)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_addPoint
            // 
            this.Button_addPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_addPoint.Location = new System.Drawing.Point(6, 23);
            this.Button_addPoint.Name = "Button_addPoint";
            this.Button_addPoint.Size = new System.Drawing.Size(80, 30);
            this.Button_addPoint.TabIndex = 0;
            this.Button_addPoint.Text = "Add point";
            this.Button_addPoint.UseVisualStyleBackColor = true;
            this.Button_addPoint.Click += new System.EventHandler(this.AddPoint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Internal_interval);
            this.groupBox1.Controls.Add(this.Ypos);
            this.groupBox1.Controls.Add(this.Xpos);
            this.groupBox1.Controls.Add(this.Button_clear);
            this.groupBox1.Controls.Add(this.Button_addPoint);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(210, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 73);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pattern ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(292, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Time interval (ms)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(198, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Y:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(95, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "X:";
            // 
            // Internal_interval
            // 
            this.Internal_interval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Internal_interval.Location = new System.Drawing.Point(403, 30);
            this.Internal_interval.Name = "Internal_interval";
            this.Internal_interval.Size = new System.Drawing.Size(60, 20);
            this.Internal_interval.TabIndex = 4;
            this.Internal_interval.Text = "500";
            this.Internal_interval.TextChanged += new System.EventHandler(this.Internal_interval_TextChanged);
            // 
            // Ypos
            // 
            this.Ypos.Location = new System.Drawing.Point(225, 27);
            this.Ypos.Name = "Ypos";
            this.Ypos.Size = new System.Drawing.Size(60, 24);
            this.Ypos.TabIndex = 3;
            this.Ypos.TextChanged += new System.EventHandler(this.YCoord_TextChanged);
            // 
            // Xpos
            // 
            this.Xpos.Location = new System.Drawing.Point(123, 27);
            this.Xpos.Name = "Xpos";
            this.Xpos.Size = new System.Drawing.Size(50, 24);
            this.Xpos.TabIndex = 2;
            this.Xpos.TextChanged += new System.EventHandler(this.XCoord_TextChanged_1);
            // 
            // Button_clear
            // 
            this.Button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_clear.Location = new System.Drawing.Point(483, 25);
            this.Button_clear.Name = "Button_clear";
            this.Button_clear.Size = new System.Drawing.Size(80, 30);
            this.Button_clear.TabIndex = 1;
            this.Button_clear.Text = "Clear pattern";
            this.Button_clear.UseVisualStyleBackColor = true;
            this.Button_clear.Click += new System.EventHandler(this.Button_clear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Repeat_count);
            this.groupBox2.Controls.Add(this.NRepeatCheck);
            this.groupBox2.Controls.Add(this.RepeatCheck);
            this.groupBox2.Location = new System.Drawing.Point(210, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 70);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clicking parameters";
            // 
            // NRepeatCheck
            // 
            this.NRepeatCheck.AutoSize = true;
            this.NRepeatCheck.Location = new System.Drawing.Point(194, 31);
            this.NRepeatCheck.Name = "NRepeatCheck";
            this.NRepeatCheck.Size = new System.Drawing.Size(91, 17);
            this.NRepeatCheck.TabIndex = 1;
            this.NRepeatCheck.Text = "Repeat times:";
            this.NRepeatCheck.UseVisualStyleBackColor = true;
            this.NRepeatCheck.CheckedChanged += new System.EventHandler(this.NRepeatCheck_CheckedChanged);
            // 
            // RepeatCheck
            // 
            this.RepeatCheck.AutoSize = true;
            this.RepeatCheck.Checked = true;
            this.RepeatCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RepeatCheck.Location = new System.Drawing.Point(18, 31);
            this.RepeatCheck.Name = "RepeatCheck";
            this.RepeatCheck.Size = new System.Drawing.Size(124, 17);
            this.RepeatCheck.TabIndex = 0;
            this.RepeatCheck.Text = "Repeat until stopped";
            this.RepeatCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RepeatCheck.UseVisualStyleBackColor = true;
            this.RepeatCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Button_start
            // 
            this.Button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_start.Location = new System.Drawing.Point(238, 349);
            this.Button_start.Name = "Button_start";
            this.Button_start.Size = new System.Drawing.Size(159, 83);
            this.Button_start.TabIndex = 1;
            this.Button_start.Text = "Start";
            this.Button_start.UseVisualStyleBackColor = true;
            this.Button_start.Click += new System.EventHandler(this.Button_start_Click);
            // 
            // Button_stop
            // 
            this.Button_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_stop.Location = new System.Drawing.Point(596, 349);
            this.Button_stop.Name = "Button_stop";
            this.Button_stop.Size = new System.Drawing.Size(159, 83);
            this.Button_stop.TabIndex = 5;
            this.Button_stop.Text = "Stop";
            this.Button_stop.UseVisualStyleBackColor = true;
            this.Button_stop.Click += new System.EventHandler(this.Button_stop_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.Interval_ms);
            this.groupBox3.Controls.Add(this.Interval_m);
            this.groupBox3.Controls.Add(this.Interval_s);
            this.groupBox3.Controls.Add(this.Interval_h);
            this.groupBox3.Location = new System.Drawing.Point(210, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(578, 62);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Time interval";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "seconds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "minutes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "hours";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "milliseconds";
            // 
            // Interval_ms
            // 
            this.Interval_ms.Location = new System.Drawing.Point(352, 27);
            this.Interval_ms.Name = "Interval_ms";
            this.Interval_ms.Size = new System.Drawing.Size(54, 20);
            this.Interval_ms.TabIndex = 3;
            this.Interval_ms.Text = "500";
            this.Interval_ms.TextChanged += new System.EventHandler(this.Interval_ms_TextChanged);
            // 
            // Interval_m
            // 
            this.Interval_m.Location = new System.Drawing.Point(122, 27);
            this.Interval_m.Name = "Interval_m";
            this.Interval_m.Size = new System.Drawing.Size(45, 20);
            this.Interval_m.TabIndex = 2;
            this.Interval_m.Text = "0";
            this.Interval_m.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // Interval_s
            // 
            this.Interval_s.Location = new System.Drawing.Point(235, 27);
            this.Interval_s.Name = "Interval_s";
            this.Interval_s.Size = new System.Drawing.Size(43, 20);
            this.Interval_s.TabIndex = 1;
            this.Interval_s.Text = "0";
            this.Interval_s.TextChanged += new System.EventHandler(this.Interval_s_TextChanged);
            // 
            // Interval_h
            // 
            this.Interval_h.Location = new System.Drawing.Point(18, 27);
            this.Interval_h.Name = "Interval_h";
            this.Interval_h.Size = new System.Drawing.Size(39, 20);
            this.Interval_h.TabIndex = 0;
            this.Interval_h.Text = "0";
            this.Interval_h.TextChanged += new System.EventHandler(this.Interval_h_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.Delay_m);
            this.groupBox4.Controls.Add(this.Delay_s);
            this.groupBox4.Controls.Add(this.Delay_h);
            this.groupBox4.Location = new System.Drawing.Point(210, 268);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(578, 61);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Initial delay";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "seconds";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "minutes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "hours";
            // 
            // Delay_m
            // 
            this.Delay_m.Location = new System.Drawing.Point(122, 23);
            this.Delay_m.Name = "Delay_m";
            this.Delay_m.Size = new System.Drawing.Size(45, 20);
            this.Delay_m.TabIndex = 2;
            this.Delay_m.Text = "0";
            this.Delay_m.TextChanged += new System.EventHandler(this.Delay_m_TextChanged);
            // 
            // Delay_s
            // 
            this.Delay_s.Location = new System.Drawing.Point(235, 23);
            this.Delay_s.Name = "Delay_s";
            this.Delay_s.Size = new System.Drawing.Size(43, 20);
            this.Delay_s.TabIndex = 1;
            this.Delay_s.Text = "5";
            this.Delay_s.TextChanged += new System.EventHandler(this.Delay_s_TextChanged);
            // 
            // Delay_h
            // 
            this.Delay_h.Location = new System.Drawing.Point(18, 23);
            this.Delay_h.Name = "Delay_h";
            this.Delay_h.Size = new System.Drawing.Size(39, 20);
            this.Delay_h.TabIndex = 0;
            this.Delay_h.Text = "0";
            this.Delay_h.TextChanged += new System.EventHandler(this.Delay_h_TextChanged);
            // 
            // Button_ClearList
            // 
            this.Button_ClearList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_ClearList.Location = new System.Drawing.Point(41, 412);
            this.Button_ClearList.Name = "Button_ClearList";
            this.Button_ClearList.Size = new System.Drawing.Size(114, 27);
            this.Button_ClearList.TabIndex = 8;
            this.Button_ClearList.Text = "Clear log";
            this.Button_ClearList.UseVisualStyleBackColor = true;
            this.Button_ClearList.Click += new System.EventHandler(this.Button_ClearList_Click);
            // 
            // MessageWindow
            // 
            this.MessageWindow.AccessibleName = "MessageWindow";
            this.MessageWindow.FormattingEnabled = true;
            this.MessageWindow.Location = new System.Drawing.Point(12, 12);
            this.MessageWindow.Name = "MessageWindow";
            this.MessageWindow.Size = new System.Drawing.Size(182, 381);
            this.MessageWindow.TabIndex = 9;
            // 
            // Repeat_count
            // 
            this.Repeat_count.Location = new System.Drawing.Point(287, 31);
            this.Repeat_count.Name = "Repeat_count";
            this.Repeat_count.Size = new System.Drawing.Size(56, 20);
            this.Repeat_count.TabIndex = 2;
            this.Repeat_count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Repeat_count.ValueChanged += new System.EventHandler(this.Repeat_count_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 451);
            this.Controls.Add(this.MessageWindow);
            this.Controls.Add(this.Button_ClearList);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Button_stop);
            this.Controls.Add(this.Button_start);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Auto Clicker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Repeat_count)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_addPoint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Button_start;
        private System.Windows.Forms.Button Button_stop;
        private System.Windows.Forms.Button Button_clear;
        private System.Windows.Forms.TextBox Internal_interval;
        private System.Windows.Forms.TextBox Ypos;
        private System.Windows.Forms.TextBox Xpos;
        private System.Windows.Forms.CheckBox NRepeatCheck;
        private System.Windows.Forms.CheckBox RepeatCheck;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Interval_ms;
        private System.Windows.Forms.TextBox Interval_m;
        private System.Windows.Forms.TextBox Interval_s;
        private System.Windows.Forms.TextBox Interval_h;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Delay_m;
        private System.Windows.Forms.TextBox Delay_s;
        private System.Windows.Forms.TextBox Delay_h;
        private System.Windows.Forms.Button Button_ClearList;
        private System.Windows.Forms.ListBox MessageWindow;
        private System.Windows.Forms.NumericUpDown Repeat_count;
    }
}

