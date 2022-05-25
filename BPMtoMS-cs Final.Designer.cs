using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using System.Drawing;

namespace bpmtomstest1
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
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.butext = new Guna.UI2.WinForms.Guna2Button();
            this.butmin = new Guna.UI2.WinForms.Guna2Button();
            this.res1LBL = new System.Windows.Forms.Label();
            this.resLBL2 = new System.Windows.Forms.Label();
            this.resLBL4 = new System.Windows.Forms.Label();
            this.resLBL8 = new System.Windows.Forms.Label();
            this.butcal = new Guna.UI2.WinForms.Guna2Button();
            this.butn = new Guna.UI2.WinForms.Guna2Button();
            this.butd = new Guna.UI2.WinForms.Guna2Button();
            this.butt = new Guna.UI2.WinForms.Guna2Button();
            this.bpmTB = new System.Windows.Forms.TextBox();
            this.modeLBL = new System.Windows.Forms.Label();
            this.resLBL16 = new System.Windows.Forms.Label();
            this.logMsg = new System.Windows.Forms.Label();
            this.shadowLBL = new System.Windows.Forms.Label();
            this.timerText = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // butext
            // 
            this.butext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butext.BackColor = System.Drawing.Color.Transparent;
            this.butext.CheckedState.Parent = this.butext;
            this.butext.CustomImages.Parent = this.butext;
            this.butext.FillColor = System.Drawing.Color.Transparent;
            this.butext.Font = new System.Drawing.Font("Candara Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butext.ForeColor = System.Drawing.Color.DimGray;
            this.butext.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.butext.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.butext.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.butext.HoverState.ForeColor = System.Drawing.Color.Black;
            this.butext.HoverState.Parent = this.butext;
            this.butext.Location = new System.Drawing.Point(614, 3);
            this.butext.Name = "butext";
            this.butext.PressedDepth = 0;
            this.butext.ShadowDecoration.Parent = this.butext;
            this.butext.Size = new System.Drawing.Size(33, 33);
            this.butext.TabIndex = 0;
            this.butext.Text = "X";
            this.butext.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // butmin
            // 
            this.butmin.AccessibleName = "butmin";
            this.butmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butmin.AutoRoundedCorners = true;
            this.butmin.BackColor = System.Drawing.Color.Transparent;
            this.butmin.BorderRadius = 15;
            this.butmin.CheckedState.Parent = this.butmin;
            this.butmin.CustomImages.Parent = this.butmin;
            this.butmin.FillColor = System.Drawing.Color.Transparent;
            this.butmin.Font = new System.Drawing.Font("Candara Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butmin.ForeColor = System.Drawing.Color.DimGray;
            this.butmin.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.butmin.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.butmin.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.butmin.HoverState.ForeColor = System.Drawing.Color.Black;
            this.butmin.HoverState.Parent = this.butmin;
            this.butmin.Location = new System.Drawing.Point(589, 1);
            this.butmin.Name = "butmin";
            this.butmin.PressedDepth = 0;
            this.butmin.ShadowDecoration.Parent = this.butmin;
            this.butmin.Size = new System.Drawing.Size(33, 33);
            this.butmin.TabIndex = 1;
            this.butmin.Text = "-";
            this.butmin.Click += new System.EventHandler(this.butmin_Click);
            // 
            // res1LBL
            // 
            this.res1LBL.BackColor = System.Drawing.Color.Transparent;
            this.res1LBL.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res1LBL.Location = new System.Drawing.Point(106, 264);
            this.res1LBL.Name = "res1LBL";
            this.res1LBL.Size = new System.Drawing.Size(52, 23);
            this.res1LBL.TabIndex = 3;
            this.res1LBL.Text = "00";
            this.res1LBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.res1LBL.DoubleClick += new System.EventHandler(this.res1LBL_DoubleClick);
            this.res1LBL.MouseLeave += new System.EventHandler(this.res1LBL_MouseLeave);
            this.res1LBL.MouseHover += new System.EventHandler(this.res1LBL_MouseHover);
            // 
            // resLBL2
            // 
            this.resLBL2.BackColor = System.Drawing.Color.Transparent;
            this.resLBL2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resLBL2.Location = new System.Drawing.Point(205, 264);
            this.resLBL2.Name = "resLBL2";
            this.resLBL2.Size = new System.Drawing.Size(52, 23);
            this.resLBL2.TabIndex = 3;
            this.resLBL2.Text = "00";
            this.resLBL2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resLBL2.DoubleClick += new System.EventHandler(this.resLBL2_DoubleClick);
            this.resLBL2.MouseLeave += new System.EventHandler(this.res2LBL_MouseLeave);
            this.resLBL2.MouseHover += new System.EventHandler(this.res2LBL_MouseHover);
            // 
            // resLBL4
            // 
            this.resLBL4.BackColor = System.Drawing.Color.Transparent;
            this.resLBL4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resLBL4.Location = new System.Drawing.Point(303, 264);
            this.resLBL4.Name = "resLBL4";
            this.resLBL4.Size = new System.Drawing.Size(52, 23);
            this.resLBL4.TabIndex = 3;
            this.resLBL4.Text = "00";
            this.resLBL4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resLBL4.DoubleClick += new System.EventHandler(this.resLBL4DoubleClick);
            this.resLBL4.MouseLeave += new System.EventHandler(this.res4LBL_MouseLeave);
            this.resLBL4.MouseHover += new System.EventHandler(this.res4LBL_MouseHover);
            // 
            // resLBL8
            // 
            this.resLBL8.BackColor = System.Drawing.Color.Transparent;
            this.resLBL8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resLBL8.Location = new System.Drawing.Point(399, 264);
            this.resLBL8.Name = "resLBL8";
            this.resLBL8.Size = new System.Drawing.Size(52, 23);
            this.resLBL8.TabIndex = 3;
            this.resLBL8.Text = "00";
            this.resLBL8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resLBL8.DoubleClick += new System.EventHandler(this.resLBL8DoubleClick);
            this.resLBL8.MouseLeave += new System.EventHandler(this.res8LBL_MouseLeave);
            this.resLBL8.MouseHover += new System.EventHandler(this.res8LBL_MouseHover);
            // 
            // butcal
            // 
            this.butcal.BackColor = System.Drawing.Color.Transparent;
            this.butcal.BorderColor = System.Drawing.Color.Red;
            this.butcal.BorderRadius = 30;
            this.butcal.CheckedState.Parent = this.butcal;
            this.butcal.CustomImages.Parent = this.butcal;
            this.butcal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(87)))), ((int)(((byte)(229)))));
            this.butcal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butcal.ForeColor = System.Drawing.Color.White;
            this.butcal.HoverState.Parent = this.butcal;
            this.butcal.Location = new System.Drawing.Point(297, 124);
            this.butcal.Name = "butcal";
            this.butcal.ShadowDecoration.BorderRadius = 30;
            this.butcal.ShadowDecoration.Depth = 0;
            this.butcal.ShadowDecoration.Enabled = true;
            this.butcal.ShadowDecoration.Parent = this.butcal;
            this.butcal.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 3);
            this.butcal.Size = new System.Drawing.Size(170, 79);
            this.butcal.TabIndex = 4;
            this.butcal.Text = "CALCULATE";
            this.butcal.TextOffset = new System.Drawing.Point(0, 1);
            this.butcal.Click += new System.EventHandler(this.butcal_Click);
            // 
            // butn
            // 
            this.butn.BackColor = System.Drawing.Color.Transparent;
            this.butn.BorderColor = System.Drawing.Color.Transparent;
            this.butn.BorderRadius = 12;
            this.butn.BorderThickness = 1;
            this.butn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.butn.Checked = true;
            this.butn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(87)))), ((int)(((byte)(229)))));
            this.butn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.butn.CheckedState.Parent = this.butn;
            this.butn.CustomImages.Parent = this.butn;
            this.butn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(237)))));
            this.butn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butn.ForeColor = System.Drawing.Color.Black;
            this.butn.HoverState.Parent = this.butn;
            this.butn.Location = new System.Drawing.Point(21, 130);
            this.butn.Name = "butn";
            this.butn.ShadowDecoration.BorderRadius = 12;
            this.butn.ShadowDecoration.Depth = 12;
            this.butn.ShadowDecoration.Enabled = true;
            this.butn.ShadowDecoration.Parent = this.butn;
            this.butn.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 3);
            this.butn.Size = new System.Drawing.Size(45, 42);
            this.butn.TabIndex = 5;
            this.butn.Text = "N";
            this.butn.TextOffset = new System.Drawing.Point(0, 2);
            this.butn.Click += new System.EventHandler(this.butn_Click);
            // 
            // butd
            // 
            this.butd.BackColor = System.Drawing.Color.Transparent;
            this.butd.BorderColor = System.Drawing.Color.Transparent;
            this.butd.BorderRadius = 12;
            this.butd.BorderThickness = 1;
            this.butd.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.butd.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(87)))), ((int)(((byte)(229)))));
            this.butd.CheckedState.ForeColor = System.Drawing.Color.White;
            this.butd.CheckedState.Parent = this.butd;
            this.butd.CustomImages.Parent = this.butd;
            this.butd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(237)))));
            this.butd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butd.ForeColor = System.Drawing.Color.Black;
            this.butd.HoverState.Parent = this.butd;
            this.butd.Location = new System.Drawing.Point(21, 178);
            this.butd.Name = "butd";
            this.butd.ShadowDecoration.BorderRadius = 12;
            this.butd.ShadowDecoration.Depth = 12;
            this.butd.ShadowDecoration.Enabled = true;
            this.butd.ShadowDecoration.Parent = this.butd;
            this.butd.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 3);
            this.butd.Size = new System.Drawing.Size(45, 42);
            this.butd.TabIndex = 5;
            this.butd.Text = "D";
            this.butd.TextOffset = new System.Drawing.Point(0, 2);
            this.butd.Click += new System.EventHandler(this.butd_Click);
            // 
            // butt
            // 
            this.butt.BackColor = System.Drawing.Color.Transparent;
            this.butt.BorderColor = System.Drawing.Color.Transparent;
            this.butt.BorderRadius = 12;
            this.butt.BorderThickness = 1;
            this.butt.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.butt.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(87)))), ((int)(((byte)(229)))));
            this.butt.CheckedState.ForeColor = System.Drawing.Color.White;
            this.butt.CheckedState.Parent = this.butt;
            this.butt.CustomImages.Parent = this.butt;
            this.butt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(237)))));
            this.butt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt.ForeColor = System.Drawing.Color.Black;
            this.butt.HoverState.Parent = this.butt;
            this.butt.Location = new System.Drawing.Point(21, 226);
            this.butt.Name = "butt";
            this.butt.ShadowDecoration.BorderRadius = 12;
            this.butt.ShadowDecoration.Depth = 12;
            this.butt.ShadowDecoration.Enabled = true;
            this.butt.ShadowDecoration.Parent = this.butt;
            this.butt.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 3);
            this.butt.Size = new System.Drawing.Size(45, 42);
            this.butt.TabIndex = 5;
            this.butt.Text = "T";
            this.butt.TextOffset = new System.Drawing.Point(0, 2);
            this.butt.Click += new System.EventHandler(this.butt_Click);
            // 
            // bpmTB
            // 
            this.bpmTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.bpmTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bpmTB.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpmTB.ForeColor = System.Drawing.Color.Black;
            this.bpmTB.Location = new System.Drawing.Point(204, 153);
            this.bpmTB.MaxLength = 3;
            this.bpmTB.Name = "bpmTB";
            this.bpmTB.Size = new System.Drawing.Size(42, 18);
            this.bpmTB.TabIndex = 7;
            this.bpmTB.Text = "000";
            this.bpmTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bpmTB.WordWrap = false;
            this.bpmTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bpmTB_MouseClick);
            this.bpmTB.TextChanged += new System.EventHandler(this.bpmTB_TextChanged);
            this.bpmTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bpmTB_KeyPress);
            this.bpmTB.Leave += new System.EventHandler(this.bpmTB_Leave);
            // 
            // modeLBL
            // 
            this.modeLBL.AutoSize = true;
            this.modeLBL.BackColor = System.Drawing.Color.Transparent;
            this.modeLBL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeLBL.ForeColor = System.Drawing.Color.DarkGray;
            this.modeLBL.Location = new System.Drawing.Point(18, 375);
            this.modeLBL.Name = "modeLBL";
            this.modeLBL.Size = new System.Drawing.Size(102, 18);
            this.modeLBL.TabIndex = 8;
            this.modeLBL.Text = "Mode:Normal";
            this.modeLBL.Click += new System.EventHandler(this.modeLBL_Click);
            // 
            // resLBL16
            // 
            this.resLBL16.BackColor = System.Drawing.Color.Transparent;
            this.resLBL16.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resLBL16.Location = new System.Drawing.Point(495, 264);
            this.resLBL16.Name = "resLBL16";
            this.resLBL16.Size = new System.Drawing.Size(52, 23);
            this.resLBL16.TabIndex = 3;
            this.resLBL16.Text = "00";
            this.resLBL16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resLBL16.DoubleClick += new System.EventHandler(this.resLBL16_DoubleClick);
            this.resLBL16.MouseLeave += new System.EventHandler(this.res16LBL_MouseLeave);
            this.resLBL16.MouseHover += new System.EventHandler(this.res16LBL_MouseHover);
            // 
            // logMsg
            // 
            this.logMsg.AutoSize = true;
            this.logMsg.BackColor = System.Drawing.Color.Transparent;
            this.logMsg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logMsg.ForeColor = System.Drawing.Color.DarkGray;
            this.logMsg.Location = new System.Drawing.Point(121, 375);
            this.logMsg.Name = "logMsg";
            this.logMsg.Size = new System.Drawing.Size(0, 18);
            this.logMsg.TabIndex = 9;
            // 
            // shadowLBL
            // 
            this.shadowLBL.AutoSize = true;
            this.shadowLBL.Location = new System.Drawing.Point(21, 1);
            this.shadowLBL.Name = "shadowLBL";
            this.shadowLBL.Size = new System.Drawing.Size(0, 13);
            this.shadowLBL.TabIndex = 10;
            // 
            // timerText
            // 
            this.timerText.Interval = 800;
            this.timerText.Tick += new System.EventHandler(this.timerText_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.butcal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bpmtomstest1.Properties.Resources.Bpm_to_ms_Calculator___Change;
            this.ClientSize = new System.Drawing.Size(650, 402);
            this.Controls.Add(this.shadowLBL);
            this.Controls.Add(this.logMsg);
            this.Controls.Add(this.modeLBL);
            this.Controls.Add(this.bpmTB);
            this.Controls.Add(this.butt);
            this.Controls.Add(this.butd);
            this.Controls.Add(this.butn);
            this.Controls.Add(this.butcal);
            this.Controls.Add(this.resLBL16);
            this.Controls.Add(this.resLBL8);
            this.Controls.Add(this.resLBL4);
            this.Controls.Add(this.resLBL2);
            this.Controls.Add(this.res1LBL);
            this.Controls.Add(this.butmin);
            this.Controls.Add(this.butext);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.Enter += new System.EventHandler(this.Form1_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button butext;
        private Guna.UI2.WinForms.Guna2Button butmin;
        private System.Windows.Forms.Label resLBL8;
        private System.Windows.Forms.Label resLBL4;
        private System.Windows.Forms.Label resLBL2;
        private System.Windows.Forms.Label res1LBL;
        private Guna.UI2.WinForms.Guna2Button butcal;
        private Guna.UI2.WinForms.Guna2Button butn;
        private Guna.UI2.WinForms.Guna2Button butt;
        private Guna.UI2.WinForms.Guna2Button butd;
        private System.Windows.Forms.TextBox bpmTB;
        private System.Windows.Forms.Label modeLBL;
        private System.Windows.Forms.Label resLBL16;
        private System.Windows.Forms.Label logMsg;
        private System.Windows.Forms.Label shadowLBL;
        private System.Windows.Forms.Timer timerText;
    }
}

