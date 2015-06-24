using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace K40Controller
{
	class Pos
	{
		public double X, Y, Z, E;
	}

    class Job
    {
		List<string> lines;
		List<Command> commands;

		public void Parse(string filename)
		{
			lines = new List<string>();
			commands = new List<Command>();

			string line;
			int discardedLines = 0;

			lines.Clear();
			commands.Clear();

			uint lineNum = 0;
			Regex gcodeRegEx = new Regex(@"([NGXYZEIJKLF])([-+]?[0-9.]+)");

			using (StreamReader reader = new StreamReader(filename))
			{
				while (!reader.EndOfStream)
				{

					line = reader.ReadLine();
					lines.Add(line);

					if (line == string.Empty || line.StartsWith(";"))
					{
						discardedLines++;

						continue;
					}

					MatchCollection m = gcodeRegEx.Matches(line);

					if(m.Count == 0)
					{
						// Comment or blank line
						continue;
					}

					Command com = new Command();
					com.line = lineNum;

					foreach(Match match in m)
					{
						char c = match.Groups[1].ToString()[0];

						double temp;
						if (!double.TryParse(match.Groups[2].ToString(), out temp))
						{
							// Error
						}

						switch (c)
						{
							case 'N': com.block = (uint)temp; break;

							case 'G': com.code = (uint)temp; com.type = c; break;
							case 'M': com.code = (uint)temp; com.type = c; break;
							case 'X': com.X = temp; break;
							case 'Y': com.Y = temp; break;
							case 'Z': com.Z = temp; break;
							case 'E': com.E = temp; break;
							case 'I': com.I = temp; break;
							case 'J': com.J = temp; break;
							case 'K': com.K = temp; break;
							case 'L': com.L = temp; break;
							case 'F': com.F = temp; break;
							case 'S': com.S = temp; break;
							default: break;
						}
					}

					commands.Add(com);

					//Console.Out.WriteLine(com.ToString());
				}

				lineNum++;
			}
		}

		private void DrawLine(Graphics dc, Pen pen, Pos pos1, Pos pos2)
		{
			Point pt1 = new Point();
			Point pt2 = new Point();
			pt1.X = (int)(pos1.X * Settings.Scale);
			pt1.Y = (int)(pos1.Y * Settings.Scale);
			pt2.X = (int)(pos2.X * Settings.Scale);
			pt2.Y = (int)(pos2.Y * Settings.Scale);

			dc.DrawLine(pen, pt1, pt2);
		}

		private void DrawLArc(Graphics dc, Pen pen, Pos pos1, Pos pos2, double I, double J)
		{
			Point pt1 = new Point();
			Point pt2 = new Point();
			pt1.X = (int)(pos1.X * Settings.Scale);
			pt1.Y = (int)(pos1.Y * Settings.Scale);
			pt2.X = (int)(pos2.X * Settings.Scale);
			pt2.Y = (int)(pos2.Y * Settings.Scale);
			Rectangle rect = new Rectangle();
			rect.X = pt1.X;
			rect.Y = pt1.Y;
			rect.Width = pt2.X - pt1.X;
			rect.Height = pt2.Y - pt1.Y;
			dc.DrawArc(pen, rect, (float)I, (float)J);
		}

		public void Draw(Graphics dc)
		{
			Pen penCut = new Pen(Color.White, 1);
			Pen penMove = new Pen(Color.Blue, 1);

			Pos pos = new Pos();

			foreach (Command com in commands)
			{
				if(com.type == 'G')
				{
					// Move
					if(com.code == 0)
					{
						Pos posDest = new Pos();
						posDest.X = com.X;
						posDest.Y = com.Y;
						DrawLine(dc, penMove, pos, posDest);
						pos = posDest;
					}

					// Move cut line
					if (com.code == 1)
					{
						Pos posDest = new Pos();
						posDest.X = com.X;
						posDest.Y = com.Y;
						DrawLine(dc, penCut, pos, posDest);
						pos = posDest;
					}

					// Move cut arc CW
					if (com.code == 2)
					{
						Pos posDest = new Pos();
						posDest.X = com.X;
						posDest.Y = com.Y;
						DrawLine(dc, penCut, pos, posDest);
						pos = posDest;
					}

					// Move cut arc CCW
					if (com.code == 3)
					{
						Pos posDest = new Pos();
						posDest.X = com.X;
						posDest.Y = com.Y;
						DrawLine(dc, penCut, posDest, pos);
						pos = posDest;
					}
				}
			}
		}
	}
}
