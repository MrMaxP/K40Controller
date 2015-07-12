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
		private SerialPort port = null;
		public string[] portList;
		SerialOutput outputToConsole = null;

		public Comms( SerialOutput output )
		{
			outputToConsole = output;
		}

		private void DataReceivedHandler( object sender, System.IO.Ports.SerialDataReceivedEventArgs e )
		{
			SerialPort sp = (SerialPort)sender;
			string retString = sp.ReadExisting();
			if( outputToConsole != null )
			{
				outputToConsole( retString );
			}
		}

		public bool Enumerate()
		{
			portList = SerialPort.GetPortNames();

			return true;
		}

		public bool Connect( string portName )
		{
			try
			{
				if( port == null )
				{
					port = new SerialPort( portName, 115200, Parity.None, 8, StopBits.One ); //Create the serial port
					port.DtrEnable = true;   //enables the Data Terminal Ready (DTR) signal during serial communication (Handshaking)
					port.DataReceived += new SerialDataReceivedEventHandler( DataReceivedHandler );
					port.Open();             //Open the port
				}
			}
			catch( Exception ex )
			{
				return false;
			}

			return true;
		}

		public bool Disconnect()
		{
			if( port != null )
			{
				port.Close();
				port = null;
				return true;
			}
			return false;
		}

		public bool Send( string send )
		{
			Console.Write( "SEND: " + send + "\n" );
			port.WriteLine( send );
			return true;
		}
	}
}
