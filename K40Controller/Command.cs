using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K40Controller
{
	class Value
	{
		double _val;

		public Value()
		{
			_val = double.MaxValue;
		}

		public Value(Value c)
		{
			_val = c._val;
		}

		public bool isSet()
		{
			return (_val != double.MaxValue);
		}

		public override string ToString()
		{
			return _val.ToString();
		}

		public bool Equals(Value v)
		{
			if ( !v.isSet() || !isSet() )
			{
				return false;
			}

			return _val.Equals(v._val);
		}

		public static implicit operator Value(double val)
		{
			return new Value { _val = val };
		}

		public static implicit operator double(Value val)
		{
			return val._val;
		}
	}

	class Coordinates
	{
		public Coordinates()
		{
			X = new Value();
			Y = new Value();
			Z = new Value();
		}

		public Coordinates(Coordinates clone)
		{
			X = new Value(clone.X);
			Y = new Value(clone.Y);
			Z = new Value(clone.Z);
		}

		public Value X;
		public Value Y;
		public Value Z;
	}

	class Command
	{
		public uint block;
		public uint line;
		public char type;
		public uint code;
		public Coordinates pos;
		public Value E;
		public Value I;
		public Value J;
		public Value K;
		public Value L;
		public Value F;
		public Value S;

		public Command()
		{
			line = 0;
			type = ' ';
			code = uint.MaxValue;
			block = uint.MaxValue;

			pos = new Coordinates();
			E = new Value();
			I = new Value();
			J = new Value();
			K = new Value();
			L = new Value();
			F = new Value();
			S = new Value();
		}

		public Command(Command clone)
		{
			line = 0;
			type = clone.type;
			code = clone.code;
			block = clone.block;

			pos = new Coordinates(clone.pos);
			E = new Value(clone.E);
			I = new Value(clone.I);
			J = new Value(clone.J);
			K = new Value(clone.K);
			L = new Value(clone.L);
			F = new Value(clone.F);
			S = new Value(clone.S);
		}

		public override string ToString()
		{
			string s = "";

			if(code == uint.MaxValue || type == ' ')
			{	return "Invalid COMMAND";}
			
			if(block != uint.MaxValue) 
			{	s += 'N' + block.ToString() +" ";}

			s += type + code.ToString();

			s += " { ";
			if (pos.X.isSet()) { s += "X" + pos.X.ToString() + " "; }
			if (pos.Y.isSet()) { s += "Y" + pos.Y.ToString() + " "; }
			if (pos.Z.isSet()) { s += "Z" + pos.Z.ToString() + " "; }
			if (E.isSet()) { s += "E" + E.ToString() + " "; }
			if (I.isSet()) { s += "I" + I.ToString() + " "; }
			if (J.isSet()) { s += "J" + J.ToString() + " "; }
			if (K.isSet()) { s += "K" + K.ToString() + " "; }
			if (L.isSet()) { s += "L" + L.ToString() + " "; }
			if (F.isSet()) { s += "F" + F.ToString() + " "; }
			if (S.isSet()) { s += "S" + S.ToString() + " "; }
			s += "}";

			return s;
		}
	}
}
