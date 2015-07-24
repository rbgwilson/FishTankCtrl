using System;
using System.Net;
using Gtk;
using GLib;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base ("Center")
	{
		Build ();
		GLib.Timeout.Add(900000, new GLib.TimeoutHandler (getIP) );
		GLib.Timeout.Add(10000, new GLib.TimeoutHandler (getTemp) );
		GLib.Timeout.Add(1000, new GLib.TimeoutHandler (heartBeat) );
		getIP ();
	}

	protected bool getTemp()
	{
		Random num = new Random ();
		decimal rndnum = new decimal();

		rndnum = decimal.Round (Convert.ToDecimal (num.NextDouble()), 3);
		pbTemp1.Fraction = Convert.ToDouble (rndnum);
		pbTemp1.Text = decimal.Round((rndnum * 100), 1).ToString () + " C";

		rndnum = decimal.Round (Convert.ToDecimal (num.NextDouble()), 3);
		pbTemp2.Fraction = Convert.ToDouble (rndnum);
		pbTemp2.Text = decimal.Round((rndnum * 100), 1).ToString () + " C";
		return true;
	}

	protected bool heartBeat()
	{
		if (status.Visible)
			status.Visible = false;
		else
			status.Visible = true;
		return true;
	}

	protected bool getIP()
	{
		IPAddress[] localIP = Dns.GetHostAddresses (Environment.MachineName);
		lblIPAddress.Text = "IP Address: " + localIP [0].ToString ();
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