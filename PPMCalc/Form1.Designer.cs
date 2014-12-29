namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtPageCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeSeconds = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPPM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIPM = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.butStop = new System.Windows.Forms.Button();
            this.ResetBut = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ClearBut = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.timeMinutes = new System.Windows.Forms.TextBox();
            this.timeHours = new System.Windows.Forms.TextBox();
            this.timeMilliSec = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPageCount
            // 
            this.txtPageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPageCount.Location = new System.Drawing.Point(142, 31);
            this.txtPageCount.MaxLength = 7;
            this.txtPageCount.Name = "txtPageCount";
            this.txtPageCount.Size = new System.Drawing.Size(100, 26);
            this.txtPageCount.TabIndex = 1;
            this.txtPageCount.TextChanged += new System.EventHandler(this.txtPageCount_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pages Scanned:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Time:";
            // 
            // timeSeconds
            // 
            this.timeSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSeconds.Location = new System.Drawing.Point(224, 63);
            this.timeSeconds.MaxLength = 6;
            this.timeSeconds.Name = "timeSeconds";
            this.timeSeconds.Size = new System.Drawing.Size(34, 26);
            this.timeSeconds.TabIndex = 3;
            this.timeSeconds.TextChanged += new System.EventHandler(this.txtTimeCount_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "PPM:";
            // 
            // txtPPM
            // 
            this.txtPPM.Enabled = false;
            this.txtPPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPPM.Location = new System.Drawing.Point(142, 110);
            this.txtPPM.Name = "txtPPM";
            this.txtPPM.Size = new System.Drawing.Size(100, 26);
            this.txtPPM.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "IPM:";
            // 
            // txtIPM
            // 
            this.txtIPM.Enabled = false;
            this.txtIPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPM.Location = new System.Drawing.Point(142, 142);
            this.txtIPM.Name = "txtIPM";
            this.txtIPM.Size = new System.Drawing.Size(100, 26);
            this.txtIPM.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(417, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(470, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Stop Watch";
            // 
            // butStop
            // 
            this.butStop.BackColor = System.Drawing.Color.Red;
            this.butStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butStop.Location = new System.Drawing.Point(486, 38);
            this.butStop.Name = "butStop";
            this.butStop.Size = new System.Drawing.Size(62, 49);
            this.butStop.TabIndex = 13;
            this.butStop.Text = "Stop";
            this.butStop.UseVisualStyleBackColor = false;
            this.butStop.Click += new System.EventHandler(this.butStop_Click);
            // 
            // ResetBut
            // 
            this.ResetBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBut.Location = new System.Drawing.Point(554, 38);
            this.ResetBut.Name = "ResetBut";
            this.ResetBut.Size = new System.Drawing.Size(62, 49);
            this.ResetBut.TabIndex = 14;
            this.ResetBut.Text = "Reset";
            this.ResetBut.UseVisualStyleBackColor = true;
            this.ResetBut.Click += new System.EventHandler(this.ResetBut_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ClearBut
            // 
            this.ClearBut.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBut.Location = new System.Drawing.Point(129, 185);
            this.ClearBut.Name = "ClearBut";
            this.ClearBut.Size = new System.Drawing.Size(122, 37);
            this.ClearBut.TabIndex = 15;
            this.ClearBut.Text = "Clear All";
            this.ClearBut.UseVisualStyleBackColor = true;
            this.ClearBut.Click += new System.EventHandler(this.ClearBut_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(676, 294);
            this.shapeContainer1.TabIndex = 16;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 90;
            this.lineShape3.X2 = 291;
            this.lineShape3.Y1 = 176;
            this.lineShape3.Y2 = 176;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 63;
            this.lineShape2.X2 = 316;
            this.lineShape2.Y1 = 99;
            this.lineShape2.Y2 = 99;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 382;
            this.lineShape1.X2 = 643;
            this.lineShape1.Y1 = 32;
            this.lineShape1.Y2 = 32;
            // 
            // timeMinutes
            // 
            this.timeMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeMinutes.Location = new System.Drawing.Point(184, 63);
            this.timeMinutes.MaxLength = 6;
            this.timeMinutes.Name = "timeMinutes";
            this.timeMinutes.Size = new System.Drawing.Size(34, 26);
            this.timeMinutes.TabIndex = 17;
            this.timeMinutes.TextChanged += new System.EventHandler(this.timeMinutes_TextChanged);
            // 
            // timeHours
            // 
            this.timeHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeHours.Location = new System.Drawing.Point(144, 63);
            this.timeHours.MaxLength = 6;
            this.timeHours.Name = "timeHours";
            this.timeHours.Size = new System.Drawing.Size(34, 26);
            this.timeHours.TabIndex = 18;
            // 
            // timeMilliSec
            // 
            this.timeMilliSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeMilliSec.Location = new System.Drawing.Point(264, 63);
            this.timeMilliSec.MaxLength = 6;
            this.timeMilliSec.Name = "timeMilliSec";
            this.timeMilliSec.Size = new System.Drawing.Size(34, 26);
            this.timeMilliSec.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 294);
            this.Controls.Add(this.timeMilliSec);
            this.Controls.Add(this.timeHours);
            this.Controls.Add(this.timeMinutes);
            this.Controls.Add(this.ClearBut);
            this.Controls.Add(this.ResetBut);
            this.Controls.Add(this.butStop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIPM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPPM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeSeconds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPageCount);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peter\'s Multifunctional Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPageCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox timeSeconds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPPM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIPM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butStop;
        private System.Windows.Forms.Button ResetBut;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ClearBut;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.TextBox timeMinutes;
        private System.Windows.Forms.TextBox timeHours;
        private System.Windows.Forms.TextBox timeMilliSec;
    }
}

