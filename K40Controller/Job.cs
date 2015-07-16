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
		public List<string> lines = null;
		public List<Command> commands = null;
		public List<Path> paths = null;



		public void Parse( string filename )
		{
			lines = new List<string>();
			commands = new List<Command>();
			paths = new List<Path>();

			string line;
			int discardedLines = 0;

			lines.Clear();
			commands.Clear();

			uint lineNum = 0;
			Regex gcodeRegEx = new Regex( @"([NGXYZEIJKLF])([-+]?[0-9.]+)" );

			Command lastCom = new Command();

			using( StreamReader reader = new StreamReader( filename ) )
			{
				while( !reader.EndOfStream )
				{
					line = reader.ReadLine();
					lines.Add( line );

					if( line == string.Empty || line.StartsWith( ";" ) )
					{
						discardedLines++;

						continue;
					}

					MatchCollection m = gcodeRegEx.Matches( line );

					if( m.Count == 0 )
					{
						// Comment or blank line
						continue;
					}

					Command com = new Command();
					com = new Command( lastCom );					// Init with current variables (i.e. last command)
					com.line = lineNum;

					foreach( Match match in m )
					{
						char c = match.Groups[ 1 ].ToString()[ 0 ];

						double temp;
						if( !double.TryParse( match.Groups[ 2 ].ToString(), out temp ) )
						{
							// Error
						}

						switch( c )
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

					commands.Add( com );
					lastCom = com;

//					Console.Out.WriteLine( com.ToString() );
				}

				lineNum++;
			}

			Group();
		}

		private void Group()
		{
			// Attempt to group G commands by paths

			Path.Type type = Path.Type.Move;
			Path currentPath = new Path(type);
			Command lastCom = new Command();

			foreach( Command com in commands )
			{
				{
					if( com.type == 'G' )
					{
						switch (com.code)
						{
							case 0:	// MOVE
								if (type != Path.Type.Move)
								{
									currentPath.End();
									paths.Add(currentPath);
									type = Path.Type.Move;
									currentPath = new Path(type, lastCom);
								}
								currentPath.Add(com);
								break;

							case 1:	// MOVE CUT
							case 2:	// ARC CW CUT
							case 3:	// ARC CCW CUT
								if (type != Path.Type.Cut)
								{
									currentPath.End();
									paths.Add(currentPath);
									type = Path.Type.Cut;
									currentPath = new Path(type, lastCom);
								}
								currentPath.Add(com);
								break;

							case 7:	// RASTER (Check this code)
								if (type != Path.Type.Raster)
								{
									currentPath.End();
									paths.Add(currentPath);
									type = Path.Type.Raster;
									currentPath = new Path(type, lastCom);
								}
								currentPath.Add(com);
								break;
						}
					}
				}

				lastCom = new Command(com);
			}


			// Debug print
			foreach ( Path path in paths )
			{
				string pathText = "Path ";
				if (path.type == Path.Type.Move) { pathText += "Move:"; }
				if (path.type == Path.Type.Cut) { pathText += "Cut:"; }
				if (path.type == Path.Type.Raster) { pathText += "Raster:"; }
				Console.WriteLine(pathText);
			}

		}

	}
}
