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

        public MainForm()
        {
            InitializeComponent();
			job = new Job();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
			job.Parse(@"C:\Users\Stuart\Documents\GitHub\K40Controller\HogwartsPlaceCard.g");
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
    }
}
