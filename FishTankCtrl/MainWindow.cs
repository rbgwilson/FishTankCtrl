using System;
using System.Net;
using System.Timers;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	// Global for Switch status
	FishTankCtrl.Switches SWStatus = new FishTankCtrl.Switches ();

	public MainWindow () : base ("Center")
	{
		Build ();
		OnBtnMasterClicked ();
		Timer UpdateIP = new Timer(300000);
		UpdateIP.Elapsed += new ElapsedEventHandler (delegate {
			getIP ();
		});
		UpdateIP.Start ();
		getIP ();
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
		if (!tbPump.Active) {
			tbPump.Label = "Pump On";
			SWStatus.Pump = false;
		} else {
			tbPump.Label = "Pump Off";
			SWStatus.Pump = true;
		}
		FishTankCtrl.MainClass.UpdateSwitches (SWStatus);
	}
		
	protected void OnTbAuxClicked (object sender, EventArgs e)
	{
		if (!tbAux.Active) {
			tbAux.Label = "Aux On";
			SWStatus.Aux = false;
		} else {
			tbAux.Label = "Aux Off";
			SWStatus.Aux = true;
		}
		FishTankCtrl.MainClass.UpdateSwitches (SWStatus);
	}

	protected void OnTbLightClicked (object sender, EventArgs e)
	{
		if (!tbLight.Active) {
			tbLight.Label = "Light On";
			SWStatus.Light = false;
		} else {
			tbLight.Label = "Light Off";
			SWStatus.Light = true;
		}
		FishTankCtrl.MainClass.UpdateSwitches (SWStatus);
	}
		
	protected void OnTbHeaterClicked (object sender, EventArgs e)
	{
		if (!tbHeater.Active) {
			tbHeater.Label = "Heater On";
			SWStatus.Heater = false;
		} else {
			tbHeater.Label = "Heater Off";
			SWStatus.Heater = true;
		}
		FishTankCtrl.MainClass.UpdateSwitches (SWStatus);
	}

	protected void OnBtnMasterClicked ()
	{
		tbPump.Active = false;
		tbPump.Label = "Pump On";
		SWStatus.Pump = false;
		tbAux.Active = false;
		tbAux.Label = "Aux On";
		SWStatus.Aux = false;
		tbHeater.Active = false;
		tbHeater.Label = "Heater On";
		SWStatus.Heater = false;
		tbLight.Active = false;
		tbLight.Label = "Light On";
		SWStatus.Light = false;
		FishTankCtrl.MainClass.UpdateSwitches (SWStatus);
	}

	protected void OnBtnMasterClicked (object sender, EventArgs e)
	{
		tbPump.Active = false;
		tbPump.Label = "Pump On";
		SWStatus.Pump = false;
		tbAux.Active = false;
		tbAux.Label = "Aux On";
		SWStatus.Aux = false;
		tbHeater.Active = false;
		tbHeater.Label = "Heater On";
		SWStatus.Heater = false;
		tbLight.Active = false;
		tbLight.Label = "Light On";
		SWStatus.Light = false;
		FishTankCtrl.MainClass.UpdateSwitches (SWStatus);
	}
}