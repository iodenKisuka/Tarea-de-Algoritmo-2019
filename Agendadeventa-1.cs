/*
 * Creado por SharpDevelop.
 * Usuario: Ekatos
 * Fecha: 12/11/2019
 * Hora: 11:56
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Trabajo_final_de_excursion
{
	/// <summary>
	/// Description of Agendadeventa.
	/// </summary>
	public class Agendadeventa
	{
		private int numerodetransaccion;
		private int numerodelegajo;
		private int numerodecliente;
		private int numerodeexcursion;
		private int cantidaddepasajes;

		public int Numerodetransaccion {
			get {
				return numerodetransaccion;
			}
		}		
		public int Numerodelegajo {
			get {
				return numerodelegajo;
			}
		}
		public int Numerodecliente {
			get {
				return numerodecliente;
			}
		}
		public int Numerodeexcursion {
			get {
				return numerodeexcursion;
			}
		}
		public int Cantidaddepasajes {
			set{
				cantidaddepasajes=value;
			}
			get {
				return cantidaddepasajes;
			}
		}

		public Agendadeventa()
		{
		}
		public Agendadeventa(int numt,int nrdl,int nrc,int nde,int cdp){
			this.numerodetransaccion=numt;
			this.numerodelegajo=nrdl;
			this.numerodecliente=nrc;
			this.numerodeexcursion=nde;
			this.cantidaddepasajes=cdp;
		}
	}
}
