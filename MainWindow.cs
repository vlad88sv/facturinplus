using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	private const string _EOL = "\n";

	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	private string sp(int cantidad)
	{
		return new string(' ', cantidad);
	}

	private string numeroEnLetras(double cantidad)
	{
		return "";
	}

	private double subtotal()
	{
		double subtotal = double.Parse(txtTotal.Text);
		double _IVA_ = 1.13;

		if (chkExIVA.Active == true)
			subtotal = ( subtotal / _IVA_ );

		return subtotal;
	}

	private double totalCalculado()
	{		
		return subtotal();
	}

	private string crearCreditoFiscal()
	{
		string contenido = "";


		return contenido;
	}

	private string crearFactura ()
	{
		string contenido = "";
		int col_base = (chkExIVA.Active == false ? 0 : 7);

		contenido += "0\n\n\n\n\n\n\n\n\n\n\n\n\n";

		// Fecha
		contenido += sp (72) + calendar1.Day.ToString () + sp (3) + (calendar1.Month + 1).ToString ("00") + sp (4) + calendar1.Year.ToString () + _EOL;

		// Cliente
		contenido += "\n";
		contenido += sp (20) + txtCliente.Text + _EOL;

		// Direccion
		contenido += "\n";
		contenido += sp (25) + txtDireccion.Text + _EOL;

		// DUI/NIT
		contenido += "\n";
		contenido += sp (20) + txtNIT.Text + _EOL;
		contenido += "\n\n";

		// Linea de concepto
		contenido += sp (15) + txtCantidad.Text + sp (8) + txtConcepto1.Text + sp ((55 - col_base) - txtConcepto1.Text.Length) + totalCalculado().ToString("0.00") + _EOL;
		
		// Sumas 
		contenido += new string('\n',20);
		contenido += sp (80  - col_base) + totalCalculado().ToString("0.00") + _EOL;

		// Total en letras
		contenido += sp (20) + numeroEnLetras(totalCalculado()) + _EOL;

		// Total

		if (chkExIVA.Active == true) contenido += new string('\n',1);
		if (chkExIVA.Active == false) contenido += new string('\n',2);
		contenido += sp (80  - col_base) + totalCalculado().ToString("0.00") + _EOL;

		return contenido;

	}

	protected void OnBtnImprimirClicked (object sender, EventArgs e)
	{
		string contenido = "";
		string titulo = "";

		// Detectamos que tipo de impresion quiere
		if (rbtCredito.Active == true)
		{
			contenido = crearCreditoFiscal();
			titulo = "credito_fiscal";
		} else {
			contenido = crearFactura();
			titulo = "consumidor_final";
		}

		Imprimidor.Slip (contenido, "", titulo);
	}
	protected void OnBtnCancelarClicked (object sender, EventArgs e)
	{
		double prueba = (double.Parse(txtCantidad.Text) / 1.13);
		Console.WriteLine( prueba );
	}

}
