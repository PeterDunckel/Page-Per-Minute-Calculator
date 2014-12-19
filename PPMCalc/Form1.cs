using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
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
                int pageCount = CheckIntParam(txtPageCount.Text, "Page Count must be an integer");
                Double timeOfScan = CheckDoubleParam(txtTimeCount.Text, "Time must be a double");

                double pagesPerMinute = 60.0 * pageCount / timeOfScan;

                double imagesPerMinute = 2 * 60.0 * pageCount / timeOfScan;

                txtPPM.Text = Math.Round(pagesPerMinute, 1).ToString();
                txtIPM.Text = Math.Round(imagesPerMinute, 1).ToString();
            }
            catch (Exception ex)
            {
                txtPPM.Text = ex.Message;
                //ReportError(ex);
            }
        }

        private void butCalculate_Click(object sender, EventArgs e)
        {
            Calculate();
        }



        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtTimeCount.Text == "")
            {
                txtTimeCount.Text = "0";
            }

            try
            {
                Double timeOfScan = CheckDoubleParam(txtTimeCount.Text, "Time must be a double");
                txtTimeCount.Enabled = false;
                timer1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTimeCount.Text = (CheckDoubleParam(txtTimeCount.Text, "bad double") + .1).ToString();
        }

        private void butStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            txtTimeCount.Enabled = true;

            if (txtPageCount.Text != "")
            {

                Calculate();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtTimeCount.Text = "";
        }

        private void ClearBut_Click(object sender, EventArgs e)
        {
            try
            {
                if (timer1.Enabled)
                {
                    throw new Exception("Can't clear while clock is running!");
                }
                txtTimeCount.Text = "";
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

       

      

        

        
    }
}
