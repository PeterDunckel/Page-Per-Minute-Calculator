using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using extra;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private DateTime _startTime;

        public Form1()
        {
            InitializeComponent();
        }



        private int CheckIntParam(string value, string message)
        {
            int val;
            bool isGood = Int32.TryParse(value, out val);
            if (!isGood)
            {
                throw new Exception(message);
            }
            return val;
        }

        private double CheckDoubleParam(string value, string message)
        {
            double val;
            bool isGood = double.TryParse(value, out val);
            if (!isGood)
            {
                throw new Exception(message);
            }
            return val;
        }

        private void Calculate()
        {
            try
            {
                int pageCount = CheckIntParam(txtPageCount.Text, "ERROR");
                Double timeOfScan = CheckDoubleParam(timeSeconds.Text, "ERROR");

                var calculator = new MathFunctions();

                double  pagesPerMinute = calculator.CalcPagesPerMinute(pageCount, timeOfScan);

                double imagesPerMinute = calculator.CalcImagesPerMinute(pageCount, timeOfScan);

                txtPPM.Text = Math.Round(pagesPerMinute, 1).ToString();
                txtIPM.Text = Math.Round(imagesPerMinute, 1).ToString();
            }
            catch (Exception ex)
            {
                txtPPM.Text = ex.Message;
                txtIPM.Text = ex.Message;
                //ReportError(ex);
            }
        }

        private void butCalculate_Click(object sender, EventArgs e)
        {
            Calculate();
        }



        private void btnStart_Click(object sender, EventArgs e)
        {
            if (timeSeconds.Text == "")
            {
                timeSeconds.Text = "0";
                timeMinutes.Text = "0";
                timeHours.Text = "0";
                timeMilliSec.Text = "0";


            }

            try
            {
                Double timeOfScan = CheckDoubleParam(timeSeconds.Text, "Time must be a double");
                timeSeconds.Enabled = false;
                timeHours.Enabled = false;
                timeMinutes.Enabled = false;
                timeMilliSec.Enabled = false;
                _startTime = GetTimeFromUiOrNow();
                timer1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            ClearBut.Enabled = false;
            ResetBut.Enabled = false;

        }

        private DateTime GetTimeFromUiOrNow()
        {
            //if (timeSeconds.Text != "")
            {
                int hrs = CheckIntParam(timeHours.Text,"Bad hours!");
                int mins = CheckIntParam(timeMinutes.Text, "Bad minutes!");
                int secs = CheckIntParam(timeSeconds.Text, "Bad seconds!");
                int milliSecs = CheckIntParam(timeMilliSec.Text, "Bad milliseconds!");

                return DateTime.Now - new TimeSpan(0,hrs, mins, secs, milliSecs);
            }
            //return DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var ts = (DateTime.Now - _startTime);

            //var ts = new TimeSpan((long)(_stopWatchTime*10000000));

            timeMilliSec.Text = ts.Milliseconds.ToString();
            timeSeconds.Text = ts.Seconds.ToString();
            timeMinutes.Text = ts.Minutes.ToString();
            timeHours.Text = ts.Hours.ToString();

            //String timeInSec = "00";
            //String timeInMiimen = "00";
            //String timeInHr = "00";

            //timeInSec = (CheckDoubleParam(timeSeconds.Text, "bad double") + .1).ToString();

            //if (timeInSec == "60")
            //{
            //    timeInSec = "00";
            //    timeInMin = (CheckDoubleParam(timeMinutes.Text, "bad double") + 1).ToString();


            //}
            //if (timeInMin == "60")
            //{
            //    timeInMin = "00";
            //    timeInHr = "00";
            //}

            //timeSeconds.Text = timeInSec;
            //timeMinutes.Text = timeInMin;
            //timeHours.Text = timeInHr;

        }

        private void butStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timeSeconds.Enabled = true;

            if (txtPageCount.Text != "")
            {
                Calculate();
            }

            ClearBut.Enabled = true;
            ResetBut.Enabled = true;
        }

        private void ResetBut_Click(object sender, EventArgs e)
        {
            timeMilliSec.Text = "";
            timeMinutes.Text = "";
            timeHours.Text = "";
            timeSeconds.Text = "";
            txtPPM.Text = "";
            txtIPM.Text = "";
        }

        private void ClearBut_Click(object sender, EventArgs e)
        {
            try
            {
                if (timer1.Enabled)
                {
                    
                    //throw new Exception("Can't clear while clock is running!");
                }

                timeMilliSec.Text = "";
                timeMinutes.Text = "";
                timeHours.Text = "";
                timeSeconds.Text = "";
                txtPageCount.Text = "";
                txtPPM.Text = "";
                txtIPM.Text = ""; 


             
            }
            catch (Exception ex)
            {
                ReportError(ex);
            }
        }

        private void ReportError(Exception ex)
        {
            MessageBox.Show("An error occurred: " + ex.Message);
           
        }

        private void txtPageCount_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtTimeCount_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void timeMinutes_TextChanged(object sender, EventArgs e)
        {
            
        }

       
    }
}
