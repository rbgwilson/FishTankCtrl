using System;
using Gtk;

namespace FishTankCtrl
{

	public class MainClass
	{

		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();
		}

		public static void UpdateSwitches (Switches SWStatus)
		{
			
		}
	}

	public class Switches
	{
		public bool Pump { get; set;}
		public bool Heater { get; set;}
		public bool Light { get; set;}
		public bool Aux { get; set;}
	}
}
