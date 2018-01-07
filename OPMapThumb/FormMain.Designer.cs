namespace OPMapThumb
{
	partial class FormMain
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
			if (disposing && (components != null)) {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.picPreview = new System.Windows.Forms.PictureBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.buttonExport = new System.Windows.Forms.ToolStripButton();
			this.buttonReplace = new System.Windows.Forms.ToolStripButton();
			this.buttonAbout = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.labelInfo = new System.Windows.Forms.ToolStripLabel();
			this.buttonOpenMap = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// picPreview
			// 
			this.picPreview.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picPreview.Location = new System.Drawing.Point(0, 25);
			this.picPreview.Name = "picPreview";
			this.picPreview.Size = new System.Drawing.Size(542, 542);
			this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picPreview.TabIndex = 0;
			this.picPreview.TabStop = false;
			// 
			// toolStrip1
			// 
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonOpenMap,
            this.toolStripSeparator2,
            this.buttonExport,
            this.buttonReplace,
            this.buttonAbout,
            this.toolStripSeparator1,
            this.labelInfo});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(542, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// buttonExport
			// 
			this.buttonExport.Image = ((System.Drawing.Image)(resources.GetObject("buttonExport.Image")));
			this.buttonExport.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Size = new System.Drawing.Size(60, 22);
			this.buttonExport.Text = "Export";
			this.buttonExport.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonReplace
			// 
			this.buttonReplace.Image = ((System.Drawing.Image)(resources.GetObject("buttonReplace.Image")));
			this.buttonReplace.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonReplace.Name = "buttonReplace";
			this.buttonReplace.Size = new System.Drawing.Size(103, 22);
			this.buttonReplace.Text = "Replace with...";
			this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
			// 
			// buttonAbout
			// 
			this.buttonAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.buttonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonAbout.Image = ((System.Drawing.Image)(resources.GetObject("buttonAbout.Image")));
			this.buttonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonAbout.Name = "buttonAbout";
			this.buttonAbout.Size = new System.Drawing.Size(23, 22);
			this.buttonAbout.Text = "Openplanet";
			this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// labelInfo
			// 
			this.labelInfo.Name = "labelInfo";
			this.labelInfo.Size = new System.Drawing.Size(53, 22);
			this.labelInfo.Text = "labelInfo";
			// 
			// buttonOpenMap
			// 
			this.buttonOpenMap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonOpenMap.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenMap.Image")));
			this.buttonOpenMap.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonOpenMap.Name = "buttonOpenMap";
			this.buttonOpenMap.Size = new System.Drawing.Size(23, 22);
			this.buttonOpenMap.Text = "Open map";
			this.buttonOpenMap.Click += new System.EventHandler(this.buttonOpenMap_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(542, 567);
			this.Controls.Add(this.picPreview);
			this.Controls.Add(this.toolStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormMain";
			this.Text = "Openplanet Map Thumb";
			((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox picPreview;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton buttonExport;
		private System.Windows.Forms.ToolStripButton buttonReplace;
		private System.Windows.Forms.ToolStripButton buttonAbout;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripLabel labelInfo;
		private System.Windows.Forms.ToolStripButton buttonOpenMap;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
	}
}

