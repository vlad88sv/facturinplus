
// This file has been generated by the GUI designer. Do not modify.
public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	private global::Gtk.HBox hbox1;
	private global::Gtk.RadioButton rbtFactura;
	private global::Gtk.CheckButton chkExIVA;
	private global::Gtk.RadioButton rbtCredito;
	private global::Gtk.Table table1;
	private global::Gtk.Calendar calendar1;
	private global::Gtk.HBox hbox2;
	private global::Gtk.Entry txtCantidad;
	private global::Gtk.Entry txtConcepto;
	private global::Gtk.Entry txtConcepto1Unitario;
	private global::Gtk.Entry txtConcepto1Total;
	private global::Gtk.HBox hbox3;
	private global::Gtk.Entry txtCantidad1;
	private global::Gtk.Entry txtConcepto1;
	private global::Gtk.Entry txtConcepto2Unitario;
	private global::Gtk.Entry txtConcepto2Total;
	private global::Gtk.HBox hbox4;
	private global::Gtk.Entry txtCantidad2;
	private global::Gtk.Entry txtConcepto2;
	private global::Gtk.Entry txtConcepto3Unitario;
	private global::Gtk.Entry txtConcepto3Total;
	private global::Gtk.HBox hbox5;
	private global::Gtk.Entry txtCantidad3;
	private global::Gtk.Entry txtConcepto3;
	private global::Gtk.Entry txtConcepto4Unitario;
	private global::Gtk.Entry txtConcepto4Total;
	private global::Gtk.HBox hbox6;
	private global::Gtk.Entry txtCantidad4;
	private global::Gtk.Entry txtConcepto4;
	private global::Gtk.Entry txtConcepto5Unitario;
	private global::Gtk.Entry txtConcepto5Total;
	private global::Gtk.Label label1;
	private global::Gtk.Label label10;
	private global::Gtk.Label label11;
	private global::Gtk.Label label12;
	private global::Gtk.Label label2;
	private global::Gtk.Label label3;
	private global::Gtk.Label label4;
	private global::Gtk.Label label5;
	private global::Gtk.Label label6;
	private global::Gtk.Label label7;
	private global::Gtk.Label label8;
	private global::Gtk.Label label9;
	private global::Gtk.Entry txtCliente;
	private global::Gtk.Entry txtDireccion;
	private global::Gtk.Entry txtGiro;
	private global::Gtk.Entry txtNIT;
	private global::Gtk.Entry txtNRC;
	private global::Gtk.Entry txtTotal;
	private global::Gtk.HButtonBox hbuttonbox1;
	private global::Gtk.Button btnCancelar;
	private global::Gtk.Button btnImprimir;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = "Facturin 0.2";
		this.Icon = global::Stetic.IconLoader.LoadIcon (this, "gtk-print", global::Gtk.IconSize.Menu);
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.Resizable = false;
		this.AllowGrow = false;
		this.Gravity = ((global::Gdk.Gravity)(5));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		this.vbox1.BorderWidth = ((uint)(11));
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.rbtFactura = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Factura"));
		this.rbtFactura.CanFocus = true;
		this.rbtFactura.Name = "rbtFactura";
		this.rbtFactura.DrawIndicator = true;
		this.rbtFactura.UseUnderline = true;
		this.rbtFactura.Group = new global::GLib.SList (global::System.IntPtr.Zero);
		this.hbox1.Add (this.rbtFactura);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.rbtFactura]));
		w1.Position = 0;
		// Container child hbox1.Gtk.Box+BoxChild
		this.chkExIVA = new global::Gtk.CheckButton ();
		this.chkExIVA.CanFocus = true;
		this.chkExIVA.Name = "chkExIVA";
		this.chkExIVA.Label = global::Mono.Unix.Catalog.GetString ("Exento de I.V.A.");
		this.chkExIVA.DrawIndicator = true;
		this.chkExIVA.UseUnderline = true;
		this.hbox1.Add (this.chkExIVA);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.chkExIVA]));
		w2.Position = 1;
		// Container child hbox1.Gtk.Box+BoxChild
		this.rbtCredito = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Credito Fiscal"));
		this.rbtCredito.CanFocus = true;
		this.rbtCredito.Name = "rbtCredito";
		this.rbtCredito.DrawIndicator = true;
		this.rbtCredito.UseUnderline = true;
		this.rbtCredito.Group = this.rbtFactura.Group;
		this.hbox1.Add (this.rbtCredito);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.rbtCredito]));
		w3.Position = 2;
		this.vbox1.Add (this.hbox1);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.table1 = new global::Gtk.Table (((uint)(12)), ((uint)(2)), false);
		this.table1.Name = "table1";
		this.table1.RowSpacing = ((uint)(6));
		this.table1.ColumnSpacing = ((uint)(6));
		// Container child table1.Gtk.Table+TableChild
		this.calendar1 = new global::Gtk.Calendar ();
		this.calendar1.WidthRequest = 168;
		this.calendar1.HeightRequest = 184;
		this.calendar1.CanFocus = true;
		this.calendar1.Name = "calendar1";
		this.calendar1.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(43));
		this.calendar1.ShowWeekNumbers = true;
		this.table1.Add (this.calendar1);
		global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.calendar1]));
		w5.LeftAttach = ((uint)(1));
		w5.RightAttach = ((uint)(2));
		w5.XOptions = ((global::Gtk.AttachOptions)(4));
		w5.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.txtCantidad = new global::Gtk.Entry ();
		this.txtCantidad.WidthRequest = 33;
		this.txtCantidad.CanFocus = true;
		this.txtCantidad.Name = "txtCantidad";
		this.txtCantidad.Text = global::Mono.Unix.Catalog.GetString ("1");
		this.txtCantidad.IsEditable = true;
		this.txtCantidad.InvisibleChar = '●';
		this.hbox2.Add (this.txtCantidad);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.txtCantidad]));
		w6.Position = 0;
		w6.Expand = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.txtConcepto = new global::Gtk.Entry ();
		this.txtConcepto.CanFocus = true;
		this.txtConcepto.Name = "txtConcepto";
		this.txtConcepto.Text = global::Mono.Unix.Catalog.GetString ("Consumo");
		this.txtConcepto.IsEditable = true;
		this.txtConcepto.InvisibleChar = '●';
		this.hbox2.Add (this.txtConcepto);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.txtConcepto]));
		w7.Position = 1;
		// Container child hbox2.Gtk.Box+BoxChild
		this.txtConcepto1Unitario = new global::Gtk.Entry ();
		this.txtConcepto1Unitario.WidthRequest = 85;
		this.txtConcepto1Unitario.CanFocus = true;
		this.txtConcepto1Unitario.Name = "txtConcepto1Unitario";
		this.txtConcepto1Unitario.Text = global::Mono.Unix.Catalog.GetString ("0.00");
		this.txtConcepto1Unitario.IsEditable = true;
		this.txtConcepto1Unitario.InvisibleChar = '●';
		this.hbox2.Add (this.txtConcepto1Unitario);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.txtConcepto1Unitario]));
		w8.Position = 2;
		w8.Expand = false;
		w8.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.txtConcepto1Total = new global::Gtk.Entry ();
		this.txtConcepto1Total.WidthRequest = 85;
		this.txtConcepto1Total.CanFocus = true;
		this.txtConcepto1Total.Name = "txtConcepto1Total";
		this.txtConcepto1Total.Text = global::Mono.Unix.Catalog.GetString ("0.00");
		this.txtConcepto1Total.IsEditable = true;
		this.txtConcepto1Total.InvisibleChar = '●';
		this.hbox2.Add (this.txtConcepto1Total);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.txtConcepto1Total]));
		w9.Position = 3;
		w9.Expand = false;
		w9.Fill = false;
		this.table1.Add (this.hbox2);
		global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox2]));
		w10.TopAttach = ((uint)(6));
		w10.BottomAttach = ((uint)(7));
		w10.LeftAttach = ((uint)(1));
		w10.RightAttach = ((uint)(2));
		w10.XOptions = ((global::Gtk.AttachOptions)(4));
		w10.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.txtCantidad1 = new global::Gtk.Entry ();
		this.txtCantidad1.WidthRequest = 33;
		this.txtCantidad1.CanFocus = true;
		this.txtCantidad1.Name = "txtCantidad1";
		this.txtCantidad1.Text = global::Mono.Unix.Catalog.GetString ("0");
		this.txtCantidad1.IsEditable = true;
		this.txtCantidad1.InvisibleChar = '●';
		this.hbox3.Add (this.txtCantidad1);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.txtCantidad1]));
		w11.Position = 0;
		w11.Expand = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.txtConcepto1 = new global::Gtk.Entry ();
		this.txtConcepto1.CanFocus = true;
		this.txtConcepto1.Name = "txtConcepto1";
		this.txtConcepto1.IsEditable = true;
		this.txtConcepto1.InvisibleChar = '●';
		this.hbox3.Add (this.txtConcepto1);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.txtConcepto1]));
		w12.Position = 1;
		// Container child hbox3.Gtk.Box+BoxChild
		this.txtConcepto2Unitario = new global::Gtk.Entry ();
		this.txtConcepto2Unitario.WidthRequest = 85;
		this.txtConcepto2Unitario.CanFocus = true;
		this.txtConcepto2Unitario.Name = "txtConcepto2Unitario";
		this.txtConcepto2Unitario.Text = global::Mono.Unix.Catalog.GetString ("0.00");
		this.txtConcepto2Unitario.IsEditable = true;
		this.txtConcepto2Unitario.InvisibleChar = '●';
		this.hbox3.Add (this.txtConcepto2Unitario);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.txtConcepto2Unitario]));
		w13.Position = 2;
		w13.Expand = false;
		w13.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.txtConcepto2Total = new global::Gtk.Entry ();
		this.txtConcepto2Total.WidthRequest = 85;
		this.txtConcepto2Total.CanFocus = true;
		this.txtConcepto2Total.Name = "txtConcepto2Total";
		this.txtConcepto2Total.Text = global::Mono.Unix.Catalog.GetString ("0.00");
		this.txtConcepto2Total.IsEditable = true;
		this.txtConcepto2Total.InvisibleChar = '●';
		this.hbox3.Add (this.txtConcepto2Total);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.txtConcepto2Total]));
		w14.Position = 3;
		w14.Expand = false;
		w14.Fill = false;
		this.table1.Add (this.hbox3);
		global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox3]));
		w15.TopAttach = ((uint)(7));
		w15.BottomAttach = ((uint)(8));
		w15.LeftAttach = ((uint)(1));
		w15.RightAttach = ((uint)(2));
		w15.XOptions = ((global::Gtk.AttachOptions)(4));
		w15.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.hbox4 = new global::Gtk.HBox ();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.txtCantidad2 = new global::Gtk.Entry ();
		this.txtCantidad2.WidthRequest = 33;
		this.txtCantidad2.CanFocus = true;
		this.txtCantidad2.Name = "txtCantidad2";
		this.txtCantidad2.Text = global::Mono.Unix.Catalog.GetString ("0");
		this.txtCantidad2.IsEditable = true;
		this.txtCantidad2.InvisibleChar = '●';
		this.hbox4.Add (this.txtCantidad2);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.txtCantidad2]));
		w16.Position = 0;
		w16.Expand = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.txtConcepto2 = new global::Gtk.Entry ();
		this.txtConcepto2.CanFocus = true;
		this.txtConcepto2.Name = "txtConcepto2";
		this.txtConcepto2.IsEditable = true;
		this.txtConcepto2.InvisibleChar = '●';
		this.hbox4.Add (this.txtConcepto2);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.txtConcepto2]));
		w17.Position = 1;
		// Container child hbox4.Gtk.Box+BoxChild
		this.txtConcepto3Unitario = new global::Gtk.Entry ();
		this.txtConcepto3Unitario.WidthRequest = 85;
		this.txtConcepto3Unitario.CanFocus = true;
		this.txtConcepto3Unitario.Name = "txtConcepto3Unitario";
		this.txtConcepto3Unitario.Text = global::Mono.Unix.Catalog.GetString ("0.00");
		this.txtConcepto3Unitario.IsEditable = true;
		this.txtConcepto3Unitario.InvisibleChar = '●';
		this.hbox4.Add (this.txtConcepto3Unitario);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.txtConcepto3Unitario]));
		w18.Position = 2;
		w18.Expand = false;
		w18.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.txtConcepto3Total = new global::Gtk.Entry ();
		this.txtConcepto3Total.WidthRequest = 85;
		this.txtConcepto3Total.CanFocus = true;
		this.txtConcepto3Total.Name = "txtConcepto3Total";
		this.txtConcepto3Total.Text = global::Mono.Unix.Catalog.GetString ("0.00");
		this.txtConcepto3Total.IsEditable = true;
		this.txtConcepto3Total.InvisibleChar = '●';
		this.hbox4.Add (this.txtConcepto3Total);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.txtConcepto3Total]));
		w19.Position = 3;
		w19.Expand = false;
		w19.Fill = false;
		this.table1.Add (this.hbox4);
		global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox4]));
		w20.TopAttach = ((uint)(8));
		w20.BottomAttach = ((uint)(9));
		w20.LeftAttach = ((uint)(1));
		w20.RightAttach = ((uint)(2));
		w20.XOptions = ((global::Gtk.AttachOptions)(4));
		w20.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.hbox5 = new global::Gtk.HBox ();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.txtCantidad3 = new global::Gtk.Entry ();
		this.txtCantidad3.WidthRequest = 33;
		this.txtCantidad3.CanFocus = true;
		this.txtCantidad3.Name = "txtCantidad3";
		this.txtCantidad3.Text = global::Mono.Unix.Catalog.GetString ("0");
		this.txtCantidad3.IsEditable = true;
		this.txtCantidad3.InvisibleChar = '●';
		this.hbox5.Add (this.txtCantidad3);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.txtCantidad3]));
		w21.Position = 0;
		w21.Expand = false;
		// Container child hbox5.Gtk.Box+BoxChild
		this.txtConcepto3 = new global::Gtk.Entry ();
		this.txtConcepto3.CanFocus = true;
		this.txtConcepto3.Name = "txtConcepto3";
		this.txtConcepto3.IsEditable = true;
		this.txtConcepto3.InvisibleChar = '●';
		this.hbox5.Add (this.txtConcepto3);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.txtConcepto3]));
		w22.Position = 1;
		// Container child hbox5.Gtk.Box+BoxChild
		this.txtConcepto4Unitario = new global::Gtk.Entry ();
		this.txtConcepto4Unitario.WidthRequest = 85;
		this.txtConcepto4Unitario.CanFocus = true;
		this.txtConcepto4Unitario.Name = "txtConcepto4Unitario";
		this.txtConcepto4Unitario.Text = global::Mono.Unix.Catalog.GetString ("0.00");
		this.txtConcepto4Unitario.IsEditable = true;
		this.txtConcepto4Unitario.InvisibleChar = '●';
		this.hbox5.Add (this.txtConcepto4Unitario);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.txtConcepto4Unitario]));
		w23.Position = 2;
		w23.Expand = false;
		w23.Fill = false;
		// Container child hbox5.Gtk.Box+BoxChild
		this.txtConcepto4Total = new global::Gtk.Entry ();
		this.txtConcepto4Total.WidthRequest = 85;
		this.txtConcepto4Total.CanFocus = true;
		this.txtConcepto4Total.Name = "txtConcepto4Total";
		this.txtConcepto4Total.Text = global::Mono.Unix.Catalog.GetString ("0.00");
		this.txtConcepto4Total.IsEditable = true;
		this.txtConcepto4Total.InvisibleChar = '●';
		this.hbox5.Add (this.txtConcepto4Total);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.txtConcepto4Total]));
		w24.Position = 3;
		w24.Expand = false;
		w24.Fill = false;
		this.table1.Add (this.hbox5);
		global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox5]));
		w25.TopAttach = ((uint)(9));
		w25.BottomAttach = ((uint)(10));
		w25.LeftAttach = ((uint)(1));
		w25.RightAttach = ((uint)(2));
		w25.XOptions = ((global::Gtk.AttachOptions)(4));
		w25.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.hbox6 = new global::Gtk.HBox ();
		this.hbox6.Name = "hbox6";
		this.hbox6.Spacing = 6;
		// Container child hbox6.Gtk.Box+BoxChild
		this.txtCantidad4 = new global::Gtk.Entry ();
		this.txtCantidad4.WidthRequest = 33;
		this.txtCantidad4.CanFocus = true;
		this.txtCantidad4.Name = "txtCantidad4";
		this.txtCantidad4.Text = global::Mono.Unix.Catalog.GetString ("0");
		this.txtCantidad4.IsEditable = true;
		this.txtCantidad4.InvisibleChar = '●';
		this.hbox6.Add (this.txtCantidad4);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.txtCantidad4]));
		w26.Position = 0;
		w26.Expand = false;
		// Container child hbox6.Gtk.Box+BoxChild
		this.txtConcepto4 = new global::Gtk.Entry ();
		this.txtConcepto4.CanFocus = true;
		this.txtConcepto4.Name = "txtConcepto4";
		this.txtConcepto4.IsEditable = true;
		this.txtConcepto4.InvisibleChar = '●';
		this.hbox6.Add (this.txtConcepto4);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.txtConcepto4]));
		w27.Position = 1;
		// Container child hbox6.Gtk.Box+BoxChild
		this.txtConcepto5Unitario = new global::Gtk.Entry ();
		this.txtConcepto5Unitario.WidthRequest = 85;
		this.txtConcepto5Unitario.CanFocus = true;
		this.txtConcepto5Unitario.Name = "txtConcepto5Unitario";
		this.txtConcepto5Unitario.Text = global::Mono.Unix.Catalog.GetString ("0.00");
		this.txtConcepto5Unitario.IsEditable = true;
		this.txtConcepto5Unitario.InvisibleChar = '●';
		this.hbox6.Add (this.txtConcepto5Unitario);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.txtConcepto5Unitario]));
		w28.Position = 2;
		w28.Expand = false;
		w28.Fill = false;
		// Container child hbox6.Gtk.Box+BoxChild
		this.txtConcepto5Total = new global::Gtk.Entry ();
		this.txtConcepto5Total.WidthRequest = 85;
		this.txtConcepto5Total.CanFocus = true;
		this.txtConcepto5Total.Name = "txtConcepto5Total";
		this.txtConcepto5Total.Text = global::Mono.Unix.Catalog.GetString ("0.00");
		this.txtConcepto5Total.IsEditable = true;
		this.txtConcepto5Total.InvisibleChar = '●';
		this.hbox6.Add (this.txtConcepto5Total);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.txtConcepto5Total]));
		w29.Position = 3;
		w29.Expand = false;
		w29.Fill = false;
		this.table1.Add (this.hbox6);
		global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox6]));
		w30.TopAttach = ((uint)(10));
		w30.BottomAttach = ((uint)(11));
		w30.LeftAttach = ((uint)(1));
		w30.RightAttach = ((uint)(2));
		w30.XOptions = ((global::Gtk.AttachOptions)(4));
		w30.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Giro");
		this.table1.Add (this.label1);
		global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table1 [this.label1]));
		w31.TopAttach = ((uint)(3));
		w31.BottomAttach = ((uint)(4));
		w31.XOptions = ((global::Gtk.AttachOptions)(4));
		w31.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label10 = new global::Gtk.Label ();
		this.label10.Name = "label10";
		this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("Concepto5");
		this.table1.Add (this.label10);
		global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table1 [this.label10]));
		w32.TopAttach = ((uint)(10));
		w32.BottomAttach = ((uint)(11));
		w32.XOptions = ((global::Gtk.AttachOptions)(4));
		w32.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label11 = new global::Gtk.Label ();
		this.label11.Name = "label11";
		this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("Concepto4");
		this.table1.Add (this.label11);
		global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.table1 [this.label11]));
		w33.TopAttach = ((uint)(9));
		w33.BottomAttach = ((uint)(10));
		w33.XOptions = ((global::Gtk.AttachOptions)(4));
		w33.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label12 = new global::Gtk.Label ();
		this.label12.Name = "label12";
		this.label12.LabelProp = global::Mono.Unix.Catalog.GetString ("Fecha");
		this.table1.Add (this.label12);
		global::Gtk.Table.TableChild w34 = ((global::Gtk.Table.TableChild)(this.table1 [this.label12]));
		w34.XOptions = ((global::Gtk.AttachOptions)(4));
		w34.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Cliente");
		this.table1.Add (this.label2);
		global::Gtk.Table.TableChild w35 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2]));
		w35.TopAttach = ((uint)(1));
		w35.BottomAttach = ((uint)(2));
		w35.XOptions = ((global::Gtk.AttachOptions)(4));
		w35.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("DUI o NIT");
		this.table1.Add (this.label3);
		global::Gtk.Table.TableChild w36 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3]));
		w36.TopAttach = ((uint)(4));
		w36.BottomAttach = ((uint)(5));
		w36.XOptions = ((global::Gtk.AttachOptions)(4));
		w36.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label4 = new global::Gtk.Label ();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("NRC");
		this.table1.Add (this.label4);
		global::Gtk.Table.TableChild w37 = ((global::Gtk.Table.TableChild)(this.table1 [this.label4]));
		w37.TopAttach = ((uint)(5));
		w37.BottomAttach = ((uint)(6));
		w37.XOptions = ((global::Gtk.AttachOptions)(4));
		w37.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label5 = new global::Gtk.Label ();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Concepto1");
		this.table1.Add (this.label5);
		global::Gtk.Table.TableChild w38 = ((global::Gtk.Table.TableChild)(this.table1 [this.label5]));
		w38.TopAttach = ((uint)(6));
		w38.BottomAttach = ((uint)(7));
		w38.XOptions = ((global::Gtk.AttachOptions)(4));
		w38.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label6 = new global::Gtk.Label ();
		this.label6.Name = "label6";
		this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Concepto2");
		this.table1.Add (this.label6);
		global::Gtk.Table.TableChild w39 = ((global::Gtk.Table.TableChild)(this.table1 [this.label6]));
		w39.TopAttach = ((uint)(7));
		w39.BottomAttach = ((uint)(8));
		w39.XOptions = ((global::Gtk.AttachOptions)(4));
		w39.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label7 = new global::Gtk.Label ();
		this.label7.Name = "label7";
		this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Total con IVA");
		this.table1.Add (this.label7);
		global::Gtk.Table.TableChild w40 = ((global::Gtk.Table.TableChild)(this.table1 [this.label7]));
		w40.TopAttach = ((uint)(11));
		w40.BottomAttach = ((uint)(12));
		w40.XOptions = ((global::Gtk.AttachOptions)(4));
		w40.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label8 = new global::Gtk.Label ();
		this.label8.Name = "label8";
		this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Direccion");
		this.table1.Add (this.label8);
		global::Gtk.Table.TableChild w41 = ((global::Gtk.Table.TableChild)(this.table1 [this.label8]));
		w41.TopAttach = ((uint)(2));
		w41.BottomAttach = ((uint)(3));
		w41.XOptions = ((global::Gtk.AttachOptions)(4));
		w41.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label9 = new global::Gtk.Label ();
		this.label9.Name = "label9";
		this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Concepto3");
		this.table1.Add (this.label9);
		global::Gtk.Table.TableChild w42 = ((global::Gtk.Table.TableChild)(this.table1 [this.label9]));
		w42.TopAttach = ((uint)(8));
		w42.BottomAttach = ((uint)(9));
		w42.XOptions = ((global::Gtk.AttachOptions)(4));
		w42.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.txtCliente = new global::Gtk.Entry ();
		this.txtCliente.CanFocus = true;
		this.txtCliente.Name = "txtCliente";
		this.txtCliente.Text = global::Mono.Unix.Catalog.GetString ("Clientes varios");
		this.txtCliente.IsEditable = true;
		this.txtCliente.InvisibleChar = '●';
		this.table1.Add (this.txtCliente);
		global::Gtk.Table.TableChild w43 = ((global::Gtk.Table.TableChild)(this.table1 [this.txtCliente]));
		w43.TopAttach = ((uint)(1));
		w43.BottomAttach = ((uint)(2));
		w43.LeftAttach = ((uint)(1));
		w43.RightAttach = ((uint)(2));
		w43.XOptions = ((global::Gtk.AttachOptions)(4));
		w43.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.txtDireccion = new global::Gtk.Entry ();
		this.txtDireccion.CanFocus = true;
		this.txtDireccion.Name = "txtDireccion";
		this.txtDireccion.IsEditable = true;
		this.txtDireccion.InvisibleChar = '●';
		this.table1.Add (this.txtDireccion);
		global::Gtk.Table.TableChild w44 = ((global::Gtk.Table.TableChild)(this.table1 [this.txtDireccion]));
		w44.TopAttach = ((uint)(2));
		w44.BottomAttach = ((uint)(3));
		w44.LeftAttach = ((uint)(1));
		w44.RightAttach = ((uint)(2));
		w44.XOptions = ((global::Gtk.AttachOptions)(4));
		w44.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.txtGiro = new global::Gtk.Entry ();
		this.txtGiro.CanFocus = true;
		this.txtGiro.Name = "txtGiro";
		this.txtGiro.IsEditable = true;
		this.txtGiro.InvisibleChar = '●';
		this.table1.Add (this.txtGiro);
		global::Gtk.Table.TableChild w45 = ((global::Gtk.Table.TableChild)(this.table1 [this.txtGiro]));
		w45.TopAttach = ((uint)(3));
		w45.BottomAttach = ((uint)(4));
		w45.LeftAttach = ((uint)(1));
		w45.RightAttach = ((uint)(2));
		w45.XOptions = ((global::Gtk.AttachOptions)(4));
		w45.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.txtNIT = new global::Gtk.Entry ();
		this.txtNIT.CanFocus = true;
		this.txtNIT.Name = "txtNIT";
		this.txtNIT.IsEditable = true;
		this.txtNIT.InvisibleChar = '●';
		this.table1.Add (this.txtNIT);
		global::Gtk.Table.TableChild w46 = ((global::Gtk.Table.TableChild)(this.table1 [this.txtNIT]));
		w46.TopAttach = ((uint)(4));
		w46.BottomAttach = ((uint)(5));
		w46.LeftAttach = ((uint)(1));
		w46.RightAttach = ((uint)(2));
		w46.XOptions = ((global::Gtk.AttachOptions)(4));
		w46.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.txtNRC = new global::Gtk.Entry ();
		this.txtNRC.CanFocus = true;
		this.txtNRC.Name = "txtNRC";
		this.txtNRC.IsEditable = true;
		this.txtNRC.InvisibleChar = '●';
		this.table1.Add (this.txtNRC);
		global::Gtk.Table.TableChild w47 = ((global::Gtk.Table.TableChild)(this.table1 [this.txtNRC]));
		w47.TopAttach = ((uint)(5));
		w47.BottomAttach = ((uint)(6));
		w47.LeftAttach = ((uint)(1));
		w47.RightAttach = ((uint)(2));
		w47.XOptions = ((global::Gtk.AttachOptions)(4));
		w47.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.txtTotal = new global::Gtk.Entry ();
		this.txtTotal.CanFocus = true;
		this.txtTotal.Name = "txtTotal";
		this.txtTotal.Text = global::Mono.Unix.Catalog.GetString ("0.00");
		this.txtTotal.IsEditable = true;
		this.txtTotal.InvisibleChar = '●';
		this.table1.Add (this.txtTotal);
		global::Gtk.Table.TableChild w48 = ((global::Gtk.Table.TableChild)(this.table1 [this.txtTotal]));
		w48.TopAttach = ((uint)(11));
		w48.BottomAttach = ((uint)(12));
		w48.LeftAttach = ((uint)(1));
		w48.RightAttach = ((uint)(2));
		w48.XOptions = ((global::Gtk.AttachOptions)(4));
		w48.YOptions = ((global::Gtk.AttachOptions)(4));
		this.vbox1.Add (this.table1);
		global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.table1]));
		w49.Position = 1;
		w49.Expand = false;
		w49.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbuttonbox1 = new global::Gtk.HButtonBox ();
		this.hbuttonbox1.Name = "hbuttonbox1";
		this.hbuttonbox1.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
		// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
		this.btnCancelar = new global::Gtk.Button ();
		this.btnCancelar.CanFocus = true;
		this.btnCancelar.Name = "btnCancelar";
		this.btnCancelar.UseUnderline = true;
		// Container child btnCancelar.Gtk.Container+ContainerChild
		global::Gtk.Alignment w50 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		global::Gtk.HBox w51 = new global::Gtk.HBox ();
		w51.Spacing = 2;
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Image w52 = new global::Gtk.Image ();
		w52.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-cancel", global::Gtk.IconSize.Menu);
		w51.Add (w52);
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Label w54 = new global::Gtk.Label ();
		w54.LabelProp = global::Mono.Unix.Catalog.GetString ("Cancelar");
		w54.UseUnderline = true;
		w51.Add (w54);
		w50.Add (w51);
		this.btnCancelar.Add (w50);
		this.hbuttonbox1.Add (this.btnCancelar);
		global::Gtk.ButtonBox.ButtonBoxChild w58 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1 [this.btnCancelar]));
		w58.Expand = false;
		w58.Fill = false;
		// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
		this.btnImprimir = new global::Gtk.Button ();
		this.btnImprimir.CanFocus = true;
		this.btnImprimir.Name = "btnImprimir";
		this.btnImprimir.UseUnderline = true;
		// Container child btnImprimir.Gtk.Container+ContainerChild
		global::Gtk.Alignment w59 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		global::Gtk.HBox w60 = new global::Gtk.HBox ();
		w60.Spacing = 2;
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Image w61 = new global::Gtk.Image ();
		w61.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-print", global::Gtk.IconSize.Menu);
		w60.Add (w61);
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Label w63 = new global::Gtk.Label ();
		w63.LabelProp = global::Mono.Unix.Catalog.GetString ("Imprimir");
		w63.UseUnderline = true;
		w60.Add (w63);
		w59.Add (w60);
		this.btnImprimir.Add (w59);
		this.hbuttonbox1.Add (this.btnImprimir);
		global::Gtk.ButtonBox.ButtonBoxChild w67 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1 [this.btnImprimir]));
		w67.Position = 1;
		w67.Expand = false;
		w67.Fill = false;
		this.vbox1.Add (this.hbuttonbox1);
		global::Gtk.Box.BoxChild w68 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbuttonbox1]));
		w68.Position = 2;
		w68.Expand = false;
		w68.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 495;
		this.DefaultHeight = 663;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.btnImprimir.Clicked += new global::System.EventHandler (this.OnBtnImprimirClicked);
	}
}