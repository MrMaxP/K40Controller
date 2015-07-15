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

		public Command start;
		public List<Command> path;
		public Type type;

		public Path(Type pathType)
		{
			type = pathType;
			path = new List<Command>();
			start = new Command();
		}

		public Path(Type pathType, Command com)
		{
			type = pathType;
			path = new List<Command>();
			start = new Command(com);
		}

		public void Add(Command com)
		{
			path.Add( com );
		}

		public void End()
		{

		}
	}
}
