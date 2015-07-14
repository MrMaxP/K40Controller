using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K40Controller
{
	class Path
	{
		Command start;
		List<Command> path;

		public Path()
		{
			path = new List<Command>();
			start = new Command();
		}

		public void Add( Command com )
		{
			path.Add( com );
		}

		public void End()
		{

		}
	}
}
