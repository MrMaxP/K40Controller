using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K40Controller
{
    public partial class MainForm : Form
    {
		Job job;
		Comms comms;

        public MainForm()
        {
            InitializeComponent();
			this.MouseWheel += new MouseEventHandler( graphPanel_MouseWheel );
			job = new Job();
			comms = new Comms();
			comms.Connect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
		}

        protected override void OnPaint(PaintEventArgs e)
        {
        }

		private void graphPanel_Paint(object sender, PaintEventArgs e)
		{
			Graphics dc = e.Graphics;
			dc.FillRectangle(new SolidBrush(Color.Black), dc.ClipBounds);
			job.Draw(dc);
			base.OnPaint(e);
		}

		private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			comms.Send( "M114" );
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog theDialog = new OpenFileDialog();
			theDialog.Title = "Open G-Code File";
			theDialog.Filter = "G-files|*.g|All Files|*.*";
			theDialog.InitialDirectory = @"";
			if (theDialog.ShowDialog() == DialogResult.OK)
			{
				job.Parse(theDialog.FileName.ToString());
				graphPanel.Invalidate();
			}
		}

		private void graphPanel_MouseWheel( object sender, MouseEventArgs e )
		{
			float delta = (float)e.Delta;
			Settings.Scale += delta / 100.0f;
			graphPanel.Invalidate();
		}

		private void Test1_Click( object sender, EventArgs e )
		{
			comms.Send( "M114" );
		}
    }
}
