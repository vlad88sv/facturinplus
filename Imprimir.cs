using System;
public static class Imprimidor
{
	public static void Tiquete (string linea, string ID_ticket)
	{
		Tiquete(linea,ID_ticket,"","Tiquete");
	}
	
	public static void Tiquete (string linea, string ID_ticket, string LPR_Printer, string Titulo)
	{
		Console.WriteLine ("LPR: Open - " + ID_ticket + " " + LPR_Printer + " ~ " + Titulo);
		string Tiquete = "";
		if (LPR_Printer == "")
		{
			LPR_Printer = "";

			// Solo para EPSON-TEXT porque PDF backend se rompe:
			// Imprimir solo en receipt 
			Tiquete += "\x1B\x63\x30\x02";
		} else {
			LPR_Printer = "-P '" + LPR_Printer + "'";
		}
		Tiquete += Imprimir("RIFT LASER TAG",	1);
		/*
		Tiquete += Imprimir("CC La Gran Via", 1);
		Tiquete += Imprimir("Edif. 104, L. 104", 1);
		Tiquete += Imprimir("Antiguo Cuscatlan, La Libertad", 1);
		*/
		Tiquete += Imprimir("www.riftelsalvador.com",	1);
		Tiquete += Imprimir("Tel. 2514-0818",	1);
		
		/*
		Tiquete += Imprimir("N.I.T. 0614-141084-101-5", 1);
		Tiquete += Imprimir("N.R.C. 199960-2", 1);
		Tiquete += Imprimir("Laura Elena Margarita Cañas Kurz", 1);
		*/
		
		Tiquete += Imprimir("Tiquete No." + ulong.Parse(ID_ticket).ToString("000000"), 1);
		Tiquete += Imprimir("Cajero: ",	1);
		Tiquete += Imprimir(DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString(),1);	
		Tiquete += "\n";
		
		
		linea = Tiquete + linea;
		
		/*
		linea += "\n\n\n";
		linea += Imprimir("Giro:\n1.venta de otros productos\nno clasificados previamente.",1);
		linea += Imprimir("2.venta de otros productos\nalimenticios no clasificados\npreviamente no incluye bebidas.", 1);
		*/
		linea += "\n\n\n\n\n\n\n\n\n\n\x1B\x69";
		
		System.Diagnostics.Process proc = new System.Diagnostics.Process();
		proc.EnableRaisingEvents=false;
		proc.StartInfo.FileName="/bin/bash";
		proc.StartInfo.Arguments=" -c \"echo -e '"+linea+"' | lpr -T '"+Titulo+"' "+LPR_Printer+"\"";
		
		proc.StartInfo.CreateNoWindow = true;
		proc.EnableRaisingEvents = true;
		proc.StartInfo.UseShellExecute = true;
		proc.StartInfo.ErrorDialog = false;
		
		proc.Start();
		proc.Close();
		Console.WriteLine ("LPR: Close");
	}
	
	// Dos columnas. Segunda columna alineada a la derecha.
	public static string Imprimir (string linea, string linea2)
	{
		string lineaCompuesta = linea.ToString() + linea2.ToString().PadLeft(30-linea.Length,' ');
		return lineaCompuesta+"\n";
	}
	
	// Cuatro columnas. Centradas.
	public static string Imprimir (string linea, string linea2, string linea3, string linea4)
	{
		string lineaCompuesta = linea.ToString().PadRight(8,' ') + linea2.ToString().PadRight(8,' ') + " | " + linea3.ToString().PadRight(8,' ') + linea4.ToString();
		return lineaCompuesta+"\n";
	}
	
	
	// Dos columnas. Segunda columna alineada a la derecha. DOBLE ALTURA
	public static string Imprimir (string linea, string linea2, bool dobleAltura)
	{
		string lineaCompuesta = linea.ToString() + linea2.ToString().PadLeft(15,' ');
		return lineaCompuesta+"\n";
	}
	
	// Una columna, alineada segun int modo.
	public static string Imprimir (string linea, int modo)
	{
		/* modo
		* 1 = Izq.
		* 2 = Centrado.
		* 3 = Derecha
		*/
		string lineaCompuesta = "";
		if (modo == 1) {
			lineaCompuesta = new string(' ',Math.Max((15-(int)(linea.Length/2)),0)) + linea.ToString();
		}
		return lineaCompuesta+"\n";
	}	

	public static void Slip (string contenido, string LPR_Printer, string Titulo)
	{
		Console.WriteLine ("LPR: Open - " + LPR_Printer + " ~ " + Titulo);
		if (LPR_Printer == "")
		{
			LPR_Printer = "";
			
			// Solo para EPSON-TEXT porque PDF backend se rompe:
			/*
				1. Enable the slip sensor (n = 48) with ESC c 4 n.
				2. Select the slip paper as the print sheet (n = 4) with ESC c 0 n.
				3. Insert the slip paper after confirming that the SLIP LED blinks (slip insertion waiting status).
				4. Process the print data (characters and bit images, etc.) and print commands (printing on the slip paper).
				5. Eject the slip paper with FF.
				6. Remove the ejected slip paper
			*/
			//contenido = "\x1B\x40"; // INITIALIZE
			contenido += "\x1B\x63\x34\x30"; // ENABLE SENSOR
			contenido += "\x1B\x63\x30\x04"; // SELECT SLIP
		} else {
			LPR_Printer = "-P '" + LPR_Printer + "'";
		}
		contenido += contenido;

		contenido += "\x0C";

		Console.WriteLine("Configurando LPR");
	
		System.Diagnostics.Process proc = new System.Diagnostics.Process();
		proc.EnableRaisingEvents=false;
		proc.StartInfo.FileName="/bin/bash";
		proc.StartInfo.Arguments=" -c \"echo -e '"+contenido+"' | lpr -T '"+Titulo+"' "+LPR_Printer+"\"";
	

		proc.StartInfo.CreateNoWindow = true;
		proc.EnableRaisingEvents = true;
		proc.StartInfo.UseShellExecute = true;
		proc.StartInfo.ErrorDialog = false;

		Console.WriteLine("Iniciando LPR");

		proc.Start();
		proc.Close();
		Console.WriteLine ("LPR: Close");
	}
}




