using System;
using System.Net;
using Gtk;
using GLib;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base ("Center")
	{
		Build ();
		GLib.Timeout.Add(500, new GLib.TimeoutHandler (getTemp) );
		getIP ();
	}

	protected bool getTemp()
	{
		
		return true;
	}

	protected void getIP()
	{
		IPAddress[] localIP = Dns.GetHostAddresses (Environment.MachineName);
		lblIPAddress.Text = "IP: " + localIP [0].ToString ();
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