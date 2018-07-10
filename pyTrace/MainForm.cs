using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pyTrace
{
	public partial class MainForm : Form
	{
		private List<int> MessageIds = new List<int>() {WM_COPYDATA, WM_DESTROY, WM_DESTROY};
		public MainForm()
		{
			InitializeComponent();
		}

		protected override void WndProc(ref Message m)
		{
			int id = m.Msg;

			if (MessageIds.Exists(x => x == id))
			{
				Debug.Print(string.Format($"{m.Msg}"));
			}

			base.WndProc(ref m);
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
