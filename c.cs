//http://www.codeproject.com/Articles/15248/Globalization-of-Windows-Applications-in-Minute
//try
//Modify again


using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Globalization;
using System.Resources;
using System.Threading;

namespace GlobalResource
{
	/// <summary>
	/// Summary description for frmMain.
	/// </summary>
	public class frmMain : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton rbEn;
		private System.Windows.Forms.RadioButton rbSp;
		private System.Windows.Forms.RadioButton rbFr;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.PictureBox picE;
		private System.Windows.Forms.PictureBox picS;
		private System.Windows.Forms.PictureBox picF;
		private System.Windows.Forms.PictureBox picTop;
		private System.Windows.Forms.Button btnMessage;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.ToolTip toolTip1;
		
		private string strResourcesPath= Application.StartupPath + "/Resources";
		private string strCulture= "en-US";
		private static ResourceManager rm;

		private System.Windows.Forms.Label lblselect;
		private System.Windows.Forms.Label lbltime;
		
		
		public frmMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
		public static ResourceManager RM
		{
			get
			{
				return rm ;
			}
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmMain));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.rbEn = new System.Windows.Forms.RadioButton();
			this.rbSp = new System.Windows.Forms.RadioButton();
			this.rbFr = new System.Windows.Forms.RadioButton();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.picTop = new System.Windows.Forms.PictureBox();
			this.picE = new System.Windows.Forms.PictureBox();
			this.picS = new System.Windows.Forms.PictureBox();
			this.picF = new System.Windows.Forms.PictureBox();
			this.btnMessage = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.lblselect = new System.Windows.Forms.Label();
			this.lbltime = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AccessibleDescription = resources.GetString("label1.AccessibleDescription");
			this.label1.AccessibleName = resources.GetString("label1.AccessibleName");
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label1.Anchor")));
			this.label1.AutoSize = ((bool)(resources.GetObject("label1.AutoSize")));
			this.label1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label1.Dock")));
			this.label1.Enabled = ((bool)(resources.GetObject("label1.Enabled")));
			this.label1.Font = ((System.Drawing.Font)(resources.GetObject("label1.Font")));
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label1.ImageAlign")));
			this.label1.ImageIndex = ((int)(resources.GetObject("label1.ImageIndex")));
			this.label1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label1.ImeMode")));
			this.label1.Location = ((System.Drawing.Point)(resources.GetObject("label1.Location")));
			this.label1.Name = "label1";
			this.label1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label1.RightToLeft")));
			this.label1.Size = ((System.Drawing.Size)(resources.GetObject("label1.Size")));
			this.label1.TabIndex = ((int)(resources.GetObject("label1.TabIndex")));
			this.label1.Text = resources.GetString("label1.Text");
			this.label1.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label1.TextAlign")));
			this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
			this.label1.Visible = ((bool)(resources.GetObject("label1.Visible")));
			// 
			// label2
			// 
			this.label2.AccessibleDescription = resources.GetString("label2.AccessibleDescription");
			this.label2.AccessibleName = resources.GetString("label2.AccessibleName");
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label2.Anchor")));
			this.label2.AutoSize = ((bool)(resources.GetObject("label2.AutoSize")));
			this.label2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label2.Dock")));
			this.label2.Enabled = ((bool)(resources.GetObject("label2.Enabled")));
			this.label2.Font = ((System.Drawing.Font)(resources.GetObject("label2.Font")));
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label2.ImageAlign")));
			this.label2.ImageIndex = ((int)(resources.GetObject("label2.ImageIndex")));
			this.label2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label2.ImeMode")));
			this.label2.Location = ((System.Drawing.Point)(resources.GetObject("label2.Location")));
			this.label2.Name = "label2";
			this.label2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label2.RightToLeft")));
			this.label2.Size = ((System.Drawing.Size)(resources.GetObject("label2.Size")));
			this.label2.TabIndex = ((int)(resources.GetObject("label2.TabIndex")));
			this.label2.Text = resources.GetString("label2.Text");
			this.label2.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label2.TextAlign")));
			this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
			this.label2.Visible = ((bool)(resources.GetObject("label2.Visible")));
			// 
			// label3
			// 
			this.label3.AccessibleDescription = resources.GetString("label3.AccessibleDescription");
			this.label3.AccessibleName = resources.GetString("label3.AccessibleName");
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label3.Anchor")));
			this.label3.AutoSize = ((bool)(resources.GetObject("label3.AutoSize")));
			this.label3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label3.Dock")));
			this.label3.Enabled = ((bool)(resources.GetObject("label3.Enabled")));
			this.label3.Font = ((System.Drawing.Font)(resources.GetObject("label3.Font")));
			this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
			this.label3.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label3.ImageAlign")));
			this.label3.ImageIndex = ((int)(resources.GetObject("label3.ImageIndex")));
			this.label3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label3.ImeMode")));
			this.label3.Location = ((System.Drawing.Point)(resources.GetObject("label3.Location")));
			this.label3.Name = "label3";
			this.label3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label3.RightToLeft")));
			this.label3.Size = ((System.Drawing.Size)(resources.GetObject("label3.Size")));
			this.label3.TabIndex = ((int)(resources.GetObject("label3.TabIndex")));
			this.label3.Text = resources.GetString("label3.Text");
			this.label3.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label3.TextAlign")));
			this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
			this.label3.Visible = ((bool)(resources.GetObject("label3.Visible")));
			// 
			// rbEn
			// 
			this.rbEn.AccessibleDescription = resources.GetString("rbEn.AccessibleDescription");
			this.rbEn.AccessibleName = resources.GetString("rbEn.AccessibleName");
			this.rbEn.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("rbEn.Anchor")));
			this.rbEn.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("rbEn.Appearance")));
			this.rbEn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbEn.BackgroundImage")));
			this.rbEn.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("rbEn.CheckAlign")));
			this.rbEn.Checked = true;
			this.rbEn.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("rbEn.Dock")));
			this.rbEn.Enabled = ((bool)(resources.GetObject("rbEn.Enabled")));
			this.rbEn.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("rbEn.FlatStyle")));
			this.rbEn.Font = ((System.Drawing.Font)(resources.GetObject("rbEn.Font")));
			this.rbEn.Image = ((System.Drawing.Image)(resources.GetObject("rbEn.Image")));
			this.rbEn.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("rbEn.ImageAlign")));
			this.rbEn.ImageIndex = ((int)(resources.GetObject("rbEn.ImageIndex")));
			this.rbEn.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("rbEn.ImeMode")));
			this.rbEn.Location = ((System.Drawing.Point)(resources.GetObject("rbEn.Location")));
			this.rbEn.Name = "rbEn";
			this.rbEn.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("rbEn.RightToLeft")));
			this.rbEn.Size = ((System.Drawing.Size)(resources.GetObject("rbEn.Size")));
			this.rbEn.TabIndex = ((int)(resources.GetObject("rbEn.TabIndex")));
			this.rbEn.TabStop = true;
			this.rbEn.Text = resources.GetString("rbEn.Text");
			this.rbEn.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("rbEn.TextAlign")));
			this.toolTip1.SetToolTip(this.rbEn, resources.GetString("rbEn.ToolTip"));
			this.rbEn.Visible = ((bool)(resources.GetObject("rbEn.Visible")));
			this.rbEn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rbEn_MouseUp);
			// 
			// rbSp
			// 
			this.rbSp.AccessibleDescription = resources.GetString("rbSp.AccessibleDescription");
			this.rbSp.AccessibleName = resources.GetString("rbSp.AccessibleName");
			this.rbSp.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("rbSp.Anchor")));
			this.rbSp.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("rbSp.Appearance")));
			this.rbSp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbSp.BackgroundImage")));
			this.rbSp.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("rbSp.CheckAlign")));
			this.rbSp.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("rbSp.Dock")));
			this.rbSp.Enabled = ((bool)(resources.GetObject("rbSp.Enabled")));
			this.rbSp.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("rbSp.FlatStyle")));
			this.rbSp.Font = ((System.Drawing.Font)(resources.GetObject("rbSp.Font")));
			this.rbSp.Image = ((System.Drawing.Image)(resources.GetObject("rbSp.Image")));
			this.rbSp.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("rbSp.ImageAlign")));
			this.rbSp.ImageIndex = ((int)(resources.GetObject("rbSp.ImageIndex")));
			this.rbSp.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("rbSp.ImeMode")));
			this.rbSp.Location = ((System.Drawing.Point)(resources.GetObject("rbSp.Location")));
			this.rbSp.Name = "rbSp";
			this.rbSp.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("rbSp.RightToLeft")));
			this.rbSp.Size = ((System.Drawing.Size)(resources.GetObject("rbSp.Size")));
			this.rbSp.TabIndex = ((int)(resources.GetObject("rbSp.TabIndex")));
			this.rbSp.Text = resources.GetString("rbSp.Text");
			this.rbSp.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("rbSp.TextAlign")));
			this.toolTip1.SetToolTip(this.rbSp, resources.GetString("rbSp.ToolTip"));
			this.rbSp.Visible = ((bool)(resources.GetObject("rbSp.Visible")));
			this.rbSp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rbSp_MouseUp);
			// 
			// rbFr
			// 
			this.rbFr.AccessibleDescription = resources.GetString("rbFr.AccessibleDescription");
			this.rbFr.AccessibleName = resources.GetString("rbFr.AccessibleName");
			this.rbFr.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("rbFr.Anchor")));
			this.rbFr.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("rbFr.Appearance")));
			this.rbFr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbFr.BackgroundImage")));
			this.rbFr.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("rbFr.CheckAlign")));
			this.rbFr.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("rbFr.Dock")));
			this.rbFr.Enabled = ((bool)(resources.GetObject("rbFr.Enabled")));
			this.rbFr.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("rbFr.FlatStyle")));
			this.rbFr.Font = ((System.Drawing.Font)(resources.GetObject("rbFr.Font")));
			this.rbFr.Image = ((System.Drawing.Image)(resources.GetObject("rbFr.Image")));
			this.rbFr.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("rbFr.ImageAlign")));
			this.rbFr.ImageIndex = ((int)(resources.GetObject("rbFr.ImageIndex")));
			this.rbFr.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("rbFr.ImeMode")));
			this.rbFr.Location = ((System.Drawing.Point)(resources.GetObject("rbFr.Location")));
			this.rbFr.Name = "rbFr";
			this.rbFr.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("rbFr.RightToLeft")));
			this.rbFr.Size = ((System.Drawing.Size)(resources.GetObject("rbFr.Size")));
			this.rbFr.TabIndex = ((int)(resources.GetObject("rbFr.TabIndex")));
			this.rbFr.Text = resources.GetString("rbFr.Text");
			this.rbFr.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("rbFr.TextAlign")));
			this.toolTip1.SetToolTip(this.rbFr, resources.GetString("rbFr.ToolTip"));
			this.rbFr.Visible = ((bool)(resources.GetObject("rbFr.Visible")));
			this.rbFr.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rbFr_MouseUp);
			// 
			// textBox1
			// 
			this.textBox1.AccessibleDescription = resources.GetString("textBox1.AccessibleDescription");
			this.textBox1.AccessibleName = resources.GetString("textBox1.AccessibleName");
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("textBox1.Anchor")));
			this.textBox1.AutoSize = ((bool)(resources.GetObject("textBox1.AutoSize")));
			this.textBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBox1.BackgroundImage")));
			this.textBox1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("textBox1.Dock")));
			this.textBox1.Enabled = ((bool)(resources.GetObject("textBox1.Enabled")));
			this.textBox1.Font = ((System.Drawing.Font)(resources.GetObject("textBox1.Font")));
			this.textBox1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("textBox1.ImeMode")));
			this.textBox1.Location = ((System.Drawing.Point)(resources.GetObject("textBox1.Location")));
			this.textBox1.MaxLength = ((int)(resources.GetObject("textBox1.MaxLength")));
			this.textBox1.Multiline = ((bool)(resources.GetObject("textBox1.Multiline")));
			this.textBox1.Name = "textBox1";
			this.textBox1.PasswordChar = ((char)(resources.GetObject("textBox1.PasswordChar")));
			this.textBox1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("textBox1.RightToLeft")));
			this.textBox1.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("textBox1.ScrollBars")));
			this.textBox1.Size = ((System.Drawing.Size)(resources.GetObject("textBox1.Size")));
			this.textBox1.TabIndex = ((int)(resources.GetObject("textBox1.TabIndex")));
			this.textBox1.Text = resources.GetString("textBox1.Text");
			this.textBox1.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("textBox1.TextAlign")));
			this.toolTip1.SetToolTip(this.textBox1, resources.GetString("textBox1.ToolTip"));
			this.textBox1.Visible = ((bool)(resources.GetObject("textBox1.Visible")));
			this.textBox1.WordWrap = ((bool)(resources.GetObject("textBox1.WordWrap")));
			// 
			// textBox2
			// 
			this.textBox2.AccessibleDescription = resources.GetString("textBox2.AccessibleDescription");
			this.textBox2.AccessibleName = resources.GetString("textBox2.AccessibleName");
			this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("textBox2.Anchor")));
			this.textBox2.AutoSize = ((bool)(resources.GetObject("textBox2.AutoSize")));
			this.textBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBox2.BackgroundImage")));
			this.textBox2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("textBox2.Dock")));
			this.textBox2.Enabled = ((bool)(resources.GetObject("textBox2.Enabled")));
			this.textBox2.Font = ((System.Drawing.Font)(resources.GetObject("textBox2.Font")));
			this.textBox2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("textBox2.ImeMode")));
			this.textBox2.Location = ((System.Drawing.Point)(resources.GetObject("textBox2.Location")));
			this.textBox2.MaxLength = ((int)(resources.GetObject("textBox2.MaxLength")));
			this.textBox2.Multiline = ((bool)(resources.GetObject("textBox2.Multiline")));
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = ((char)(resources.GetObject("textBox2.PasswordChar")));
			this.textBox2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("textBox2.RightToLeft")));
			this.textBox2.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("textBox2.ScrollBars")));
			this.textBox2.Size = ((System.Drawing.Size)(resources.GetObject("textBox2.Size")));
			this.textBox2.TabIndex = ((int)(resources.GetObject("textBox2.TabIndex")));
			this.textBox2.Text = resources.GetString("textBox2.Text");
			this.textBox2.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("textBox2.TextAlign")));
			this.toolTip1.SetToolTip(this.textBox2, resources.GetString("textBox2.ToolTip"));
			this.textBox2.Visible = ((bool)(resources.GetObject("textBox2.Visible")));
			this.textBox2.WordWrap = ((bool)(resources.GetObject("textBox2.WordWrap")));
			// 
			// textBox3
			// 
			this.textBox3.AccessibleDescription = resources.GetString("textBox3.AccessibleDescription");
			this.textBox3.AccessibleName = resources.GetString("textBox3.AccessibleName");
			this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("textBox3.Anchor")));
			this.textBox3.AutoSize = ((bool)(resources.GetObject("textBox3.AutoSize")));
			this.textBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBox3.BackgroundImage")));
			this.textBox3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("textBox3.Dock")));
			this.textBox3.Enabled = ((bool)(resources.GetObject("textBox3.Enabled")));
			this.textBox3.Font = ((System.Drawing.Font)(resources.GetObject("textBox3.Font")));
			this.textBox3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("textBox3.ImeMode")));
			this.textBox3.Location = ((System.Drawing.Point)(resources.GetObject("textBox3.Location")));
			this.textBox3.MaxLength = ((int)(resources.GetObject("textBox3.MaxLength")));
			this.textBox3.Multiline = ((bool)(resources.GetObject("textBox3.Multiline")));
			this.textBox3.Name = "textBox3";
			this.textBox3.PasswordChar = ((char)(resources.GetObject("textBox3.PasswordChar")));
			this.textBox3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("textBox3.RightToLeft")));
			this.textBox3.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("textBox3.ScrollBars")));
			this.textBox3.Size = ((System.Drawing.Size)(resources.GetObject("textBox3.Size")));
			this.textBox3.TabIndex = ((int)(resources.GetObject("textBox3.TabIndex")));
			this.textBox3.Text = resources.GetString("textBox3.Text");
			this.textBox3.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("textBox3.TextAlign")));
			this.toolTip1.SetToolTip(this.textBox3, resources.GetString("textBox3.ToolTip"));
			this.textBox3.Visible = ((bool)(resources.GetObject("textBox3.Visible")));
			this.textBox3.WordWrap = ((bool)(resources.GetObject("textBox3.WordWrap")));
			// 
			// btnSubmit
			// 
			this.btnSubmit.AccessibleDescription = resources.GetString("btnSubmit.AccessibleDescription");
			this.btnSubmit.AccessibleName = resources.GetString("btnSubmit.AccessibleName");
			this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btnSubmit.Anchor")));
			this.btnSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubmit.BackgroundImage")));
			this.btnSubmit.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btnSubmit.Dock")));
			this.btnSubmit.Enabled = ((bool)(resources.GetObject("btnSubmit.Enabled")));
			this.btnSubmit.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btnSubmit.FlatStyle")));
			this.btnSubmit.Font = ((System.Drawing.Font)(resources.GetObject("btnSubmit.Font")));
			this.btnSubmit.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmit.Image")));
			this.btnSubmit.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnSubmit.ImageAlign")));
			this.btnSubmit.ImageIndex = ((int)(resources.GetObject("btnSubmit.ImageIndex")));
			this.btnSubmit.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btnSubmit.ImeMode")));
			this.btnSubmit.Location = ((System.Drawing.Point)(resources.GetObject("btnSubmit.Location")));
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btnSubmit.RightToLeft")));
			this.btnSubmit.Size = ((System.Drawing.Size)(resources.GetObject("btnSubmit.Size")));
			this.btnSubmit.TabIndex = ((int)(resources.GetObject("btnSubmit.TabIndex")));
			this.btnSubmit.Text = resources.GetString("btnSubmit.Text");
			this.btnSubmit.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnSubmit.TextAlign")));
			this.toolTip1.SetToolTip(this.btnSubmit, resources.GetString("btnSubmit.ToolTip"));
			this.btnSubmit.Visible = ((bool)(resources.GetObject("btnSubmit.Visible")));
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.AccessibleDescription = resources.GetString("btnCancel.AccessibleDescription");
			this.btnCancel.AccessibleName = resources.GetString("btnCancel.AccessibleName");
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btnCancel.Anchor")));
			this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
			this.btnCancel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btnCancel.Dock")));
			this.btnCancel.Enabled = ((bool)(resources.GetObject("btnCancel.Enabled")));
			this.btnCancel.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btnCancel.FlatStyle")));
			this.btnCancel.Font = ((System.Drawing.Font)(resources.GetObject("btnCancel.Font")));
			this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
			this.btnCancel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnCancel.ImageAlign")));
			this.btnCancel.ImageIndex = ((int)(resources.GetObject("btnCancel.ImageIndex")));
			this.btnCancel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btnCancel.ImeMode")));
			this.btnCancel.Location = ((System.Drawing.Point)(resources.GetObject("btnCancel.Location")));
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btnCancel.RightToLeft")));
			this.btnCancel.Size = ((System.Drawing.Size)(resources.GetObject("btnCancel.Size")));
			this.btnCancel.TabIndex = ((int)(resources.GetObject("btnCancel.TabIndex")));
			this.btnCancel.Text = resources.GetString("btnCancel.Text");
			this.btnCancel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnCancel.TextAlign")));
			this.toolTip1.SetToolTip(this.btnCancel, resources.GetString("btnCancel.ToolTip"));
			this.btnCancel.Visible = ((bool)(resources.GetObject("btnCancel.Visible")));
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// picTop
			// 
			this.picTop.AccessibleDescription = resources.GetString("picTop.AccessibleDescription");
			this.picTop.AccessibleName = resources.GetString("picTop.AccessibleName");
			this.picTop.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("picTop.Anchor")));
			this.picTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picTop.BackgroundImage")));
			this.picTop.Cursor = System.Windows.Forms.Cursors.Default;
			this.picTop.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("picTop.Dock")));
			this.picTop.Enabled = ((bool)(resources.GetObject("picTop.Enabled")));
			this.picTop.Font = ((System.Drawing.Font)(resources.GetObject("picTop.Font")));
			this.picTop.Image = ((System.Drawing.Image)(resources.GetObject("picTop.Image")));
			this.picTop.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("picTop.ImeMode")));
			this.picTop.Location = ((System.Drawing.Point)(resources.GetObject("picTop.Location")));
			this.picTop.Name = "picTop";
			this.picTop.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("picTop.RightToLeft")));
			this.picTop.Size = ((System.Drawing.Size)(resources.GetObject("picTop.Size")));
			this.picTop.SizeMode = ((System.Windows.Forms.PictureBoxSizeMode)(resources.GetObject("picTop.SizeMode")));
			this.picTop.TabIndex = ((int)(resources.GetObject("picTop.TabIndex")));
			this.picTop.TabStop = false;
			this.picTop.Text = resources.GetString("picTop.Text");
			this.toolTip1.SetToolTip(this.picTop, resources.GetString("picTop.ToolTip"));
			this.picTop.Visible = ((bool)(resources.GetObject("picTop.Visible")));
			this.picTop.Click += new System.EventHandler(this.picTop_Click);
			// 
			// picE
			// 
			this.picE.AccessibleDescription = resources.GetString("picE.AccessibleDescription");
			this.picE.AccessibleName = resources.GetString("picE.AccessibleName");
			this.picE.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("picE.Anchor")));
			this.picE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picE.BackgroundImage")));
			this.picE.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("picE.Dock")));
			this.picE.Enabled = ((bool)(resources.GetObject("picE.Enabled")));
			this.picE.Font = ((System.Drawing.Font)(resources.GetObject("picE.Font")));
			this.picE.Image = ((System.Drawing.Image)(resources.GetObject("picE.Image")));
			this.picE.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("picE.ImeMode")));
			this.picE.Location = ((System.Drawing.Point)(resources.GetObject("picE.Location")));
			this.picE.Name = "picE";
			this.picE.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("picE.RightToLeft")));
			this.picE.Size = ((System.Drawing.Size)(resources.GetObject("picE.Size")));
			this.picE.SizeMode = ((System.Windows.Forms.PictureBoxSizeMode)(resources.GetObject("picE.SizeMode")));
			this.picE.TabIndex = ((int)(resources.GetObject("picE.TabIndex")));
			this.picE.TabStop = false;
			this.picE.Text = resources.GetString("picE.Text");
			this.toolTip1.SetToolTip(this.picE, resources.GetString("picE.ToolTip"));
			this.picE.Visible = ((bool)(resources.GetObject("picE.Visible")));
			// 
			// picS
			// 
			this.picS.AccessibleDescription = resources.GetString("picS.AccessibleDescription");
			this.picS.AccessibleName = resources.GetString("picS.AccessibleName");
			this.picS.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("picS.Anchor")));
			this.picS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picS.BackgroundImage")));
			this.picS.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("picS.Dock")));
			this.picS.Enabled = ((bool)(resources.GetObject("picS.Enabled")));
			this.picS.Font = ((System.Drawing.Font)(resources.GetObject("picS.Font")));
			this.picS.Image = ((System.Drawing.Image)(resources.GetObject("picS.Image")));
			this.picS.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("picS.ImeMode")));
			this.picS.Location = ((System.Drawing.Point)(resources.GetObject("picS.Location")));
			this.picS.Name = "picS";
			this.picS.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("picS.RightToLeft")));
			this.picS.Size = ((System.Drawing.Size)(resources.GetObject("picS.Size")));
			this.picS.SizeMode = ((System.Windows.Forms.PictureBoxSizeMode)(resources.GetObject("picS.SizeMode")));
			this.picS.TabIndex = ((int)(resources.GetObject("picS.TabIndex")));
			this.picS.TabStop = false;
			this.picS.Text = resources.GetString("picS.Text");
			this.toolTip1.SetToolTip(this.picS, resources.GetString("picS.ToolTip"));
			this.picS.Visible = ((bool)(resources.GetObject("picS.Visible")));
			// 
			// picF
			// 
			this.picF.AccessibleDescription = resources.GetString("picF.AccessibleDescription");
			this.picF.AccessibleName = resources.GetString("picF.AccessibleName");
			this.picF.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("picF.Anchor")));
			this.picF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picF.BackgroundImage")));
			this.picF.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("picF.Dock")));
			this.picF.Enabled = ((bool)(resources.GetObject("picF.Enabled")));
			this.picF.Font = ((System.Drawing.Font)(resources.GetObject("picF.Font")));
			this.picF.Image = ((System.Drawing.Image)(resources.GetObject("picF.Image")));
			this.picF.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("picF.ImeMode")));
			this.picF.Location = ((System.Drawing.Point)(resources.GetObject("picF.Location")));
			this.picF.Name = "picF";
			this.picF.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("picF.RightToLeft")));
			this.picF.Size = ((System.Drawing.Size)(resources.GetObject("picF.Size")));
			this.picF.SizeMode = ((System.Windows.Forms.PictureBoxSizeMode)(resources.GetObject("picF.SizeMode")));
			this.picF.TabIndex = ((int)(resources.GetObject("picF.TabIndex")));
			this.picF.TabStop = false;
			this.picF.Text = resources.GetString("picF.Text");
			this.toolTip1.SetToolTip(this.picF, resources.GetString("picF.ToolTip"));
			this.picF.Visible = ((bool)(resources.GetObject("picF.Visible")));
			// 
			// btnMessage
			// 
			this.btnMessage.AccessibleDescription = resources.GetString("btnMessage.AccessibleDescription");
			this.btnMessage.AccessibleName = resources.GetString("btnMessage.AccessibleName");
			this.btnMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btnMessage.Anchor")));
			this.btnMessage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMessage.BackgroundImage")));
			this.btnMessage.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMessage.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btnMessage.Dock")));
			this.btnMessage.Enabled = ((bool)(resources.GetObject("btnMessage.Enabled")));
			this.btnMessage.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btnMessage.FlatStyle")));
			this.btnMessage.Font = ((System.Drawing.Font)(resources.GetObject("btnMessage.Font")));
			this.btnMessage.ForeColor = System.Drawing.Color.Transparent;
			this.btnMessage.Image = ((System.Drawing.Image)(resources.GetObject("btnMessage.Image")));
			this.btnMessage.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnMessage.ImageAlign")));
			this.btnMessage.ImageIndex = ((int)(resources.GetObject("btnMessage.ImageIndex")));
			this.btnMessage.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btnMessage.ImeMode")));
			this.btnMessage.Location = ((System.Drawing.Point)(resources.GetObject("btnMessage.Location")));
			this.btnMessage.Name = "btnMessage";
			this.btnMessage.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btnMessage.RightToLeft")));
			this.btnMessage.Size = ((System.Drawing.Size)(resources.GetObject("btnMessage.Size")));
			this.btnMessage.TabIndex = ((int)(resources.GetObject("btnMessage.TabIndex")));
			this.btnMessage.Text = resources.GetString("btnMessage.Text");
			this.btnMessage.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnMessage.TextAlign")));
			this.toolTip1.SetToolTip(this.btnMessage, resources.GetString("btnMessage.ToolTip"));
			this.btnMessage.Visible = ((bool)(resources.GetObject("btnMessage.Visible")));
			this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
			// 
			// lblselect
			// 
			this.lblselect.AccessibleDescription = resources.GetString("lblselect.AccessibleDescription");
			this.lblselect.AccessibleName = resources.GetString("lblselect.AccessibleName");
			this.lblselect.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lblselect.Anchor")));
			this.lblselect.AutoSize = ((bool)(resources.GetObject("lblselect.AutoSize")));
			this.lblselect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblselect.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lblselect.Dock")));
			this.lblselect.Enabled = ((bool)(resources.GetObject("lblselect.Enabled")));
			this.lblselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblselect.Font = ((System.Drawing.Font)(resources.GetObject("lblselect.Font")));
			this.lblselect.Image = ((System.Drawing.Image)(resources.GetObject("lblselect.Image")));
			this.lblselect.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lblselect.ImageAlign")));
			this.lblselect.ImageIndex = ((int)(resources.GetObject("lblselect.ImageIndex")));
			this.lblselect.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lblselect.ImeMode")));
			this.lblselect.Location = ((System.Drawing.Point)(resources.GetObject("lblselect.Location")));
			this.lblselect.Name = "lblselect";
			this.lblselect.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lblselect.RightToLeft")));
			this.lblselect.Size = ((System.Drawing.Size)(resources.GetObject("lblselect.Size")));
			this.lblselect.TabIndex = ((int)(resources.GetObject("lblselect.TabIndex")));
			this.lblselect.Text = resources.GetString("lblselect.Text");
			this.lblselect.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lblselect.TextAlign")));
			this.toolTip1.SetToolTip(this.lblselect, resources.GetString("lblselect.ToolTip"));
			this.lblselect.Visible = ((bool)(resources.GetObject("lblselect.Visible")));
			// 
			// lbltime
			// 
			this.lbltime.AccessibleDescription = resources.GetString("lbltime.AccessibleDescription");
			this.lbltime.AccessibleName = resources.GetString("lbltime.AccessibleName");
			this.lbltime.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbltime.Anchor")));
			this.lbltime.AutoSize = ((bool)(resources.GetObject("lbltime.AutoSize")));
			this.lbltime.BackColor = System.Drawing.Color.Transparent;
			this.lbltime.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbltime.Dock")));
			this.lbltime.Enabled = ((bool)(resources.GetObject("lbltime.Enabled")));
			this.lbltime.Font = ((System.Drawing.Font)(resources.GetObject("lbltime.Font")));
			this.lbltime.Image = ((System.Drawing.Image)(resources.GetObject("lbltime.Image")));
			this.lbltime.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbltime.ImageAlign")));
			this.lbltime.ImageIndex = ((int)(resources.GetObject("lbltime.ImageIndex")));
			this.lbltime.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbltime.ImeMode")));
			this.lbltime.Location = ((System.Drawing.Point)(resources.GetObject("lbltime.Location")));
			this.lbltime.Name = "lbltime";
			this.lbltime.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbltime.RightToLeft")));
			this.lbltime.Size = ((System.Drawing.Size)(resources.GetObject("lbltime.Size")));
			this.lbltime.TabIndex = ((int)(resources.GetObject("lbltime.TabIndex")));
			this.lbltime.Text = resources.GetString("lbltime.Text");
			this.lbltime.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbltime.TextAlign")));
			this.toolTip1.SetToolTip(this.lbltime, resources.GetString("lbltime.ToolTip"));
			this.lbltime.Visible = ((bool)(resources.GetObject("lbltime.Visible")));
			// 
			// frmMain
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.lbltime);
			this.Controls.Add(this.lblselect);
			this.Controls.Add(this.btnMessage);
			this.Controls.Add(this.picF);
			this.Controls.Add(this.picS);
			this.Controls.Add(this.picE);
			this.Controls.Add(this.picTop);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.rbEn);
			this.Controls.Add(this.rbFr);
			this.Controls.Add(this.rbSp);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximizeBox = false;
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimizeBox = false;
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "frmMain";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmMain());
		}

		private void SetCulture()
		{
			CultureInfo objCI = new CultureInfo(strCulture);
			Thread.CurrentThread.CurrentCulture = objCI;
			Thread.CurrentThread.CurrentUICulture = objCI;
			
		}
		private void SetResource()
		{
			rm = ResourceManager.CreateFileBasedResourceManager
				("resource", strResourcesPath, null);

		}

		private void GlobalizeApp()
		{
			SetCulture();
			SetResource();
			SetUIChanges();
		}
		private void SetUIChanges()
		{
			if (String.Compare(strCulture,"en-US")==0)
			{ 
				picTop.Image = picE.Image;
			}
 
			if (String.Compare(strCulture,"es-ES")==0)
			{ 
				picTop.Image = picS.Image;
			}
 
			if (String.Compare(strCulture,"fr-FR")==0)
			{ 
				picTop.Image = picF.Image;
			}
			label1.Text=rm.GetString("0001");
			label2.Text=rm.GetString("0002");
			label3.Text=rm.GetString("0003");
			btnSubmit.Text=rm.GetString("0004");
			btnCancel.Text=rm.GetString("0005");
			this.Text = rm.GetString("0000");
			lblselect.Text = rm.GetString("0009");

			lbltime.Text = DateTime.Now.ToLongDateString().ToString(); 
			   
		
		}


		private void frmMain_Load(object sender, System.EventArgs e)
		{
			strCulture = RegistryAccess.GetStringRegistryValue(@"Language","en-US");

			if (String.Compare(strCulture,"en-US")==0)
			{ 
				rbEn.Checked = true; 
			}
 
			if (String.Compare(strCulture,"es-ES")==0)
			{ 
				rbSp.Checked = true;
			}
 
			if (String.Compare(strCulture,"fr-FR")==0)
			{ 
				rbFr.Checked = true;
			}

			GlobalizeApp();
			  
		}

		
		private void btnMessage_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show ( rm.GetString("0007"),rm.GetString("0000"),MessageBoxButtons.OK  ,MessageBoxIcon.Information ); 
		}

		private void picTop_Click(object sender, System.EventArgs e)
		{
			
		}

		private void btnSubmit_Click(object sender, System.EventArgs e)
		{
			frmSubmit myform = new frmSubmit();
 
			if (myform.ShowDialog() == DialogResult.OK)
			{

			}
		}

		
		private void changeLanguage()
		{
			if (rbEn.Checked) 
			{ 
				strCulture ="en-US";
			}
 
			if (rbSp.Checked) 
			{ 
				strCulture ="es-ES";
			}
 
			if (rbFr.Checked) 
			{ 
				strCulture ="fr-FR";
			}

			GlobalizeApp();

			DialogResult d=	MessageBox.Show(rm.GetString("0010") ,rm.GetString("0000"), MessageBoxButtons.YesNo , MessageBoxIcon.Information );
			if (d ==DialogResult.Yes )
			{
				RegistryAccess.SetStringRegistryValue("Language", strCulture );
			}
		}

	
		private void rbEn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			changeLanguage();		
		}

		private void rbSp_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			changeLanguage();
		}

		private void rbFr_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			changeLanguage();
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = ""; 
		}

		

	}
}
