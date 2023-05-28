using System;

namespace Personnel.model
{
	public class Absence
	{
		public Personnel Personnel { get; set; }
		public Motif Motif { get; set; }
		public DateTime DateDebut { get; set; }
		public DateTime DateFin { get; set; }

		public Absence(Personnel personnel, Motif motif, DateTime dateDebut, DateTime dateFin)
		{
			Personnel = personnel;
			Motif = motif;
			DateDebut = dateDebut;
			DateFin = dateFin;
		}

		public override string ToString()
		{
			return DateDebut.ToString("d") + " - " + DateFin.ToString("d") + " (" + Motif.ToString() + ")";
		}
	}
}
