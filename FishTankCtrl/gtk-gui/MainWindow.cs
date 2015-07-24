
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	
	private global::Gtk.HBox hbox1;
	
	private global::Gtk.VBox vbox10;
	
	private global::Gtk.HBox hbox5;
	
	private global::Gtk.Label label3;
	
	private global::Gtk.ToggleButton tbPump;
	
	private global::Gtk.HBox hbox7;
	
	private global::Gtk.Label label4;
	
	private global::Gtk.ToggleButton tbHeater;
	
	private global::Gtk.HBox hbox8;
	
	private global::Gtk.Label label5;
	
	private global::Gtk.ToggleButton tbLight;
	
	private global::Gtk.HBox hbox9;
	
	private global::Gtk.Label label6;
	
	private global::Gtk.ToggleButton tbAux;
	
	private global::Gtk.HSeparator hseparator1;
	
	private global::Gtk.Button btnMaster;
	
	private global::Gtk.VSeparator vseparator1;
	
	private global::Gtk.VBox vbox9;
	
	private global::Gtk.Label label9;
	
	private global::Gtk.ProgressBar pbTemp2;
	
	private global::Gtk.VBox vbox3;
	
	private global::Gtk.HBox hbox6;
	
	private global::Gtk.Label label8;
	
	private global::Gtk.ProgressBar pbTemp1;
	
	private global::Gtk.HBox hbox2;
	
	private global::Gtk.Label lblIPAddress;
	
	private global::Gtk.Image status;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.WidthRequest = 320;
		this.HeightRequest = 240;
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Fish Tank Ctrl");
		this.WindowPosition = ((global::Gtk.WindowPosition)(1));
		this.Resizable = false;
		this.AllowGrow = false;
		this.Gravity = ((global::Gdk.Gravity)(5));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.vbox10 = new global::Gtk.VBox ();
		this.vbox10.Name = "vbox10";
		this.vbox10.Spacing = 6;
		// Container child vbox10.Gtk.Box+BoxChild
		this.hbox5 = new global::Gtk.HBox ();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Pump:");
		this.hbox5.Add (this.label3);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.label3]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child hbox5.Gtk.Box+BoxChild
		this.tbPump = new global::Gtk.ToggleButton ();
		this.tbPump.HeightRequest = 35;
		this.tbPump.CanFocus = true;
		this.tbPump.Name = "tbPump";
		this.tbPump.Label = global::Mono.Unix.Catalog.GetString ("Turn On");
		this.hbox5.Add (this.tbPump);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.tbPump]));
		w2.PackType = ((global::Gtk.PackType)(1));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		this.vbox10.Add (this.hbox5);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox10 [this.hbox5]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox10.Gtk.Box+BoxChild
		this.hbox7 = new global::Gtk.HBox ();
		this.hbox7.Name = "hbox7";
		this.hbox7.Spacing = 6;
		// Container child hbox7.Gtk.Box+BoxChild
		this.label4 = new global::Gtk.Label ();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Heater:");
		this.hbox7.Add (this.label4);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.label4]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child hbox7.Gtk.Box+BoxChild
		this.tbHeater = new global::Gtk.ToggleButton ();
		this.tbHeater.HeightRequest = 35;
		this.tbHeater.CanFocus = true;
		this.tbHeater.Name = "tbHeater";
		this.tbHeater.UseUnderline = true;
		this.tbHeater.Label = global::Mono.Unix.Catalog.GetString ("Turn On");
		this.hbox7.Add (this.tbHeater);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.tbHeater]));
		w5.PackType = ((global::Gtk.PackType)(1));
		w5.Position = 1;
		w5.Expand = false;
		w5.Fill = false;
		this.vbox10.Add (this.hbox7);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox10 [this.hbox7]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbox10.Gtk.Box+BoxChild
		this.hbox8 = new global::Gtk.HBox ();
		this.hbox8.Name = "hbox8";
		this.hbox8.Spacing = 6;
		// Container child hbox8.Gtk.Box+BoxChild
		this.label5 = new global::Gtk.Label ();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Light:");
		this.hbox8.Add (this.label5);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.label5]));
		w7.Position = 0;
		w7.Expand = false;
		w7.Fill = false;
		// Container child hbox8.Gtk.Box+BoxChild
		this.tbLight = new global::Gtk.ToggleButton ();
		this.tbLight.HeightRequest = 35;
		this.tbLight.CanFocus = true;
		this.tbLight.Name = "tbLight";
		this.tbLight.UseUnderline = true;
		this.tbLight.Label = global::Mono.Unix.Catalog.GetString ("Turn On");
		this.hbox8.Add (this.tbLight);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.tbLight]));
		w8.PackType = ((global::Gtk.PackType)(1));
		w8.Position = 1;
		w8.Expand = false;
		w8.Fill = false;
		this.vbox10.Add (this.hbox8);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox10 [this.hbox8]));
		w9.Position = 2;
		w9.Expand = false;
		w9.Fill = false;
		// Container child vbox10.Gtk.Box+BoxChild
		this.hbox9 = new global::Gtk.HBox ();
		this.hbox9.Name = "hbox9";
		this.hbox9.Spacing = 6;
		// Container child hbox9.Gtk.Box+BoxChild
		this.label6 = new global::Gtk.Label ();
		this.label6.Name = "label6";
		this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Aux:");
		this.hbox9.Add (this.label6);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.label6]));
		w10.Position = 0;
		w10.Expand = false;
		w10.Fill = false;
		// Container child hbox9.Gtk.Box+BoxChild
		this.tbAux = new global::Gtk.ToggleButton ();
		this.tbAux.HeightRequest = 35;
		this.tbAux.CanFocus = true;
		this.tbAux.Name = "tbAux";
		this.tbAux.UseUnderline = true;
		this.tbAux.Label = global::Mono.Unix.Catalog.GetString ("Turn On");
		this.hbox9.Add (this.tbAux);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.tbAux]));
		w11.PackType = ((global::Gtk.PackType)(1));
		w11.Position = 1;
		w11.Expand = false;
		w11.Fill = false;
		this.vbox10.Add (this.hbox9);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox10 [this.hbox9]));
		w12.Position = 3;
		w12.Expand = false;
		w12.Fill = false;
		// Container child vbox10.Gtk.Box+BoxChild
		this.hseparator1 = new global::Gtk.HSeparator ();
		this.hseparator1.Name = "hseparator1";
		this.vbox10.Add (this.hseparator1);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox10 [this.hseparator1]));
		w13.Position = 4;
		w13.Expand = false;
		w13.Fill = false;
		// Container child vbox10.Gtk.Box+BoxChild
		this.btnMaster = new global::Gtk.Button ();
		this.btnMaster.HeightRequest = 35;
		this.btnMaster.CanFocus = true;
		this.btnMaster.Name = "btnMaster";
		this.btnMaster.UseUnderline = true;
		this.btnMaster.Label = global::Mono.Unix.Catalog.GetString ("Master Off");
		this.vbox10.Add (this.btnMaster);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox10 [this.btnMaster]));
		w14.PackType = ((global::Gtk.PackType)(1));
		w14.Position = 5;
		w14.Expand = false;
		w14.Fill = false;
		this.hbox1.Add (this.vbox10);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox10]));
		w15.Position = 0;
		w15.Expand = false;
		w15.Fill = false;
		w15.Padding = ((uint)(5));
		// Container child hbox1.Gtk.Box+BoxChild
		this.vseparator1 = new global::Gtk.VSeparator ();
		this.vseparator1.Name = "vseparator1";
		this.hbox1.Add (this.vseparator1);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vseparator1]));
		w16.Position = 1;
		w16.Expand = false;
		w16.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.vbox9 = new global::Gtk.VBox ();
		this.vbox9.Name = "vbox9";
		this.vbox9.Spacing = 6;
		// Container child vbox9.Gtk.Box+BoxChild
		this.label9 = new global::Gtk.Label ();
		this.label9.Name = "label9";
		this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Temp 2:");
		this.vbox9.Add (this.label9);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.label9]));
		w17.Position = 0;
		w17.Expand = false;
		w17.Fill = false;
		// Container child vbox9.Gtk.Box+BoxChild
		this.pbTemp2 = new global::Gtk.ProgressBar ();
		this.pbTemp2.Name = "pbTemp2";
		this.pbTemp2.Orientation = ((global::Gtk.ProgressBarOrientation)(2));
		this.vbox9.Add (this.pbTemp2);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.pbTemp2]));
		w18.PackType = ((global::Gtk.PackType)(1));
		w18.Position = 1;
		this.hbox1.Add (this.vbox9);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox9]));
		w19.PackType = ((global::Gtk.PackType)(1));
		w19.Position = 2;
		w19.Expand = false;
		w19.Fill = false;
		w19.Padding = ((uint)(5));
		// Container child hbox1.Gtk.Box+BoxChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox6 = new global::Gtk.HBox ();
		this.hbox6.Name = "hbox6";
		this.hbox6.Spacing = 6;
		// Container child hbox6.Gtk.Box+BoxChild
		this.label8 = new global::Gtk.Label ();
		this.label8.Name = "label8";
		this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Temp 1:");
		this.hbox6.Add (this.label8);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.label8]));
		w20.PackType = ((global::Gtk.PackType)(1));
		w20.Position = 0;
		w20.Expand = false;
		w20.Fill = false;
		this.vbox3.Add (this.hbox6);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox6]));
		w21.Position = 0;
		w21.Expand = false;
		w21.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.pbTemp1 = new global::Gtk.ProgressBar ();
		this.pbTemp1.Name = "pbTemp1";
		this.pbTemp1.Orientation = ((global::Gtk.ProgressBarOrientation)(2));
		this.vbox3.Add (this.pbTemp1);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.pbTemp1]));
		w22.PackType = ((global::Gtk.PackType)(1));
		w22.Position = 1;
		this.hbox1.Add (this.vbox3);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox3]));
		w23.PackType = ((global::Gtk.PackType)(1));
		w23.Position = 3;
		w23.Expand = false;
		w23.Fill = false;
		w23.Padding = ((uint)(5));
		this.vbox1.Add (this.hbox1);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
		w24.Position = 0;
		w24.Expand = false;
		w24.Fill = false;
		w24.Padding = ((uint)(5));
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.HeightRequest = 20;
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.lblIPAddress = new global::Gtk.Label ();
		this.lblIPAddress.Name = "lblIPAddress";
		this.lblIPAddress.LabelProp = global::Mono.Unix.Catalog.GetString ("IP Address");
		this.hbox2.Add (this.lblIPAddress);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.lblIPAddress]));
		w25.Position = 0;
		w25.Expand = false;
		w25.Fill = false;
		w25.Padding = ((uint)(5));
		// Container child hbox2.Gtk.Box+BoxChild
		this.status = new global::Gtk.Image ();
		this.status.Name = "status";
		this.status.Pixbuf = new global::Gdk.Pixbuf (global::System.IO.Path.Combine (global::System.AppDomain.CurrentDomain.BaseDirectory, ".\\20px-Heart.png"));
		this.hbox2.Add (this.status);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.status]));
		w26.PackType = ((global::Gtk.PackType)(1));
		w26.Position = 1;
		w26.Expand = false;
		w26.Fill = false;
		w26.Padding = ((uint)(5));
		this.vbox1.Add (this.hbox2);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox2]));
		w27.PackType = ((global::Gtk.PackType)(1));
		w27.Position = 1;
		w27.Expand = false;
		w27.Fill = false;
		w27.Padding = ((uint)(5));
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 320;
		this.DefaultHeight = 286;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.tbPump.Clicked += new global::System.EventHandler (this.OnTbPumpClicked);
		this.tbHeater.Clicked += new global::System.EventHandler (this.OnTbHeaterClicked);
		this.tbLight.Clicked += new global::System.EventHandler (this.OnTbLightClicked);
		this.tbAux.Clicked += new global::System.EventHandler (this.OnTbAuxClicked);
		this.btnMaster.Clicked += new global::System.EventHandler (this.OnBtnMasterClicked);
	}
}
