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
            this.bpmtextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.res1 = new System.Windows.Forms.Label();
            this.res2 = new System.Windows.Forms.Label();
            this.res4 = new System.Windows.Forms.Label();
            this.res8 = new System.Windows.Forms.Label();
            this.butcal = new Guna.UI2.WinForms.Guna2Button();
            this.butn = new Guna.UI2.WinForms.Guna2Button();
            this.butd = new Guna.UI2.WinForms.Guna2Button();
            this.butt = new Guna.UI2.WinForms.Guna2Button();
            this.bpmTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // butext
            // 
            this.butext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butext.AutoRoundedCorners = true;
            this.butext.BackColor = System.Drawing.Color.Transparent;
            this.butext.BorderRadius = 15;
            this.butext.CheckedState.Parent = this.butext;
            this.butext.CustomImages.Parent = this.butext;
            this.butext.FillColor = System.Drawing.Color.Transparent;
            this.butext.Font = new System.Drawing.Font("Montserrat Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butext.ForeColor = System.Drawing.Color.Black;
            this.butext.HoverState.Parent = this.butext;
            this.butext.Location = new System.Drawing.Point(614, 3);
            this.butext.Name = "butext";
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
            this.butmin.Font = new System.Drawing.Font("Montserrat Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butmin.ForeColor = System.Drawing.Color.Black;
            this.butmin.HoverState.Parent = this.butmin;
            this.butmin.Location = new System.Drawing.Point(575, 3);
            this.butmin.Name = "butmin";
            this.butmin.ShadowDecoration.Parent = this.butmin;
            this.butmin.Size = new System.Drawing.Size(33, 33);
            this.butmin.TabIndex = 1;
            this.butmin.Text = "-";
            this.butmin.Click += new System.EventHandler(this.butmin_Click);
            // 
            // bpmtextbox
            // 
            this.bpmtextbox.AutoRoundedCorners = true;
            this.bpmtextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.bpmtextbox.BorderRadius = 13;
            this.bpmtextbox.BorderThickness = 0;
            this.bpmtextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bpmtextbox.DefaultText = "120";
            this.bpmtextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bpmtextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bpmtextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bpmtextbox.DisabledState.Parent = this.bpmtextbox;
            this.bpmtextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bpmtextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.bpmtextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bpmtextbox.FocusedState.Parent = this.bpmtextbox;
            this.bpmtextbox.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Bold);
            this.bpmtextbox.ForeColor = System.Drawing.Color.Black;
            this.bpmtextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bpmtextbox.HoverState.Parent = this.bpmtextbox;
            this.bpmtextbox.Location = new System.Drawing.Point(203, 1);
            this.bpmtextbox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bpmtextbox.Name = "bpmtextbox";
            this.bpmtextbox.PasswordChar = '\0';
            this.bpmtextbox.PlaceholderText = "";
            this.bpmtextbox.SelectedText = "";
            this.bpmtextbox.SelectionStart = 3;
            this.bpmtextbox.ShadowDecoration.Parent = this.bpmtextbox;
            this.bpmtextbox.Size = new System.Drawing.Size(42, 29);
            this.bpmtextbox.TabIndex = 2;
            this.bpmtextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bpmtextbox.TextChanged += new System.EventHandler(this.bpmtextbox_TextChanged);
            this.bpmtextbox.Enter += new System.EventHandler(this.bpmtextbox_Enter);
            this.bpmtextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bpmtextbox_KeyPress);
            this.bpmtextbox.Leave += new System.EventHandler(this.bpmtextbox_Leave);
            this.bpmtextbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bpmtextbox_MouseClick);
            // 
            // res1
            // 
            this.res1.BackColor = System.Drawing.Color.Transparent;
            this.res1.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Bold);
            this.res1.Location = new System.Drawing.Point(133, 272);
            this.res1.Name = "res1";
            this.res1.Size = new System.Drawing.Size(52, 23);
            this.res1.TabIndex = 3;
            this.res1.Text = "0000";
            this.res1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // res2
            // 
            this.res2.BackColor = System.Drawing.Color.Transparent;
            this.res2.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Bold);
            this.res2.Location = new System.Drawing.Point(245, 272);
            this.res2.Name = "res2";
            this.res2.Size = new System.Drawing.Size(52, 23);
            this.res2.TabIndex = 3;
            this.res2.Text = "0000";
            this.res2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // res4
            // 
            this.res4.BackColor = System.Drawing.Color.Transparent;
            this.res4.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Bold);
            this.res4.Location = new System.Drawing.Point(357, 272);
            this.res4.Name = "res4";
            this.res4.Size = new System.Drawing.Size(52, 23);
            this.res4.TabIndex = 3;
            this.res4.Text = "0000";
            this.res4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // res8
            // 
            this.res8.BackColor = System.Drawing.Color.Transparent;
            this.res8.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Bold);
            this.res8.Location = new System.Drawing.Point(469, 272);
            this.res8.Name = "res8";
            this.res8.Size = new System.Drawing.Size(52, 23);
            this.res8.TabIndex = 3;
            this.res8.Text = "0000";
            this.res8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butcal
            // 
            this.butcal.AutoRoundedCorners = true;
            this.butcal.BackColor = System.Drawing.Color.Transparent;
            this.butcal.BorderRadius = 32;
            this.butcal.CheckedState.Parent = this.butcal;
            this.butcal.CustomImages.Parent = this.butcal;
            this.butcal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(87)))), ((int)(((byte)(229)))));
            this.butcal.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butcal.ForeColor = System.Drawing.Color.White;
            this.butcal.HoverState.Parent = this.butcal;
            this.butcal.Location = new System.Drawing.Point(297, 140);
            this.butcal.Name = "butcal";
            this.butcal.ShadowDecoration.BorderRadius = 29;
            this.butcal.ShadowDecoration.Depth = 15;
            this.butcal.ShadowDecoration.Enabled = true;
            this.butcal.ShadowDecoration.Parent = this.butcal;
            this.butcal.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1, 1, 4, 3);
            this.butcal.Size = new System.Drawing.Size(216, 67);
            this.butcal.TabIndex = 4;
            this.butcal.Text = "CALCULATE";
            // 
            // butn
            // 
            this.butn.BackColor = System.Drawing.Color.Transparent;
            this.butn.BorderColor = System.Drawing.Color.Transparent;
            this.butn.BorderRadius = 12;
            this.butn.BorderThickness = 1;
            this.butn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.butn.Checked = true;
            this.butn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(87)))), ((int)(((byte)(229)))));
            this.butn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.butn.CheckedState.Parent = this.butn;
            this.butn.CustomImages.Parent = this.butn;
            this.butn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(237)))));
            this.butn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
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
            this.butn.Click += new System.EventHandler(this.butn_Click);
            // 
            // butd
            // 
            this.butd.BackColor = System.Drawing.Color.Transparent;
            this.butd.BorderColor = System.Drawing.Color.Transparent;
            this.butd.BorderRadius = 12;
            this.butd.BorderThickness = 1;
            this.butd.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.butd.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(87)))), ((int)(((byte)(229)))));
            this.butd.CheckedState.ForeColor = System.Drawing.Color.White;
            this.butd.CheckedState.Parent = this.butd;
            this.butd.CustomImages.Parent = this.butd;
            this.butd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(237)))));
            this.butd.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
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
            this.butd.Click += new System.EventHandler(this.butd_Click);
            // 
            // butt
            // 
            this.butt.BackColor = System.Drawing.Color.Transparent;
            this.butt.BorderColor = System.Drawing.Color.Transparent;
            this.butt.BorderRadius = 12;
            this.butt.BorderThickness = 1;
            this.butt.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.butt.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(87)))), ((int)(((byte)(229)))));
            this.butt.CheckedState.ForeColor = System.Drawing.Color.White;
            this.butt.CheckedState.Parent = this.butt;
            this.butt.CustomImages.Parent = this.butt;
            this.butt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(232)))), ((int)(((byte)(237)))));
            this.butt.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
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
            this.butt.Click += new System.EventHandler(this.butt_Click);
            // 
            // bpmTB
            // 
            this.bpmTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.bpmTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bpmTB.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Bold);
            this.bpmTB.Location = new System.Drawing.Point(203, 159);
            this.bpmTB.MaxLength = 3;
            this.bpmTB.Name = "bpmTB";
            this.bpmTB.Size = new System.Drawing.Size(42, 18);
            this.bpmTB.TabIndex = 7;
            this.bpmTB.Text = "120";
            this.bpmTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bpmTB.WordWrap = false;
            this.bpmTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bpmTB_MouseClick);
            this.bpmTB.TextChanged += new System.EventHandler(this.bpmTB_TextChanged);
            this.bpmTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bpmTB_KeyPress);
            this.bpmTB.Leave += new System.EventHandler(this.bpmTB_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bpmtomstest1.Properties.Resources.Bpm_to_ms_Calculator___with_buttons;
            this.ClientSize = new System.Drawing.Size(650, 402);
            this.Controls.Add(this.bpmTB);
            this.Controls.Add(this.butt);
            this.Controls.Add(this.butd);
            this.Controls.Add(this.butn);
            this.Controls.Add(this.butcal);
            this.Controls.Add(this.res8);
            this.Controls.Add(this.res4);
            this.Controls.Add(this.res2);
            this.Controls.Add(this.res1);
            this.Controls.Add(this.bpmtextbox);
            this.Controls.Add(this.butmin);
            this.Controls.Add(this.butext);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "0";
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
        private Guna.UI2.WinForms.Guna2TextBox bpmtextbox;
        private System.Windows.Forms.Label res8;
        private System.Windows.Forms.Label res4;
        private System.Windows.Forms.Label res2;
        private System.Windows.Forms.Label res1;
        private Guna.UI2.WinForms.Guna2Button butcal;
        private Guna.UI2.WinForms.Guna2Button butn;
        private Guna.UI2.WinForms.Guna2Button butt;
        private Guna.UI2.WinForms.Guna2Button butd;
        private System.Windows.Forms.TextBox bpmTB;
    }
}

