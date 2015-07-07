using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace K40Controller
{
	class Comms
	{
		SerialPort port = null;

		private void DataReceivedHandler( object sender, System.IO.Ports.SerialDataReceivedEventArgs e )
		{
			SerialPort sp = (SerialPort)sender;
			string retString = sp.ReadExisting();
			Console.Write( retString );
		}

		public bool Connect()
		{
			port = new SerialPort( "COM6", 115200, Parity.None, 8, StopBits.One ); //Create the serial port
			port.DtrEnable = true;   //enables the Data Terminal Ready (DTR) signal during serial communication (Handshaking)
			port.DataReceived += new SerialDataReceivedEventHandler( DataReceivedHandler );
			port.Open();             //Open the port

			return true;
		}

		public bool Send( string send )
		{
			Console.Write( "SEND: " + send + "\n" );
			port.WriteLine( send );
			return true;
		}
	}
}
