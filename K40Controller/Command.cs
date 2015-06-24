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

		public bool isSet()
		{
			return (_val != double.MaxValue);
		}

		public override string ToString()
		{
			return _val.ToString();
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

	class Command
	{
		public uint block;
		public uint line;
		public char type;
		public uint code;
		public Value X;
		public Value Y;
		public Value Z;
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

			X = new Value();
			Y = new Value();
			Z = new Value();
			E = new Value();
			I = new Value();
			J = new Value();
			K = new Value();
			L = new Value();
			F = new Value();
			S = new Value();
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
			if (X.isSet()) { s += "X" + X.ToString() + " "; }
			if (Y.isSet()) { s += "Y" + Y.ToString() + " "; }
			if (Z.isSet()) { s += "Z" + Z.ToString() + " "; }
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
