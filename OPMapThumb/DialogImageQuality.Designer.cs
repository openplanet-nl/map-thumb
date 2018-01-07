namespace OPMapThumb
{
	partial class DialogImageQuality
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogImageQuality));
			this.trackQuality = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			this.numQuality = new System.Windows.Forms.NumericUpDown();
			this.buttonDefault = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.trackQuality)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numQuality)).BeginInit();
			this.SuspendLayout();
			// 
			// trackQuality
			// 
			this.trackQuality.Location = new System.Drawing.Point(12, 25);
			this.trackQuality.Maximum = 100;
			this.trackQuality.Name = "trackQuality";
			this.trackQuality.Size = new System.Drawing.Size(161, 45);
			this.trackQuality.TabIndex = 0;
			this.trackQuality.TickStyle = System.Windows.Forms.TickStyle.None;
			this.trackQuality.Value = 95;
			this.trackQuality.Scroll += new System.EventHandler(this.trackQuality_Scroll);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Quality";
			// 
			// numQuality
			// 
			this.numQuality.Location = new System.Drawing.Point(179, 25);
			this.numQuality.Name = "numQuality";
			this.numQuality.Size = new System.Drawing.Size(78, 20);
			this.numQuality.TabIndex = 1;
			this.numQuality.Value = new decimal(new int[] {
            95,
            0,
            0,
            0});
			this.numQuality.ValueChanged += new System.EventHandler(this.numQuality_ValueChanged);
			// 
			// buttonDefault
			// 
			this.buttonDefault.Location = new System.Drawing.Point(12, 47);
			this.buttonDefault.Name = "buttonDefault";
			this.buttonDefault.Size = new System.Drawing.Size(75, 23);
			this.buttonDefault.TabIndex = 2;
			this.buttonDefault.Text = "Default";
			this.buttonDefault.UseVisualStyleBackColor = true;
			this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.Location = new System.Drawing.Point(182, 89);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 4;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonOK
			// 
			this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOK.Location = new System.Drawing.Point(101, 89);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 3;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// DialogImageQuality
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(269, 124);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonDefault);
			this.Controls.Add(this.numQuality);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.trackQuality);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DialogImageQuality";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Image quality";
			((System.ComponentModel.ISupportInitialize)(this.trackQuality)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numQuality)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TrackBar trackQuality;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numQuality;
		private System.Windows.Forms.Button buttonDefault;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOK;
	}
}