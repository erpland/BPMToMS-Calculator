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
using Telerik.WinControls.UI;

namespace bpmtomstest1
{
    public partial class Form1 : Form
    {
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

        private void bpmtextbox_Enter(object sender, EventArgs e)
        {
            this.bpmtextbox.ForeColor = System.Drawing.Color.Red;

        }

        private void bpmtextbox_Leave(object sender, EventArgs e)
        {
            this.bpmtextbox.ForeColor = System.Drawing.Color.Black;
        }

        private void bpmtextbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            this.bpmtextbox.ForeColor = System.Drawing.Color.Black;
        }

        private void butd_Click(object sender, EventArgs e)
        {
            this.butn.Checked = false;
            this.butt.Checked = false;
        }

        private void butn_Click(object sender, EventArgs e)
        {
            this.butd.Checked = false;
            this.butt.Checked = false;

        }

        private void butt_Click(object sender, EventArgs e)
        {
            this.butn.Checked = false;
            this.butd.Checked = false;
        }

        private void bpmtextbox_MouseClick(object sender, MouseEventArgs e)
        {
            this.bpmtextbox.SelectAll();
        }


        private void bpmtextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void bpmTB_TextChanged(object sender, EventArgs e)
        {
            // auto focus change
            //if (bpmTB.TextLength == bpmTB.MaxLength)
            //    butd.Focus();
            
        }

        private void bpmTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            
            this.bpmTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(87)))), ((int)(((byte)(229)))));
    
               
        }

        private void bpmTB_MouseClick(object sender, MouseEventArgs e)
        {
            this.bpmTB.Text = "";
        }

        private void bpmTB_Leave(object sender, EventArgs e)
        {
            this.bpmTB.ForeColor = System.Drawing.Color.Black;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            butd.Focus();
        }
    }
}
