using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Text.RegularExpressions;

namespace K40Controller
{
	class Draw
	{
		enum Mode : uint
		{
			Raw = 0x00,
			Paths = 0x01,
			Inner = 0x02,
			Nearest = 0x04
		}

		Mode mode = Mode.Raw;

		Pen penCut = new Pen(Color.White, 1);
		Pen penLoop = new Pen(Color.Yellow, 1);
		Pen penMove = new Pen(Color.Blue, 1);


		private void DrawLine( Graphics dc, Pen pen, Pos pos1, Pos pos2 )
		{
			Point pt1 = new Point();
			Point pt2 = new Point();
			pt1.X = (int)( pos1.X * Settings.Scale );
			pt1.Y = (int)( pos1.Y * Settings.Scale );
			pt2.X = (int)( pos2.X * Settings.Scale );
			pt2.Y = (int)( pos2.Y * Settings.Scale );

			dc.DrawLine( pen, pt1, pt2 );
		}

		private void DrawLArc( Graphics dc, Pen pen, Pos pos1, Pos pos2, double I, double J )
		{
			Point pt1 = new Point();
			Point pt2 = new Point();
			pt1.X = (int)( pos1.X * Settings.Scale );
			pt1.Y = (int)( pos1.Y * Settings.Scale );
			pt2.X = (int)( pos2.X * Settings.Scale );
			pt2.Y = (int)( pos2.Y * Settings.Scale );
			Rectangle rect = new Rectangle();
			rect.X = pt1.X;
			rect.Y = pt1.Y;
			rect.Width = pt2.X - pt1.X;
			rect.Height = pt2.Y - pt1.Y;
			dc.DrawArc( pen, rect, (float)I, (float)J );
		}

		public void DrawJob( Job job, Graphics dc )
		{
			if( job.commands == null )
			{
				return;
			}

			if( (mode & Mode.Raw) == Mode.Raw )
			{
				// Raw is exclusive
				DrawRaw( job, dc );
			}
			else
			{
				DrawPaths( job, dc );
			}
		}

		public void DrawPaths( Job job, Graphics dc )
		{
			Pos pos = new Pos();

			foreach ( Path path in job.paths )
			{
				if (path.type == Path.Type.Move)
				{
					DrawPath(job, dc, path);
				}
			}
		}

		public void DrawPath(Job job, Graphics dc, Path path)
		{
			Pen pen = null;
			switch (path.type)
			{
				case Path.Type.Move:
					pen = penMove;
					break;
			}

			foreach (Command com in path.commands)
			{

			}
		}

		public void DrawRaw( Job job, Graphics dc )
		{
			Pos pos = new Pos();

			foreach( Command com in job.commands )
			{
				if( com.type == 'G' )
				{
					// Move
					if( com.code == 0 )
					{
						Pos posDest = new Pos();
						posDest.X = com.pos.X;
						posDest.Y = com.pos.Y;
						if( K40Controller.Properties.Settings.Default.drawMoves )
						{
							DrawLine( dc, penMove, pos, posDest );
						}
						pos = posDest;
					}

					// Move cut line
					if( com.code == 1 )
					{
						Pos posDest = new Pos();
						posDest.X = com.pos.X;
						posDest.Y = com.pos.Y;
						if( K40Controller.Properties.Settings.Default.drawCuts )
						{
							DrawLine( dc, penCut, pos, posDest );
						}
						pos = posDest;
					}

					// Move cut arc CW
					if( com.code == 2 )
					{
						Pos posDest = new Pos();
						posDest.X = com.pos.X;
						posDest.Y = com.pos.Y;
						if( K40Controller.Properties.Settings.Default.drawCuts )
						{
							DrawLine( dc, penCut, pos, posDest );
						}
						pos = posDest;
					}

					// Move cut arc CCW
					if( com.code == 3 )
					{
						Pos posDest = new Pos();
						posDest.X = com.pos.X;
						posDest.Y = com.pos.Y;
						if( K40Controller.Properties.Settings.Default.drawCuts )
						{
							DrawLine( dc, penCut, posDest, pos );
						}
						pos = posDest;
					}
				}
			}
		}

	}
}
