using System;
using System.Collections.Concurrent;
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
		private List<int> MessageIds = new List<int>() {Win32_WMCtrl.WM_COPYDATA, Win32_WMCtrl.WM_DESTROY,Win32_WMCtrl.WM_DESTROY};
		private BlockingCollection<CommandItem> commandItemQueue = new BlockingCollection<CommandItem>();
		public MainForm()
		{
			InitializeComponent();
			toolStripButtonPlay.Image = imageListPlayback.Images[0];
			toolStripButtonPause.Image = imageListPlayback.Images[2];
			toolStripButtonStop.Image = imageListPlayback.Images[4];
			toolStripButtonAddFilter.Image = imageListFilter.Images[0];
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

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ToolStripButtonPlay_MouseDown(object sender, MouseEventArgs e)
		{
			toolStripButtonPlay.Image = imageListPlayback.Images[1];
		}

		private void ToolStripButtonPlay_MouseUp(object sender, MouseEventArgs e)
		{
			toolStripButtonPlay.Image = imageListPlayback.Images[0];
		}

		private void ToolStripButtonPlay_MouseLeave(object sender, EventArgs e)
		{
			toolStripButtonPlay.Image = imageListPlayback.Images[0];
		}

		private void ToolStripButtonPause_MouseDown(object sender, MouseEventArgs e)
		{
			toolStripButtonPause.Image = imageListPlayback.Images[3];
		}

		private void ToolStripButtonPause_MouseUp(object sender, MouseEventArgs e)
		{
			toolStripButtonPause.Image = imageListPlayback.Images[2];
		}

		private void ToolStripButtonPause_MouseLeave(object sender, EventArgs e)
		{
			toolStripButtonPause.Image = imageListPlayback.Images[2];
		}

		private void ToolStripButtonStop_MouseDown(object sender, MouseEventArgs e)
		{
			toolStripButtonStop.Image = imageListPlayback.Images[5];
		}

		private void ToolStripButtonStop_MouseUp(object sender, MouseEventArgs e)
		{
			toolStripButtonStop.Image = imageListPlayback.Images[4];
		}

		private void ToolStripButtonStop_MouseLeave(object sender, EventArgs e)
		{
			toolStripButtonStop.Image = imageListPlayback.Images[4];
		}

		private void ToolStripButtonAddFilter_MouseDown(object sender, MouseEventArgs e)
		{
			toolStripButtonAddFilter.Image = imageListFilter.Images[1];
		}

		private void ToolStripButtonAddFilter_MouseUp(object sender, MouseEventArgs e)
		{
			toolStripButtonAddFilter.Image = imageListFilter.Images[0];
		}

		private void ToolStripButtonAddFilter_MouseLeave(object sender, EventArgs e)
		{
			toolStripButtonAddFilter.Image = imageListFilter.Images[0];
		}

		private void ToolStripButtonPlay_Click(object sender, EventArgs e)
		{
			CommandItem item = new MsgCommandItem();
			Debug.Print($"{item.CmdId}");
		}

		private void ToolStripButtonPause_Click(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonStop_Click(object sender, EventArgs e)
		{

		}

		private void ToolStripButtonAddFilter_Click(object sender, EventArgs e)
		{

		}
	}
}
