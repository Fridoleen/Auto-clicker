using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_clicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KeyboardInterceptor.OnClick += KeyboardClicked;

        }

        private void AddPoint_Click(object sender, EventArgs e)
        {
            if (Xpos.Text == "" && Ypos.Text == "")
            {
                this.WindowState = FormWindowState.Minimized;
                MouseInterceptor.OnClick += MouseClicked;
            }
            else if (Xpos.Text == "" || Ypos.Text == "")
            {
                ToolTip tip = new ToolTip();
                tip.IsBalloon = true;
                tip.InitialDelay = 0;
                tip.ShowAlways = true;
                tip.Show("Need two numbers!", this.Xpos, 2000);
            }
            else
            {
                ClickPattern.AddPoint(Int32.Parse(Xpos.Text), Int32.Parse(Ypos.Text),
                    Int32.Parse(Internal_interval.Text));
                MessageWindow.Items.Add("Point added (" + Xpos.Text + ", " + Ypos.Text + ")");
            }
        }

        private void MouseClicked(Point pt)
        {
            ClickPattern.AddPoint(pt.x, pt.y, Int32.Parse(Internal_interval.Text));
            MessageWindow.Items.Add("Added point (" + pt.x + ", " + pt.y + ")");
            MouseInterceptor.OnClick -= MouseClicked;
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void KeyboardClicked(int key)
        {
            if(key == 117)
            {
                if(! ClickPattern.OnStatus())
                {                 
                    Start();
                }
                else
                {                    
                    Stop();
                }
            }
        }        

        private void Button_clear_Click(object sender, EventArgs e)
        {
            MessageWindow.Items.Clear();
        }

        private void YCoord_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(Ypos.Text, out int sec))
            {
                Ypos.Text = "";
                ToolTip tip = new ToolTip();
                tip.IsBalloon = true;
                tip.InitialDelay = 0;
                tip.ShowAlways = true;
                tip.Show("Must enter a number!", this.Ypos, 2000);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(Interval_m.Text, out int sec))
            {
                Interval_m.Text = "";
                ToolTip tip = new ToolTip();
                tip.IsBalloon = true;
                tip.InitialDelay = 0;
                tip.ShowAlways = true;
                tip.Show("Must enter a number!", this.Interval_m, 2000);
            }
        }

        private void Button_ClearList_Click(object sender, EventArgs e)
        {
            MessageWindow.Items.Clear();
        }        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (RepeatCheck.Checked) NRepeatCheck.Checked = false;
            else NRepeatCheck.Checked = true;
        }
        
        private void XCoord_TextChanged_1(object sender, EventArgs e)
        {
            if (!Int32.TryParse(Xpos.Text, out int sec))
            {
                Xpos.Text = "";
                ToolTip tip = new ToolTip();
                tip.IsBalloon = true;
                tip.InitialDelay = 0;
                tip.ShowAlways = true;
                tip.Show("Must enter a number!", this.Xpos, 2000);
            }
        }

        private void Delay_s_TextChanged(object sender, EventArgs e)
        {
            if(! Int32.TryParse(Delay_s.Text, out int sec))
            {
                Delay_s.Text = "";
                ToolTip tip = new ToolTip();
                tip.IsBalloon = true;
                tip.InitialDelay = 0;
                tip.ShowAlways = true;
                tip.Show("Must enter a number!", this.Delay_s, 2000);
            }
        }

        

        private void Delay_h_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(Delay_h.Text, out int sec))
            {
                Delay_h.Text = "";
                ToolTip tip = new ToolTip();
                tip.IsBalloon = true;
                tip.InitialDelay = 0;
                tip.ShowAlways = true;
                tip.Show("Must enter a number!", this.Delay_h, 2000);
            }
        }

        private void Delay_m_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(Delay_m.Text, out int sec))
            {
                Delay_m.Text = "";
                ToolTip tip = new ToolTip();
                tip.IsBalloon = true;
                tip.InitialDelay = 0;
                tip.ShowAlways = true;
                tip.Show("Must enter a number!", this.Delay_m, 2000);
            }
        }

        private void Interval_h_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(Interval_h.Text, out int sec))
            {
                Interval_h.Text = "";
                ToolTip tip = new ToolTip();
                tip.IsBalloon = true;
                tip.InitialDelay = 0;
                tip.ShowAlways = true;
                tip.Show("Must enter a number!", this.Interval_h, 2000);
            }
        }

        private void Interval_s_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(Interval_s.Text, out int sec))
            {
                Interval_s.Text = "";
                ToolTip tip = new ToolTip();
                tip.IsBalloon = true;
                tip.InitialDelay = 0;
                tip.ShowAlways = true;
                tip.Show("Must enter a number!", this.Interval_s, 2000);
            }
        }

        private void Interval_ms_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(Interval_ms.Text, out int sec))
            {
                Interval_ms.Text = "";
                ToolTip tip = new ToolTip();
                tip.IsBalloon = true;
                tip.InitialDelay = 0;
                tip.ShowAlways = true;
                tip.Show("Must enter a number!", this.Interval_ms, 2000);
            }
        }

        private void Internal_interval_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(Internal_interval.Text, out int sec))
            {
                Internal_interval.Text = "";
                ToolTip tip = new ToolTip();
                tip.IsBalloon = true;
                tip.InitialDelay = 0;
                tip.ShowAlways = true;
                tip.Show("Must enter a number!", this.Internal_interval, 2000);
            }
        }

        private void Repeat_count_ValueChanged(object sender, EventArgs e)
        {
            RepeatCheck.Checked = false;
            NRepeatCheck.Checked = true;
        }
        
        private void Start()
        {
            MessageWindow.Items.Add("Pattern clicking started");
            Console.WriteLine("Pattern started");
            ClickPattern.SwitchOn();
            int interval = Int32.Parse(Interval_h.Text) * 60 * 60 * 1000 +
                Int32.Parse(Interval_m.Text) * 60 * 1000 +
                Int32.Parse(Interval_s.Text) * 1000 +
                Int32.Parse(Interval_ms.Text);
            int delay = Int32.Parse(Delay_h.Text) * 60 * 60 * 1000 +
                Int32.Parse(Delay_m.Text) * 60 * 1000 +
                Int32.Parse(Delay_s.Text) * 1000;
            ClickPattern.SetInterval(interval);

            Timer _tmr = new Timer();
            _tmr.Interval = delay;
            _tmr.Tick += (Object sender, EventArgs e) =>
            {
                if (ClickPattern.OnStatus())
                { 
                    if (RepeatCheck.Checked)
                    {
                        ClickPattern.Click();
                    }
                    else
                    {
                        ClickPattern.Click(Decimal.ToInt32(Repeat_count.Value));
                    }
                }
                _tmr.Stop();
            };
            _tmr.Start();
        }

        private void Stop()
        {
            MessageWindow.Items.Add("Pattern clicking stopped");
            Console.WriteLine("Pattern stopped");
            ClickPattern.SwitchOff();
        }

        private void Button_start_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void Button_stop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void NRepeatCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (NRepeatCheck.Checked) RepeatCheck.Checked = false;
            else RepeatCheck.Checked = true;
        }
    }
}
