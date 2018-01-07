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
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonReplace = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
			this.SuspendLayout();
			// 
			// picPreview
			// 
			this.picPreview.Location = new System.Drawing.Point(12, 12);
			this.picPreview.Name = "picPreview";
			this.picPreview.Size = new System.Drawing.Size(512, 512);
			this.picPreview.TabIndex = 0;
			this.picPreview.TabStop = false;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(530, 12);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(129, 23);
			this.buttonSave.TabIndex = 0;
			this.buttonSave.Text = "Save to file...";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonReplace
			// 
			this.buttonReplace.Location = new System.Drawing.Point(530, 41);
			this.buttonReplace.Name = "buttonReplace";
			this.buttonReplace.Size = new System.Drawing.Size(129, 23);
			this.buttonReplace.TabIndex = 1;
			this.buttonReplace.Text = "Replace with...";
			this.buttonReplace.UseVisualStyleBackColor = true;
			this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(671, 536);
			this.Controls.Add(this.buttonReplace);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.picPreview);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormMain";
			this.Text = "Openplanet Map Thumb";
			((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox picPreview;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonReplace;
	}
}

