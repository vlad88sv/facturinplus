using System;
using System.Net;

namespace Facturin
{
	public class Network
	{
		public Network ()
		{

		}

		public void obtenerJSON(string URL, Array DATOS)
		{
			var html_json = new WebClient().DownloadString(URL);
			Console.WriteLine ( html_json );
		}
	}
}

