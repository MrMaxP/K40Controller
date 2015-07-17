using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K40Controller
{
	class Path
	{
		public enum Type
		{
			Move,
			Cut,
			Raster
		};

		public Coordinates start;
		public List<Command> commands;
		public Type type;
		public bool looped;

		public Path(Type pathType)
		{
			type = pathType;
			commands = new List<Command>();
			start = new Coordinates();
			looped = false;
		}

		public Path(Type pathType, Command com)
		{
			type = pathType;
			commands = new List<Command>();
			start = new Coordinates(com.pos);
			looped = false;
		}

		public void Add(Command com)
		{
			commands.Add(com);
		}

		public void End()
		{
			Coordinates end = commands[commands.Count-1].pos;
			if (start.X.Equals(end.X) && start.Y.Equals(end.Y) && start.Z.Equals(end.Z))
			{
				looped = true;
			}
		}
	}
}
