using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public delegate void SerialOutput( string line );

namespace K40Controller
{
    public partial class MainForm : Form
    {
		Job job;
		Comms comms;
		bool autoconnect;
		string lastConnectedPort;
		bool connected = false;

		void OutputConsole( string  line )
		{
			consoleWindow.AppendText( line );
		}

        public MainForm()
        {
            InitializeComponent();

			MainForm.CheckForIllegalCrossThreadCalls = false;

			this.MouseWheel += new MouseEventHandler( graphPanel_MouseWheel );
			job = new Job();
			comms = new Comms( new SerialOutput( OutputConsole ) );
			comms.Enumerate();

			listBoxConnect.Items.Clear();
			foreach( string port in comms.portList )
			{	listBoxConnect.Items.Add( port );}

//			if(autoconnect)
//			{
//				comms.Connect();
//			}
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

		private void buttonConnect_Click( object sender, EventArgs e )
		{
			if( !connected )
			{
				if( comms.Connect( listBoxConnect.Items[ listBoxConnect.TopIndex ].ToString() ) )
				{
					lastConnectedPort = listBoxConnect.Items[ listBoxConnect.TopIndex ].ToString();
					connected = true;
					buttonConnect.Text = "Disconnect";
				}
			}
			else
			{
				if( comms.Disconnect() )
				{
					connected = false;
					buttonConnect.Text = "Connect";
				}
			}
		}

		private void consoleWindow_TextChanged( object sender, EventArgs e )
		{
			consoleWindow.SelectionStart = consoleWindow.Text.Length; //Set the current caret position at the end
			consoleWindow.ScrollToCaret(); //Now scroll it automatically
		}
    }
}
