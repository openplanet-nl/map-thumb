using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPMapThumb
{
	public partial class DialogImageQuality : Form
	{
		public int Value { get; set; } = 95;

		public DialogImageQuality()
		{
			InitializeComponent();
		}

		private void buttonDefault_Click(object sender, EventArgs e)
		{
			Value = 95;
			trackQuality.Value = 95;
			numQuality.Value = 95;
		}

		private void trackQuality_Scroll(object sender, EventArgs e)
		{
			Value = trackQuality.Value;
			numQuality.Value = Value;
		}

		private void numQuality_ValueChanged(object sender, EventArgs e)
		{
			Value = (int)numQuality.Value;
			trackQuality.Value = Value;
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
