using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Diagnostics;

namespace ShutDown
{    
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            timer.Start();
            Final_Time_Set();
        }

        private void printText(Label label, int value)
        {
            if (value < 10)
                label.Text = "0" + value;
            else
                label.Text = "" + value;
        }

        private void Final_Time_Set()
        {
            DateTime time = System.DateTime.Now;

            int hour = time.Hour;
            int min = time.Minute;
            
            hour = (hour + Int32.Parse(HOUR_R.Text)) % 24;
            if (min + Int32.Parse(MIN_R.Text) > 60)
                hour = hour + 1;
            min = (min + Int32.Parse(MIN_R.Text)) % 60;

            printText(HOUR_F, hour);
            printText(MIN_F, min);
        }

        private void HOUR_P_Click(object sender, EventArgs e)
        {
            int hour = Int32.Parse(HOUR_R.Text);
            if (hour < 9)
                hour++;
            printText(HOUR_R, hour);
                        
            Final_Time_Set();
        }

        private void HOURS_M_Click(object sender, EventArgs e)
        {
            int hour = Int32.Parse(HOUR_R.Text);
            if (hour > 0)
                hour--;
            printText(HOUR_R, hour);

            Final_Time_Set();
        }

        private void MIN_P_Click(object sender, EventArgs e)
        {
            int min = Int32.Parse(MIN_R.Text);
            int hour = Int32.Parse(HOUR_R.Text);
            if (min < 50)
            {
                min += 10;
            }
            else if (hour < 9)
            {
                min = 0;
                hour++;
                printText(HOUR_R, hour);
            }
            printText(MIN_R, min);
            Final_Time_Set();
        }

        private void MIN_M_Click(object sender, EventArgs e)
        {
            int min = Int32.Parse(MIN_R.Text);
            int hour = Int32.Parse(HOUR_R.Text);
            if (min > 0)
            {
                min -= 10;
            }
            else if (hour > 0)
            {
                min = 50;
                hour--;
                printText(HOUR_R, hour);

            }
            printText(MIN_R, min);

            Final_Time_Set();
        }

        private void FHOUR_P_Click(object sender, EventArgs e)
        {
            int hour = Int32.Parse(HOUR_F.Text);
            int rhour = Int32.Parse(HOUR_R.Text);

            if (rhour < 9)
            {
                hour++;
                rhour++;

                hour = hour % 24;
                printText(HOUR_F, hour);
                printText(HOUR_R, rhour);
            }            
        }
    
        private void FHOUR_M_Click(object sender, EventArgs e)
        {
            int hour = Int32.Parse(HOUR_F.Text);
            int rhour = Int32.Parse(HOUR_R.Text);

            if (rhour > 0)
            {
                if (hour == 0)
                    hour = 24;
                hour--;
                rhour--;
                printText(HOUR_F, hour);
                printText(HOUR_R, rhour);
            }         
        }

        private void FMIN_P_Click(object sender, EventArgs e)
        {
            int min = Int32.Parse(MIN_F.Text);
            int rmin = Int32.Parse(MIN_R.Text);
            int hour = Int32.Parse(HOUR_F.Text);
            int rhour = Int32.Parse(HOUR_R.Text);

            if (rmin < 50)
            {
                rmin += 10;
                min += 10;
                if (min >= 60)
                {
                    min = min % 60;
                    hour++;
                }

            }
            else if (rhour < 9)
            {
                rmin = 0;
                rhour++;
                min += 10;
                if (min >= 60)
                {
                    min = min % 60;
                    hour++;
                }
            }

            printText(MIN_F, min);
            printText(MIN_R, rmin);
            printText(HOUR_F, hour);
            printText(HOUR_R, rhour);
        }

        private void FMIN_M_Click(object sender, EventArgs e)
        {
            int min = Int32.Parse(MIN_F.Text);
            int rmin = Int32.Parse(MIN_R.Text);
            int hour = Int32.Parse(HOUR_F.Text);
            int rhour = Int32.Parse(HOUR_R.Text);

            if (rmin > 0)
            {
                rmin -= 10;
                if (min < 10)
                {
                    min += 60;
                    if (hour == 0)
                        hour = 24;
                    hour--;
                }
                min -= 10;
            }
            else if (rhour > 0)
            {
                rmin = 50;
                rhour--;
                if(min < 10)
                {
                    min += 60;
                    if (hour == 0)
                        hour = 24;
                    hour--;
                }
                min -= 10;
            }
            printText(MIN_F, min);
            printText(MIN_R, rmin);
            printText(HOUR_F, hour);
            printText(HOUR_R, rhour);

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime time = System.DateTime.Now;
            DateTime shutTime = System.DateTime.Now;
            shutTime = shutTime.AddMinutes(Int32.Parse(MIN_R.Text));
            shutTime = shutTime.AddHours(Int32.Parse(HOUR_R.Text));            
            CurrentTime.Text = "Now is " + time.ToString("yyyy.MM.dd (ddd) HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"));
            SDTime.Text = "Shut Down at " + shutTime.ToString("yyyy.MM.dd (ddd) HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"));
        }

        private void doCMD(String cmdStr)
        {
            ProcessStartInfo cmd = new ProcessStartInfo();
            Process process = new Process();
            cmd.FileName = "cmd.exe";
            cmd.WindowStyle = ProcessWindowStyle.Hidden;
            cmd.CreateNoWindow = true;

            cmd.UseShellExecute = false;
            cmd.RedirectStandardInput = true;
            cmd.RedirectStandardOutput = true;
            cmd.RedirectStandardError = true;

            process.EnableRaisingEvents = false;
            process.StartInfo = cmd;
            process.Start();
            process.StandardInput.Write(cmdStr + Environment.NewLine);
            process.StandardInput.Close();

            string result = process.StandardOutput.ReadToEnd();
            StringBuilder sb = new StringBuilder();
            sb.Append("[Result Info]" + DateTime.Now + "\r\n");
            sb.Append(result);
            sb.Append("\r\n");

            //label2.Text = sb.ToString();
            process.WaitForExit();
            process.Close();
        }

        private void doShutDown_Click(object sender, EventArgs e)
        {
            doCMD("c:\\windows\\system32\\shutdown.exe -s -f -t " + (((Int32.Parse(HOUR_R.Text) * 60) + Int32.Parse(MIN_R.Text)) * 60));
            Application.Exit();
        }

        private void doCancel_Click(object sender, EventArgs e)
        {
            //Process.Start("Shutdown.exe", "-a");
            doCMD("c:\\windows\\system32\\shutdown.exe -a");
            Application.Exit();
        }
    }
}
