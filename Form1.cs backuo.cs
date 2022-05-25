using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace bpmtomstest1
{
    public partial class Form1 : Form
    {
        int bpmInput;
        const int divN = 60000;
        const int divD = 90000;
        const int divT = 40000;
        int result1;
        int result2;
        int result4;
        int result8;
        int result16;
        int[] targetColor = { 255, 255, 255 };
        int[] fadeRGB = new int[3];
        //msg msgBox = new msg(); - custom pop invalid message
        




        public Form1()
        {
            InitializeComponent();
            
        }
        
 
        
        private void Form1_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            guna2Elipse1.SetElipse(this);
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void butmin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }



        private void Form1_Enter(object sender, EventArgs e)
        {

        }

        private void butd_Click(object sender, EventArgs e)
        {
            this.butn.Checked = false;
            this.butt.Checked = false;
            modeLBL.Text = "Mode:Dotted";
            
            
        }

        private void butn_Click(object sender, EventArgs e)
        {
            this.butd.Checked = false;
            this.butt.Checked = false;
            modeLBL.Text = "Mode:Normal";




        }

        private void butt_Click(object sender, EventArgs e)
        {
            this.butn.Checked = false;
            this.butd.Checked = false;
            modeLBL.Text = "Mode:Triplets";
        }


        private void bpmTB_TextChanged(object sender, EventArgs e)
        {

            //auto focus change
            if (bpmTB.TextLength == bpmTB.MaxLength)
            {
                shadowLBL.Focus();
            }


        }

        private void bpmTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            //get only digits
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            this.bpmTB.ForeColor = System.Drawing.Color.Crimson;
            //this.bpmTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(87)))), ((int)(((byte)(229)))));
    
               
        }

        private void bpmTB_MouseClick(object sender, MouseEventArgs e)
        {
            this.bpmTB.Text = "";
            logMsg.Text = "";
            this.res1LBL.ForeColor = System.Drawing.Color.Black;
            this.resLBL2.ForeColor = System.Drawing.Color.Black;
            this.resLBL4.ForeColor = System.Drawing.Color.Black;
            this.resLBL8.ForeColor = System.Drawing.Color.Black;
            this.resLBL16.ForeColor = System.Drawing.Color.Black;

        }

        private void bpmTB_Leave(object sender, EventArgs e)
        {
            this.bpmTB.ForeColor = System.Drawing.Color.Black;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            butd.Focus();
   
            
        }

        private void modeLBL_Click(object sender, EventArgs e)
        {

        }




        private void butcal_Click(object sender, EventArgs e)
        {
            if (bpmTB.Text == "")
            {
                bpmInput = 0;
                //logMsg.Text = "Input a value"; - cheak why not working!
                this.res1LBL.ForeColor = System.Drawing.Color.Crimson;
                this.res1LBL.Text = "00";
                this.resLBL2.ForeColor = System.Drawing.Color.Crimson;
                this.resLBL2.Text = "00";
                this.resLBL4.ForeColor = System.Drawing.Color.Crimson;
                this.resLBL4.Text = "00";
                this.resLBL8.ForeColor = System.Drawing.Color.Crimson;
                this.resLBL8.Text = "00";
                this.resLBL16.ForeColor = System.Drawing.Color.Crimson;
                this.resLBL16.Text = "00";

            }
            else

                bpmInput = Convert.ToInt32(bpmTB.Text);

            if (bpmInput < 40 || bpmInput > 300)
            {
                logMsg.Text = "Input a value between 40-300";
                this.bpmTB.ForeColor = System.Drawing.Color.Crimson;
                this.res1LBL.ForeColor = System.Drawing.Color.Crimson;
                this.res1LBL.Text = "00";
                this.resLBL2.ForeColor = System.Drawing.Color.Crimson;
                this.resLBL2.Text = "00";
                this.resLBL4.ForeColor = System.Drawing.Color.Crimson;
                this.resLBL4.Text = "00";
                this.resLBL8.ForeColor = System.Drawing.Color.Crimson;
                this.resLBL8.Text = "00";
                this.resLBL16.ForeColor = System.Drawing.Color.Crimson;
                this.resLBL16.Text = "00";

            }

            //msgBox.Show(); - custom popup invalid message

            else if (butn.Checked == true)
            {
                result4 = divN / bpmInput;
                resLBL4.Text = Convert.ToString(result4);
                result1 = result4 * 4;
                res1LBL.Text = Convert.ToString(result1);
                result2 = result4 * 2;
                resLBL2.Text = Convert.ToString(result2);
                result8 = result4 / 2;
                resLBL8.Text = Convert.ToString(result8);
                result16 = result4 / 4;
                resLBL16.Text = Convert.ToString(result16);
            }
            else if (butd.Checked == true)
            {
                result4 = divD / bpmInput;
                resLBL4.Text = Convert.ToString(result4);
                result1 = result4 * 4;
                res1LBL.Text = Convert.ToString(result1);
                result2 = result4 * 2;
                resLBL2.Text = Convert.ToString(result2);
                result8 = result4 / 2;
                resLBL8.Text = Convert.ToString(result8);
                result16 = result4 / 4;
                resLBL16.Text = Convert.ToString(result16);

            }
            else if (butt.Checked == true)
            {
                result4 = divT / bpmInput;
                resLBL4.Text = Convert.ToString(result4);
                result1 = result4 * 4;
                res1LBL.Text = Convert.ToString(result1);
                result2 = result4 * 2;
                resLBL2.Text = Convert.ToString(result2);
                result8 = result4 / 2;
                resLBL8.Text = Convert.ToString(result8);
                result16 = result4 / 4;
                resLBL16.Text = Convert.ToString(result16);

            }



        }

        private void res1LBL_DoubleClick(object sender, EventArgs e)
        {
            logMsg.Text = "Copied!";
            res1LBL.ForeColor = System.Drawing.Color.White;
         
            timer1.Enabled = true;
        }

        private void resLBL2_DoubleClick(object sender, EventArgs e)
        {
            logMsg.Text = "Copied!";
            timer1.Enabled = true;
        }

        private void resLBL4_Click(object sender, EventArgs e)
        {
            logMsg.Text = "Copied!";
            timer1.Enabled = true;
        }

        private void resLBL8_Click(object sender, EventArgs e)
        {
            logMsg.Text = "Copied!";
            timer1.Enabled = true;
        }

        private void resLBL16_Click(object sender, EventArgs e)
        {
            logMsg.Text = "Copied!";
            timer1.Enabled = true;
        }

        private void res1LBL_MouseHover(object sender, EventArgs e)
        {
            logMsg.Text = "Double click to copy";
            timer1.Enabled = true;
        }

        private void res1LBL_MouseLeave(object sender, EventArgs e)
        {
            if (logMsg.Text == "Copied!")
                logMsg.Text = "Copied!";
            else
                logMsg.Text = "";
        }
        private void res2LBL_MouseHover(object sender, EventArgs e)
        {
            logMsg.Text = "Double click to copy";
        }

        private void res2LBL_MouseLeave(object sender, EventArgs e)
        {
            if (logMsg.Text == "Copied!")
                logMsg.Text = "Copied!";
            else
                logMsg.Text = "";
        }
        private void res4LBL_MouseHover(object sender, EventArgs e)
        {
            if (logMsg.Text =="")
            logMsg.Text = "Double click to copy";
        }

        private void res4LBL_MouseLeave(object sender, EventArgs e)
        {
            if (logMsg.Text == "Copied!")
                logMsg.Text = "Copied!";
            else
                logMsg.Text = "";
        }
        private void res8LBL_MouseHover(object sender, EventArgs e)
        {
            logMsg.Text = "Double click to copy";
        }

        private void res8LBL_MouseLeave(object sender, EventArgs e)
        {
            if (logMsg.Text == "Copied!")
                logMsg.Text = "Copied!";
            else
                logMsg.Text = "";
        }
        private void res16LBL_MouseHover(object sender, EventArgs e)
        {
            logMsg.Text = "Double click to copy";
        }

        private void res16LBL_MouseLeave(object sender, EventArgs e)
        {
            if (logMsg.Text == "Copied!")
                logMsg.Text = "Copied!";
            else
                logMsg.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            logMsg.Text = "";
            res1LBL.ForeColor = System.Drawing.Color.Black;
            timer1.Enabled = false;
        }
    }
}
