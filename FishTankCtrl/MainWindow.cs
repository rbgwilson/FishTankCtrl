using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Net;
using Gtk;
using GLib;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base ("Center")
	{
		Build ();
		GLib.Timeout.Add(900000, new GLib.TimeoutHandler (getIP) );
		GLib.Timeout.Add(10000, new GLib.TimeoutHandler (updateTemp) );
		getIP ();
	}

	protected bool updateTemp()
	{
		if (!Directory.Exists ("/sys/bus/w1/devices/")) {
			Random num = new Random ();
			decimal rndnum = new decimal();

			rndnum = decimal.Round (Convert.ToDecimal (num.NextDouble ()), 3);
			pbTemp1.Fraction = Convert.ToDouble (rndnum);
			pbTemp1.Text = decimal.Round ((rndnum * 100), 1).ToString () + " C";

			rndnum = decimal.Round (Convert.ToDecimal (num.NextDouble ()), 3);
			pbTemp2.Fraction = Convert.ToDouble (rndnum);
			pbTemp2.Text = decimal.Round ((rndnum * 100), 1).ToString () + " C";
			return true;
		} else {
			decimal temp1 = decimal.Round(Convert.ToDecimal(getTemp (0)), 1);
			pbTemp1.Fraction = Convert.ToDouble (temp1 * Convert.ToDecimal(0.01));
			pbTemp1.Text = temp1.ToString() + " C";

			decimal temp2 = decimal.Round(Convert.ToDecimal(getTemp (1)), 1);
			pbTemp2.Fraction = Convert.ToDouble (temp2 * Convert.ToDecimal(0.01));
			pbTemp2.Text = temp2.ToString() + " C";
			return true;
		}
	}

	protected double getTemp(int sensorID)
	{
		DirectoryInfo devsDir = new DirectoryInfo ("/sys/bus/w1/devices/");
		IEnumerable<DirectoryInfo> Sensors = devsDir.EnumerateDirectories ("28*");
		string tempText = "";

		if (sensorID <= Sensors.Count()) {
			DirectoryInfo Sensor = Sensors.ElementAt (sensorID);
			StreamReader Stream = Sensor.GetFiles ("w1_slave").FirstOrDefault ().OpenText ();
			string w1slavetext = Stream.ReadToEnd ();
			tempText = w1slavetext.Split(new string[] { "t=" }, StringSplitOptions.RemoveEmptyEntries)[1];
			Stream.Close ();
		} else {
			tempText = "0";
		}

		return double.Parse (tempText) / 1000;
	}

	protected bool getIP()
	{
		IPAddress[] localIP = Dns.GetHostAddresses (Environment.MachineName);
		lblIPAddress.Text = "IP Address:\n" + localIP [0].ToString ();
		return true;
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnTbPumpClicked (object sender, EventArgs e)
	{
		if (tbPump.Active) {
			tbPump.Label = "Turn Off";
		} else {
			tbPump.Label = "Turn On";
		}
	}
		
	protected void OnTbAuxClicked (object sender, EventArgs e)
	{
		if (tbAux.Active) {
			tbAux.Label = "Turn Off";
		} else {
			tbAux.Label = "Turn On";
		}
	}

	protected void OnTbLightClicked (object sender, EventArgs e)
	{
		if (tbLight.Active) {
			tbLight.Label = "Turn Off";
		} else {
			tbLight.Label = "Turn On";
		}
	}
		
	protected void OnTbHeaterClicked (object sender, EventArgs e)
	{
		if (tbHeater.Active) {
			tbHeater.Label = "Turn Off";
		} else {
			tbHeater.Label = "Turn On";
		}
	}

	protected void OnBtnMasterClicked (object sender, EventArgs e)
	{
		MessageDialog md = new MessageDialog (this, DialogFlags.DestroyWithParent, MessageType.Question, ButtonsType.YesNo, "Power Everything Off?");
		var myResponse = md.Run ();
		md.Destroy ();

		if (Convert.ToInt16 (myResponse) == -8) {
			tbPump.Active = false;
			tbPump.Label = "Turn On";
			tbAux.Active = false;
			tbAux.Label = "Turn On";
			tbHeater.Active = false;
			tbHeater.Label = "Turn On";
			tbLight.Active = false;
			tbLight.Label = "Turn On";
		}
	}
}